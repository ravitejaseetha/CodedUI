namespace TourOperators
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
        public void EnterText(UITestControl parent, String id, String value)
        {
            var edit = new HtmlEdit(parent);
            edit.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            edit.Text = value;
        }
        public void EnterArea(UITestControl parent, String id, String value)
        {
            var edit = new HtmlTextArea(parent);
            edit.SearchProperties.Add(HtmlTextArea.PropertyNames.Id, id);
            edit.Text = value;
        }
        public void SelectDrop(UITestControl parent, String id, String value)
        {
            var select = new HtmlComboBox(parent);
            select.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, id);
            select.SelectedItem = value;
            // select.SelectedIndex = value;
        }
       public void ClickLink(UITestControl parent, String innerText,String clName)
        {
            var link = new HtmlHyperlink(parent);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, innerText);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.ClassName, clName);
            Mouse.Click(link);
        }
        public void ClickButton(UITestControl parent, String innerText)
        {
            var buttonText = new HtmlButton(parent);
            buttonText.SearchProperties.Add(HtmlButton.PropertyNames.InnerText, innerText);
            Mouse.Click(buttonText);
        }
        public void ClickDatePicker(UITestControl parent, String id)
        {
            var dateText = new HtmlEdit(parent);
            dateText.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            Mouse.Click(dateText);
        }
        public void ClickCell(UITestControl parent, String innerText)
        {
            var dateCell = new HtmlCell(parent);
            dateCell.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, innerText);
            Mouse.Click(dateCell);
        }
        public void ClickSpan(UITestControl parent, String innerText)
        {
            var dateYear = new HtmlSpan(parent);
            dateYear.SearchProperties.Add(HtmlSpan.PropertyNames.InnerText, innerText);
            Mouse.Click(dateYear);
        }
        public void InputButton(UITestControl parent, String displayText)
        {
            HtmlInputButton button = new HtmlInputButton(parent);
            button.SearchProperties.Add(HtmlInputButton.PropertyNames.DisplayText, displayText);
            Mouse.Click(button);
        }
        public void EditClick(UITestControl parent, String id)
        {
            HtmlEdit edit1 = new HtmlEdit(parent);
            edit1.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            Mouse.Click(edit1);
        }
    }
}
