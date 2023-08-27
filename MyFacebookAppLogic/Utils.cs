using System.Drawing;

namespace MyFacebookAppLogic
{
    public static class Utils
    {
        public static Color GetColorByName(string i_ColorName)
        {
            return Color.FromName(i_ColorName);
        }
    }
}
