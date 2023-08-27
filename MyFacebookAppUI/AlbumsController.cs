using System;
using MyFacebookAppLogic;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace MyFacebookAppUI
{
    public class AlbumsController
    {
        private readonly FlowLayoutPanel r_FlowLayoutPanel;

        public AlbumsController(FlowLayoutPanel i_FlowLayoutPanel)
        {
            r_FlowLayoutPanel = i_FlowLayoutPanel;
        }

        public void ShowAlbums()
        {
            int i = 0;
            foreach (Album album in MyFacebookAppController.Instance.LoggedInUser.Albums) {
                PanelAlbum panelAlbum = new PanelAlbum(album, i);

                panelAlbum.ShowAlbum();
                r_FlowLayoutPanel.Controls.Add(panelAlbum);
                i++;
            }
        }
    }
}
