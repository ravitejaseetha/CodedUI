using Microsoft.VisualStudio.TestTools.UITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsMetro
{
    public class CustomCaller
    {
        public static void EnterText()
        {
            CustomUIWindow customItemWin = new CustomUIWindow();
            customItemWin.UIUserNameTextboxEdit.Text = "ramesh";
            customItemWin.UIPasswordTextboxEdit.Text = "123456";
        }
        public static void ButtonClick()
        {
            //Instance for calc window
            //CustomUI customWindow = new CustomUI();
            CustomUIWindow customItemWindow = new CustomUIWindow();
            Mouse.Click(customItemWindow.UILoginButton);
            
        }
    }
}
