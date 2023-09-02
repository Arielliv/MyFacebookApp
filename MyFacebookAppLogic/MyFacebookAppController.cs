using System;
using System.Collections.Generic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace MyFacebookAppLogic
{
	public class MyFacebookAppController
	{
		private readonly Dictionary<int, List<int>> r_FavoriteImageIndex = new Dictionary<int, List<int>>();
		public LoginResult LoginResult { get; set; }
		public User LoggedInUser { get; set; }
		public MyFacebookAppSettings MyFacebookAppSettings { get; }
		public Dictionary<int, List<int>> FavoriteImageIndex => r_FavoriteImageIndex;
		public List<List<int>> ImagesIndicesToSave { get; set; }
		public List<int> AlbumsIndicesToSave { get; set; }
		public List<string> CategoriesToSave { get; set; }
		public CategoriesController CategoriesController { get; private set; }
		private static MyFacebookAppController s_Instance = null;
		private static object s_LockObj = new object();
		public SliderGalleryController SliderGalleryController { get; } = new SliderGalleryController(TimeSpan.FromSeconds(1.5));

		private MyFacebookAppController()
		{
			MyFacebookAppSettings = MyFacebookAppSettings.GetApplicationSettingsFromFile();
		}

		public static MyFacebookAppController Instance
        {
			get
            {
				if(s_Instance == null)
                {
					lock(s_LockObj)
                    {
						if(s_Instance == null)
                        {
							s_Instance = new MyFacebookAppController();
                        }
                    }
                }

				return s_Instance;
            }
        }

		public void Login()
		{
			if (LoginResult == null)
			{
				LoginResult = FacebookService.Login(
					MyFacebookAppSettings.AppId,
					MyFacebookAppSettings.AppPermissions
				);
			}

			Initialize();
		}

		public void Logout() 
		{
			if (LoggedInUser != null) 
			{
				LoggedInUser = null;
				MyFacebookAppSettings.DeleteSettingsFile();
				FacebookService.Logout(null, LoginResult.AccessToken);
				LoginResult = null;
			}
		}

		public void Initialize()
		{
			LoggedInUser = LoginResult.LoggedInUser;
			CategoriesController = new CategoriesController(this.LoggedInUser.LikedPages);
		}

		public bool IsTokenNull()
		{
			return string.IsNullOrEmpty(LoginResult.AccessToken);
		}

		public void SaveAlbumsAndImagesIndices()
		{
			List<List<int>> imagesIndices = new List<List<int>>();
			List<int> albumsIndices = new List<int>();

			foreach (int key in r_FavoriteImageIndex.Keys)
			{
				if (r_FavoriteImageIndex.TryGetValue(key, out List<int> indices))
				{
					imagesIndices.Add(indices);
					albumsIndices.Add(key);
				}
			}

			ImagesIndicesToSave = imagesIndices;
			AlbumsIndicesToSave = albumsIndices;
		}

		public void AddImagesIndicesToFavorites()
		{
			for (int i = 0; i < AlbumsIndicesToSave.Count; i++)
			{
				r_FavoriteImageIndex.Add(AlbumsIndicesToSave[i], ImagesIndicesToSave[i]);
			}
		}

		public HashSet<string> GetAllCategories()
		{
			HashSet<string> allCategories = new HashSet<string>();

			foreach (string category in CategoriesController.Categories.Keys)
			{
				allCategories.Add(category);
			}

			return allCategories;
		}

		public void AddCategory(string i_NewCategory)
		{
			CategoriesController.CreateCategory(i_NewCategory);
		}

		public void ChangePageCategory(Page i_Page, string i_Category)
		{
			CategoriesController.ChangePageCategory(i_Page, i_Category);
		}

		public Dictionary<Page, string> GetPageToCategoryMap()
		{
			return CategoriesController.PagesWithCategories;
		}

		public string GetPageCategory(Page i_Page)
		{
			return CategoriesController.GetPageCategory(i_Page);
		}

		public void UpdateCheckedCategories(HashSet<string> i_CheckedCategories)
		{
			CategoriesController.UpdateCheckedCategories(i_CheckedCategories);
		}

		public Dictionary<string, bool> GetCategories()
		{
			return CategoriesController.Categories;
		}

		public HashSet<string> GetCheckedCategories()
		{
			HashSet<string> checkedCategories = new HashSet<string>();

			foreach (KeyValuePair<string, bool> entry in GetCategories())
			{
				if (entry.Value == true)
				{
					checkedCategories.Add(entry.Key);
				}
			}

			return checkedCategories;
		}

		public void SaveCategories()
		{
			MyFacebookAppSettings.Categories = new List<string>(CategoriesController.Categories.Keys);
		}

		public void LoadCategories()
        {
			CategoriesController.Categories.Clear();
			foreach(string category in MyFacebookAppSettings.Categories)
            {
				CategoriesController.Categories.Add(category, false);
			}
		}

		public void SavePagesWithCategories()
        {
			MyFacebookAppSettings.PagesWithCategories.Clear();
			foreach (KeyValuePair<Page, string> PagesWithCategory in CategoriesController)
            {
				MyFacebookAppSettings.PagesWithCategories.Add(PagesWithCategory.Value);
			}
		}

        public void LoadPagesWithCategories()
        {
			int i = 0;

			if (MyFacebookAppSettings.PagesWithCategories.Count > 0)
            {
				CategoriesController.PagesWithCategories.Clear();
				foreach (string pageWithCategory in MyFacebookAppSettings.PagesWithCategories)
				{
					CategoriesController.PagesWithCategories.Add(this.LoggedInUser.LikedPages[i], pageWithCategory);
					i++;
				}
			}
        }
    }
}