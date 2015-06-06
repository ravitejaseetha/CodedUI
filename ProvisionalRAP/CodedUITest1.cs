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


namespace ProvisionalRAP
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class CodedUITest1
    {
        XamlWindow appWindow;
        public CodedUITest1()
        {
        }
        [TestInitialize]
        public void launch()
        {
           appWindow = XamlWindow.Launch(UIMap.UIStartmenuPane.UIStartAppsList.UIMailGroup.UIPTSListItem.AutomationId);

        }

        [TestMethod]
        public void Provisional()
        {
            appWindow.CloseOnPlaybackCleanup = false;
            UIMap.UIPTSWindow.UIUserNameTextboxEdit.Text = "ramesh";
            UIMap.UIPTSWindow.UIPasswordTextboxEdit.Text = "123456";
            Mouse.Click(UIMap.UIPTSWindow.UILoginButton);
            Mouse.Click(UIMap.UIPTSWindow.UISearchButton);
            UIMap.UIPTSWindow.UIPassportSearchTextBoEdit.Text = "SATE6";
            Mouse.Click(UIMap.UIPTSWindow.UIPassportSearchButtonButton);
            Playback.Wait(2000);
            var count = UIMap.UIPTSWindow.UIItemList.Items;
            Debug.WriteLine("Total Tourists in the list :"+count.Count);
            foreach (var i in count)
            {
                list(appWindow, "Pts.Model.Tourist");
                Playback.Wait(5000);
                UIMap.UIPTSWindow.UIDatepickerGroup.UIDayComboBox.SelectedIndex = 21;
                UIMap.UIPTSWindow.UIDatepickerGroup.UIMonthComboBox.SelectedIndex = 1;
                UIMap.UIPTSWindow.UIItemPane.UIArrivedFromTextBoxEdit.Text = "Delhi";
                Playback.Wait(2000);
                Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UIUploadButtonButtonButton);
                Playback.Wait(2000);
                Keyboard.SendKeys("{Space}"); Keyboard.SendKeys("{Enter}"); Playback.Wait(5000);
                Keyboard.SendKeys("{Tab}"); Keyboard.SendKeys("{Enter}");
                Playback.Wait(3000);
                Keyboard.SendKeys("{Space}"); Playback.Wait(4000);
                Mouse.Click(UIMap.UIPTSWindow.UIIdPhotoCommandBarToolBar.UIAcceptcurrentphotoButton);
                Playback.Wait(3000);
                Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UIUpdateButton);
                Playback.Wait(5000);
                
               
                
            }
            
            Mouse.Click(UIMap.UIPTSWindow.UIItemPane.UISaveAndPrintButtonButton);
            this.UIMap.RAP();

        }
      
        public void EnterText(XamlControl parent, String id, String value)
        {
            var edit = new XamlEdit(parent);
            edit.SearchProperties.Add(XamlEdit.PropertyNames.AutomationId, id);
            edit.Text = value;

        }
        public void ClickButton(XamlControl parent, String id)
        {
            var button = new XamlButton(parent);
            button.SearchProperties.Add(XamlButton.PropertyNames.Instance, id);
            Mouse.Click(button);

        }
        public void list(XamlControl parent, String id)
        {
            var lisitem = new XamlListItem(parent);
            lisitem.SearchProperties.Add(XamlListItem.PropertyNames.Name, id);
            Mouse.Click(lisitem);
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
