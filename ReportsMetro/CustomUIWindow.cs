using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportsMetro
{

    public class CustomUIWindow : XamlWindow
    {

        public CustomUIWindow()
        {
            #region Search Criteria
            this.SearchProperties[XamlControl.PropertyNames.Name] = "PTS";
            this.SearchProperties[XamlControl.PropertyNames.ClassName] = "Windows.UI.Core.CoreWindow";
            this.WindowTitles.Add("PTS");
            #endregion
        }

        #region Properties
        public XamlEdit UIUserNameTextboxEdit
        {
            get
            {
                if ((this.mUIUserNameTextboxEdit == null))
                {
                    this.mUIUserNameTextboxEdit = new XamlEdit(this);
                    #region Search Criteria
                    this.mUIUserNameTextboxEdit.SearchProperties[XamlEdit.PropertyNames.AutomationId] = "UserNameTextbox";
                    this.mUIUserNameTextboxEdit.WindowTitles.Add("PTS");
                    #endregion
                }
                return this.mUIUserNameTextboxEdit;
            }
        }

        public XamlEdit UIPasswordTextboxEdit
        {
            get
            {
                if ((this.mUIPasswordTextboxEdit == null))
                {
                    this.mUIPasswordTextboxEdit = new XamlEdit(this);
                    #region Search Criteria
                    this.mUIPasswordTextboxEdit.SearchProperties[XamlEdit.PropertyNames.AutomationId] = "PasswordTextbox";
                    this.mUIPasswordTextboxEdit.WindowTitles.Add("PTS");
                    #endregion
                }
                return this.mUIPasswordTextboxEdit;
            }
        }

        public XamlButton UILoginButton
        {
            get
            {
                if ((this.mUILoginButton == null))
                {
                    this.mUILoginButton = new XamlButton(this);
                    #region Search Criteria
                    this.mUILoginButton.SearchProperties[XamlButton.PropertyNames.AutomationId] = "Login";
                    this.mUILoginButton.WindowTitles.Add("PTS");
                    #endregion
                }
                return this.mUILoginButton;
            }
        }

        public XamlButton UIReportsButton
        {
            get
            {
                if ((this.mUIReportsButton == null))
                {
                    this.mUIReportsButton = new XamlButton(this);
                    #region Search Criteria
                    this.mUIReportsButton.SearchProperties[XamlButton.PropertyNames.AutomationId] = "Reports";
                    this.mUIReportsButton.WindowTitles.Add("PTS");
                    #endregion
                }
                return this.mUIReportsButton;
            }
        }

        public XamlButton UITouristVisitingReporButton
        {
            get
            {
                if ((this.mUITouristVisitingReporButton == null))
                {
                    this.mUITouristVisitingReporButton = new XamlButton(this);
                    #region Search Criteria
                    this.mUITouristVisitingReporButton.SearchProperties[XamlButton.PropertyNames.AutomationId] = "TouristVisitingReportButton";
                    this.mUITouristVisitingReporButton.WindowTitles.Add("PTS");
                    #endregion
                }
                return this.mUITouristVisitingReporButton;
            }
        }

        public UIDatepickerGroup UIDatepickerGroup
        {
            get
            {
                if ((this.mUIDatepickerGroup == null))
                {
                    this.mUIDatepickerGroup = new UIDatepickerGroup(this);
                }
                return this.mUIDatepickerGroup;
            }
        }

        public XamlButton UISearchButton
        {
            get
            {
                if ((this.mUISearchButton == null))
                {
                    this.mUISearchButton = new XamlButton(this);
                    #region Search Criteria
                    this.mUISearchButton.SearchProperties[XamlButton.PropertyNames.Name] = "Search";
                    this.mUISearchButton.WindowTitles.Add("PTS");
                    #endregion
                }
                return this.mUISearchButton;
            }
        }

        public UIScrollViewerPane UIScrollViewerPane
        {
            get
            {
                if ((this.mUIScrollViewerPane == null))
                {
                    this.mUIScrollViewerPane = new UIScrollViewerPane(this);
                }
                return this.mUIScrollViewerPane;
            }
        }
        #endregion

        #region Fields
        private XamlEdit mUIUserNameTextboxEdit;

        private XamlEdit mUIPasswordTextboxEdit;

        private XamlButton mUILoginButton;

        private XamlButton mUIReportsButton;

        private XamlButton mUITouristVisitingReporButton;

        private UIDatepickerGroup mUIDatepickerGroup;

        private XamlButton mUISearchButton;

        private UIScrollViewerPane mUIScrollViewerPane;
        #endregion
    }
}
