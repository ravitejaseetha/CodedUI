using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsMetro
{
    class CustomUI : XamlWindow
    {

        public CustomUI()
        {
            #region Search Criteria
            this.SearchProperties[XamlControl.PropertyNames.Name] = "PTS";
            this.SearchProperties[XamlControl.PropertyNames.ClassName] = "Windows.UI.Core.CoreWindow";
            this.WindowTitles.Add("PTS");
            #endregion
        }

    }
}
