using System;
using MyFacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyFacebookAppUI
{
    public partial class PanelPage : Panel
    {
        private Page m_Page;
        private string m_Category;

        public PanelPage(Page i_Page, string i_Category)
        {
            InitializeComponent();
            m_Page = i_Page;
            m_Category = i_Category;
            AutoSize = true;
            BackColor = Color.AliceBlue;
        }

        public void ShowPage()
        {
            Controls.AddRange(
                PanelBuilderComposer.CreatePanelPage(
                    m_Category,
                    m_Page,
                    ChangePageCategory_Click
                    )
                .ToArray()
                );
        }

        private void ChangePageCategory_Click(object sender, EventArgs e, Page i_Page, Label i_LabelCategoryName)
        {
            FormChangeCategory formChangePageLabel = new FormChangeCategory(i_Page);

            formChangePageLabel.ShowDialog();
            refreshPageCategory(i_LabelCategoryName, i_Page);
        }

        private void refreshPageCategory(Label i_LabelCategoryName, Page i_Page)
        {
            i_LabelCategoryName.Text = "Category:" + MyFacebookAppController.Instance.GetPageCategory(i_Page);
        }

        public string GetPageCategory()
        {
            return MyFacebookAppController.Instance.GetPageCategory(m_Page);
        }
    }
}
