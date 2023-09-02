using System;
using System.Windows.Forms;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using System.Drawing;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public static class BuilderComposer
    {
        private static readonly int sr_XPositionStart = 0;
        private static readonly int sr_XPositionMiddle = 50;
        private static readonly Size sr_BigImageSize = new Size(Constants.k_PictureBoxWidth, Constants.k_PictureBoxHeight);
        private static readonly Size sr_SmallImageSize = new Size(50, 50);
        public static List<Control> CreatePanelImage(string i_PictureAlbumURL, int i_LikesCount, EventHandler i_Button_Click, bool i_CheckboxState, EventHandler i_CheckBox_CheckedChanged)
        {
            ImageBuilder imageBuilder = new ImageBuilder(new CoreBuilder());

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
            PageBuilder pageBuilder = new PageBuilder(new CoreBuilder());

            pageBuilder
               .AddCategoryLabel("Category:" + i_CategoryName)
               .AddLinkLabel("Change category", i_Page, i_ChangePageCategory_Click)
               .AddNameLabel(i_Page.Name)
               .AddPictureBox(i_Page.PictureSmallURL, sr_SmallImageSize, sr_XPositionMiddle);

                return pageBuilder.Build().Get();
               
        }

        public static List<Control> CreatePanelAlbum(Album i_Album, EventHandler i_Button_Click) 
        {
            AlbumBuilder albumBuilder = new AlbumBuilder(new CoreBuilder());

             albumBuilder
               .AddButton(i_Album.Name, i_Button_Click)
               .AddPictureBox(i_Album.PictureAlbumURL, sr_BigImageSize, sr_XPositionStart, PictureBoxSizeMode.Zoom);
            
            return albumBuilder.Build().Get();
        }
    }
}
