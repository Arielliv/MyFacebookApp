
namespace MyFacebookAppUI
{
    partial class FormChangeCategory
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
            this.labelChooseCategory = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelChooseCategory
            // 
            this.labelChooseCategory.AutoSize = true;
            this.labelChooseCategory.Location = new System.Drawing.Point(45, 37);
            this.labelChooseCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChooseCategory.Name = "labelChooseCategory";
            this.labelChooseCategory.Size = new System.Drawing.Size(99, 13);
            this.labelChooseCategory.TabIndex = 0;
            this.labelChooseCategory.Text = "Choose a category:";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(148, 37);
            this.comboBoxCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(195, 21);
            this.comboBoxCategories.TabIndex = 1;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(48, 69);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(295, 30);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApplyChanges_Click);
            // 
            // FormChangeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 125);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.labelChooseCategory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormChangeCategory";
            this.Text = "Change Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseCategory;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Button buttonApply;
    }
}