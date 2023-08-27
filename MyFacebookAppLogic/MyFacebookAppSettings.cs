using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace MyFacebookAppLogic
{
    public class MyFacebookAppSettings
    {
        private const string k_AppSettingsFilePath = @"C:\Temp\myFacebookAppSettings.xml";
        public static string AppId { get; } = "244637817895644"; // Real: 3585499691695924, Fake: 244637817895644
        public Point PreviousWindowLocation { get; set; }
        public string PreviousPageColor { get; set; }
        public string PreviousButtonsColor { get; set; }
        public string PreviousNameColor { get; set; }
        public string PreviousStatus { get; set; }
        public bool ShouldRememberUser { get; set; }
        public string PreviousAccessToken { get; set; }
        public List<List<int>> ImagesIndicesInAlbum { get; set; }
        public List<int> AlbumsIndices { get; set; }
        public List<string> Categories { get; set; }
        public List<string> PagesWithCategories { get; set; }
        public static string[] AppPermissions { get; } =
            {
            "public_profile",
                    "email",
                    "user_birthday",
                    "user_gender",
                    "user_link",
                    "user_videos",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_location",
                    "user_photos",
                    "user_hometown",
                    "user_posts",
        };

        private MyFacebookAppSettings()
        {
            PreviousWindowLocation = new Point(20, 50);
            PreviousPageColor = "WhiteSmoke";
            PreviousButtonsColor = "MidnightBlue";
            PreviousNameColor = "Black";
            PreviousStatus = string.Empty;
            ShouldRememberUser = false;
            PreviousAccessToken = null;
            ImagesIndicesInAlbum = new List<List<int>>();
            AlbumsIndices = new List<int>();
            Categories = new List<string>();
            PagesWithCategories = new List<string>();
        }

        public static MyFacebookAppSettings GetApplicationSettingsFromFile()
        {
            MyFacebookAppSettings facebookApplicationSettings;
            try
            {
                using (Stream stream = new FileStream(k_AppSettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializerXml = new XmlSerializer(typeof(MyFacebookAppSettings));
                    facebookApplicationSettings = serializerXml.Deserialize(stream) as MyFacebookAppSettings;
                }
            }
            catch
            {
                facebookApplicationSettings = new MyFacebookAppSettings();
            }

            return facebookApplicationSettings;
        }

        public void SaveAppSettingsIntoFile()
        {
            writeContentToStream(!File.Exists(k_AppSettingsFilePath) ? FileMode.Create : FileMode.Truncate);
        }

        private void writeContentToStream(FileMode i_FileMode)
        {
            FileMode fileMode = i_FileMode;

            using (Stream stream = new FileStream(k_AppSettingsFilePath, fileMode))
            {
                XmlSerializer serializerXml = new XmlSerializer(this.GetType());
                serializerXml.Serialize(stream, this);
            }
        }

        public void DeleteSettingsFile()
        {
            try
            {
                if (File.Exists(k_AppSettingsFilePath))
                {
                    File.Delete(k_AppSettingsFilePath);
                }
                else 
                { 
                    System.Console.WriteLine("File not found"); 
                }
            }
            catch (IOException ioExp)
            {
                System.Console.WriteLine(ioExp.Message);
            }
        }
    }
}
