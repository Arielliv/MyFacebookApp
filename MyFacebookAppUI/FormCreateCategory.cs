using System;
using System.Windows.Forms;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public partial class FormCreateCategory : Form
    {
        public FormCreateCategory()
        {
            InitializeComponent();
        }

        private void TextBoxCategoryName_TextChanged(object sender, EventArgs e)
        {
            this.buttonCreateCategory.Enabled = !string.IsNullOrEmpty(this.textBoxCategoryName.Text);
        }

        private void buttonCreateCategory_Click(object sender, EventArgs e)
        {
            string newPageCategoryName = this.textBoxCategoryName.Text;

            if (!string.IsNullOrEmpty(newPageCategoryName))
            {
                try
                {
                    MyFacebookAppController.Instance.AddCategory(newPageCategoryName);
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            MyFacebookAppController.Instance.SaveCategories();
        }
    }
}
