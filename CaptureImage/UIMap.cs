namespace CaptureImage
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    
    
    public partial class UIMap
    {
        public void HyperLink(UITestControl parent, String id)
        {
            var hyperlink = new HtmlHyperlink(parent);
            hyperlink.SearchProperties.Add(HtmlHyperlink.PropertyNames.Id, id);
            Mouse.Click(hyperlink);
        }
        public void EditBox(UITestControl parent, String id, String value)
        {
            var edit = new HtmlEdit(parent);
            edit.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            edit.Text = value;
        }
        public void ComboBox(UITestControl parent, String id, String value)
        {
            var combo = new HtmlComboBox(parent);
            combo.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, id);
            combo.SelectedItem = value;
        }
        public void DateYearMonth(UITestControl parent, String innertext)
        {
            var date = new HtmlSpan(parent);
            date.SearchProperties.Add(HtmlSpan.PropertyNames.InnerText, innertext);
            Mouse.Click(date);
        }
        public void DatePicker(UITestControl parent, String innertext)
        {
            var date = new HtmlCell(parent);
            date.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, innertext);
            Mouse.Click(date);
        }
        public void EditClick(UITestControl parent, String id)
        {
            var date = new HtmlEdit(parent);
            date.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            Mouse.Click(date);
        }
        public void Button(UITestControl parent,String innertext)
        {
            var button = new HtmlButton(parent);
            button.SearchProperties.Add(HtmlButton.PropertyNames.InnerText, innertext);
            Mouse.Click(button);
        }
        public void TextArea(UITestControl parent, String id, String value)
        {
            var textarea = new HtmlTextArea(parent);
            textarea.SearchProperties.Add(HtmlTextArea.PropertyNames.Id, id);
            textarea.Text = value;
        }
        public static bool isEnabled(UITestControl parent)
        {
            var editwait = new HtmlSpan(parent);
            return editwait.InnerText == "RAP Report";
        }
        
    }
}
