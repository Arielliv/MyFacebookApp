using System;
using System.Drawing;
using System.Windows.Forms;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public class AlbumPanelBuilder: PanelBuilderDecorator
    {
        private Button m_Button;
        private readonly int r_XPosition = 0;
        private readonly int r_ButtonYPosition = 150;

        public AlbumPanelBuilder(IPanelBuilder i_Builder) : base(i_Builder) { }

        public IPanelBuilder AddButton(string i_Text, EventHandler i_EventHandler)
        {
            m_Button = new Button();
            m_Button.Text = i_Text;
            m_Button.Width = Constants.k_ButtonsWidth;
            m_Button.Location = new Point(r_XPosition, r_ButtonYPosition);
            m_Button.Click += i_EventHandler;

            return this;
        }

        public override IPanelBuilder Build() 
        {
            base.Build();
            AddToComponents(m_Button);
            
            return this;
        }
    }
}
