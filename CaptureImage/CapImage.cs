using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using CaptureImage.UIMap1Classes;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CaptureImage
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CapImage
    {
        public CapImage()
        {
        }

        [TestMethod]
        public void CaptureImage()
        {
            BrowserWindow.CurrentBrowser = "chrome";
            BrowserWindow browser = BrowserWindow.Launch();
            browser.NavigateToUrl(new System.Uri("http://raviteja/ptsweb"));
            browser.Maximized = true;
            browser.CloseOnPlaybackCleanup = false;
            Playback.Wait(2000);
            var methods = new UIMap();
            methods.HyperLink(browser, "button-start");
            this.UIMap1.UpdateButton();    
            methods.EditClick(browser, "fromDate");
            UITestControl edit = new HtmlEdit(browser);
            UITestControlCollection controlCollection = edit.FindMatchingControls();
            var controls = controlCollection.Select(x => x.Name);
            //var enumerable = controls as IList<string> ?? controls.ToList();
            Console.WriteLine("No of control" + controls.Count());
            foreach (var control in controls)
            {
                Console.WriteLine(control.ToString());
            }
            Playback.Wait(2000);
            methods.DatePicker(browser, "31");
            String[] array = { "Rajkumar", "Statham"};
            for (int i = 0; i < array.Length; i++)
            {
                methods.EditBox(browser, "username", array[i]);
                methods.EditClick(browser, "DateOfBirth");
                methods.DateYearMonth(browser, "2010");
                methods.DateYearMonth(browser, "Feb");
                methods.DatePicker(browser, "1" + i);
                methods.ComboBox(browser, "Nationality", "South Africa");
                methods.EditBox(browser, "state", "Centurion");
                methods.EditBox(browser, "PhoneNo", "919032552879");
                methods.EditBox(browser, "Email", "ravitejaseetha@gmail.com");
                methods.EditBox(browser, "PassportNumber", "434dd" + i);
                methods.EditClick(browser, "passportvaliditydate");
                methods.DateYearMonth(browser, "2016");
                methods.DateYearMonth(browser, "Feb");
                methods.DatePicker(browser, "2" + i);
                methods.EditBox(browser, "VisaNumber", "V334");
                methods.ComboBox(browser, "visatype", "Business Visa");
                methods.EditClick(browser, "VisaValidityDate");
                methods.DateYearMonth(browser, "2017");
                methods.DateYearMonth(browser, "Jun");
                methods.DatePicker(browser, "2" + i);
                methods.EditBox(browser, "visaissuedin", "South Africa");
                methods.TextArea(browser, "purposeofvisit", "Tourist");
                Keyboard.SendKeys("{Tab},{Tab},{Enter}");
                Playback.Wait(8000);
                methods.Button(browser, "Snapshot to image");
                methods.Button(browser, "Save changes");
                Playback.Wait(1000);
                methods.Button(browser, "Add to group");
            }
            Playback.Wait(1000);
            //methods.Button(browser, "Save ILP");
            
            //UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UICtl01Custom.UIRAPReportPane.WaitForControlExist();
            //this.UIMap.RAPReporPage();
            MessageBox.Show("Message", "Thanks for visiting", MessageBoxButtons.OK);
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
       
        public UIMap1 UIMap1
        {
            get
            {
                if ((this.map1 == null))
                {
                    this.map1 = new UIMap1();
                }

                return this.map1;
            }
        }
        private UIMap1 map1;
    }
}
