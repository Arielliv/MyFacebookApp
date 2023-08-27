using System;
using System.Drawing;

namespace MyFacebookAppLogic
{
    public static class Constants
    {
        public const int k_DefaultOption = 0;
        public const int k_StartLocationX = 50;
        public const int k_StartLocationY = 10;
        public const int k_ImagesCountInRow = 5;
        public const int k_GalleryItemsGap = 185;
        public const int k_PictureBoxWidth = 150;
        public const int k_PictureBoxHeight = 100;
        public const int k_ButtonsWidth = 150;

        public static readonly string[] sr_Statuses =
            {
    "Feeling excited about my upcoming vacation! 🌞🏖️",
    "Had a great time catching up with old friends today! 😄👋",
    "Feeling blessed and grateful for all the love and support in my life. ❤️🙏",
    "Just finished reading an amazing book. Highly recommended! 📚👍",
    "Enjoying a delicious homemade meal with my family. 🍽️👪",
    "Feeling motivated to start a new project. Wish me luck! 💪😊",
    "Missing my favorite city. Can't wait to go back! 🌆✈️",
    "Feeling proud of my team's accomplishments at work. 🏢👏",
    "Trying out a new hobby – painting! 🎨🖌️",
    "Enjoying a peaceful Sunday afternoon with a cup of tea. ☕😌"
        };

        public static readonly string[] sr_ColorNames = Enum.GetNames(typeof(KnownColor));
    }
}
