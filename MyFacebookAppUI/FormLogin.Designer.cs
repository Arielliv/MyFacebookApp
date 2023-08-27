namespace MyFacebookAppUI
{
    public partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.MyFacebookAppLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogin.Location = new System.Drawing.Point(28, 145);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 53;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(28, 110);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(126, 22);
            this.checkBoxRememberMe.TabIndex = 54;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            this.checkBoxRememberMe.CheckedChanged += new System.EventHandler(this.checkBoxRememberMe_CheckedChanged);
            // 
            // MyFacebookAppLabel
            // 
            this.MyFacebookAppLabel.AutoSize = true;
            this.MyFacebookAppLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MyFacebookAppLabel.Font = new System.Drawing.Font("Microsoft YaHei", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyFacebookAppLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MyFacebookAppLabel.Location = new System.Drawing.Point(37, 33);
            this.MyFacebookAppLabel.Name = "MyFacebookAppLabel";
            this.MyFacebookAppLabel.Size = new System.Drawing.Size(243, 35);
            this.MyFacebookAppLabel.TabIndex = 55;
            this.MyFacebookAppLabel.Text = "My Facebook App";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(324, 190);
            this.Controls.Add(this.MyFacebookAppLabel);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.buttonLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Label MyFacebookAppLabel;
    }
}

