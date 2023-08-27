
namespace MyFacebookAppUI
{
    partial class FormCreateCategory
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
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.buttonCreateCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(59, 31);
            this.labelCategoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(38, 13);
            this.labelCategoryName.TabIndex = 0;
            this.labelCategoryName.Text = "Name:";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(110, 31);
            this.textBoxCategoryName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(133, 20);
            this.textBoxCategoryName.TabIndex = 1;
            this.textBoxCategoryName.TextChanged += new System.EventHandler(this.TextBoxCategoryName_TextChanged);
            // 
            // buttonCreateCategory
            // 
            this.buttonCreateCategory.Location = new System.Drawing.Point(62, 55);
            this.buttonCreateCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateCategory.Name = "buttonCreateCategory";
            this.buttonCreateCategory.Size = new System.Drawing.Size(181, 30);
            this.buttonCreateCategory.TabIndex = 2;
            this.buttonCreateCategory.Text = "Create";
            this.buttonCreateCategory.UseVisualStyleBackColor = true;
            this.buttonCreateCategory.Click += new System.EventHandler(this.buttonCreateCategory_Click);
            // 
            // FormCreateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 111);
            this.Controls.Add(this.buttonCreateCategory);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.labelCategoryName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormCreateCategory";
            this.Text = "Create Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Button buttonCreateCategory;
    }
}