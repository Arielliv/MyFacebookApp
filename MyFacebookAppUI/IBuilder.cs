using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public interface IBuilder
    {
        IBuilder Build();
        void AddToComponents(Control i_Control);
        List<Control> Get();
        IBuilder AddPictureBox(string i_PictureURL, Size i_Size, int i_XPosition, PictureBoxSizeMode i_PictureBoxSizeMode = PictureBoxSizeMode.Normal);
    }
}
