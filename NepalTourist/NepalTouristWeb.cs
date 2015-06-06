using System;
using System.Runtime.InteropServices;

using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace NepalTourist
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class NepalTouristWeb
    {
        public NepalTouristWeb()
        {
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
           var browser = BrowserWindow.Launch("http://raviteja/ptsweb/");
           browser.CloseOnPlaybackCleanup = false;
           ClickLink(browser, "Get Started ! It as easy as 123");
           ClickDatePicker(browser, "fromDate");
           ClickCell(browser, "27");
           EnterText(browser, "username", "Rajesh reddy");
           ClickDatePicker(browser, "DateOfBirth");
           Playback.Wait(2000);
           //ClickCell(browser, "<<");
           ClickSpan(browser, "2010");
           ClickSpan(browser, "Feb");
           ClickCell(browser, "20");
           SelectDrop(browser,"Nationality","Nepal");
           EnterText(browser, "state", "Nepal");
           EnterText(browser, "PhoneNo", "9032577446");
           EnterText(browser, "Email", "Rajeshreddy@ponnala.com");
           EnterText(browser, "PassportNumber", "ffr2376");
           ClickDatePicker(browser, "passportvaliditydate");
           ClickSpan(browser, "2016");
           ClickSpan(browser, "Jun");
           ClickCell(browser, "25");
           EnterArea(browser, "purposeofvisit", "Tourism");
           ClickButton(browser, "Add to group");
           ClickButton(browser, "Save RAP");
           
           
        } 
        void EnterText(UITestControl parent,String id,String value)
        {
            var edit = new HtmlEdit(parent);
            edit.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            edit.Text = value;
        }
        void EnterArea(UITestControl parent, String id, String value)
        {
            var edit = new HtmlTextArea(parent);
            edit.SearchProperties.Add(HtmlTextArea.PropertyNames.Id, id);
            edit.Text = value;
        }
        void SelectDrop(UITestControl parent,String id,String value)
        {
            var select = new HtmlComboBox(parent);
            select.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, id);
            select.SelectedItem = value;
        }
        void ClickLink(UITestControl parent,String innerText)
        {
            var link = new HtmlHyperlink(parent);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText,innerText);
            Mouse.Click(link);
        }
        void ClickButton(UITestControl parent,String innerText)
        {
            var buttonText = new HtmlButton(parent);
            buttonText.SearchProperties.Add(HtmlButton.PropertyNames.InnerText, innerText);
            Mouse.Click(buttonText);
        }
        void ClickDatePicker(UITestControl parent, String id)
        {
            var dateText = new HtmlEdit(parent);
            dateText.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            Mouse.Click(dateText);
        }
       void ClickCell(UITestControl parent,String innerText)
        {
            var dateCell = new HtmlCell(parent);
            dateCell.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, innerText);
            Mouse.Click(dateCell);
        }
        void ClickSpan(UITestControl parent,String innerText)
       {
           var dateYear = new HtmlSpan(parent);
           dateYear.SearchProperties.Add(HtmlSpan.PropertyNames.InnerText, innerText);
           Mouse.Click(dateYear);
       }
        //void ClickIcon(UITestControl parent,String )

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
