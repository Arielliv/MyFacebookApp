namespace MyFacebookAppUI
{
    partial class FormAlbumImages
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
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.pictureBoxInstruction = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelImages = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstruction)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCover.Location = new System.Drawing.Point(9, 10);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(1250, 36);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 8;
            this.pictureBoxCover.TabStop = false;
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(25, 57);
            this.labelInstruction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(209, 15);
            this.labelInstruction.TabIndex = 10;
            this.labelInstruction.Text = "Add To Favorite By Checking The Box";
            // 
            // pictureBoxInstruction
            // 
            this.pictureBoxInstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxInstruction.Location = new System.Drawing.Point(8, 57);
            this.pictureBoxInstruction.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxInstruction.Name = "pictureBoxInstruction";
            this.pictureBoxInstruction.Size = new System.Drawing.Size(14, 15);
            this.pictureBoxInstruction.TabIndex = 11;
            this.pictureBoxInstruction.TabStop = false;
            // 
            // flowLayoutPanelImages
            // 
            this.flowLayoutPanelImages.AutoScroll = true;
            this.flowLayoutPanelImages.Location = new System.Drawing.Point(8, 86);
            this.flowLayoutPanelImages.Name = "flowLayoutPanelImages";
            this.flowLayoutPanelImages.Size = new System.Drawing.Size(584, 435);
            this.flowLayoutPanelImages.TabIndex = 12;
            // 
            // FormAlbumImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(600, 554);
            this.Controls.Add(this.flowLayoutPanelImages);
            this.Controls.Add(this.pictureBoxInstruction);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.pictureBoxCover);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAlbumImages";
            this.Text = "Images In Current Album";
            this.Load += new System.EventHandler(this.fromImagesGallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstruction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.PictureBox pictureBoxInstruction;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImages;
    }
}