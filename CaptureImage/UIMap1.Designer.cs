﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CaptureImage.UIMap1Classes
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
    public partial class UIMap1
    {
        
        /// <summary>
        /// UpdateButton - Use 'UpdateButtonExpectedValues' to pass parameters into this method.
        /// </summary>
        public void UpdateButton()
        {
            #region Variable Declarations
            HtmlDiv uIUpdateTouristPane = this.UIHttpsravitejaPtsWebiWindow.UIHttpsravitejaPtsWebiDocument.UIRegisterFormCustom.UIUpdateTouristPane;
            #endregion

            // Verify that the 'InnerText' property of 'UpdateTourist' pane equals ' UpdateTourist  '
            Assert.AreEqual(this.UpdateButtonExpectedValues.UIUpdateTouristPaneInnerText, uIUpdateTouristPane.InnerText, "Button not found ");
        }
        
        #region Properties
        public virtual UpdateButtonExpectedValues UpdateButtonExpectedValues
        {
            get
            {
                if ((this.mUpdateButtonExpectedValues == null))
                {
                    this.mUpdateButtonExpectedValues = new UpdateButtonExpectedValues();
                }
                return this.mUpdateButtonExpectedValues;
            }
        }
        
        public UIHttpsravitejaPtsWebiWindow UIHttpsravitejaPtsWebiWindow
        {
            get
            {
                if ((this.mUIHttpsravitejaPtsWebiWindow == null))
                {
                    this.mUIHttpsravitejaPtsWebiWindow = new UIHttpsravitejaPtsWebiWindow();
                }
                return this.mUIHttpsravitejaPtsWebiWindow;
            }
        }
        #endregion
        
        #region Fields
        private UpdateButtonExpectedValues mUpdateButtonExpectedValues;
        
        private UIHttpsravitejaPtsWebiWindow mUIHttpsravitejaPtsWebiWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'UpdateButton'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UpdateButtonExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'InnerText' property of 'UpdateTourist' pane equals ' UpdateTourist  '
        /// </summary>
        public string UIUpdateTouristPaneInnerText = "UpdateTourist";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHttpsravitejaPtsWebiWindow : BrowserWindow
    {
        
        public UIHttpsravitejaPtsWebiWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "https://raviteja/PtsWeb/ilp/register";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("https://raviteja/PtsWeb/ilp/register");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHttpsravitejaPtsWebiDocument UIHttpsravitejaPtsWebiDocument
        {
            get
            {
                if ((this.mUIHttpsravitejaPtsWebiDocument == null))
                {
                    this.mUIHttpsravitejaPtsWebiDocument = new UIHttpsravitejaPtsWebiDocument(this);
                }
                return this.mUIHttpsravitejaPtsWebiDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHttpsravitejaPtsWebiDocument mUIHttpsravitejaPtsWebiDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIHttpsravitejaPtsWebiDocument : HtmlDocument
    {
        
        public UIHttpsravitejaPtsWebiDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/PtsWeb/ilp/register";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://raviteja/PtsWeb/ilp/register";
            this.WindowTitles.Add("https://raviteja/PtsWeb/ilp/register");
            #endregion
        }
        
        #region Properties
        public UIRegisterFormCustom UIRegisterFormCustom
        {
            get
            {
                if ((this.mUIRegisterFormCustom == null))
                {
                    this.mUIRegisterFormCustom = new UIRegisterFormCustom(this);
                }
                return this.mUIRegisterFormCustom;
            }
        }
        #endregion
        
        #region Fields
        private UIRegisterFormCustom mUIRegisterFormCustom;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.21005.1")]
    public class UIRegisterFormCustom : HtmlCustom
    {
        
        public UIRegisterFormCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "FORM";
            this.SearchProperties["Id"] = "registerForm";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = "form-horizontal bv-form";
            this.FilterProperties["ControlDefinition"] = "class=\"form-horizontal bv-form\" id=\"regi";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("https://raviteja/PtsWeb/ilp/register");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIUpdateTouristPane
        {
            get
            {
                if ((this.mUIUpdateTouristPane == null))
                {
                    this.mUIUpdateTouristPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIUpdateTouristPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIUpdateTouristPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIUpdateTouristPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "UpdateTourist  ";
                    this.mUIUpdateTouristPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIUpdateTouristPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "col-lg-6";
                    this.mUIUpdateTouristPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"col-lg-6\"";
                    this.mUIUpdateTouristPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "112";
                    this.mUIUpdateTouristPane.WindowTitles.Add("https://raviteja/PtsWeb/ilp/register");
                    #endregion
                }
                return this.mUIUpdateTouristPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIUpdateTouristPane;
        #endregion
    }
}
