using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace UsingGenerics
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
        BrowserWindow browser;
        [TestMethod]
        public void CodedUITestMethod1()
        {
               
            browser = BrowserWindow.Launch("https://raviteja/ptsweb");
            browser.CloseOnPlaybackCleanup = false;
            EnterText<HtmlEdit>(PropertyType.Id, "userName", "gjd@gmail.com");
            EnterText<HtmlEdit>(PropertyType.Name, "password", "Design_20");
            Playback.Wait(1000);
            Click<HtmlInputButton>(PropertyType.Id, "login");
            Click<HtmlEdit>(PropertyType.Id, "fromDate");
            Click<HtmlCell>(PropertyType.InnerText, "25");
            EnterText<HtmlEdit>(PropertyType.Id, "username", "Roger");
            Click<HtmlEdit>(PropertyType.Id, "DateOfBirth");
            Click<HtmlSpan>(PropertyType.InnerText, "2010");
            Click<HtmlSpan>(PropertyType.InnerText, "Jun");
            Click<HtmlCell>(PropertyType.InnerText, "21");
            EnterText<HtmlComboBox>(PropertyType.Id, "Nationality", "Srilanka");
        }

        public void EnterText<T>(PropertyType type, string propertyValue, string text) where T : HtmlControl
        {
            HtmlControl genericControl = (T)Activator.CreateInstance(typeof (T), new object[] {browser});
            if (type == PropertyType.Name)
                genericControl.SearchProperties.Add(HtmlControl.PropertyNames.Name,propertyValue);
            else if (type == PropertyType.Id)
                genericControl.SearchProperties.Add(HtmlControl.PropertyNames.Id, propertyValue);
            else if (type == PropertyType.InnerText)
                genericControl.SearchProperties.Add(HtmlControl.PropertyNames.InnerText, propertyValue);
            Keyboard.SendKeys(genericControl, text);
            
        }

        public void Click<T>(PropertyType type, string propertyValue) where T : HtmlControl
        {
            HtmlControl genericControl = (T) Activator.CreateInstance(typeof (T), new object[] {browser});
            if (type == PropertyType.Name)
                genericControl.SearchProperties[HtmlControl.PropertyNames.Name] = propertyValue;
            else if (type == PropertyType.Id)
                genericControl.SearchProperties[HtmlControl.PropertyNames.Id] = propertyValue;
            else if (type == PropertyType.InnerText)
                genericControl.SearchProperties[HtmlControl.PropertyNames.InnerText] = propertyValue;
            else if (type == PropertyType.ClassName)
                genericControl.SearchProperties[HtmlControl.PropertyNames.ClassName] = propertyValue;
            Mouse.Click(genericControl);
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
        public enum PropertyType
        {
            Id,
            Name,
            ClassName,
            InnerText,
            TagInstance,
            DisplayText,
        }
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
