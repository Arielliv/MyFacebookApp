using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MyFacebookAppUI
{
    public partial class EllipsePictureBox : PictureBox
    {
        protected override void OnSizeChanged(EventArgs e)
        {
            GraphicsPath graphicsPath = new GraphicsPath();

            graphicsPath.AddEllipse(DisplayRectangle);
            Region = new Region(graphicsPath);
            base.OnSizeChanged(e);
        }
    }
}
