using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.Threading.Tasks;


namespace MetroAPP
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class CodedUITest1
    {
        XamlWindow window;
        public CodedUITest1()
        {
        }
        //static private UIMap sharedTest = new UIMap();
        //static public CodedUITest1 sharedTest2 = new CodedUITest1();
        //[ClassInitialize]
        //static public void ClassInt(TestContext context)
        //{
        //    Playback.Initialize();
        //    try
        //    {
                
        //        XamlWindow window = XamlWindow.Launch("15fa5c6d-509c-4ea1-9459-cb4b0a9a0b35_bqdmac4rycgqj!App");
        //        //window.CloseOnPlaybackCleanup = false;
        //        UIMap list1 = new UIMap();
        //        list1.EnterText(window, "UserNameTextbox", "ramesh");
        //        list1.EnterText(window, "PasswordTextbox", "123456");
        //        list1.ClickButton(window, "Login");
        //    }
        //    finally
        //    {
        //        Playback.Cleanup();
        //    }
        //}
        

        [TestMethod]
        public async Task MetroTourist()
        {
             XamlWindow window = XamlWindow.Launch("15fa5c6d-509c-4ea1-9459-cb4b0a9a0b35_bqdmac4rycgqj!App");
             //window.CloseOnPlaybackCleanup = false;
             UIMap list = new UIMap();
             list.EnterText(window, "UserNameTextbox", "ramesh");
             list.EnterText(window, "PasswordTextbox", "123456");
             list.ClickButton(window, "Login");
             for (int i = 0; i < 2; i++)
             {
                 list.ClickButton(window, "Newilp");
                 list.EnterText(window, "ArrivedFromTextBox", "Delhi");
                 list.EnterText(window, "FullNameTextBox", "Raju");
                 list.SelectItem(window, "Gendercombobox", 0);
                 list.SelectItem(window, "MonthPicker", 5);
                 list.SelectItem(window, "YearPicker", 50);
                 list.SelectItem(window, "CountryCombobox", 10);
                 list.EnterText(window, "PhoneNumberTextBox", "9032552879");
                 list.EnterText(window, "PasssportTextBox", "K9H7"+i);
                 Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Down}");
                 list.EnterText(window, "VisaNumberTextBox", "VTR123");
                 list.SelectItem(window, "VisaTypeComboBox", 7);
                 list.EnterText(window, "VisaIssuedInComboBox", "SouthAfrica");
                 list.ClickButton(window, "UploadButtonButton"); Playback.Wait(2000);
                 Keyboard.SendKeys("{Space}"); Playback.Wait(1000);
                 Keyboard.SendKeys("{Enter}");
                 list.ClickButton(window, "PhotoAppBarButton"); Playback.Wait(2000);
                 Keyboard.SendKeys("{Space}"); Playback.Wait(2000);
                 Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Enter}"); Playback.Wait(2000);
                 Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UIAddButton); Playback.Wait(1000);
                 //var input = UIMap.UIPTSWindow.UIItemPane.UIAcceptsonlyalphabetsButton;
                 
                 
              
                 list.ClickButton(window, "SaveAndPrintButton");
                 UIMap.UIPTSWindow.UIRAPReportText.WaitForControlExist(); Playback.Wait(3000);
                 list.ClickButton(window, "BackButton");
            }

             await list.resultsAsync();
             
             
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        //public void EnterText(XamlControl appWindow, String id, String value)
        //{
        //    var edit = new XamlEdit(appWindow);
        //    edit.SearchProperties.Add(XamlEdit.PropertyNames.AutomationId, id);
        //    edit.Text = value;
        //}
        //public void ClickButton(XamlControl appWindow, String id)
        //{
        //    var button = new XamlButton(appWindow);
        //    button.SearchProperties.Add(XamlButton.PropertyNames.AutomationId, id);
        //    Mouse.Click(button);
        //}
        //public void SelectItem(XamlControl appWindow, String id, int value)
        //{
        //    var item = new XamlComboBox(appWindow);
        //    item.SearchProperties.Add(XamlComboBox.PropertyNames.AutomationId, id);
        //    item.SelectedIndex = value;
        //}
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
        //    window.Close(); // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
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
if ((this.map == null)) {
    this.map = new UIMap();
}

return this.map;
            }
        }

        private UIMap map;
    }
}
