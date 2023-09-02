using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyFacebookAppUI
{
    public class CorePanelBuilder: IPanelBuilder
    {
        private readonly List<Control> r_Components = new List<Control>();
        private PictureBox m_PictureBox;
        private readonly int r_PictureBoxYPosition = 50;

        public IPanelBuilder AddPictureBox(string i_PictureURL, Size i_Size, int i_XPosition, PictureBoxSizeMode i_PictureBoxSizeMode = PictureBoxSizeMode.Normal)
        {
            m_PictureBox = new PictureBox();
            m_PictureBox.LoadAsync(i_PictureURL);
            m_PictureBox.SizeMode = i_PictureBoxSizeMode;
            m_PictureBox.Location = new Point(i_XPosition, r_PictureBoxYPosition);
            m_PictureBox.Size = i_Size;

            return this;
        }

        public void AddToComponents(Control i_Control) 
        {
            r_Components.Add(i_Control);
        }

        public IPanelBuilder Build()
        {
            AddToComponents(m_PictureBox);

            return this;
        }

        public List<Control> Get()
        {
            return r_Components;
        }
    }
}
