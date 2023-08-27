using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public partial class PanelAlbum : Panel
    {
        private readonly Album r_Album;
        private readonly int r_AlbumIndex;
        public PanelAlbum(Album i_Album, int i_AlbumIndex)
        {
            InitializeComponent();
            r_Album = i_Album;
            r_AlbumIndex = i_AlbumIndex;
            AutoSize = true;
            BackColor = Color.PeachPuff;
        }

        public void ShowAlbum()
        {
            AlbumBuilder albumBuilder = new AlbumBuilder();

            Controls.AddRange(albumBuilder
               .AddPictureBox(r_Album.PictureAlbumURL)
               .AddButton(r_Album.Name, new EventHandler(currentButton_Click))
               .Build()
               .ToArray()
               );

        }

        private void currentButton_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            FormAlbumImages imagesInCurrent = new FormAlbumImages(r_Album, r_AlbumIndex);

            imagesInCurrent.ShowDialog();
        }
    }
}
