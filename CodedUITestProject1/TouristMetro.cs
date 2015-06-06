using System;

using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
//using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace CodedUITestProject1
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class TouristMetro
    {
        public TouristMetro()
        {
        }
        #region Launch App and Signin
        [TestInitialize]
        public void launch()
        {
            XamlWindow appWindow = XamlWindow.Launch("15fa5c6d-509c-4ea1-9459-cb4b0a9a0b35_bqdmac4rycgqj!App");  // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items..
            //appWindow.CloseOnPlaybackCleanup = false;
            
            UIMap.UIPTSWindow.UIUserNameTextboxEdit.WaitForControlExist();
            this.UIMap.LoginAssert();
            Gesture.Tap(UIMap.UIPTSWindow.UIUserNameTextboxEdit);
            Keyboard.SendKeys("user");
            Gesture.Tap(UIMap.UIPTSWindow.UIPasswordTextboxEdit);
            Keyboard.SendKeys("Design_20");
            Keyboard.SendKeys("{tab}");
            Keyboard.SendKeys("{Enter}");
            UIMap.UIPTSWindow.UINewilpButton.WaitForControlExist();
            Mouse.Click(UIMap.UIPTSWindow.UINewilpButton);
            UIMap.UIPTSWindow.UIItemPane.UIArrivedFromTextBoxEdit.WaitForControlExist();
            //UIMap.UIPTSWindow.UIDatepickerGroup2.UIDayComboBox.SelectedIndex = 0;
            //UIMap.UIPTSWindow.UIDatepickerGroup2.UIMonthComboBox.SelectedIndex = 1;
            //UIMap.UIPTSWindow.UIDatepickerGroup1.UIDayComboBox.SelectedIndex = 26; Playback.Wait(2000);
            //UIMap.UIPTSWindow.UIDatepickerGroup1.UIMonthComboBox.SelectedIndex = 1;
            UIMap.UIPTSWindow.UIItemPane.UIArrivedFromTextBoxEdit.Text = "Bagdogra";
            
        }
        #endregion

        #region Tourist Registration
        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"),TestMethod,Priority(1)]
        //[DataSource("System.Data.Odbc", "Dsn=Excel Files;Driver={Microsoft Excel Driver (*.xls)};dbq=|DataDirectory|\\Data.xls;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "Sheet1$", DataAccessMethod.Sequential), TestMethod]
        public void NormalTourist()
        {
           String[] array = { "Rakesh", "Kiran", "Rakesh", "Kiran", "Rakesh", "Kiran"};
           for (var j = 0; j <1;j++)
            {
            
            UIMap.UIPTSWindow.UIDatepickerGroup2.UIDayComboBox.SelectedIndex = int.Parse(TestContext.DataRow["date"].ToString());
            UIMap.UIPTSWindow.UIItemPane.UIFullNameTextBoxEdit.Text = array[j];//TestContext.DataRow["Name"].ToString();
            UIMap.UIPTSWindow.UIItemPane.UIGendercomboboxComboBox.SelectedIndex = 0;
            Mouse.Click(UIMap.UIPTSWindow.UIDatepickerGroup.UIYearComboBox);
            UIMap.UIPTSWindow.UIDatepickerGroup.UIYearComboBox.SelectedIndex = 30;
            var countries = UIMap.UIPTSWindow.UIItemPane.UICountryComboboxComboBox.Items;
            var count = countries.Count;
            UIMap.UIPTSWindow.UIItemPane.UICountryComboboxComboBox.SelectedIndex = 7;
            Gesture.Tap(UIMap.UIPTSWindow.UIItemPane.UIPhoneNumberTextBoxEdit);
            Keyboard.SendKeys("9032552879");
            UIMap.UIPTSWindow.UIItemPane.UIPasssportTextBoxEdit.Text = (TestContext.DataRow["id"].ToString()) + j;
            Keyboard.SendKeys("{tab}");
            Keyboard.SendKeys("{tab}");
            Keyboard.SendKeys("{tab}");
            Keyboard.SendKeys("{down}");
            Gesture.Tap(UIMap.UIPTSWindow.UIItemPane.UIVisaNumberTextBoxEdit);
            Keyboard.SendKeys("CD221");
            UIMap.UIPTSWindow.UIItemPane.UIVisaTypeComboBoxComboBox.SelectedIndex = 7;
            Gesture.Tap(UIMap.UIPTSWindow.UIItemPane.UIVisaIssuedInComboBoxEdit);
            Keyboard.SendKeys("Canberra");
            Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UIUploadButtonButtonButton);
            Playback.Wait(2000); Keyboard.SendKeys("{Space}");
            Keyboard.SendKeys("{Enter}");
            Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UIPhotoButton); Playback.Wait(2000);
            Playback.Wait(2000);
            Keyboard.SendKeys("{Space}");
            Playback.Wait(2000);
            Mouse.Click(UIMap.UIPTSWindow.UIIdPhotoCommandBarToolBar.UIAcceptcurrentphotoButton); Playback.Wait(2000);
            Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UIAddButton); Playback.Wait(1000);
            //this.UIMap.AssertMethod1();
            UIMap.UIPTSWindow.UIItemPane.UIVisaIssuedInComboBoxEdit.Text = null;
            UIMap.UIPTSWindow.UIItemPane.UIPhoneNumberTextBoxEdit.Text = null;
            //Mouse.Click(UIMap.UIPTSWindow.UIBackButton);
            
           }
           
        }
     
        #endregion


        #region Nepal Tourist Registration
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod,Priority(2)]
        public void NepalTourist()
        {
            String[] array = { "Rakesh", "Kiran", "Rahul", "Yuvraj", "Rakesh", "Kiran", "Rahul", "Yuvraj", "Rakesh", "Kiran", "Rahul", "Yuvraj" };

            for (var j = 0; j < 1; j++)
            {
                UIMap.UIPTSWindow.UIDatepickerGroup2.UIDayComboBox.SelectedIndex = int.Parse(TestContext.DataRow["date"].ToString());
                UIMap.UIPTSWindow.UIItemPane.UIFullNameTextBoxEdit.Text = array[j];//TestContext.DataRow["Name"].ToString();
                UIMap.UIPTSWindow.UIItemPane.UIGendercomboboxComboBox.SelectedIndex = 0;
                Mouse.Click(UIMap.UIPTSWindow.UIDatepickerGroup.UIYearComboBox);
                UIMap.UIPTSWindow.UIDatepickerGroup.UIYearComboBox.SelectedIndex = 30;
                var countries = UIMap.UIPTSWindow.UIItemPane.UICountryComboboxComboBox.Items;
                var count = countries.Count;
                UIMap.UIPTSWindow.UIItemPane.UICountryComboboxComboBox.SelectedIndex = 5;
                UIMap.UIPTSWindow.UIItemPane.UIPasssportTextBoxEdit.Text = (TestContext.DataRow["id"].ToString())+j;
                UIMap.UIPTSWindow.UIItemPane.UIPhoneNumberTextBoxEdit.Text = "9425466662";
                Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UIUploadButtonButtonButton);
                Playback.Wait(2000); Keyboard.SendKeys("{Space}");
                Keyboard.SendKeys("{Enter}");
                Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UIPhotoButton); Playback.Wait(2000);
                Keyboard.SendKeys("{Space}");
                //UIMap.UIPTSWindow.UIIdPhotoCommandBarToolBar.UIAcceptcurrentphotoButton.WaitForControlExist();
                Playback.Wait(2000);
                Mouse.Click(UIMap.UIPTSWindow.UIIdPhotoCommandBarToolBar.UIAcceptcurrentphotoButton); Playback.Wait(2000);
                Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UIAddButton); Playback.Wait(1000);
                UIMap.UIPTSWindow.UIItemPane.UIPhoneNumberTextBoxEdit.Text = null;
           }
        }
        #endregion

        #region Save RAP and validate report
        [TestCleanup]
        public void SaveRap()
        {
            Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UISaveAndPrintButtonButton);
            UIMap.UIPTSWindow.UIRAPReportText.WaitForControlExist();
            UIMap.UIPTSWindow.UIScrollViewerPane.UIHelpandassistanceTelText.UIItemImage.WaitForControlExist();
            Playback.Wait(2000);
            
            //CloseApp();
        }
        private void CloseApp()
        {
            var middle = UIMap.UIPTSWindow.Width / 2;
            Gesture.Slide(UIMap.UIPTSWindow, new Point(middle, 2), new Point(middle, UIMap.UIPTSWindow.Height - 1));
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
