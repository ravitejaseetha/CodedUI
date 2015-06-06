using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace WebReports
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class WebReport
    {
        
        static BrowserWindow window;
        public WebReport()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void ReportWeb()
        {
            //int expected = int.Parse(sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UICountriesTable.TotalRAP.InnerText);
            //this.UIMap.ValidateTotalRAP(expected);
            //Mouse.Click(sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UIReportsHyperlink);
            //Mouse.Click(sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UITouristMonthlyVisitiHyperlink);
            
            Playback.Wait(2000);
            this.UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIDateInputEdit.Text = TestContext.DataRow["month"].ToString();
            Debug.WriteLine("Tourists for the month:" + TestContext.DataRow["month"].ToString());
            Mouse.Click(UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UISearchButton);

            Playback.Wait(2000);
            if (UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIItem2Pane.InnerText.Equals("2"))
            {
               
                Mouse.Click(UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Table.UIItemCell);
                Playback.Wait(2000);
                int expected2 = int.Parse(this.UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame2.UIMonthlyTouristVisitiDocument.TotalMonthCount2.InnerText);
                Playback.Wait(2000);
                this.UIMap.ValidateTotalFrame2(TestContext, expected2);
                Image pic = UITestControl.Desktop.CaptureImage();
                pic.Save(@"d:\"+TestContext.DataRow["month"].ToString()+".jpeg",ImageFormat.Jpeg);
                pic.Dispose();

            }
            else
            {
                int expectedCount = int.Parse(this.UIMap.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame4.UIMonthlyTouristVisitiDocument.TotalCountSingleFrame.InnerText);
                this.UIMap.TotalTourists(TestContext,expectedCount);
            }
            Playback.Wait(2000);
        }
        public void ClickButton(UITestControl parent,String id)
        {
            var button = new HtmlButton(parent);
            button.SearchProperties.Add(HtmlButton.PropertyNames.Id, id);
            Mouse.Click(button);
        }
        static public UIMap sharedTest = new UIMap();
        [ClassInitialize]
        static public void ClassInit(TestContext context)
        {
            Playback.Initialize();
            try
            {
                UIMap sharedTest1 = new UIMap();
                BrowserWindow.CurrentBrowser = "IE";
                BrowserWindow window = BrowserWindow.Launch("http://raviteja/ptsweb/admin/signin");
                window.Maximized = true;
                window.CloseOnPlaybackCleanup = false;
                sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument.UIUsernameEdit.Text = "admin";
                sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument.UIPasswordEdit.Text = "Design_20";
                Mouse.Click(sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument.UISignInButton);
                Playback.Wait(2000);
                //UIMap test = new UIMap();
                int expected = int.Parse(sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UICountriesTable.TotalRAP.InnerText);
                sharedTest.ValidateTotalRAP(context,expected);
                Mouse.Click(sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UIReportsHyperlink);
                Mouse.Click(sharedTest.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UITouristMonthlyVisitiHyperlink);
                Playback.Wait(2000);
            }
            finally
            {
                //Playback.Cleanup();
            }

        }
        static public UIMap sharedTest1 = new UIMap();
        [ClassCleanup]
        static public void ClassCleanup()
        {
            Playback.Initialize();
            try
            {

                Mouse.Click(sharedTest1.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UIItemHyperlink);
                Mouse.Click(sharedTest1.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UILogoutHyperlink);
                //window.Close();
            }
            finally
            {
                Playback.Cleanup();
            }
        }
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
