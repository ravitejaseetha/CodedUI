using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace RDT
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
        //private static BrowserWindow browser;
        //[ClassInitialize]
        //static public void BrowserUrl(TestContext context)
        //{
        //    try
        //    {
        //        Playback.Initialize();
        //        BrowserWindow.CurrentBrowser = "IE";
        //        browser = BrowserWindow.Launch("http://192.168.0.105/RDT/login.aspx");
        //        browser.Maximized = true;
        //        browser.CloseOnPlaybackCleanup = false;
        //        Playback.Wait(2000);
        //        UIMap.UIWelcometoSilverBulleWindow.UIWelcometoSilverBulleDocument.UIUserNameEdit.Text = "sureshbabu.chintapalli@gmail.com";
        //        this.UIMap.UIWelcometoSilverBulleWindow.UIWelcometoSilverBulleDocument.UIPasswordEdit.Text = "Design_20";
        //        Mouse.click(UIMap.UIWelcometoSilverBulleWindow.UIWelcometoSilverBulleDocument.UILogin1LoginButtonButton);
        //        //Playback.PlaybackSettings.MatchExactHierarchy = true;
        //    }
        //    finally
        //    {
        //        Playback.Cleanup();
        //    }
        //}
        [TestMethod]
        public void AddRdt()
        {

            BrowserWindow.CurrentBrowser = "Chrome";
            var browser = BrowserWindow.Launch("http://192.168.0.105/RDT/login.aspx");
            browser.Maximized = true;
            //Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.Disabled;

            //browser.CloseOnPlaybackCleanup = false;
            Playback.Wait(1000);
            UIMap.UIWelcometoSilverBulleWindow.UIWelcometoSilverBulleDocument.UIUserNameEdit.WaitForControlExist();
            this.UIMap.UIWelcometoSilverBulleWindow.UIWelcometoSilverBulleDocument.UIUserNameEdit.Text = "sureshbabu.chintapalli@gmail.com";
            this.UIMap.UIWelcometoSilverBulleWindow.UIWelcometoSilverBulleDocument.UIPasswordEdit.Text = "Design_20";
            Mouse.Click(UIMap.UIWelcometoSilverBulleWindow.UIWelcometoSilverBulleDocument.UILogin1LoginButtonButton);
            Playback.Wait(1000);
            //Mouse.Hover(UIMap.UIWelcometoSilverBulleWindow.UIRelianceToolDocument.UICtl00_RadMenu1Pane.UIHRManagementHyperlink);
            browser.NavigateToUrl(new Uri("http://192.168.0.105/RDT/OverTimes/list.aspx"));
            Playback.Wait(1000);
            //Mouse.Click(UIMap.UIWelcometoSilverBulleWindow.UIRelianceToolDocument.UICtl00_RadMenu1Pane.UIOvertimeWorkHyperlink);
            String[] name = { "c", "s", "c", "n" };
            for (int i = 1; i <= 9; i++)
            {
                Mouse.Click(UIMap.UIWelcometoSilverBulleWindow.UIRelianceToolDocument.UIAddNewOverTimeHyperlink);
                
                Mouse.Click(UIMap.UIWelcometoSilverBulleWindow.UIOverTimeDocument.UIEmployeeEdit);
                //Textbox_EnterText(browser,"ctl00_ContentPlaceHolder1_FormView1_insertItemTemplate_ctl00_ctl00___Employee_RadComboBox1_Employee_Input","c");
                Keyboard.SendKeys("{Down},{Tab}");
                //this.UIMap.July();
                Playback.Wait(1000);
                //browser.Refresh();
                Mouse.Click(UIMap.UIWelcometoSilverBulleWindow.UIOverTimeDocument.UIOpenthecalendarpopupHyperlink);
                Click_HyperLink(browser, "1" + i);
                this.UIMap.UIWelcometoSilverBulleWindow.UIOverTimeDocument.UIOverTimeHoursEdit.Text = "2" + i;
                this.UIMap.UIWelcometoSilverBulleWindow.UIOverTimeDocument.UIAmountPerHourEdit.Text = "5" + i;
                Mouse.Click(UIMap.UIWelcometoSilverBulleWindow.UIOverTimeDocument.UIWebForm_DoPostBackWiHyperlink);
                Playback.Wait(2000);

            }

        }
         public void Textbox_EnterText(UITestControl parent, String id, String value)
        {
            var edit = new HtmlEdit(parent);
            edit.SearchProperties.Add(HtmlEdit.PropertyNames.Id,id);
            edit.Text = value;
        }
           public void Click_HyperLink(UITestControl parent, String innerText)
        {
            var link = new HtmlHyperlink(parent);
            link.SearchProperties.Add(HtmlControl.PropertyNames.InnerText, innerText);
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
