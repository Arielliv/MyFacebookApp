using System.Collections.Generic;
using MyFacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace MyFacebookAppUI
{
    public class PagesController
    {
        private readonly Dictionary<Page, string> r_PageToCategoryDictionary;
        private readonly FlowLayoutPanel r_FlowLayoutPanel;
        
        public PagesController(FlowLayoutPanel i_FlowLayoutPanel)
        {
            r_PageToCategoryDictionary = MyFacebookAppController.Instance.GetPageToCategoryMap();
            r_FlowLayoutPanel = i_FlowLayoutPanel;
        }

        public void ShowPages()
        {
            foreach (KeyValuePair<Page, string> entry in r_PageToCategoryDictionary)
            {
                PanelPage panelPage = new PanelPage(entry.Key, entry.Value);
                
                panelPage.ShowPage();
                r_FlowLayoutPanel.Controls.Add(panelPage);
            }

            if (r_PageToCategoryDictionary.Count == 0)
            {
                MessageBox.Show("There are no pages to display.");
            }
        }

        public void FilterPagesByCategory()
        {
            HashSet<string> checkedCategories = MyFacebookAppController.Instance.GetCheckedCategories();

            if (checkedCategories.Count > 0)
            {
                foreach (PanelPage panelPage in r_FlowLayoutPanel.Controls)
                {
                    panelPage.Visible = checkedCategories.Contains(panelPage.GetPageCategory());
                }
            }
            else
            {
                foreach (PanelPage panelPage in r_FlowLayoutPanel.Controls)
                {
                    panelPage.Visible = true;
                }
            }
        }
    }
}
