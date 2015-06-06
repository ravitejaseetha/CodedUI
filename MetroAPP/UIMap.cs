namespace MetroAPP
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using Microsoft.VisualStudio.TestTools.UITest.Input;
    using MouseButtons = Microsoft.VisualStudio.TestTools.UITest.Input.MouseButtons;
    using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
    using System.IO;
    using System.Diagnostics;
    using System.Threading.Tasks;
    
    public partial class UIMap
    {
        public void EnterText(XamlControl appWindow, String id, String value)
        {
            var edit = new XamlEdit(appWindow);
            edit.SearchProperties.Add(XamlEdit.PropertyNames.AutomationId, id);
            edit.Text = value;
        }
        public void ClickButton(XamlControl appWindow, String id)
        {
            var button = new XamlButton(appWindow);
            button.SearchProperties.Add(XamlButton.PropertyNames.AutomationId, id);
            Mouse.Click(button);
        }
        public void SelectItem(XamlControl appWindow, String id, int value)
        {
            var item = new XamlComboBox(appWindow);
            item.SearchProperties.Add(XamlComboBox.PropertyNames.AutomationId, id);
            item.SelectedIndex = value;
        }

     
       
        public async Task resultsAsync()
        {
             FileInfo f = new FileInfo(@"d:/Results.txt");
             using (StreamWriter sw = f.AppendText())
             {
                 sw.WriteLine("Results for the date" + DateTime.Today);
                 sw.Close();
             }
            string line;
            using (StreamReader reader = new StreamReader(@"d:/Results.txt"))
            {
                line = await reader.ReadToEndAsync();
                Debug.WriteLine(line);
                //return line;
                
            }
      
        }
        
    }
}


