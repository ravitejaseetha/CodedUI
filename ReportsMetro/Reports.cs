using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace ReportsMetro
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class Reports
    {
        public Reports()
        {
        }
        #region TouristVisiting report
        [TestMethod]
        public void TouristReport()
        {
            XamlWindow appWindow = XamlWindow.Launch(UIMap.UIStartmenuPane.UIStartAppsList.UIMailGroup.UIPTSListItem.AutomationId);
            appWindow.CloseOnPlaybackCleanup = false;// To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            EditText(appWindow, "UserNameTextbox", "ramesh");
            EditText(appWindow, "PasswordTextbox", "123456"); Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Enter}");
            //ClickButton(appWindow, "Login");
            ClickButton(appWindow, "Reports");
            ClickButton(appWindow, "TouristVisitingReportButton");
            SelectItem(appWindow, "DayPicker", 8);
            Mouse.Click(UIMap.UIPTSWindow.UISearchButton);
            Playback.Wait(5000);
            int total = int.Parse(UIMap.UIPTSWindow.UIScrollViewerPane.TotalTourists.Name);

            this.UIMap.TouristCountExpectedValues.TotalTouristsDisplayText = total.ToString();
            Playback.Wait(2000);
            //this.UIMap.TouristCount();
            //UIMap form = new UIMap();
            
            //form.TouristCountExpectedValues.UIItem10TextDisplayText = "10"; Playback.Wait(2000);
            //form.TouristCount();
            
            

          
           // CustomCaller.EnterText();

            //CustomCaller.ButtonClick(); Playback.Wait(8000);
             
            

        }
        #endregion 

        public void EditText(XamlControl parent,String id,String value)
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
        public void SelectItem(XamlControl parent,String id,int value)
        {
            var item = new XamlComboBox(parent);
            item.SearchProperties.Add(XamlComboBox.PropertyNames.AutomationId, id);
            item.SelectedIndex = value;
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
