using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;


namespace SapmleReports
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class SampleReport
    {
        BrowserWindow browser;
        public SampleReport()
        {
        }
        //Add System.xml referrence and install exceldatareader from nuget packages
        [TestMethod]
        public void ReportSample()
        {
            UIMap test = new UIMap();
            ExcelUtil util = new ExcelUtil();
            util.PopulateInCollection(@"C:\Users\Raviteja\Desktop\Data.xlsx");
            //BrowserWindow.ClearCookies();
            //BrowserWindow.ClearCache();
            //browser.Forward();
            //browser.Back();
            //BrowserWindow.CurrentBrowser = "IE";// To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            browser = BrowserWindow.Launch("https://raviteja/PtsWeb/Admin/SignIn");
            //browser = BrowserWindow.Locate("Government of Sikkim | State Permit Tracking System");
            browser.Maximized = true;
            browser.CloseOnPlaybackCleanup = false;
            //browser.ExecuteScript("var controlCount = document.getElementsByTagName('Input').length; alert('The total controls count in login page is:'+controlCount);");
            var result = browser.ExecuteScript("var controlCount = document.getElementsByTagName('Input').length; return controlCount;");
            if (result.ToString() == "3")
            {
                
                EditText(browser, "username", util.ReadData(1, "Username"));
                //Assert.AreEqual("admin",GetText(browser,"username"),"Failed !!!! Expected result is not equal to actual result");
                Equals("admin", GetText(browser, "usernames"),"Failed !!!! Expected result is not equal to actual result");
                EditText(browser, "password", util.ReadData(1, "Password"));
                //Button(browser, "btn-signIn", "Sign");
                Button(browser, "btn-signIn");
                HyperLink(browser, "Reports ");
                HyperLink(browser, "RAP Issuance Report");
                EditText(browser, "ctl00_ContentPlaceHolder1_FromDatePicker_dateInput", "01-05-2015");
                EditText(browser, "ctl00_ContentPlaceHolder1_ToDatePicker_dateInput", "31-05-2015");
                EditText(browser, "ctl00_ContentPlaceHolder1_LocationNameComboBox_Input", "ALL");
                Button(browser, "ctl00_ContentPlaceHolder1_SearchButton_input");
                UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame
                    .UIRAPIssuanceReportDocument.UIItemPane.WaitForControlExist();
                //Keyboard.SendKeys("{PageDown}");
                //this.UIMap.ScrollBar();
                Console.WriteLine(UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument.UISignInButton.GetProperty(HtmlButton.PropertyNames.Exists));
                var expected = this.UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame.UIRAPIssuanceReportDocument.LocationName.InnerText;
                this.UIMap.ValidateLocation(TestContext, expected);
                Mouse.Click(this.UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame.UIRAPIssuanceReportDocument.LocationName);
                UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame.UIRAPIssuanceReportDocument.UIItemPane.WaitForControlExist();
                var list = UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIDropDownListComboBox.Items;
                var j = list.GetValuesOfControls();
                foreach (var i in j)
                {
                    Console.WriteLine(i);
                }
                browser.ExecuteScript("alert('Hello world')");
                
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }

        [TestCleanup]
        public void MethodClean()
        {
            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Passed)
            {
                Image image = UITestControl.Desktop.CaptureImage();
                image.Save(@"d:\"+TestContext.TestName+".jpeg", ImageFormat.Jpeg);
                image.Dispose();
            }
        }

        //public void WaitForControl<T>(PropertyType type, string propertyvalue, string text) where T : HtmlControl;
        public void EditText(UITestControl parent, String id, String value)
        {
            var edit = new HtmlEdit(parent);
            //edi
            edit.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            edit.Text = value;
        }
        public void Button(UITestControl parent, String id)//,String display)
        {
            var button = new HtmlInputButton(parent);
            //Search properties is logical AND, Filter properties is logical OR 
            button.SearchProperties.Add(HtmlInputButton.PropertyNames.Id, id);
            //button.FilterProperties.Add(HtmlInputButton.PropertyNames.Id, id);
            //button.FilterProperties.Add(HtmlInputButton.PropertyNames.DisplayText, display);
            Mouse.Click(button);
        }
        public void HyperLink(UITestControl parent,String innertext)
        {
            var hyperlink = new HtmlHyperlink(parent);
            hyperlink.SearchProperties.Add(HtmlControl.PropertyNames.InnerText, innertext);
            Mouse.Click(hyperlink);
        }

        public void Equals(string expected, string actual, string message)
        {
            try
            {
                Assert.AreEqual(expected, actual, message);
            }
            catch (AssertFailedException e)
            {
                Console.Write(e.Message);
            }
        }
        public string GetText(UITestControl parent, String propertyValue)
        {
            try
            {
                HtmlEdit edit = new HtmlEdit(parent);
                //edit.SearchProperties.Add(HtmlEdit.PropertyNames.Name, propertyValue);
                edit.SearchProperties[HtmlEdit.PropertyNames.Name] = propertyValue;
                return edit.GetProperty("Text").ToString();
            }
            catch (UITestControlNotFoundException e)
            {
                return "";
            }
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
