using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Extend_Exit
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class ExtendExit
    {
        public ExtendExit()
        {
        }

        [TestMethod]
        public void ExtendTourist()
        {
            XamlWindow appWindow = XamlWindow.Launch(UIMap.UIStartmenuPane.UIStartAppsList.UIMailGroup.UIPTSListItem.AutomationId);
            appWindow.CloseOnPlaybackCleanup = false;
            EnterText(appWindow, "UserNameTextbox", "fro");
            EnterText(appWindow, "PasswordTextbox", "123456");
            //ClickButton(appWindow, "Login");
            Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Enter}");
            UIMap.UIPTSWindow.UISearchButton.WaitForControlExist();
            ClickButton(appWindow, "Search");
            EnterText(appWindow, "PassportSearchTextBox", "mki0");
            ClickButton(appWindow, "PassportSearchButton");
            if (UIMap.UIPTSWindow.UIGridViewList.UIPtsModelInLinePermitListItem.Exists)
            {
                Mouse.Click(UIMap.UIPTSWindow.UIGridViewList.UIPtsModelInLinePermitListItem);
                ClickButton(appWindow, "ExtendRapButton");
                //Keyboard.SendKeys("{Tab}");
                Keyboard.SendKeys("{Down}"); Keyboard.SendKeys("{Down}"); Keyboard.SendKeys("{Down}");
                Playback.Wait(1000);
                ClickButton(appWindow, "SaveIlpExtensionDateButton");
                Playback.Wait(1000);
                Keyboard.SendKeys("{Enter}");
                Playback.Wait(2000);
            }
            else
            {
                ClickButton(appWindow, "ExtendRapButton");
                //Keyboard.SendKeys("{Tab}");
                Keyboard.SendKeys("{Down}");
                Playback.Wait(1000);
                ClickButton(appWindow, "SaveIlpExtensionDateButton");
                Playback.Wait(1000);
                Keyboard.SendKeys("{Enter}");
                Playback.Wait(2000);
            }
        }
        [TestMethod]
        public void ExitTourist()
        {
            XamlWindow appWindow = XamlWindow.Launch(UIMap.UIStartmenuPane.UIStartAppsList.UIMailGroup.UIPTSListItem.AutomationId);
            appWindow.CloseOnPlaybackCleanup = false;
            EnterText(appWindow, "UserNameTextbox", "fro");
            EnterText(appWindow, "PasswordTextbox", "123456");
            //ClickButton(appWindow, "Login");
            Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Enter}");
            UIMap.UIPTSWindow.UISearchButton.WaitForControlExist();
            ClickButton(appWindow, "Search");
            EnterText(appWindow, "PassportSearchTextBox", "fgt440");
            ClickButton(appWindow, "PassportSearchButton");
            if (UIMap.UIPTSWindow.UIGridViewList.UIPtsModelInLinePermitListItem.Exists)
            {
                Mouse.Click(UIMap.UIPTSWindow.UIGridViewList.UIPtsModelInLinePermitListItem);
                UIMap.UIPTSWindow.UIItemList.UIPtsModelTouristListItem.UICheckBoxCheckBox.Checked = true;
                Playback.Wait(2000);
                Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Tab}");
                Keyboard.SendKeys("{Space}");
                Playback.Wait(1000);
                Keyboard.SendKeys("{Escape}");
                ClickButton(appWindow, "EntryExitButton");
                Keyboard.SendKeys("{Enter}");
            }
            else
            {
                UIMap.UIPTSWindow.UIItemList.UIPtsModelTouristListItem.UICheckBoxCheckBox.Checked = true;
                Playback.Wait(2000);
                Keyboard.SendKeys("{Tab}");
                Keyboard.SendKeys("{Space}");
                Playback.Wait(1000);
                Keyboard.SendKeys("{Escape}");
                ClickButton(appWindow, "EntryExitButton");
                Keyboard.SendKeys("{Enter}");
                Playback.Wait(2000);
            }
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
            button.SearchProperties.Add(XamlButton.PropertyNames.AutomationId, id);
            Mouse.Click(button);
        }
        public void SelectItem(XamlControl parent,String id,String value)
        {
            var item = new XamlComboBox(parent);
            item.SearchProperties.Add(XamlComboBox.PropertyNames.AutomationId, id);
            item.SelectedItem = value;
        }
        public void CheckBox(XamlControl parent,String id,Boolean b)
        {
            var check = new XamlCheckBox(parent);
            check.SearchProperties.Add(XamlCheckBox.PropertyNames.Name, id);
            check.Checked = b;
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
