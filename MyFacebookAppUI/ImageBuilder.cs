﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public class ImageBuilder
    {
        private readonly List<Control> r_Components = new List<Control>();
        private PictureBox m_PictureBox;
        private Label m_Label;
        private CheckBox m_CheckBox;
        private Button m_Button;
        private readonly int r_XPosition = 0;
        private readonly int r_PictureBoxYPosition = 50;
        private readonly int r_ButtonYPosition = 150;
        private readonly int r_LikesLabelYPosition = 180;
        private readonly int r_CheckboxYPosition = 200;
        

        public ImageBuilder AddPictureBox(string i_PictureURL)
        {
            m_PictureBox = new PictureBox();
            m_PictureBox.LoadAsync(i_PictureURL);
            m_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            m_PictureBox.Location = new Point(r_XPosition, r_PictureBoxYPosition);
            m_PictureBox.Size = new Size(Constants.k_PictureBoxWidth, Constants.k_PictureBoxHeight);

            return this;
        }

        public ImageBuilder AddButton(string i_Text, EventHandler i_EventHandler)
        {
            m_Button = new Button();
            m_Button.Text = i_Text;
            m_Button.Width = Constants.k_ButtonsWidth;
            m_Button.Location = new Point(r_XPosition, r_ButtonYPosition);
            m_Button.Click += i_EventHandler;

            return this;
        }

        public ImageBuilder AddLabel(string i_Name)
        {
            m_Label = new Label();
            m_Label.Text = i_Name;
            m_Label.Location = new Point(r_XPosition, r_LikesLabelYPosition);

            return this;
        }

        public ImageBuilder AddCheckbox(bool i_IsChecked, EventHandler i_EventHandler)
        {
            m_CheckBox = new CheckBox();
            m_CheckBox.Location = new Point(r_XPosition, r_CheckboxYPosition);
            m_CheckBox.Checked = i_IsChecked;
            m_CheckBox.CheckedChanged += i_EventHandler;

            return this;
        }

        public List<Control> Build() 
        {
            r_Components.Add(m_PictureBox);
            r_Components.Add(m_Label);
            r_Components.Add(m_CheckBox);
            r_Components.Add(m_Button);
            return r_Components;
        }
    }
}