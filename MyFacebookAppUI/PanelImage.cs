using System;
using MyFacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MyFacebookAppUI
{
    public partial class PanelImage : Panel
    {

        private readonly Photo r_Image;
        private readonly List<int> r_IndexesOfFavoritePhotos = new List<int>();
        private readonly int r_ImageIndex;
        private readonly ListBox r_CommentsListBox = new ListBox();
        private eClickStatus m_MouseClickStatus = eClickStatus.UnClickedOnMouse;
        public PanelImage(Photo i_Image, List<int> i_IndexesOfFavoritePhotos, int i_ImageIndex)
        {
            InitializeComponent();
            r_Image = i_Image;
            r_IndexesOfFavoritePhotos = i_IndexesOfFavoritePhotos;
            r_ImageIndex = i_ImageIndex;
            AutoSize = true;
            BackColor = Color.PeachPuff;
        }

        public void ShowImage()
        {
            Controls.AddRange(
                PanelBuilderComposer.CreatePanelImage(
                    r_Image.PictureAlbumURL,
                    r_Image.LikedBy.Count,
                    new EventHandler(currentButton_Click),
                    r_IndexesOfFavoritePhotos.Contains(r_ImageIndex),
                    new EventHandler(addToFavoriteCheckBox_CheckedChanged)
                    )
                .ToArray()
            );
            Controls.Add(r_CommentsListBox);
            r_CommentsListBox.Hide();
        }

        private void addToFavoriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox currentCheckBox)
            {
                if (currentCheckBox.Checked)
                {
                    if (!r_IndexesOfFavoritePhotos.Contains(r_ImageIndex))
                    {
                        MyFacebookAppController.Instance.SliderGalleryController.Add(r_Image.ImageNormal);
                        r_IndexesOfFavoritePhotos.Add(r_ImageIndex);
                    }
                }
                else
                {
                    MyFacebookAppController.Instance.SliderGalleryController.Remove(r_Image.ImageNormal);
                    r_IndexesOfFavoritePhotos.Remove(r_ImageIndex);
                }
            }
        }

        private void currentButton_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;

            if (m_MouseClickStatus.Equals(eClickStatus.UnClickedOnMouse))
            {
                showComments(currentButton);
            }
            else
            {
                displayCommentsPostAction(currentButton);
            }
        }

        private void displayCommentsPostAction(Button i_CurrentButton)
        {
            if (i_CurrentButton.Text.Equals("Comments"))
            {
                MessageBox.Show("Please hide comments first");
            }
            else
            {
                r_CommentsListBox.Hide();
                i_CurrentButton.Text = "Comments";
                m_MouseClickStatus = eClickStatus.UnClickedOnMouse;
            }
        }


        private void showComments(Button i_CurrentButton)
        {
            r_CommentsListBox.Items.Clear();
            foreach (Comment comment in r_Image.Comments)
            {
                if (comment.Message != null)
                {
                    r_CommentsListBox.Items.Add(comment.Message);
                }
            }

            i_CurrentButton.Text = "Hide Comments";
            Point commentsListBoxPosition = new Point(i_CurrentButton.Location.X + Constants.k_PictureBoxWidth, i_CurrentButton.Location.Y);

            r_CommentsListBox.Location = commentsListBoxPosition;
            r_CommentsListBox.BringToFront();
            r_CommentsListBox.Show();
            m_MouseClickStatus = eClickStatus.ClickedOnMouse;
        }

    }
}
