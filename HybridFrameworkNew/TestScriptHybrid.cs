using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace HybridFrameworkNew
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class TestScriptHybrid
    {
        private static BrowserWindow browser;
        private GlobalFunctions gs;
        public TestScriptHybrid()
        {
        }
        [ClassInitialize]
        static public void BrowserUrl(TestContext context)
        {
            try
            {
                Playback.Initialize();
                BrowserWindow.CurrentBrowser = "IE";
                browser = BrowserWindow.Launch("https://raviteja/PtsWeb/ilp/register");
                browser.Maximized = true;
                browser.CloseOnPlaybackCleanup = false;
                Playback.Wait(2000);
                Playback.PlaybackSettings.MatchExactHierarchy = true;
            }
            finally
            {
               Playback.Cleanup();
            }
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV","|DataDirectory|\\data.csv","data#csv",DataAccessMethod.Sequential),DeploymentItem("data.csv"),TestMethod]
        public void AddTourist()
        {
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.Disabled;
            gs = new GlobalFunctions();
            gs.Select_ComboItem(browser,Variables.StrTourop,DataTest.DataTouroperator);
            gs.Click_DatePicker(browser,Variables.StrArrivaldate);
            //cannot access non static field in static context . We either need to make the variable static or create an instance(object) of the class to access the variables
            //gs.Calender_Arrows(browser,Variables.StrCalendernext,"9");
            gs.Click_Cell(browser, "30", Variables.StrDaytype);
            String[] namesTourists = {"Rahul", "Karthik", "Jaiswal"};
            for (int i = 0; i < 2; i++)
            {
                gs.Textbox_EnterText(browser, Variables.StrUsername, namesTourists[i]);
                gs.Click_DatePicker(browser, Variables.StrDateofBirth);
                gs.Click_Span(browser, DataTest.DataYearBirth);
                gs.Click_Span(browser, DataTest.DataMonthBirth);
                gs.Click_Cell(browser, "2"+i, Variables.StrDaytype);
                gs.Select_ComboItem(browser, Variables.StrNationality, DataTest.DataNationality);
                gs.Textbox_EnterText(browser, Variables.StrState, DataTest.DataState);
                gs.Textbox_EnterText(browser, Variables.StrPhoneNo, DataTest.DataPhone);
                gs.Textbox_EnterText(browser, Variables.StrEmail, DataTest.DataEmail);
                gs.Textbox_EnterText(browser, Variables.StrPassportNumber, (TestContext.DataRow["passport"].ToString())+i);
                gs.Click_DatePicker(browser, Variables.StrPassportValidity);
                gs.Click_Span(browser, DataTest.DataYearPassport);
                gs.Click_Span(browser, DataTest.DataMonthPassport);
                gs.Click_Cell(browser, "2"+i, Variables.StrDaytype);
                gs.Textbox_EnterText(browser, Variables.StrVisaNumber, (TestContext.DataRow["visa"].ToString())+i);
                gs.Select_ComboItem(browser, Variables.StrVisaType, DataTest.DataVisaType);
                gs.Click_DatePicker(browser, Variables.StrVisaValidity);
                gs.Click_Span(browser, DataTest.DataYearVisa);
                gs.Click_Span(browser, DataTest.DataMonthVisa);
                gs.Click_Cell(browser, "1"+i, Variables.StrDaytype);
                gs.Textbox_EnterText(browser, Variables.StrVisaIssuedin, DataTest.DataVisaIssuedin);
                gs.Enter_Textarea(browser, Variables.StrPurposeofVisit, DataTest.DataPurposeofVisit);
                //gs.Input_Buttonclick(browser,Variables.StrCapture);
                //Playback.Wait(6000);
                //gs.Button_Click(browser,Variables.StrSnapshot);
                //gs.Button_Click(browser,Variables.StrSavechange);
                Playback.Wait(1000);
                //gs.Button_Click(browser,Variables.StrAddtoGroup);
                Keyboard.SendKeys("{Tab},{Tab},{Tab},{Tab},{Enter}");
                Playback.Wait(1000);
            }
            //gs.Button_Icon(browser, Variables.StrEditiconclass);
            //gs.Textbox_EnterText(browser, Variables.StrUsername, DataTest.DataFullName);
            //gs.Button_Click(browser, Variables.StrUpdate);
            //var cell = gs.GetCell(browser, 2, 1);
            //Assert.AreEqual("Karthik", cell.InnerText, "Full name wrong");
            //cell = gs.GetCell(browser, 2, 0);
            //gs.Button_Icon(cell, Variables.StrDeleteicon);
            //Keyboard.SendKeys("{Enter}");
            //gs.Button_Click(browser,Variables.StrSave);
            //UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame.UIILPReportDocument.UIItemPane.WaitForControlExist();
            //Assert.AreEqual("Rambo",GetTextReport(browser, "textBox19 s7-"),"Failed");
        }
        public string GetTextReport(UITestControl parent,String classname)
        {
            var name = new HtmlDiv(parent);
            name.SearchProperties.Add(UITestControl.PropertyNames.ClassName,classname);
            return name.GetProperty("FriendlyName").ToString();
        }
        [TestMethod]
        public void EditTourist()
        {
            Playback.PlaybackSettings.WaitForReadyLevel = WaitForReadyLevel.Disabled;
            var gs = new GlobalFunctions();
            //Mouse.Click(UIMap.UIHttpsravitejaPtsWebiWindow.UIHttpsravitejaPtsWebiDocument.UITouristsTable.UIItemButton);
            //MessageBox.Show("hi", "message", MessageBoxButtons.OKCancel);
            gs.Button_Icon(browser, Variables.StrEditiconclass);
        }
        [TestCleanup]
        public void EndOfTest()
        {
            if (TestContext.CurrentTestOutcome == UnitTestOutcome.Passed)
            {
                Image image = UITestControl.Desktop.CaptureImage();
                image.Save(@"d:\" + TestContext.TestName + ".jpeg", ImageFormat.Jpeg);
                image.Dispose();
                FileInfo f = new FileInfo(@"d:\Results.txt");
                StreamWriter sw = f.AppendText();
                sw.WriteLine(TestContext.TestName + "Passed");
                sw.Close();
            }
        }
        public string GetText(UITestControl parent, String value)
        {
            try
            {
                var edit = new HtmlButton(parent);
                edit.SearchProperties.Add(HtmlButton.PropertyNames.Id, value);
                return edit.GetProperty("ValueAttribute").ToString();
            }
            catch(UITestControlNotFoundException e)
            {
                return "";
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
        private  TestContext testContextInstance;
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
