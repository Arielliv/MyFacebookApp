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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label cityLabel;
            this.menuTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.checkinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.checkInDescriptionLabel = new System.Windows.Forms.Label();
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
            this.pictureBoxProfile = new MyFacebookAppUI.EllipsePictureBox();
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
            descriptionLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            this.menuTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(13, 87);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(83, 17);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(15, 12);
            createdTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(97, 17);
            createdTimeLabel.TabIndex = 7;
            createdTimeLabel.Text = "Created Time:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(13, 65);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // menuTab
            // 
            this.menuTab.Controls.Add(this.tabPage1);
            this.menuTab.Controls.Add(this.tabPage2);
            this.menuTab.Controls.Add(this.tabPage3);
            this.menuTab.Location = new System.Drawing.Point(0, 0);
            this.menuTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuTab.Name = "menuTab";
            this.menuTab.SelectedIndex = 0;
            this.menuTab.ShowToolTips = true;
            this.menuTab.Size = new System.Drawing.Size(1683, 791);
            this.menuTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.menuTab.TabIndex = 0;
            this.menuTab.Tag = "";
            this.menuTab.Click += new System.EventHandler(this.menuTab_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.panel1);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1675, 762);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.createdTimeLabel1);
            this.panel1.Controls.Add(cityLabel);
            this.panel1.Controls.Add(this.cityTextBox);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.checkInDescriptionLabel);
            this.panel1.Location = new System.Drawing.Point(1049, 554);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 188);
            this.panel1.TabIndex = 123;
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(15, 35);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 9;
            // 
            // checkinBindingSource
            // 
            this.checkinBindingSource.AllowNew = true;
            this.checkinBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Checkin);
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Place.Location.City", true));
            this.cityTextBox.Location = new System.Drawing.Point(54, 62);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 8;
            // 
            // checkInDescriptionLabel
            // 
            this.checkInDescriptionLabel.AutoEllipsis = true;
            this.checkInDescriptionLabel.AutoSize = true;
            this.checkInDescriptionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.checkinBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[No data]"));
            this.checkInDescriptionLabel.Location = new System.Drawing.Point(15, 113);
            this.checkInDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkInDescriptionLabel.MaximumSize = new System.Drawing.Size(133, 74);
            this.checkInDescriptionLabel.Name = "checkInDescriptionLabel";
            this.checkInDescriptionLabel.Size = new System.Drawing.Size(0, 17);
            this.checkInDescriptionLabel.TabIndex = 7;
            // 
            // labelMyFavorites
            // 
            this.labelMyFavorites.AutoSize = true;
            this.labelMyFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMyFavorites.Location = new System.Drawing.Point(773, 128);
            this.labelMyFavorites.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMyFavorites.Name = "labelMyFavorites";
            this.labelMyFavorites.Size = new System.Drawing.Size(129, 25);
            this.labelMyFavorites.TabIndex = 121;
            this.labelMyFavorites.Text = "My favorites";
            // 
            // SaveDesign
            // 
            this.SaveDesign.BackColor = System.Drawing.Color.MidnightBlue;
            this.SaveDesign.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveDesign.Location = new System.Drawing.Point(1508, 20);
            this.SaveDesign.Margin = new System.Windows.Forms.Padding(5);
            this.SaveDesign.Name = "SaveDesign";
            this.SaveDesign.Size = new System.Drawing.Size(145, 39);
            this.SaveDesign.TabIndex = 120;
            this.SaveDesign.Text = "Save Design";
            this.SaveDesign.UseVisualStyleBackColor = false;
            this.SaveDesign.Click += new System.EventHandler(this.SaveDesign_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogout.Location = new System.Drawing.Point(1508, 81);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(145, 39);
            this.buttonLogout.TabIndex = 119;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // labelDesignSettings
            // 
            this.labelDesignSettings.AutoSize = true;
            this.labelDesignSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDesignSettings.Location = new System.Drawing.Point(24, 554);
            this.labelDesignSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDesignSettings.Name = "labelDesignSettings";
            this.labelDesignSettings.Size = new System.Drawing.Size(159, 20);
            this.labelDesignSettings.TabIndex = 118;
            this.labelDesignSettings.Text = "Design My Profile";
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonAddPost.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonAddPost.Location = new System.Drawing.Point(1141, 186);
            this.buttonAddPost.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(512, 49);
            this.buttonAddPost.TabIndex = 117;
            this.buttonAddPost.Text = "Add Post";
            this.buttonAddPost.UseVisualStyleBackColor = false;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click);
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(1141, 142);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(511, 35);
            this.textBoxPost.TabIndex = 116;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(337, 450);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 17);
            this.labelEmail.TabIndex = 115;
            this.labelEmail.Text = "Email:";
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Location = new System.Drawing.Point(28, 450);
            this.labelEducation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(75, 17);
            this.labelEducation.TabIndex = 114;
            this.labelEducation.Text = "Education:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(337, 366);
            this.labelBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(64, 17);
            this.labelBirthday.TabIndex = 113;
            this.labelBirthday.Text = "Birthday:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(28, 366);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(66, 17);
            this.labelLocation.TabIndex = 112;
            this.labelLocation.Text = "Location:";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelStatus.Location = new System.Drawing.Point(24, 674);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(600, 68);
            this.labelStatus.TabIndex = 110;
            this.labelStatus.Text = "ChosenStatus";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "None"});
            this.comboBoxStatus.Location = new System.Drawing.Point(309, 638);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(281, 24);
            this.comboBoxStatus.TabIndex = 109;
            this.comboBoxStatus.Text = "          Choose Favorite Status";
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // comboBoxNameColor
            // 
            this.comboBoxNameColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxNameColor.FormattingEnabled = true;
            this.comboBoxNameColor.Location = new System.Drawing.Point(23, 604);
            this.comboBoxNameColor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBoxNameColor.Name = "comboBoxNameColor";
            this.comboBoxNameColor.Size = new System.Drawing.Size(281, 24);
            this.comboBoxNameColor.TabIndex = 108;
            this.comboBoxNameColor.Text = "         Choose Name Color";
            this.comboBoxNameColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameColor_SelectedIndexChanged);
            // 
            // comboBoxButtonsColor
            // 
            this.comboBoxButtonsColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxButtonsColor.FormattingEnabled = true;
            this.comboBoxButtonsColor.Location = new System.Drawing.Point(23, 638);
            this.comboBoxButtonsColor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBoxButtonsColor.Name = "comboBoxButtonsColor";
            this.comboBoxButtonsColor.Size = new System.Drawing.Size(281, 24);
            this.comboBoxButtonsColor.TabIndex = 107;
            this.comboBoxButtonsColor.Text = "         Choose Buttons Color";
            this.comboBoxButtonsColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxButtonsColor_SelectedIndexChanged);
            // 
            // comboBoxPageColor
            // 
            this.comboBoxPageColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxPageColor.FormattingEnabled = true;
            this.comboBoxPageColor.Location = new System.Drawing.Point(309, 604);
            this.comboBoxPageColor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBoxPageColor.Name = "comboBoxPageColor";
            this.comboBoxPageColor.Size = new System.Drawing.Size(281, 24);
            this.comboBoxPageColor.TabIndex = 106;
            this.comboBoxPageColor.Text = "          Choose Page Color";
            this.comboBoxPageColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageColor_SelectedIndexChanged);
            // 
            // listBoxCheckIn
            // 
            this.listBoxCheckIn.DataSource = this.checkinBindingSource;
            this.listBoxCheckIn.DisplayMember = "Name";
            this.listBoxCheckIn.FormattingEnabled = true;
            this.listBoxCheckIn.ItemHeight = 16;
            this.listBoxCheckIn.Location = new System.Drawing.Point(857, 609);
            this.listBoxCheckIn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBoxCheckIn.Name = "listBoxCheckIn";
            this.listBoxCheckIn.Size = new System.Drawing.Size(185, 132);
            this.listBoxCheckIn.TabIndex = 105;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonCheckIn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonCheckIn.Location = new System.Drawing.Point(857, 551);
            this.buttonCheckIn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(125, 44);
            this.buttonCheckIn.TabIndex = 104;
            this.buttonCheckIn.Text = "Get Check-ins";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(25, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 103;
            this.label3.Text = "Info";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(1249, 609);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(185, 132);
            this.listBoxGroups.TabIndex = 101;
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonGroups.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonGroups.Location = new System.Drawing.Point(1249, 553);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(131, 43);
            this.buttonGroups.TabIndex = 100;
            this.buttonGroups.Text = "Get Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(635, 609);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(185, 132);
            this.listBoxEvents.TabIndex = 99;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(1467, 609);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(185, 132);
            this.listBoxFriends.TabIndex = 98;
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonEvents.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEvents.Location = new System.Drawing.Point(635, 554);
            this.buttonEvents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(136, 42);
            this.buttonEvents.TabIndex = 97;
            this.buttonEvents.Text = "Get Events";
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(1143, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 96;
            this.label2.Text = "Posts";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.Location = new System.Drawing.Point(21, 242);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(273, 31);
            this.labelUserName.TabIndex = 95;
            this.labelUserName.Text = "LoggedInUserName";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(25, 20);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(253, 215);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 94;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCover.Location = new System.Drawing.Point(309, 20);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(1156, 100);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 93;
            this.pictureBoxCover.TabStop = false;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(1141, 281);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(511, 180);
            this.listBoxPosts.TabIndex = 92;
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonFriends.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonFriends.Location = new System.Drawing.Point(1467, 554);
            this.buttonFriends.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(129, 43);
            this.buttonFriends.TabIndex = 91;
            this.buttonFriends.Text = "Get Friends";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.flowLayoutPanelAlbums);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1675, 762);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Albums";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelAlbums
            // 
            this.flowLayoutPanelAlbums.AutoScroll = true;
            this.flowLayoutPanelAlbums.Location = new System.Drawing.Point(45, 97);
            this.flowLayoutPanelAlbums.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelAlbums.Name = "flowLayoutPanelAlbums";
            this.flowLayoutPanelAlbums.Size = new System.Drawing.Size(1443, 619);
            this.flowLayoutPanelAlbums.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.checkedListBoxCategories);
            this.tabPage3.Controls.Add(this.flowLayoutPanelPages);
            this.tabPage3.Controls.Add(this.buttonFilter);
            this.tabPage3.Controls.Add(this.buttonCreateCategory);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1675, 762);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pages";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxCategories
            // 
            this.checkedListBoxCategories.FormattingEnabled = true;
            this.checkedListBoxCategories.Location = new System.Drawing.Point(411, 36);
            this.checkedListBoxCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxCategories.Name = "checkedListBoxCategories";
            this.checkedListBoxCategories.Size = new System.Drawing.Size(217, 174);
            this.checkedListBoxCategories.TabIndex = 2;
            this.checkedListBoxCategories.Visible = false;
            // 
            // flowLayoutPanelPages
            // 
            this.flowLayoutPanelPages.AutoScroll = true;
            this.flowLayoutPanelPages.Location = new System.Drawing.Point(44, 102);
            this.flowLayoutPanelPages.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelPages.Name = "flowLayoutPanelPages";
            this.flowLayoutPanelPages.Size = new System.Drawing.Size(1443, 619);
            this.flowLayoutPanelPages.TabIndex = 3;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(211, 36);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(195, 32);
            this.buttonFilter.TabIndex = 1;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilterPagesByCategory_Click);
            // 
            // buttonCreateCategory
            // 
            this.buttonCreateCategory.Location = new System.Drawing.Point(44, 36);
            this.buttonCreateCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreateCategory.Name = "buttonCreateCategory";
            this.buttonCreateCategory.Size = new System.Drawing.Size(133, 32);
            this.buttonCreateCategory.TabIndex = 0;
            this.buttonCreateCategory.Text = "Create Category";
            this.buttonCreateCategory.UseVisualStyleBackColor = true;
            this.buttonCreateCategory.Click += new System.EventHandler(this.buttonCreateCategory_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1683, 789);
            this.Controls.Add(this.menuTab);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1701, 836);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
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
        private EllipsePictureBox pictureBoxProfile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlbums;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource checkinBindingSource;
        private System.Windows.Forms.Label checkInDescriptionLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label createdTimeLabel1;
    }
}