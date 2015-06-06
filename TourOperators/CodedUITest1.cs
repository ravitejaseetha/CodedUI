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


namespace TourOperators
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        static public BrowserWindow Browser;
        public CodedUITest1()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv",DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void TourOp()
        {
            using (var sharedTest1 = new UIMap())
            {
                //browser.CloseOnPlaybackCleanup = false;
                //Playback.Wait(3000);
                //Mouse.Click(UIMap.UIHttpsravitejaPtsWebaWindow.UIHttpsravitejaPtsWebtDocument.UITourOperatorHyperlink);
                sharedTest1.ClickLink(Browser, "Tour Operator", "HtmlHyperlink");
                sharedTest1.EnterText(Browser, "name", TestContext.DataRow["name"].ToString());
                sharedTest1.EnterText(Browser, "travelagency", TestContext.DataRow["travel"].ToString());
                sharedTest1.EnterText(Browser, "registrationnumber", TestContext.DataRow["reg"].ToString());
                sharedTest1.EnterText(Browser, "mobilenumber", TestContext.DataRow["mobile"].ToString());
                sharedTest1.EnterText(Browser, "phonenumber", TestContext.DataRow["phone"].ToString());
                sharedTest1.EnterArea(Browser, "address", TestContext.DataRow["address"].ToString());
                sharedTest1.EnterText(Browser, "email", TestContext.DataRow["email"].ToString());
                sharedTest1.EnterText(Browser, "website", TestContext.DataRow["website"].ToString());
                sharedTest1.EnterText(Browser, "locationname", TestContext.DataRow["location"].ToString());
                sharedTest1.SelectDrop(Browser, "grade", TestContext.DataRow["grade"].ToString());
                sharedTest1.EditClick(Browser, "renewedupto");
                MessageBox.Show(TestContext.DataRow["date"].ToString(), "Renewed date", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                sharedTest1.EnterArea(Browser, "remarks", TestContext.DataRow["remarks"].ToString());
                sharedTest1.InputButton(Browser, "Create");
                Playback.Wait(2000);
            }
        }

        static public UIMap SharedTest = new UIMap();
        [ClassInitialize]
        static public void ClassInit(TestContext context)
        {
            Playback.Initialize();
            try
            {
                
                Browser = BrowserWindow.Launch("http://raviteja/ptsweb/admin/signin");
                Browser.Maximized = true;
                Browser.CloseOnPlaybackCleanup = false;
                SharedTest.EnterText(Browser, "username", "admin");
                SharedTest.EnterText(Browser, "password", "Design_20");
                SharedTest.InputButton(Browser, "Sign In"); Playback.Wait(1000);
                SharedTest.ClickLink(Browser, "Tour Operators", "HtmlHyperlink");
            }
            finally
            {
                //Playback.Cleanup();
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
