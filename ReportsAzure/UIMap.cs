namespace ReportsAzure
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
        public void WriteLogs(TestContext varTestcontext, string Status)
        {
            string strAppPath = varTestcontext.DataRow["month"].ToString();
            FileInfo f = new FileInfo(strAppPath + "Results.txt");
            StreamWriter w = f.AppendText();
            //Azure
            //w.WriteLine("Module : " + Status + " TimeStamp : \t" + DateTime.Now.ToString() + "\tToal No of RAP's issued till now :\t" + this.UIHttpssikkimptsazurewWindow.UIHttpssikkimptsazurewDocument.UICountriesTable.RAPCount.InnerText );
            //Local
            w.WriteLine("Total RAP's issued in till now :" + this.UIHttpsravitejaPtsWebAWindow1.UIHttpsravitejaPtsWebADocument.UICountriesTable.LocalCount.InnerText);
            w.Close();
        }
        //Azure
        public void TotalRAPCount(TestContext varTestcontext,int expectedResult)
        {
            this.TotalRAPCountExpectedValues.RAPCountInnerText = expectedResult.ToString();
            Console.WriteLine("Total RAP's issued till now" + this.UIHttpssikkimptsazurewWindow.UIHttpssikkimptsazurewDocument.UICountriesTable.RAPCount.InnerText);
            TotalRAPCount();
        }
        //Local
        public void LocalRAPCount(int expectedResult2)
        {
            this.LocalRAPCountExpectedValues.LocalCountInnerText = expectedResult2.ToString();
            Console.WriteLine("Total RAP's issued till now :" +this.UIHttpsravitejaPtsWebAWindow1.UIHttpsravitejaPtsWebADocument.UICountriesTable.LocalCount.InnerText);
            LocalRAPCount();
            FileInfo f = new FileInfo("Results.txt");
            StreamWriter w = f.AppendText();
            w.WriteLine("Total RAP's issued till now:" + this.mUIHttpsravitejaPtsWebAWindow1.UIHttpsravitejaPtsWebADocument.UICountriesTable.LocalCount.InnerText);
            w.Close();
        }
    }
}
