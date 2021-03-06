﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace ReportsAzure
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// LocalRAPCount - Use 'LocalRAPCountExpectedValues' to pass parameters into this method.
        /// </summary>
        public void LocalRAPCount()
        {
            #region Variable Declarations
            HtmlCell localCount = this.UIHttpsravitejaPtsWebAWindow1.UIHttpsravitejaPtsWebADocument.UICountriesTable.LocalCount;
            #endregion

            // Verify that the 'InnerText' property of '816' cell equals '816'
            Assert.AreEqual(this.LocalRAPCountExpectedValues.LocalCountInnerText, localCount.InnerText, "Not found");
        }
        
        /// <summary>
        /// SignIn - Use 'SignInParams' to pass parameters into this method.
        /// </summary>
        public void SignIn()
        {
            #region Variable Declarations
            HtmlEdit uIUsernameEdit = this.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument.UIUsernameEdit;
            HtmlEdit uIPasswordEdit = this.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument.UIPasswordEdit;
            HtmlInputButton uISignInButton = this.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument.UISignInButton;
            #endregion

            // Type 'admin' in 'username' text box
            uIUsernameEdit.Text = this.SignInParams.UIUsernameEditText;

            // Type '********' in 'password' text box
            uIPasswordEdit.Password = this.SignInParams.UIPasswordEditPassword;

            // Click 'Sign In' button
            Mouse.Click(uISignInButton, new Point(44, 15));
        }
        
        /// <summary>
        /// TotalRAPCount - Use 'TotalRAPCountExpectedValues' to pass parameters into this method.
        /// </summary>
        public void TotalRAPCount()
        {
            #region Variable Declarations
            HtmlCell rAPCount = this.UIHttpssikkimptsazurewWindow.UIHttpssikkimptsazurewDocument.UICountriesTable.RAPCount;
            #endregion

            // Verify that the 'InnerText' property of '2557' cell equals '2557'
            Assert.AreEqual(this.TotalRAPCountExpectedValues.RAPCountInnerText, rAPCount.InnerText, "Not Found");
        }
        
        #region Properties
        public virtual LocalRAPCountExpectedValues LocalRAPCountExpectedValues
        {
            get
            {
                if ((this.mLocalRAPCountExpectedValues == null))
                {
                    this.mLocalRAPCountExpectedValues = new LocalRAPCountExpectedValues();
                }
                return this.mLocalRAPCountExpectedValues;
            }
        }
        
        public virtual SignInParams SignInParams
        {
            get
            {
                if ((this.mSignInParams == null))
                {
                    this.mSignInParams = new SignInParams();
                }
                return this.mSignInParams;
            }
        }
        
        public virtual TotalRAPCountExpectedValues TotalRAPCountExpectedValues
        {
            get
            {
                if ((this.mTotalRAPCountExpectedValues == null))
                {
                    this.mTotalRAPCountExpectedValues = new TotalRAPCountExpectedValues();
                }
                return this.mTotalRAPCountExpectedValues;
            }
        }
        
        public UIHttpssikkimptsazurewWindow UIHttpssikkimptsazurewWindow
        {
            get
            {
                if ((this.mUIHttpssikkimptsazurewWindow == null))
                {
                    this.mUIHttpssikkimptsazurewWindow = new UIHttpssikkimptsazurewWindow();
                }
                return this.mUIHttpssikkimptsazurewWindow;
            }
        }
        
        public UIHttpsravitejaPtsWebAWindow UIHttpsravitejaPtsWebAWindow
        {
            get
            {
                if ((this.mUIHttpsravitejaPtsWebAWindow == null))
                {
                    this.mUIHttpsravitejaPtsWebAWindow = new UIHttpsravitejaPtsWebAWindow();
                }
                return this.mUIHttpsravitejaPtsWebAWindow;
            }
        }
        
        public UIHttpsravitejaPtsWebAWindow1 UIHttpsravitejaPtsWebAWindow1
        {
            get
            {
                if ((this.mUIHttpsravitejaPtsWebAWindow1 == null))
                {
                    this.mUIHttpsravitejaPtsWebAWindow1 = new UIHttpsravitejaPtsWebAWindow1();
                }
                return this.mUIHttpsravitejaPtsWebAWindow1;
            }
        }
        #endregion
        
        #region Fields
        private LocalRAPCountExpectedValues mLocalRAPCountExpectedValues;
        
        private SignInParams mSignInParams;
        
        private TotalRAPCountExpectedValues mTotalRAPCountExpectedValues;
        
        private UIHttpssikkimptsazurewWindow mUIHttpssikkimptsazurewWindow;
        
        private UIHttpsravitejaPtsWebAWindow mUIHttpsravitejaPtsWebAWindow;
        
        private UIHttpsravitejaPtsWebAWindow1 mUIHttpsravitejaPtsWebAWindow1;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'LocalRAPCount'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class LocalRAPCountExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of '816' cell equals '816'
        /// </summary>
        public string LocalCountInnerText = "816";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'SignIn'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class SignInParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'admin' in 'username' text box
        /// </summary>
        public string UIUsernameEditText = "admin";
        
        /// <summary>
        /// Type '********' in 'password' text box
        /// </summary>
        public string UIPasswordEditPassword = "lUdvQtd4h59Qj8/MRj8Ych6B3dQLCw48";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TotalRAPCount'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class TotalRAPCountExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of '2557' cell equals '2557'
        /// </summary>
        public string RAPCountInnerText = "2557";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHttpssikkimptsazurewWindow : BrowserWindow
    {
        
        public UIHttpssikkimptsazurewWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "https://sikkimpts.azurewebsites.net/Admin";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("https://sikkimpts.azurewebsites.net/Admin");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpssikkimptsazurewDocument UIHttpssikkimptsazurewDocument
        {
            get
            {
                if ((this.mUIHttpssikkimptsazurewDocument == null))
                {
                    this.mUIHttpssikkimptsazurewDocument = new UIHttpssikkimptsazurewDocument(this);
                }
                return this.mUIHttpssikkimptsazurewDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpssikkimptsazurewDocument mUIHttpssikkimptsazurewDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHttpssikkimptsazurewDocument : HtmlDocument
    {
        
        public UIHttpssikkimptsazurewDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/Admin";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://sikkimpts.azurewebsites.net/Admin";
            this.WindowTitles.Add("https://sikkimpts.azurewebsites.net/Admin");
            #endregion
        }
        
        #region Properties
        public UICountriesTable UICountriesTable
        {
            get
            {
                if ((this.mUICountriesTable == null))
                {
                    this.mUICountriesTable = new UICountriesTable(this);
                }
                return this.mUICountriesTable;
            }
        }
        #endregion
        
        #region Fields
        private UICountriesTable mUICountriesTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UICountriesTable : HtmlTable
    {
        
        public UICountriesTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = "countries";
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties[HtmlTable.PropertyNames.InnerText] = "Location\r\n\r\nNumber of RAP\'s\r\n\r\n\r\nTotal R";
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "class=\"table table-striped table-bordered \" id=\"countries\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "13";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "2";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "table table-striped table-bordered ";
            this.FilterProperties[HtmlTable.PropertyNames.TagInstance] = "1";
            this.WindowTitles.Add("https://sikkimpts.azurewebsites.net/Admin");
            #endregion
        }
        
        #region Properties
        public HtmlCell RAPCount
        {
            get
            {
                if ((this.mRAPCount == null))
                {
                    this.mRAPCount = new HtmlCell(this);
                    #region Search Criteria
                    this.mRAPCount.SearchProperties[HtmlCell.PropertyNames.Id] = null;
                    this.mRAPCount.SearchProperties[HtmlCell.PropertyNames.Name] = null;
                    this.mRAPCount.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mRAPCount.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "class=\"text-center\" data-bind=\"text: m_Item2\"";
                    this.mRAPCount.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "10";
                    this.mRAPCount.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mRAPCount.FilterProperties[HtmlCell.PropertyNames.Class] = "text-center";
                    this.mRAPCount.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "20";
                    this.mRAPCount.WindowTitles.Add("https://sikkimpts.azurewebsites.net/Admin");
                    #endregion
                }
                return this.mRAPCount;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mRAPCount;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHttpsravitejaPtsWebAWindow : BrowserWindow
    {
        
        public UIHttpsravitejaPtsWebAWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "https://raviteja/PtsWeb/Admin/SignIn";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("https://raviteja/PtsWeb/Admin/SignIn");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpsravitejaPtsWebADocument UIHttpsravitejaPtsWebADocument
        {
            get
            {
                if ((this.mUIHttpsravitejaPtsWebADocument == null))
                {
                    this.mUIHttpsravitejaPtsWebADocument = new UIHttpsravitejaPtsWebADocument(this);
                }
                return this.mUIHttpsravitejaPtsWebADocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpsravitejaPtsWebADocument mUIHttpsravitejaPtsWebADocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHttpsravitejaPtsWebADocument : HtmlDocument
    {
        
        public UIHttpsravitejaPtsWebADocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/PtsWeb/Admin/SignIn";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://raviteja/PtsWeb/Admin/SignIn";
            this.WindowTitles.Add("https://raviteja/PtsWeb/Admin/SignIn");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIUsernameEdit
        {
            get
            {
                if ((this.mUIUsernameEdit == null))
                {
                    this.mUIUsernameEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIUsernameEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "username";
                    this.mUIUsernameEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "username";
                    this.mUIUsernameEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUIUsernameEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIUsernameEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIUsernameEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control";
                    this.mUIUsernameEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"username\" class=\"form-control\" id=";
                    this.mUIUsernameEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "1";
                    this.mUIUsernameEdit.WindowTitles.Add("https://raviteja/PtsWeb/Admin/SignIn");
                    #endregion
                }
                return this.mUIUsernameEdit;
            }
        }
        
        public HtmlEdit UIPasswordEdit
        {
            get
            {
                if ((this.mUIPasswordEdit == null))
                {
                    this.mUIPasswordEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIPasswordEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "password";
                    this.mUIPasswordEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "password";
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "PASSWORD";
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control";
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"password\" class=\"form-control\" id=";
                    this.mUIPasswordEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "2";
                    this.mUIPasswordEdit.WindowTitles.Add("https://raviteja/PtsWeb/Admin/SignIn");
                    #endregion
                }
                return this.mUIPasswordEdit;
            }
        }
        
        public HtmlInputButton UISignInButton
        {
            get
            {
                if ((this.mUISignInButton == null))
                {
                    this.mUISignInButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUISignInButton.SearchProperties[HtmlButton.PropertyNames.Id] = "btn-signIn";
                    this.mUISignInButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUISignInButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Sign In";
                    this.mUISignInButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUISignInButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUISignInButton.FilterProperties[HtmlButton.PropertyNames.Class] = "btn btn-primary pull-left";
                    this.mUISignInButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"btn btn-primary pull-left\" id=\"bt";
                    this.mUISignInButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "3";
                    this.mUISignInButton.WindowTitles.Add("https://raviteja/PtsWeb/Admin/SignIn");
                    #endregion
                }
                return this.mUISignInButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIUsernameEdit;
        
        private HtmlEdit mUIPasswordEdit;
        
        private HtmlInputButton mUISignInButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHttpsravitejaPtsWebAWindow1 : BrowserWindow
    {
        
        public UIHttpsravitejaPtsWebAWindow1()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "https://raviteja/PtsWeb/Admin";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("https://raviteja/PtsWeb/Admin");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpsravitejaPtsWebADocument1 UIHttpsravitejaPtsWebADocument
        {
            get
            {
                if ((this.mUIHttpsravitejaPtsWebADocument == null))
                {
                    this.mUIHttpsravitejaPtsWebADocument = new UIHttpsravitejaPtsWebADocument1(this);
                }
                return this.mUIHttpsravitejaPtsWebADocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpsravitejaPtsWebADocument1 mUIHttpsravitejaPtsWebADocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHttpsravitejaPtsWebADocument1 : HtmlDocument
    {
        
        public UIHttpsravitejaPtsWebADocument1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/PtsWeb/Admin";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://raviteja/PtsWeb/Admin";
            this.WindowTitles.Add("https://raviteja/PtsWeb/Admin");
            #endregion
        }
        
        #region Properties
        public UICountriesTable1 UICountriesTable
        {
            get
            {
                if ((this.mUICountriesTable == null))
                {
                    this.mUICountriesTable = new UICountriesTable1(this);
                }
                return this.mUICountriesTable;
            }
        }
        #endregion
        
        #region Fields
        private UICountriesTable1 mUICountriesTable;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UICountriesTable1 : HtmlTable
    {
        
        public UICountriesTable1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlTable.PropertyNames.Id] = "countries";
            this.SearchProperties[HtmlTable.PropertyNames.Name] = null;
            this.FilterProperties[HtmlTable.PropertyNames.InnerText] = "Location\r\n\r\nNumber of RAP\'s\r\n\r\n\r\nTotal R";
            this.FilterProperties[HtmlTable.PropertyNames.ControlDefinition] = "class=\"table table-striped table-bordered \" id=\"countries\"";
            this.FilterProperties[HtmlTable.PropertyNames.RowCount] = "10";
            this.FilterProperties[HtmlTable.PropertyNames.ColumnCount] = "2";
            this.FilterProperties[HtmlTable.PropertyNames.Class] = "table table-striped table-bordered ";
            this.FilterProperties[HtmlTable.PropertyNames.TagInstance] = "1";
            this.WindowTitles.Add("https://raviteja/PtsWeb/Admin");
            #endregion
        }
        
        #region Properties
        public HtmlCell LocalCount
        {
            get
            {
                if ((this.mLocalCount == null))
                {
                    this.mLocalCount = new HtmlCell(this);
                    #region Search Criteria
                    this.mLocalCount.SearchProperties[HtmlCell.PropertyNames.Id] = "";
                    this.mLocalCount.SearchProperties[HtmlCell.PropertyNames.Name] = "";
                    this.mLocalCount.SearchProperties[HtmlCell.PropertyNames.MaxDepth] = "3";
                    this.mLocalCount.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "class=\"text-center\" data-bind=\"text: m_Item2\"";
                    this.mLocalCount.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "7";
                    this.mLocalCount.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mLocalCount.FilterProperties[HtmlCell.PropertyNames.Class] = "text-center";
                    this.mLocalCount.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "14";
                    this.mLocalCount.WindowTitles.Add("https://raviteja/PtsWeb/Admin");
                    #endregion
                }
                return this.mLocalCount;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCell mLocalCount;
        #endregion
    }
}
