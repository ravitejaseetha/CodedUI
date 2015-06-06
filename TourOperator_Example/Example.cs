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


namespace TourOperator_Example
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class Example
    {
        public Example()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void CodedUITestMethod1()
        {
            Mouse.Click(UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument.UITourOperatorHyperlink);  // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UINameEdit.Text = TestContext.DataRow["name"].ToString();
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UITravelAgencyEdit.Text = TestContext.DataRow["travel"].ToString();
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UIRegistrationNumberEdit.Text = TestContext.DataRow["reg"].ToString();
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UIMobileNumberEdit.Text = TestContext.DataRow["mobile"].ToString();
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UIPhoneNumberEdit.Text = TestContext.DataRow["phone"].ToString();
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UIAddressEdit.Text = TestContext.DataRow["address"].ToString();
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UIEmailEdit.Text = TestContext.DataRow["email"].ToString();
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UIWebsiteEdit.Text = TestContext.DataRow["website"].ToString();
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UILocationNameEdit.Text = TestContext.DataRow["location"].ToString(); Playback.Wait(1000);
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UIGradeComboBox.SelectedItem = TestContext.DataRow["grade"].ToString(); Playback.Wait(1000);
            Mouse.Click(UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UIRenewedUptoEdit);
            //Keyboard.SendKeys("{Enter}");
            MessageBox.Show("Hello", "Hi", MessageBoxButtons.OK);
            UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UIRemarksEdit.Text = TestContext.DataRow["remarks"].ToString();
            Mouse.Click(UIMap.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument1.UIMshtmlHTMLInputElemeCustom.UICreateButton);
            Playback.Wait(2000);

        }
        static public UIMap sharedTest = new UIMap();
        [ClassInitialize]
        static public void ClassIni(TestContext context)
        {
            Playback.Initialize();
            try
            {
                BrowserWindow window = BrowserWindow.Launch("http://raviteja/ptsweb/admin/signin");
                window.Maximized = true;
                window.CloseOnPlaybackCleanup = false;
                sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument.UIUsernameEdit.Text = "admin";
                sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument.UIPasswordEdit.Text = "Design_20";
                Mouse.Click(sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument.UISignInButton);
                Mouse.Click(sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UITourOperatorsHyperlink);
                
            }
            finally
            {
               //Playback.Cleanup();
            }
        }
        static public UIMap sharedTest1 = new UIMap();
        [ClassCleanup]
        static public void ClassClean()
        {
            Playback.Initialize();
            try
            {
                Mouse.Click(sharedTest1.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument.UIItemHyperlink);
                Mouse.Click(sharedTest1.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebtDocument.UILogoutHyperlink);
            }
            finally
            {
                Playback.Cleanup();
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
