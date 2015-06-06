using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace TouristStatus
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class TouristStatus
    {
        public TouristStatus()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            XamlWindow appWindow = XamlWindow.Launch(UIMap.UIStartmenuPane.UIStartAppsList.UIMailGroup.UIPTSListItem.AutomationId);// To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            appWindow.CloseOnPlaybackCleanup = false;
            EnterText(appWindow, "UserNameTextbox", "fro");
            EnterText(appWindow, "PasswordTextbox", "123456");
            Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Enter}");
            UIMap.UIPTSWindow.UISearchButton.WaitForControlExist();
            ClickButton(appWindow, "Search");
            EnterText(appWindow, "PassportSearchTextBox", "fgt440");
            ClickButton(appWindow, "PassportSearchButton");
            ClickButton(appWindow, "converttoinsikimbutton");
            Keyboard.SendKeys("{Enter}");
            Playback.Wait(2000);
        }
        
        public void EnterText(XamlControl parent,String id,String value)
        {
            
            var edit = new XamlEdit(parent);
            edit.SearchProperties.Add(XamlEdit.PropertyNames.AutomationId, id);
            edit.Text = value;

        }
        public void ClickButton(XamlControl parent,String id)
        {
            var button = new XamlButton(parent);
            button.SearchProperties.Add(XamlEdit.PropertyNames.AutomationId, id);
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
