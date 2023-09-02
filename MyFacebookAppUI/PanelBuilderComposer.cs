using System;
using System.Windows.Forms;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using System.Drawing;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public static class PanelBuilderComposer
    {
        private static readonly int sr_XPositionStart = 0;
        private static readonly int sr_XPositionMiddle = 50;
        private static readonly Size sr_BigImageSize = new Size(Constants.k_PictureBoxWidth, Constants.k_PictureBoxHeight);
        private static readonly Size sr_SmallImageSize = new Size(50, 50);
        public static List<Control> CreatePanelImage(string i_PictureAlbumURL, int i_LikesCount, EventHandler i_Button_Click, bool i_CheckboxState, EventHandler i_CheckBox_CheckedChanged)
        {
            ImagePanelBuilder imageBuilder = new ImagePanelBuilder(new CorePanelBuilder());

            imageBuilder
               .AddButton("Comments", i_Button_Click)
               .AddCheckbox(i_CheckboxState, i_CheckBox_CheckedChanged)
               .AddLabel($"Likes: {i_LikesCount}")
               .AddPictureBox(i_PictureAlbumURL, sr_BigImageSize, sr_XPositionStart, PictureBoxSizeMode.Zoom);
            
            return imageBuilder.Build()
               .Get();
        }

        public static List<Control> CreatePanelPage(string i_CategoryName, Page i_Page, Action<object, EventArgs, Page, Label> i_ChangePageCategory_Click) 
        {
            PagePanelBuilder pageBuilder = new PagePanelBuilder(new CorePanelBuilder());

            pageBuilder
               .AddCategoryLabel("Category:" + i_CategoryName)
               .AddLinkLabel("Change category", i_Page, i_ChangePageCategory_Click)
               .AddNameLabel(i_Page.Name)
               .AddPictureBox(i_Page.PictureSmallURL, sr_SmallImageSize, sr_XPositionMiddle);

                return pageBuilder.Build().Get();
               
        }

        public static List<Control> CreatePanelAlbum(Album i_Album, EventHandler i_Button_Click) 
        {
            AlbumPanelBuilder albumBuilder = new AlbumPanelBuilder(new CorePanelBuilder());

             albumBuilder
               .AddButton(i_Album.Name, i_Button_Click)
               .AddPictureBox(i_Album.PictureAlbumURL, sr_BigImageSize, sr_XPositionStart, PictureBoxSizeMode.Zoom);
            
            return albumBuilder.Build().Get();
        }
    }
}
