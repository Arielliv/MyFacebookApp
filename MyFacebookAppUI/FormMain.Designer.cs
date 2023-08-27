namespace MyFacebookAppUI
{
    public partial class FormMain
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
            this.menuTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelMyFavorites = new System.Windows.Forms.Label();
            this.SaveDesign = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelDesignSettings = new System.Windows.Forms.Label();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelEducation = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxNameColor = new System.Windows.Forms.ComboBox();
            this.comboBoxButtonsColor = new System.Windows.Forms.ComboBox();
            this.comboBoxPageColor = new System.Windows.Forms.ComboBox();
            this.listBoxCheckIn = new System.Windows.Forms.ListBox();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkedListBoxCategories = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanelPages = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonCreateCategory = new System.Windows.Forms.Button();
            this.buttonShowFavorites = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new MyFacebookAppUI.RoundPictureBox();
            this.menuTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTab
            // 
            this.menuTab.Controls.Add(this.tabPage1);
            this.menuTab.Controls.Add(this.tabPage2);
            this.menuTab.Controls.Add(this.tabPage3);
            this.menuTab.Location = new System.Drawing.Point(0, 0);
            this.menuTab.Margin = new System.Windows.Forms.Padding(2);
            this.menuTab.Name = "menuTab";
            this.menuTab.SelectedIndex = 0;
            this.menuTab.ShowToolTips = true;
            this.menuTab.Size = new System.Drawing.Size(1262, 643);
            this.menuTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.menuTab.TabIndex = 0;
            this.menuTab.Tag = "";
            this.menuTab.Click += new System.EventHandler(this.menuTab_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.buttonShowFavorites);
            this.tabPage1.Controls.Add(this.labelMyFavorites);
            this.tabPage1.Controls.Add(this.SaveDesign);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.labelDesignSettings);
            this.tabPage1.Controls.Add(this.buttonAddPost);
            this.tabPage1.Controls.Add(this.textBoxPost);
            this.tabPage1.Controls.Add(this.labelEmail);
            this.tabPage1.Controls.Add(this.labelEducation);
            this.tabPage1.Controls.Add(this.labelBirthday);
            this.tabPage1.Controls.Add(this.labelLocation);
            this.tabPage1.Controls.Add(this.labelStatus);
            this.tabPage1.Controls.Add(this.comboBoxStatus);
            this.tabPage1.Controls.Add(this.comboBoxNameColor);
            this.tabPage1.Controls.Add(this.comboBoxButtonsColor);
            this.tabPage1.Controls.Add(this.comboBoxPageColor);
            this.tabPage1.Controls.Add(this.listBoxCheckIn);
            this.tabPage1.Controls.Add(this.buttonCheckIn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listBoxGroups);
            this.tabPage1.Controls.Add(this.buttonGroups);
            this.tabPage1.Controls.Add(this.listBoxEvents);
            this.tabPage1.Controls.Add(this.listBoxFriends);
            this.tabPage1.Controls.Add(this.buttonEvents);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelUserName);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.pictureBoxCover);
            this.tabPage1.Controls.Add(this.listBoxPosts);
            this.tabPage1.Controls.Add(this.buttonFriends);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1254, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelMyFavorites
            // 
            this.labelMyFavorites.AutoSize = true;
            this.labelMyFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMyFavorites.Location = new System.Drawing.Point(580, 104);
            this.labelMyFavorites.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMyFavorites.Name = "labelMyFavorites";
            this.labelMyFavorites.Size = new System.Drawing.Size(129, 25);
            this.labelMyFavorites.TabIndex = 121;
            this.labelMyFavorites.Text = "My favorites";
            // 
            // SaveDesign
            // 
            this.SaveDesign.BackColor = System.Drawing.Color.MidnightBlue;
            this.SaveDesign.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveDesign.Location = new System.Drawing.Point(1131, 16);
            this.SaveDesign.Margin = new System.Windows.Forms.Padding(4);
            this.SaveDesign.Name = "SaveDesign";
            this.SaveDesign.Size = new System.Drawing.Size(109, 32);
            this.SaveDesign.TabIndex = 120;
            this.SaveDesign.Text = "Save Design";
            this.SaveDesign.UseVisualStyleBackColor = false;
            this.SaveDesign.Click += new System.EventHandler(this.SaveDesign_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogout.Location = new System.Drawing.Point(1131, 66);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(109, 32);
            this.buttonLogout.TabIndex = 119;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelDesignSettings
            // 
            this.labelDesignSettings.AutoSize = true;
            this.labelDesignSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDesignSettings.Location = new System.Drawing.Point(18, 450);
            this.labelDesignSettings.Name = "labelDesignSettings";
            this.labelDesignSettings.Size = new System.Drawing.Size(159, 20);
            this.labelDesignSettings.TabIndex = 118;
            this.labelDesignSettings.Text = "Design My Profile";
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAddPost.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddPost.Location = new System.Drawing.Point(856, 151);
            this.buttonAddPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(384, 40);
            this.buttonAddPost.TabIndex = 117;
            this.buttonAddPost.Text = "Add Post";
            this.buttonAddPost.UseVisualStyleBackColor = false;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(856, 115);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(384, 29);
            this.textBoxPost.TabIndex = 116;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(253, 366);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 15);
            this.labelEmail.TabIndex = 115;
            this.labelEmail.Text = "Email:";
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(21, 366);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(65, 15);
            this.labelEducation.TabIndex = 114;
            this.labelEducation.Text = "Education:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(253, 297);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(54, 15);
            this.labelBirthday.TabIndex = 113;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(21, 297);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(57, 15);
            this.labelLocation.TabIndex = 112;
            this.labelLocation.Text = "Location:";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStatus.Location = new System.Drawing.Point(18, 548);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(493, 55);
            this.labelStatus.TabIndex = 110;
            this.labelStatus.Text = "ChosenStatus";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "None"});
            this.comboBoxStatus.Location = new System.Drawing.Point(232, 518);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(212, 24);
            this.comboBoxStatus.TabIndex = 109;
            this.comboBoxStatus.Text = "          Choose Favorite Status";
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // comboBoxNameColor
            // 
            this.comboBoxNameColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxNameColor.FormattingEnabled = true;
            this.comboBoxNameColor.Location = new System.Drawing.Point(17, 491);
            this.comboBoxNameColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxNameColor.Name = "comboBoxNameColor";
            this.comboBoxNameColor.Size = new System.Drawing.Size(212, 24);
            this.comboBoxNameColor.TabIndex = 108;
            this.comboBoxNameColor.Text = "         Choose Name Color";
            this.comboBoxNameColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameColor_SelectedIndexChanged);
            // 
            // comboBoxButtonsColor
            // 
            this.comboBoxButtonsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxButtonsColor.FormattingEnabled = true;
            this.comboBoxButtonsColor.Location = new System.Drawing.Point(17, 518);
            this.comboBoxButtonsColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxButtonsColor.Name = "comboBoxButtonsColor";
            this.comboBoxButtonsColor.Size = new System.Drawing.Size(212, 24);
            this.comboBoxButtonsColor.TabIndex = 107;
            this.comboBoxButtonsColor.Text = "         Choose Buttons Color";
            this.comboBoxButtonsColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxButtonsColor_SelectedIndexChanged);
            // 
            // comboBoxPageColor
            // 
            this.comboBoxPageColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxPageColor.FormattingEnabled = true;
            this.comboBoxPageColor.Location = new System.Drawing.Point(232, 491);
            this.comboBoxPageColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPageColor.Name = "comboBoxPageColor";
            this.comboBoxPageColor.Size = new System.Drawing.Size(212, 24);
            this.comboBoxPageColor.TabIndex = 106;
            this.comboBoxPageColor.Text = "          Choose Page Color";
            this.comboBoxPageColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageColor_SelectedIndexChanged);
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.Location = new System.Drawing.Point(772, 495);
            this.listBoxCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(140, 108);
            this.listBoxCheckIn.TabIndex = 105;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCheckIn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCheckIn.Location = new System.Drawing.Point(772, 448);
            this.buttonCheckIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(94, 36);
            this.buttonCheckIn.TabIndex = 104;
            this.buttonCheckIn.Text = "Get Check-ins";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(19, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 103;
            this.label3.Text = "Info";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(937, 495);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(140, 108);
            this.listBoxGroups.TabIndex = 101;
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonGroups.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonGroups.Location = new System.Drawing.Point(937, 449);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(98, 35);
            this.buttonGroups.TabIndex = 100;
            this.buttonGroups.Text = "Get Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(606, 495);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(140, 108);
            this.listBoxEvents.TabIndex = 99;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(1100, 495);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(140, 108);
            this.listBoxFriends.TabIndex = 98;
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonEvents.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEvents.Location = new System.Drawing.Point(606, 450);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(102, 34);
            this.buttonEvents.TabIndex = 97;
            this.buttonEvents.Text = "Get Events";
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(857, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 96;
            this.label2.Text = "Posts";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.Location = new System.Drawing.Point(16, 197);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(273, 31);
            this.labelUserName.TabIndex = 95;
            this.labelUserName.Text = "LoggedInUserName";
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCover.Location = new System.Drawing.Point(232, 16);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(867, 81);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 93;
            this.pictureBoxCover.TabStop = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(856, 228);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(384, 147);
            this.listBoxPosts.TabIndex = 92;
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonFriends.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonFriends.Location = new System.Drawing.Point(1100, 450);
            this.buttonFriends.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(97, 35);
            this.buttonFriends.TabIndex = 91;
            this.buttonFriends.Text = "Get Friends";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.flowLayoutPanelAlbums);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1254, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Albums";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.AutoScroll = true;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(34, 79);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(1082, 503);
            this.flowLayoutPanelAlbums.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.checkedListBoxCategories);
            this.tabPage3.Controls.Add(this.flowLayoutPanelPages);
            this.tabPage3.Controls.Add(this.buttonFilter);
            this.tabPage3.Controls.Add(this.buttonCreateCategory);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1254, 617);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pages";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCategories
            // 
            this.checkedListBoxCategories.FormattingEnabled = true;
            this.checkedListBoxCategories.Location = new System.Drawing.Point(308, 29);
            this.checkedListBoxCategories.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxCategories.Name = "checkedListBoxCategories";
            this.checkedListBoxCategories.Size = new System.Drawing.Size(164, 154);
            this.checkedListBoxCategories.TabIndex = 2;
            this.checkedListBoxCategories.Visible = false;
            // 
            // flowLayoutPanelPages
            // 
            this.flowLayoutPanelPages.AutoScroll = true;
            this.flowLayoutPanelPages.Location = new System.Drawing.Point(33, 83);
            this.flowLayoutPanelPages.Name = "flowLayoutPanelPages";
            this.flowLayoutPanelPages.Size = new System.Drawing.Size(1082, 503);
            this.flowLayoutPanelPages.TabIndex = 3;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(158, 29);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(146, 26);
            this.buttonFilter.TabIndex = 1;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilterPagesByCategory_Click);
            // 
            // buttonCreateCategory
            // 
            this.buttonCreateCategory.Location = new System.Drawing.Point(33, 29);
            this.buttonCreateCategory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreateCategory.Name = "buttonCreateCategory";
            this.buttonCreateCategory.Size = new System.Drawing.Size(100, 26);
            this.buttonCreateCategory.TabIndex = 0;
            this.buttonCreateCategory.Text = "Create Category";
            this.buttonCreateCategory.UseVisualStyleBackColor = true;
            this.buttonCreateCategory.Click += new System.EventHandler(this.buttonCreateCategory_Click);
            // 
            // buttonShowFavorites
            // 
            this.buttonShowFavorites.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonShowFavorites.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonShowFavorites.Location = new System.Drawing.Point(585, 133);
            this.buttonShowFavorites.Name = "buttonShowFavorites";
            this.buttonShowFavorites.Size = new System.Drawing.Size(124, 26);
            this.buttonShowFavorites.TabIndex = 122;
            this.buttonShowFavorites.Text = "View";
            this.buttonShowFavorites.UseVisualStyleBackColor = false;
            this.buttonShowFavorites.Click += new System.EventHandler(this.buttonShowFavorites_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(19, 16);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(190, 175);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 94;
            this.pictureBoxProfile.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 641);
            this.Controls.Add(this.menuTab);
            this.MaximumSize = new System.Drawing.Size(1280, 688);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button SaveDesign;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelDesignSettings;
        private System.Windows.Forms.Button buttonAddPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxNameColor;
        private System.Windows.Forms.ComboBox comboBoxButtonsColor;
        private System.Windows.Forms.ComboBox comboBoxPageColor;
        private System.Windows.Forms.ListBox listBoxCheckIn;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelMyFavorites;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonCreateCategory;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPages;
        private RoundPictureBox pictureBoxProfile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
        private System.Windows.Forms.Button buttonShowFavorites;
    }
}