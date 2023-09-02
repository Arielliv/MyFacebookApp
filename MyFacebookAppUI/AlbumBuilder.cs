using System;
using System.Drawing;
using System.Windows.Forms;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public class AlbumBuilder: BuilderDecorator
    {
        private Button m_Button;
        private readonly int r_XPosition = 0;
        private readonly int r_ButtonYPosition = 150;

        public AlbumBuilder(IBuilder i_Builder) : base(i_Builder) { }

        public IBuilder AddButton(string i_Text, EventHandler i_EventHandler)
        {
            m_Button = new Button();
            m_Button.Text = i_Text;
            m_Button.Width = Constants.k_ButtonsWidth;
            m_Button.Location = new Point(r_XPosition, r_ButtonYPosition);
            m_Button.Click += i_EventHandler;

            return this;
        }

        public override IBuilder Build() 
        {
            base.Build();
            AddToComponents(m_Button);
            
            return this;
        }
    }
}
