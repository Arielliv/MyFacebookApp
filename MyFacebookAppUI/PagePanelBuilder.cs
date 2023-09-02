using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public class PagePanelBuilder: PanelBuilderDecorator
    {
        private Label m_CategoryLabel;
        private Label m_PageLabel;
        private LinkLabel m_LinkLabel;
        private readonly int r_CategoryLabelYPosition = 123;
        private readonly int r_LinkLabelYPosition = 146;
        private readonly int r_AddNameLabelYPosition = 100;

        public PagePanelBuilder(IPanelBuilder i_Builder) : base(i_Builder) { }

        public PagePanelBuilder AddCategoryLabel(string i_Name)
        {
            m_CategoryLabel = new Label();
            m_CategoryLabel.Text = i_Name;
            m_CategoryLabel.Location = new Point(Constants.k_StartLocationX, r_CategoryLabelYPosition);
            
            return this;
        }

        public PagePanelBuilder AddNameLabel(string i_Name)
        {
            m_PageLabel = new Label();
            m_PageLabel.Text = i_Name;
            m_PageLabel.Location = new Point(Constants.k_StartLocationX, r_AddNameLabelYPosition);

            return this;
        }

        public PagePanelBuilder AddLinkLabel(string i_LinkLabelText, Page i_Page, Action<object, EventArgs, Page, Label> i_ClickHandler)
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

        public override IPanelBuilder Build()
        {
            base.Build();
            r_Builder.AddToComponents(m_CategoryLabel);
            r_Builder.AddToComponents(m_LinkLabel);
            r_Builder.AddToComponents(m_PageLabel);

            return this;
        }
    }
}
