using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace HybridFrameworkNew
{
    class GlobalFunctions
    {
        public void Textbox_EnterText(UITestControl parent, String id, String value)
        {
            var edit = new HtmlEdit(parent);
            edit.SearchProperties.Add(HtmlEdit.PropertyNames.Id,id);
            edit.Text = value;
        }

        public void Button_Click(UITestControl parent, String innerText)
        {
            var button = new HtmlButton(parent);
            button.SearchProperties.Add(HtmlButton.PropertyNames.InnerText, innerText);
            Mouse.Click(button);
        }

        public void Input_Buttonclick(UITestControl parent, String id)
        {
            var inpButton = new HtmlInputButton(parent);
            inpButton.SearchProperties.Add(HtmlInputButton.PropertyNames.Id,id);
            Mouse.Click(inpButton);
        }
        public void Select_ComboItem(UITestControl parent, String id, String value)
        {
            var item = new HtmlComboBox(parent);
            item.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, id);
            item.SelectedItem = value;
        }
        public void Enter_Textarea(UITestControl parent, String id, String value)
        {
            var edit = new HtmlTextArea(parent);
            edit.SearchProperties.Add(HtmlTextArea.PropertyNames.Id, id);
            edit.Text = value;
        }
        public void Click_HyperLink(UITestControl parent, String innerText)
        {
            var link = new HtmlHyperlink(parent);
            link.SearchProperties.Add(HtmlControl.PropertyNames.InnerText, innerText);
            Mouse.Click(link);
        }
       public void Click_DatePicker(UITestControl parent, String id)
        {
            var dateText = new HtmlEdit(parent);
            dateText.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            Mouse.Click(dateText);
        }
        public void Click_Cell(UITestControl parent, String innerText, String cl)
        {
            var dateCell = new HtmlCell(parent);
            dateCell.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, innerText);
            dateCell.SearchProperties.Add(HtmlCell.PropertyNames.Class,cl);
            Mouse.Click(dateCell);
        }
        public void Click_Span(UITestControl parent, String innerText)
        {
            var dateYear = new HtmlSpan(parent);
            dateYear.SearchProperties.Add(HtmlSpan.PropertyNames.InnerText, innerText);
            Mouse.Click(dateYear);
        }
        public void File_Input(UITestControl parent, String id, String value)
        {
            var input = new HtmlFileInput(parent);
            input.SearchProperties.Add(HtmlFileInput.PropertyNames.Id, id);
            input.FileName = value;
        }

        public void Calender_Arrows(UITestControl parent, String classname, String control)
        {
            var arrow = new HtmlCell(parent);
            arrow.SearchProperties.Add(HtmlCell.PropertyNames.Class, classname);
            arrow.SearchProperties.Add(HtmlCell.PropertyNames.TagInstance,control);
            Mouse.Click(arrow);
        }

        public void Button_Icon(UITestControl parent, String taginstance)
        {
            var icon = new HtmlButton(parent);
            icon.SearchProperties.Add(HtmlButton.PropertyNames.Class, taginstance);
            //icon.SearchProperties.Add(HtmlButton.PropertyNames.Class,classname);
            Mouse.Click(icon);
        }
        public HtmlCell GetCell(UITestControl parent, int row, int column)
        {
            var cell = new HtmlCell(parent);
            cell.SearchProperties.Add(HtmlCell.PropertyNames.RowIndex, row.ToString());
            cell.SearchProperties.Add(HtmlCell.PropertyNames.ColumnIndex, column.ToString());
            return cell;
        }

        public void DialogButton(UITestControl parent, String displayText)
        {
            var button = new HtmlButton(parent);
            button.TechnologyName = "MSAA";
            button.SearchProperties.Add(HtmlButton.PropertyNames.DisplayText,displayText);
            Mouse.Click(button);
        }
    }
}
