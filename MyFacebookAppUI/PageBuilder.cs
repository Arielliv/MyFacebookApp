using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public class PageBuilder
    {
        private readonly List<Control> r_Components = new List<Control>();
        private PictureBox m_PictureBox;
        private Label m_CategoryLabel;
        private Label m_PageLabel;
        private LinkLabel m_LinkLabel;
        private readonly int r_XPosition = 50;
        private readonly int r_PictureBoxYPosition = 50;
        private readonly int r_AddNameLabelYPosition = 100;
        private readonly int r_CategoryLabelYPosition = 123;
        private readonly int r_LinkLabelYPosition = 146;

        public PageBuilder AddPictureBox(string i_PictureURL)
        {
            m_PictureBox = new PictureBox();
            m_PictureBox.LoadAsync(i_PictureURL);
            m_PictureBox.Location = new Point(r_XPosition, r_PictureBoxYPosition);
            
            return this;
        }

        public PageBuilder AddNameLabel(string i_Name)
        {
            m_PageLabel = new Label();
            m_PageLabel.Text = i_Name;
            m_PageLabel.Location = new Point(Constants.k_StartLocationX, r_AddNameLabelYPosition);
            
            return this;
        }

        public PageBuilder AddCategoryLabel(string i_Name)
        {
            m_CategoryLabel = new Label();
            m_CategoryLabel.Text = i_Name;
            m_CategoryLabel.Location = new Point(Constants.k_StartLocationX, r_CategoryLabelYPosition);
            
            return this;
        }

        public PageBuilder AddLinkLabel(string i_LinkLabelText, Page i_Page, Action<object, EventArgs, Page, Label> i_ClickHandler)
        {
            m_LinkLabel = new LinkLabel();
            m_LinkLabel.Text = i_LinkLabelText;
            m_LinkLabel.Location = new Point(Constants.k_StartLocationX, r_LinkLabelYPosition);
            if (i_ClickHandler != null)
            {
                m_LinkLabel.Click += (sender, e) => i_ClickHandler(sender, e,i_Page, m_CategoryLabel);
            }
            
            return this;
        }

        public List<Control> Build() 
        {
            r_Components.Add(m_PictureBox);
            r_Components.Add(m_PageLabel);
            r_Components.Add(m_CategoryLabel);
            r_Components.Add(m_LinkLabel);
            
            return r_Components;
        }
    }
}
