using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;


namespace PtsWeb
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        BrowserWindow browser;
        
        public CodedUITest1()
        {
        }
        //[TestInitialize]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\browserdata.csv", "browserdata#csv", DataAccessMethod.Sequential), DeploymentItem("browserdata.csv")]
        //public void launch()
        //{
        //    BrowserWindow.CurrentBrowser = "Chrome";
        //    var browser = BrowserWindow.Launch("https://raviteja/PtsWeb/ilp/register");
        //    browser.CloseOnPlaybackCleanup = false;

        //}


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv")]
        public void NormalTourist()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.Disabled;
            BrowserWindow.CurrentBrowser = "Chrome";
            BrowserWindow browser = BrowserWindow.Launch("https://raviteja/PtsWeb/ilp/register");
            Playback.Wait(3000); 
            browser.Maximized = true;
            browser.CloseOnPlaybackCleanup = false;
            Playback.Wait(2000);
            SelectItem(browser, "TourOperator", "Nag travels");
            ClickDatePicker(browser, "fromDate");
            Keyboard.SendKeys("{Enter}");
            EnterText(browser, "username", "Richards");
            Playback.Wait(5000);
            ClickDatePicker(browser, "DateOfBirth");
            Playback.Wait(2000);
            ClickSpan(browser, "2010");
            ClickSpan(browser, "Feb");
            ClickCell(browser, "20");
            SelectItem(browser, "Nationality", "Zimbabwe"); Playback.Wait(2000);
            EnterText(browser, "state", "Tibetan refugee");
            EnterText(browser, "PhoneNo", "9032577446");
            EnterText(browser, "Email", "ravitejaseetha@gmail.com");
            EnterText(browser, "PassportNumber", TestContext.DataRow["passport"].ToString());
            ClickDatePicker(browser, "passportvaliditydate");
            ClickSpan(browser, "2016"); 
            ClickSpan(browser, "Jun"); 
            ClickCell(browser, "20");
            EnterText(browser, "VisaNumber", "V1233");
            SelectItem(browser, "visatype", "Entry Visa");
            ClickDatePicker(browser, "VisaValidityDate");
            ClickSpan(browser, "2015"); 
            ClickSpan(browser, "Jun"); 
            ClickCell(browser, "20");
            EnterText(browser, "visaissuedin", "Australia");
            EnterArea(browser, "purposeofvisit", "Tourism");
            Input(browser, "input-id", TestContext.DataRow["file"].ToString());
            ClickButton(browser, " Add to group ");
            Playback.Wait(1000);
            
            this.UIMap.NameValidation();
            ClickButton(browser, " Save RAP ");
            DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            if (result == DialogResult.No)
            {
                browser.Close();
                //Playback.Cancel();

            }
            //else
            //{
            //    Playback.Initialize();
            //}

            //ClickLink(browser, "New RAP"); Playback.Wait(2000);
            //UIMap.UIGovernmentofSikkimStWindow1.UIGovernmentofSikkimStDocument.UIDropDownListComboBox.SelectedIndex = 3;
            //Mouse.Click(UIMap.UIGovernmentofSikkimStWindow1.UIGovernmentofSikkimStDocument.UIExportHyperlink);
            //Playback.Wait(2000);
            //if (UIMap.UIGovernmentofSikkimStWindow1.UINotificationToolBar.UISaveSplitButton.Exists)
            //{
            //    Mouse.Click(UIMap.UIGovernmentofSikkimStWindow1.UINotificationToolBar.UISaveSplitButton);
            //}
            //else
            //{
            //    //Keyboard.SendKeys("{Down}");
            //    Playback.Wait(1000);
            //    Keyboard.SendKeys("{Enter}");
            //}
            //Playback.Wait(8000);
        }
        public void EnterText(UITestControl parent, String id, String value)
        {
           
            var edit = new HtmlEdit(parent);
            edit.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            edit.Text = value;
        }
        public void SelectItem(UITestControl parent,String id,String value)
        {
            var item = new HtmlComboBox(parent);
            item.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, id);
            item.SelectedItem = value;
        }
        public void ClickButton(UITestControl parent,String displaytext)
        {
            var button = new HtmlButton(parent);
            button.SearchProperties.Add(HtmlButton.PropertyNames.DisplayText, displaytext);
            Mouse.Click(button);
        }
        void EnterArea(UITestControl parent, String id, String value)
        {
            var edit = new HtmlTextArea(parent);
            edit.SearchProperties.Add(HtmlTextArea.PropertyNames.Id, id);
            edit.Text = value;
        }
        void ClickLink(UITestControl parent, String innerText)
        {
            var link = new HtmlHyperlink(parent);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, innerText);
            Mouse.Click(link);
        }
        void ClickDatePicker(UITestControl parent, String id)
        {
            var dateText = new HtmlEdit(parent);
            dateText.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            Mouse.Click(dateText);
        }
        void ClickCell(UITestControl parent, String innerText)
        {
            var dateCell = new HtmlCell(parent);
            dateCell.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, innerText);
            Mouse.Click(dateCell);
        }
        void ClickSpan(UITestControl parent, String innerText)
        {
            var dateYear = new HtmlSpan(parent);
            dateYear.SearchProperties.Add(HtmlSpan.PropertyNames.InnerText, innerText);
            Mouse.Click(dateYear);
        }
        void Input(UITestControl parent, String id, String value)
        {
            var input = new HtmlFileInput(parent);
            input.SearchProperties.Add(HtmlFileInput.PropertyNames.Id, id);
            input.FileName = value;
        }

        String GetText(HtmlEdit parent, String id)
        {
            var input = new UITestControl(parent);
            input.SearchProperties.Add(UITestControl.PropertyNames.FriendlyName, id);
            String text = input.GetProperty("HelpText").ToString();
           // Console.WriteLine(text);
            return text;
        }
        //static private UIMap test = new UIMap();
        //[ClassInitialize]
        //static public void ClassInit(TestContext context)
        //{
        //    Playback.Initialize();
        //    try
        //    {
        //        BrowserWindow.CurrentBrowser = "IE";
        //        BrowserWindow browser = BrowserWindow.Launch("https://raviteja/PtsWeb/ilp/register");
        //        Playback.Wait(3000);

        //        // browser.CloseOnPlaybackCleanup = false;
        //        //test.UIHttpsravitejaPtsWebiWindow.UIHttpsravitejaPtsWebiDocument.UIFirmNameComboBox.WaitForControlExist();
        //    }
        //    finally
        //    {
        //        //Playback.Cleanup();
        //    }
        //}
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
