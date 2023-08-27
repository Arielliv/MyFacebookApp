using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public partial class FormChangeCategory : Form
    {
        private Page m_ChoosenPage;

        public FormChangeCategory(Page i_Page)
        {
            InitializeComponent();
            m_ChoosenPage = i_Page;
            initCategoriesList();
        }

        private void initCategoriesList()
        {
            this.comboBoxCategories.Items.Clear();
            foreach (string pageCategory in MyFacebookAppController.Instance.GetAllCategories())
            {
                this.comboBoxCategories.Items.Add(pageCategory);
            }
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buttonApply.Enabled = this.comboBoxCategories.SelectedItem != null;
        }

        private void buttonApplyChanges_Click(object sender, EventArgs e)
        {
            if (this.comboBoxCategories.SelectedItem != null)
            {
                MyFacebookAppController.Instance.ChangePageCategory(m_ChoosenPage, this.comboBoxCategories.SelectedItem.ToString());
            }

            this.Close();
        }
    }
}
