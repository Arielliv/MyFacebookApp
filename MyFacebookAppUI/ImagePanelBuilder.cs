using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public class ImagePanelBuilder: PanelBuilderDecorator
    {
        private Label m_Label;
        private CheckBox m_CheckBox;
        private Button m_Button;
        private readonly int r_XPosition = 0;
        private readonly int r_ButtonYPosition = 150;
        private readonly int r_LikesLabelYPosition = 180;
        private readonly int r_CheckboxYPosition = 200;

        public ImagePanelBuilder(IPanelBuilder i_Builder) : base(i_Builder) { }

        public ImagePanelBuilder AddButton(string i_Text, EventHandler i_EventHandler)
        {
            m_Button = new Button();
            m_Button.Text = i_Text;
            m_Button.Width = Constants.k_ButtonsWidth;
            m_Button.Location = new Point(r_XPosition, r_ButtonYPosition);
            m_Button.Click += i_EventHandler;

            return this;
        }

        public ImagePanelBuilder AddLabel(string i_Name)
        {
            m_Label = new Label();
            m_Label.Text = i_Name;
            m_Label.Location = new Point(r_XPosition, r_LikesLabelYPosition);

            return this;
        }

        public ImagePanelBuilder AddCheckbox(bool i_IsChecked, EventHandler i_EventHandler)
        {
            m_CheckBox = new CheckBox();
            m_CheckBox.Location = new Point(r_XPosition, r_CheckboxYPosition);
            m_CheckBox.Checked = i_IsChecked;
            m_CheckBox.CheckedChanged += i_EventHandler;

            return this;
        }

        public override IPanelBuilder Build()
        {
            base.Build();
            r_Builder.AddToComponents(m_Label);
            r_Builder.AddToComponents(m_CheckBox);
            r_Builder.AddToComponents(m_Button);

            return this;
        }
    }
}
