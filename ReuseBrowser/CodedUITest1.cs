using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace ReuseBrowser
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        private static Process proc = null;
        public CodedUITest1()
        {
        }

        
        [ClassInitialize]
        public static void initializeTest(TestContext context)
        {
            Playback.Initialize();
            //BrowserWindow.CurrentBrowser = "Chrome";
            var browser = BrowserWindow.Launch(new Uri("http://bing.com"));
            proc = browser.Process;
            browser.Maximized = true;
            browser.CloseOnPlaybackCleanup = false;
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            BrowserWindow browser = BrowserWindow.FromProcess(proc);
            browser.Close();
        }
        [TestMethod]
        public void CodedUITestMethod1()
        {
            BrowserWindow browser = BrowserWindow.FromProcess(proc);
            browser.NavigateToUrl(new Uri("http://bing.com"));
            EnterSearch(browser,"Pluralsight Coded ui training");
            ClickSearch(browser);
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        [TestMethod]
        public void CodedUITestMethod2()
        {
            BrowserWindow browser = BrowserWindow.FromProcess(proc);
            browser.NavigateToUrl(new Uri("http://bing.com"));
            EnterSearch(browser,"Selenium webdriver");
            ClickSearch(browser);
        }

        [TestMethod]
        public void CodedUITestMethod3()
        {
            BrowserWindow browser = BrowserWindow.FromProcess(proc);
            browser.NavigateToUrl(new Uri("http://bing.com"));
            EnterSearch(browser,"BDD framework");
            ClickSearch(browser);
        }
        public void EnterSearch(UITestControl parent, String value)
        {
            var edit = new HtmlEdit(parent);
            edit.SearchProperties.Add(HtmlEdit.PropertyNames.Id, "sb_form_q");
            edit.Text = value;
        }

        public void ClickSearch(UITestControl parent)
        {
            var button = new HtmlInputButton(parent);
            button.SearchProperties.Add(HtmlButton.PropertyNames.Id, "sb_form_go");
            Mouse.Click(button);
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
    }
}
