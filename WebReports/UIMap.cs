namespace WebReports
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
    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using System.IO;
    
    public partial class UIMap
    {
        public void ValidateTotalRAP(TestContext varTestcontext, int expectedResult)
        {
            this.ValidateTotalRAPExpectedValues.TotalRAPInnerText = expectedResult.ToString();
            Console.WriteLine("Total RAP's issued till now :\t" + this.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UICountriesTable.TotalRAP.InnerText);
            //ValidateTotalRAP();
            //string data = varTestcontext.DataRow["month"].ToString();
            FileInfo f = new FileInfo(@"d:/Results.txt");
            StreamWriter w = f.AppendText();
            w.WriteLine(this.UIHttpsravitejaPtsWebAWindow.UIHttpsravitejaPtsWebADocument1.UICountriesTable.TotalRAP.InnerText+ "\ttotal RAP's issued till now\t");
            w.Close();
        }
        public void ValidateTotalFrame2(TestContext varTestcontext,int expectedResult)
        {
            this.ValidateTotalFrame2ExpectedValues.TotalMonthCount2InnerText = expectedResult.ToString();
            Console.WriteLine("\n\n"+this.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame2.UIMonthlyTouristVisitiDocument.TotalMonthCount2.InnerText);
            //ValidateTotalFrame2();
            string data = varTestcontext.DataRow["month"].ToString();
            FileInfo f = new FileInfo(@"d:/Results.txt");
            StreamWriter w = f.AppendText();
            //TextWriter tw = new StreamWriter("d:/Results.txt");
            w.WriteLine(this.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame2.UIMonthlyTouristVisitiDocument.TotalMonthCount2.InnerText+"\ttourists registered in the month\t"+data);
            w.Close();
        }
        public void TotalTourists(TestContext varTestcontext,int expectedResult)
        {
            this.TotalTouristsExpectedValues.TotalCountSingleFrameInnerText = expectedResult.ToString();
            Console.WriteLine(this.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame4.UIMonthlyTouristVisitiDocument.TotalCountSingleFrame.InnerText);
            //TotalTourists();
            string data = varTestcontext.DataRow["month"].ToString();
            FileInfo f = new FileInfo(@"d:/Results.txt");
            StreamWriter w = f.AppendText();
            w.WriteLine(this.UIGovernmentofSikkimStWindow.UIGovernmentofSikkimStDocument.UIContentPlaceHolder1_Frame4.UIMonthlyTouristVisitiDocument.TotalCountSingleFrame.InnerText + "\ttourists registered in the month\t" + data);
            w.Close();
        }
    }
}
