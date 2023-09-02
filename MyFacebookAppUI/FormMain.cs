using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MyFacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace MyFacebookAppUI
{
    public partial class FormMain : Form
    {
        public PagesController PagesController { get; private set; }
        public AlbumsController AlbumsController { get; private set; }
        public SliderGallery SliderGallery { get; private set; }

        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new Thread(getProfileImage).Start();
            new Thread(getInfo).Start();
            new Thread(getPosts).Start();
            new Thread(setFavoriteImages).Start();
        }

        private void getProfileImage()
        {
            pictureBoxProfile.LoadAsync(MyFacebookAppController.Instance.LoggedInUser.PictureNormalURL);
        }

        private void getPages()
        {
            PagesController = new PagesController(flowLayoutPanelPages);
            MyFacebookAppController.Instance.LoadCategories();
            MyFacebookAppController.Instance.LoadPagesWithCategories();
            Invoke(new Action(() => PagesController.ShowPages()));
        }

        private void getInfo()
        {
            Invoke(new Action (() => labelUserName.Text = MyFacebookAppController.Instance.LoggedInUser.Name));
            if (MyFacebookAppController.Instance.LoggedInUser.Educations != null)
            {
                Invoke(new Action(() =>  labelEducation.Text = $"{labelEducation.Text} {MyFacebookAppController.Instance.LoggedInUser.Educations}"));
            }

            if (MyFacebookAppController.Instance.LoggedInUser.Location != null)
            {
                Invoke(new Action(() => labelLocation.Text = $"{labelLocation.Text} {MyFacebookAppController.Instance.LoggedInUser.Location.Name}"));
            }

            if (MyFacebookAppController.Instance.LoggedInUser.Birthday != null)
            {
                Invoke(new Action(() => labelBirthday.Text = $"{labelBirthday.Text} {MyFacebookAppController.Instance.LoggedInUser.Birthday}"));
            }

            if (MyFacebookAppController.Instance.LoggedInUser.Email != null)
            {
                Invoke(new Action(() => labelEmail.Text = $"{labelEmail.Text} {MyFacebookAppController.Instance.LoggedInUser.Email}"));
            }
        }

        private void getPosts()
        {
            foreach (Post post in MyFacebookAppController.Instance.LoggedInUser.Posts)
            {
                Invoke(new Action(() => listBoxPosts.Items.Add(new PostProxy(post))));
            }

            if (MyFacebookAppController.Instance.LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to display");
            }
        }

        private void setFavoriteImages()
        {
            MyFacebookAppController.Instance.ImagesIndicesToSave = MyFacebookAppController.Instance.MyFacebookAppSettings.ImagesIndicesInAlbum;
            MyFacebookAppController.Instance.AlbumsIndicesToSave = MyFacebookAppController.Instance.MyFacebookAppSettings.AlbumsIndices;
            MyFacebookAppController.Instance.AddImagesIndicesToFavorites();
            setSliderGallery();
        }

        private void setSliderGallery()
        {
            SliderGallery = new SliderGallery();
            Invoke(new Action(() => this.tabPage1.Controls.Add(SliderGallery)));
            showSliderGallery();
        }

        private void buttonAddPost_Click(object sender, EventArgs e)
        {
            try
            {
                MyFacebookAppController.Instance.LoggedInUser.PostStatus(textBoxPost.Text);
            }
            catch
            {
                MessageBox.Show("Post was not published!");
            }

            MessageBox.Show("Post published successfully");
            listBoxPosts.Items.Add(textBoxPost.Text);
            textBoxPost.Text = "";
        }

        private void comboBoxNameColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelUserName.ForeColor = Utils.GetColorByName(comboBoxNameColor.SelectedItem.ToString());
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelStatus.Text = comboBoxStatus.SelectedIndex != Constants.k_DefaultOption ? comboBoxStatus.Text : string.Empty;
        }

        private void comboBoxButtonsColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeButtonsColors(Utils.GetColorByName(comboBoxButtonsColor.SelectedItem.ToString()));
        }

        private void comboBoxPageColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabPage1.BackColor = Utils.GetColorByName(comboBoxPageColor.SelectedItem.ToString());
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            getCheckIns();
        }

        private void getCheckIns()
        {
            checkinBindingSource.DataSource = MyFacebookAppController.Instance.LoggedInUser.Checkins;
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            getGroups();
        }

        private void getGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";
            foreach (Group group in MyFacebookAppController.Instance.LoggedInUser.Groups)
            {
                listBoxGroups.Items.Add(group);
            }

            if (MyFacebookAppController.Instance.LoggedInUser.Groups.Count == 0)
            {
                MessageBox.Show("No group to display");
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            getEvents();
        }

        private void getEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in MyFacebookAppController.Instance.LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent.Name);
            }

            if (MyFacebookAppController.Instance.LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to display");
            }
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            getFriends();
        }

        private void getFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            listBoxFriends.DataSource = MyFacebookAppController.Instance.LoggedInUser.Friends;
            if (MyFacebookAppController.Instance.LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No friends to display");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (MyFacebookAppController.Instance.MyFacebookAppSettings.ShouldRememberUser)
            {
                saveLoggedInUser();
                MyFacebookAppController.Instance.SavePagesWithCategories();
            }

            Application.Exit();
        }

        private void saveLoggedInUser() 
        {
            MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousAccessToken = MyFacebookAppController.Instance.LoginResult.AccessToken;
            MyFacebookAppController.Instance.MyFacebookAppSettings.SaveAppSettingsIntoFile();
        }

        private void updatePreviousUserSettings()
        {
            MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousWindowLocation = this.Location;
            MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousPageColor = tabPage1.BackColor.Name;
            MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousNameColor = labelUserName.ForeColor.Name;
            MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousStatus = labelStatus.Text;
            MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousButtonsColor = buttonAddPost.BackColor.Name;
            MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousAccessToken = MyFacebookAppController.Instance.LoginResult.AccessToken;
            MyFacebookAppController.Instance.MyFacebookAppSettings.SaveAppSettingsIntoFile();
        }

        private void changeButtonsColors(Color i_SelectedColor)
        {
            foreach (Control control in tabPage1.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = i_SelectedColor;
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = $"Logged in as {MyFacebookAppController.Instance.LoggedInUser.Name}";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousWindowLocation;
            tabPage1.BackColor = Color.FromName(MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousPageColor);
            changeButtonsColors(Color.FromName(MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousButtonsColor));
            labelUserName.ForeColor = Color.FromName(MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousNameColor);
            labelStatus.Text = MyFacebookAppController.Instance.MyFacebookAppSettings.PreviousStatus;
            this.comboBoxStatus.Items.AddRange(Constants.sr_Statuses.Cast<object>().ToArray());
            comboBoxButtonsColor.Items.AddRange(Constants.sr_ColorNames);
            comboBoxNameColor.Items.AddRange(Constants.sr_ColorNames);
            comboBoxPageColor.Items.AddRange(Constants.sr_ColorNames);
            MyFacebookAppController.Instance.SliderGalleryController.SliderGalleryImagesChanged += sliderGallery_OnSliderGalleryImagesChanged;
        }

        private void sliderGallery_OnSliderGalleryImagesChanged()
        {
            SliderGallery.Image = MyFacebookAppController.Instance.SliderGalleryController.CurrentImage;
        }

        private void showFormLogin()
        {
            FormLogin formLogin = new FormLogin();

            this.Hide();
            formLogin.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MyFacebookAppController.Instance.Logout();
            showFormLogin();
        }

        private void SaveDesign_Click(object sender, EventArgs e)
        {
            updatePreviousUserSettings();
        }

        private void buttonFilterPagesByCategory_Click(object sender, EventArgs e)
        {
            if (checkedListBoxCategories.Visible)
            {
                checkedListBoxCategories.Visible = false;
                buttonFilter.Text = "Filter By Category";
                updateCheckedCategoriesInCheckedListBoxFilters();
                PagesController.FilterPagesByCategory();
            }
            else
            {
                initCheckedListBoxFilters();
                checkedListBoxCategories.Visible = true;
                buttonFilter.Text = "Filter and Close";
            }
        }

        private void initCheckedListBoxFilters()
        {
            this.checkedListBoxCategories.Items.Clear();
            foreach (KeyValuePair<string, bool> entry in MyFacebookAppController.Instance.GetCategories())
            {
                this.checkedListBoxCategories.Items.Add(entry.Key, entry.Value);
            }
        }

        private void updateCheckedCategoriesInCheckedListBoxFilters()
        {
            HashSet<string> checkedCategories = new HashSet<string>();

            foreach (string checkedChoice in checkedListBoxCategories.CheckedItems)
            {
                checkedCategories.Add(checkedChoice);
            }

            MyFacebookAppController.Instance.UpdateCheckedCategories(checkedCategories);
        }

        private void buttonCreateCategory_Click(object sender, EventArgs e)
        {
            FormCreateCategory formCreateCategory = new FormCreateCategory();
            
            formCreateCategory.ShowDialog();
        }

        private void getImageGallery()
        {
            AlbumsController = new AlbumsController(flowLayoutPanelAlbums);

            Invoke(new Action(() => AlbumsController.ShowAlbums()));
        }

        private void menuTab_Click(object sender, EventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            int selectedIndex = tabControl.SelectedIndex;

            if(selectedIndex == 1)
            {
                new Thread(getImageGallery).Start();
            }
            else if(selectedIndex == 2)
            {
                new Thread(getPages).Start();
            }
        }

        private void showSliderGallery()
        {
            for (int i = 0; i < MyFacebookAppController.Instance.MyFacebookAppSettings.AlbumsIndices.Count; i++)
            {
                int albumIndex = MyFacebookAppController.Instance.MyFacebookAppSettings.AlbumsIndices[i];
                List<int> favoriteImagesIndexesInAlbum = MyFacebookAppController.Instance.MyFacebookAppSettings.ImagesIndicesInAlbum[i];

                foreach (int imageIndex in favoriteImagesIndexesInAlbum)
                {
                    MyFacebookAppController.Instance.SliderGalleryController.Add(MyFacebookAppController.Instance.LoggedInUser.Albums[albumIndex].Photos[imageIndex].ImageNormal);
                }

                MyFacebookAppController.Instance.SliderGalleryController.Start();
            }
        }
    }
}
