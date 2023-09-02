using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace MyFacebookAppUI
{
    public class BuilderDecorator: IBuilder
    {
        protected readonly IBuilder r_Builder;

        public BuilderDecorator(IBuilder i_Builder)
        {
            r_Builder = i_Builder;
        }

        public virtual IBuilder Build() 
        {
            return r_Builder.Build();
        }

        public void AddToComponents(Control i_Control)
        {
            r_Builder.AddToComponents(i_Control);
        }

        public IBuilder AddPictureBox(string i_PictureURL, Size i_Size, int i_XPosition, PictureBoxSizeMode i_PictureBoxSizeMode = PictureBoxSizeMode.Normal) 
        {
            return r_Builder.AddPictureBox(i_PictureURL, i_Size, i_XPosition, i_PictureBoxSizeMode);
        }

        public List<Control> Get()
        {
            return r_Builder.Get();
        }

    }
}
