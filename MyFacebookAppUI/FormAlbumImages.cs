using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyFacebookAppLogic;
using FacebookWrapper.ObjectModel;

namespace MyFacebookAppUI
{
    public partial class FormAlbumImages : Form
    {
        private readonly Album r_CurrentAlbum;
        private readonly int r_AlbumIndex;
        private readonly List<int> r_IndexesOfFavoritePhotos = new List<int>();
        
        public FormAlbumImages(Album i_CurrentAlbum, int i_AlbumIndex)
        {
            InitializeComponent();

            r_AlbumIndex = i_AlbumIndex;
            r_CurrentAlbum = i_CurrentAlbum;
            this.Text = r_CurrentAlbum.Name;
            MyFacebookAppController.Instance.FavoriteImageIndex.TryGetValue(r_AlbumIndex, out r_IndexesOfFavoritePhotos);
            if (r_IndexesOfFavoritePhotos == null)
            {
                r_IndexesOfFavoritePhotos = new List<int>();
            }
        }

        private void fromImagesGallery_Load(object sender, EventArgs e)
        {
            showImages();
        }

        private void showImages()
        {
            int i = 0;
            foreach (Photo photo in r_CurrentAlbum.Photos)
            {
                PanelImage panelImage = new PanelImage(photo, r_IndexesOfFavoritePhotos, i);

                panelImage.ShowImage();
                flowLayoutPanelImages.Controls.Add(panelImage);
                i++;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            MyFacebookAppController.Instance.SliderGalleryController.Start();
            if (MyFacebookAppController.Instance.FavoriteImageIndex.ContainsKey(r_AlbumIndex))
            {
                MyFacebookAppController.Instance.FavoriteImageIndex.Remove(r_AlbumIndex);
            }

            MyFacebookAppController.Instance.FavoriteImageIndex.Add(r_AlbumIndex, r_IndexesOfFavoritePhotos);
            MyFacebookAppController.Instance.SaveAlbumsAndImagesIndices();
            MyFacebookAppController.Instance.MyFacebookAppSettings.ImagesIndicesInAlbum = MyFacebookAppController.Instance.ImagesIndicesToSave;
            MyFacebookAppController.Instance.MyFacebookAppSettings.AlbumsIndices = MyFacebookAppController.Instance.AlbumsIndicesToSave;
        }
    }
}