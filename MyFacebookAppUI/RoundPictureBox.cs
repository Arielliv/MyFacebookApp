using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyFacebookAppUI
{
    public partial class RoundPictureBox : PictureBox
    {
        protected override void OnSizeChanged(EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(DisplayRectangle);
            Region = new Region(gp);
            base.OnSizeChanged(e);
        }
    }
}
