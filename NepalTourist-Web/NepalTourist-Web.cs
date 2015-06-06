using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;


namespace NepalTourist_Web
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }
        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void NepalTourist()
        {
           BrowserWindow.CurrentBrowser = "IE";
           BrowserWindow browser = BrowserWindow.Launch("http://raviteja/ptsweb");
           browser.CloseOnPlaybackCleanup = false;
           browser.Maximized = true;
           ClickLink(browser, "Get Started ! It as easy as 123"); Playback.Wait(5000);
           ClickDatePicker(browser, "fromDate");
           Keyboard.SendKeys("{Enter}");
           String[] array = { "Sachin", "Virat", "Ponting", "Sachin", "Virat", "Ponting", "Kallis", "Mccullum", "Virat", "Ponting", "Kallis", "Mccullum", "Virat", "Ponting", "Kallis", "Mccullum", "Virat", "Ponting", "Kallis", "Mccullum", "Virat", "Ponting", "Kallis", "Mccullum" };
           for (int i = 2; i <= 4; i++)
           {
               EnterText(browser, "username", array[i]);
               ClickDatePicker(browser, "DateOfBirth");
               Playback.Wait(2000);
               ClickSpan(browser, "2010");
               ClickSpan(browser, "Feb");
               ClickCell(browser, "2"+i);
               SelectDrop(browser, "Nationality",8); Playback.Wait(2000);
               //if (UIMap.UIHttpsravitejaPtsWebIWindow.UIHttpsravitejaPtsWebIDocument.UIMyModalPane.UIOKButton.Exists)
               //{
               //    if (UIMap.UIHttpsravitejaPtsWebIWindow.UIHttpsravitejaPtsWebIDocument.UIMyModalPane.UIOKButton.BoundingRectangle.X > 0)
               //    {
               //        ClickButton(browser, "Ok");
               //    }
               //    else
               //    {
                       EnterText(browser, "state", "Tibetan refugee");
                       EnterText(browser, "PhoneNo", "9032577446");
                       EnterText(browser, "Email", "ravitejaseetha@gmail.com");
                       EnterText(browser, "PassportNumber", (TestContext.DataRow["passport"].ToString()) + i);
                      // EnterText(browser, "PassportNumber", "123ABC");
                       ClickDatePicker(browser, "passportvaliditydate");
                       ClickSpan(browser, "2016");
                       ClickSpan(browser, "Jun");
                       ClickCell(browser, "2"+i);
                       EnterArea(browser, "purposeofvisit", "Tourism");
                       Playback.Wait(2000);
                       //Input(browser,"input-id",i+(TestContext.DataRow["file"].ToString()));
                       Input(browser, "input-id", "41999_honda_passport-pic-65301-tmb.png");
                       Playback.Wait(1000);
               
                       //MessageBox.Show("Upload image?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                       Playback.Wait(1000);        
                       ClickButton(browser, "Add to group");
                       Playback.Wait(1000);
                       
                       
                       
                   //}
               //}
           }
           DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
           if (result == DialogResult.Yes)
           {
               ClickButton(browser, "Save RAP");
               UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UICtl01Custom.UIRAPReportPane.WaitForControlExist();
               browser.Close();
               //MessageBox.Show("Tourist Details Saved Suceessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               MessageBox.Show("OK.....Get Lost", "Abort", MessageBoxButtons.OK, MessageBoxIcon.Hand);
           }
        } 
        void EnterText(UITestControl parent,String id,String value)
        {
            var edit = new HtmlEdit(parent);
            edit.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            edit.Text = value;
        }
        void Input(UITestControl parent,String id,String value)
        {
            var input = new HtmlFileInput(parent);
            input.SearchProperties.Add(HtmlFileInput.PropertyNames.Id, id);
            input.FileName = value;
        }
        void EnterArea(UITestControl parent, String id, String value)
        {
            var edit = new HtmlTextArea(parent);
            edit.SearchProperties.Add(HtmlTextArea.PropertyNames.Id, id);
            edit.Text = value;
        }
        void SelectDrop(UITestControl parent,String id,int value)
        {
            var select = new HtmlComboBox(parent);
            select.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, id);
            //select.SelectedItem = value;
            select.SelectedIndex = value;
        }
        void ClickLink(UITestControl parent,String innerText)
        {
            var link = new HtmlHyperlink(parent);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText,innerText);
            Mouse.Click(link);
        }
        void ClickButton(UITestControl parent,String innerText)
        {
            var buttonText = new HtmlButton(parent);
            buttonText.SearchProperties.Add(HtmlButton.PropertyNames.InnerText, innerText);
            Mouse.Click(buttonText);
        }
        void ClickDatePicker(UITestControl parent, String id)
        {
            var dateText = new HtmlEdit(parent);
            dateText.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            Mouse.Click(dateText);
        }
       void ClickCell(UITestControl parent,String innerText)
        {
            var dateCell = new HtmlCell(parent);
            dateCell.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, innerText);
            Mouse.Click(dateCell);
        }
        void ClickSpan(UITestControl parent,String innerText)
       {
           HtmlSpan dateYear = new HtmlSpan(parent);
           dateYear.SearchProperties.Add(HtmlSpan.PropertyNames.InnerText, innerText);
           Mouse.Click(dateYear);
       }    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        

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

