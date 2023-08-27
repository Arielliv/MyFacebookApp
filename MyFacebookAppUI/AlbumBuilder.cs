using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public class AlbumBuilder: IBuilder
    {
        private readonly List<Control> r_Components = new List<Control>();
        private PictureBox m_PictureBox;
        private Button m_Button;
        private readonly int r_XPosition = 0;
        private readonly int r_PictureBoxYPosition = 50;
        private readonly int r_ButtonYPosition = 150;

        public AlbumBuilder AddPictureBox(string i_PictureURL)
        {
            m_PictureBox = new PictureBox();
            m_PictureBox.LoadAsync(i_PictureURL);
            m_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            m_PictureBox.Location = new Point(r_XPosition, r_PictureBoxYPosition);
            m_PictureBox.Size = new Size(Constants.k_PictureBoxWidth, Constants.k_PictureBoxHeight);

            return this;
        }

        public AlbumBuilder AddButton(string i_Text, EventHandler i_EventHandler)
        {
            m_Button = new Button();
            m_Button.Text = i_Text;
            m_Button.Width = Constants.k_ButtonsWidth;
            m_Button.Location = new Point(r_XPosition, r_ButtonYPosition);
            m_Button.Click += i_EventHandler;

            return this;
        }

        public IBuilder Build() 
        {
            r_Components.Add(m_PictureBox);
            r_Components.Add(m_Button);
            
            return this;
        }

        public List<Control> Get()
        {
            return r_Components;
        }
    }
}
