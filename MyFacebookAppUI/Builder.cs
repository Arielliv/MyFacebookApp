using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MyFacebookAppLogic;

namespace MyFacebookAppUI
{
    public interface IBuilder
    {
        IBuilder Build();

        List<Control> Get();
    }
}
