using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        // connect to local sql server
        //[DataSource("System.Data.SqlClient", "Data Source=.\\RAVITEJA;Initial catalog=PTS;Integrated Security=True", "Tourists", DataAccessMethod.Sequential), TestMethod]
        [TestMethod]
        public void CodedUITestMethod1()
        {
               
            browser = BrowserWindow.Launch("https://raviteja/ptsweb");
            Playback.PlaybackSettings.DelayBetweenActions = 1000;
            browser.CloseOnPlaybackCleanup = false;
            browser.Maximized = true;
            EnterText<HtmlEdit>(PropertyType.Id, "userName", "gjd@gmail.com");
            EnterText<HtmlEdit>(PropertyType.Name, "password", "Design_20");
            Playback.Wait(1000);
            Click<HtmlInputButton>(PropertyType.Id, "login");
            Click<HtmlEdit>(PropertyType.Id, "fromDate");
            Click<HtmlCell>(PropertyType.InnerText, "31", "today day");
            EnterText<HtmlEdit>(PropertyType.Id, "username","rt");
            Click<HtmlEdit>(PropertyType.Id, "DateOfBirth");
            Click<HtmlSpan>(PropertyType.InnerText, "2010");
            Click<HtmlSpan>(PropertyType.InnerText, "Jun");
            Click<HtmlCell>(PropertyType.InnerText, "21");
            EnterText<HtmlComboBox>(PropertyType.Id, "Nationality", "Srilanka");
            EnterText<HtmlEdit>(PropertyType.Id, "state","columbo");
            //string connectionString =
            //    @"Data Source =192.168.0.11\technoid;Initial Catalog=PTS;Integrated Security=True";
            //SqlConnection intellex = new SqlConnection(connectionString);
            //string sqlQuery = "Select FirstName from Tourists";
            //SqlCommand command = new SqlCommand(sqlQuery,intellex);
            //intellex.Open();
            //SqlDataReader reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    string intellexName = reader.GetString(0);
            //    Console.WriteLine(intellexName);
            //}
            //reader.Close();
            SqlConnection conn = new SqlConnection("Data Source=192.168.0.11\\technoid;Initial Catalog=PTS;User ID=sa;Password=Design_20;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select FirstName from Tourists");
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
             Console.WriteLine(reader.GetString(0));
            }
            reader.Close();
            conn.Close();
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

        public void Click<T>(PropertyType type, string propertyValue, String filterProperties = null) where T : HtmlControl
        {
            HtmlControl genericControl = (T) Activator.CreateInstance(typeof (T), new object[] {browser});
            if (type == PropertyType.Id)
                genericControl.SearchProperties[HtmlControl.PropertyNames.Id] = propertyValue;
            else if (type == PropertyType.ClassName)
                genericControl.SearchProperties[HtmlControl.PropertyNames.ClassName] = propertyValue;
            else if (type == PropertyType.InnerText)
                genericControl.SearchProperties[HtmlControl.PropertyNames.InnerText] = propertyValue;
            else if (type == PropertyType.Id && filterProperties != null)
                genericControl.SearchProperties[HtmlControl.PropertyNames.Id] = propertyValue;
                genericControl.FilterProperties[HtmlControl.PropertyNames.Class] = filterProperties;
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
