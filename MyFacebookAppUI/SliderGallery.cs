using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace MyFacebookAppUI
{
    public partial class SliderGallery : PictureBox
    {
        private const int k_SliderInterval = 3500;
        private readonly List<Image> r_Images = new List<Image>();
        private readonly Timer r_Timer = new Timer();

        public SliderGallery() : base()
        {
            Size = new Size(383, 200);
            Location = new Point(450, 160);
            SizeMode = PictureBoxSizeMode.Zoom;
            r_Timer.Tick += presentedImage;
            r_Timer.Interval = k_SliderInterval;
        }

        public List<Image> Images => r_Images;

        private void presentedImage(object sender, EventArgs e)
        {
            if (r_Images.Count > 0)
            {
                Image = Images[new Random().Next(Images.Count)];
            }
            else
            {
                this.Hide();
                r_Timer.Stop();
            }
        }
    }
}