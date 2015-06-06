namespace SapmleReports
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
    using System.IO;
    
    
    public partial class UIMap
    {
        public void ValidateLocation(TestContext varTestcontext, String expectedResult)
        {
            this.LocationExpectedValues.LocationNameInnerText = expectedResult;
            //Console.WriteLine(expectedResult);
            //ValidateLocation(varTestcontext, expectedResult);
            //string data = varTestcontext.DataRow["month"].ToString();
            FileInfo f = new FileInfo(@"d:/Results.txt");
            StreamWriter w = f.AppendText();
            w.WriteLine(this.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame.UIRAPIssuanceReportDocument.LocationName.InnerText);
            w.Close();
        }

       
    }
}
