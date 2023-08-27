using System;
using System.Windows.Forms;
using MyFacebookAppLogic;
using FacebookWrapper;

namespace MyFacebookAppUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            isRememberMeBoxChecked();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MyFacebookAppController.Instance.Login();
            continueAfterLogin();
        }

        private void continueAfterLogin()
        {
            if (!MyFacebookAppController.Instance.IsTokenNull())
            {
                showFormMain();
            }
            else
            {
                MessageBox.Show(MyFacebookAppController.Instance.LoginResult.ErrorMessage);
            }
        }

        private void showFormMain()
        {
            FormMain formMain = new FormMain();

            this.Hide();
            formMain.ShowDialog();
        }

        private void isRememberMeBoxChecked()
        {
            string previousAccessToken = MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousAccessToken;
            
            if (MyFacebookAppController.Instance.MyFacebookAppSettings.ShouldRememberUser && !string.IsNullOrEmpty(previousAccessToken))
            {
                MyFacebookAppController.Instance.LoginResult = FacebookService.Connect(previousAccessToken);
                MyFacebookAppController.Instance.Initialize();
                continueAfterLogin();
            }
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRememberMe.Checked)
            {
                MyFacebookAppController.Instance.MyFacebookAppSettings.ShouldRememberUser = true;
            }
        }
    }
}
