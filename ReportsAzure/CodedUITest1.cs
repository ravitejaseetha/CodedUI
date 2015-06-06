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


namespace ReportsAzure
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
        public void CodedUITestMethod1()
        {
            BrowserWindow.CurrentBrowser = "IE";
            BrowserWindow browser = BrowserWindow.Launch("http://raviteja/ptsweb/admin/SignIn");
            //BrowserWindow browser = BrowserWindow.Launch("http://sikkimilp.in/admin/signin");
            browser.Maximized = true;
            browser.CloseOnPlaybackCleanup = false;
            
            //HyperLink(browser, "Reports ");
            //HyperLink(browser, "Tourist Monthly Visiting Report");
            //EnterText(browser, "ctl00_ContentPlaceHolder1_MonthYearPicker_dateInput", TestContext.DataRow["month"].ToString());
            //ClickButton(browser, "ctl00_ContentPlaceHolder1_SearchButton_input");
            try
            {
                EnterText(browser, "username", "admin");
                EnterText(browser, "password", "Design_20");
                ClickButton(browser, "btn-signIn"); Playback.Wait(8000);
                //Azure
                //var expected = int.Parse(this.UIMap.UIHttpssikkimptsazurewWindow.UIHttpssikkimptsazurewDocument.UICountriesTable.RAPCount.InnerText);
                //this.UIMap.TotalRAPCount(expected);
                //Local
                var expected1 = int.Parse(this.UIMap.UIHttpsravitejaPtsWebAWindow1.UIHttpsravitejaPtsWebADocument.UICountriesTable.LocalCount.InnerText);
                this.UIMap.LocalRAPCount(expected1);

                //this.UIMap.WriteLogs(TestContext, "Logging into application event success");
            }
            catch (PlaybackFailureException e)
            {
                this.UIMap.WriteLogs(TestContext, "Logging into application event failure");
            }
        }
        public void EnterText(UITestControl parent,String id,String value)
        {
            HtmlEdit edit = new HtmlEdit(parent);
            edit.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            edit.Text = value;
        }
        public void ClickButton(UITestControl parent,String id)
        {
            HtmlInputButton button = new HtmlInputButton(parent);
            button.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, id);
            
            Mouse.Click(button);
        }
        public void HyperLink(UITestControl parent,String innertext)
        {
            HtmlHyperlink link = new HtmlHyperlink(parent);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, innertext);
            Mouse.Click(link);
        }
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
