using System;
using System.Windows.Forms;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace MyFacebookAppUI
{
    public static class BuilderComposer
    {
        public static List<Control> CreatePanelImage(string i_PictureAlbumURL, int i_LikesCount, EventHandler i_Button_Click, bool i_CheckboxState, EventHandler i_CheckBox_CheckedChanged)
        {
            ImageBuilder imageBuilder = new ImageBuilder();

            return imageBuilder
               .AddPictureBox(i_PictureAlbumURL)
               .AddLabel($"Likes: {i_LikesCount}")
               .AddButton("Comments", i_Button_Click)
               .AddCheckbox(i_CheckboxState, i_CheckBox_CheckedChanged)
               .Build()
               .Get();
        }

        public static List<Control> CreatePanelPage(string i_CategoryName, Page i_Page, Action<object, EventArgs, Page, Label> i_ChangePageCategory_Click) 
        {
            PageBuilder pageBuilder = new PageBuilder();
            return pageBuilder
               .AddPictureBox(i_Page.PictureSmallURL)
               .AddNameLabel(i_Page.Name)
               .AddCategoryLabel("Category:" + i_CategoryName)
               .AddLinkLabel("Change category", i_Page, i_ChangePageCategory_Click)
               .Build()
               .Get();
               
        }

        public static List<Control> CreatePanelAlbum(Album i_Album, EventHandler i_Button_Click) 
        {
            AlbumBuilder albumBuilder = new AlbumBuilder();

            return albumBuilder
               .AddPictureBox(i_Album.PictureAlbumURL)
               .AddButton(i_Album.Name, i_Button_Click)
               .Build()
               .Get();
        }
    }
}
