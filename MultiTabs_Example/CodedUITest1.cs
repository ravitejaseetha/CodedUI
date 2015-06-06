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
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace MultiTabs_Example
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

        [TestMethod]
        public void CodedUITestMethod1()
        {
            //BrowserWindow.CurrentBrowser = "Chrome";
            BrowserWindow myBrowser = BrowserWindow.Launch();
            myBrowser.CloseOnPlaybackCleanup = false;
            myBrowser.NavigateToUrl(new System.Uri("http://bing.com/"));

            var proc = myBrowser.Process;
            WinTabList tabList = new WinTabList(myBrowser);
            WinButton newTabButton = new WinButton(tabList);
            newTabButton.SearchProperties[WinButton.PropertyNames.Name] = "New Tab (Ctrl+T)";
           
            Mouse.Click(newTabButton);
            Playback.Wait(3000);
            myBrowser = BrowserWindow.FromProcess(proc);
            //myBrowser.SearchProperties[UITestControl.PropertyNames.Name] = "New Tab";
            //myBrowser.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            myBrowser.NavigateToUrl(new System.Uri("http://yahoo.com/"));

            Mouse.Click(newTabButton);
            Playback.Wait(3000);
            myBrowser = BrowserWindow.FromProcess(proc);
            myBrowser.SearchProperties[UITestControl.PropertyNames.Name] = "New Tab";
            //myBrowser.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            myBrowser.NavigateToUrl(new System.Uri("http://google.com/"));// To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
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
