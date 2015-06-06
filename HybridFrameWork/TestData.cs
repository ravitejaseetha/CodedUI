using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HybridFrameWork
{
    class TestData
    {
        public string DataTouroperator = "Nag travels";
        public string DataFullName = "Rambo";
        public string DataNationality = "Zimbabwe";
        public string DataState = "Harare";
        public string DataPhone = "9032552879";
        public string DataEmail = "ravitejaseetha@gmail.com";
        public string DataPassportNumber = TestContext.DataRow["sdfsdf"].ToString();
        public string DataVisaNumber = TestContext.DataRow["ddd"].ToString();
        
        public static TestContext TestContext
        {
            get
            {
                TestContext testContextInstance = null;
                return testContextInstance;
            }
            set { var testContextInstance = value; }
        }
        
        
    }
  

}

