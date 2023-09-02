using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Collections;

namespace MyFacebookAppLogic
{
    public class CategoriesController: IEnumerable<KeyValuePair<Page, string>>
    {
        public Dictionary<string, bool> Categories { get; private set; }
        public Dictionary<Page, string> PagesWithCategories { get; }
        private readonly string r_DefualtCategory = "None";
        private readonly bool r_DefaultCategoryState = false;

        public CategoriesController(FacebookObjectCollection<Page> i_Pages)
        {
            this.Categories = new Dictionary<string, bool>();
            this.PagesWithCategories = new Dictionary<Page, string>();
            initPagesWithCategoriesMap(i_Pages);
        }

        private void initPagesWithCategoriesMap(FacebookObjectCollection<Page> i_Pages)
        {
            this.Categories.Add(r_DefualtCategory, r_DefaultCategoryState);
            foreach (Page page in i_Pages)
            {
                this.PagesWithCategories.Add(page, r_DefualtCategory);
            }
        }

        public void CreateCategory(string i_NewCategory)
        {
            if (Categories.ContainsKey(i_NewCategory))
            {
                throw new ArgumentException(string.Format("Category {0} already exist", i_NewCategory));
            }

            this.Categories.Add(i_NewCategory, r_DefaultCategoryState);
        }

        public string GetPageCategory(Page i_Page)
        {
            if (!this.PagesWithCategories.ContainsKey(i_Page))
            {
                throw new ArgumentException(string.Format("Page {0} does not exist.", i_Page.Name));
            }

            this.PagesWithCategories.TryGetValue(i_Page, out string pageCategory);

            return pageCategory;
        }

        public void ChangePageCategory(Page i_Page, string i_Category)
        {
            if (!this.Categories.ContainsKey(i_Category))
            {
                CreateCategory(i_Category);
            }

            if (!this.PagesWithCategories.ContainsKey(i_Page))
            {
                throw new ArgumentException(string.Format("Page {0} does not exist", i_Page.Name));
            }

            this.PagesWithCategories[i_Page] = i_Category;
        }

        public void UpdateCheckedCategories(HashSet<string> i_CheckedCategories)
        {
            List<string> categories = new List<string>(Categories.Keys);

            foreach (string category in categories)
            {
                if (i_CheckedCategories.Contains(category))
                {
                    this.Categories[category] = true;
                }
                else
                {
                    this.Categories[category] = false;
                }
            }
        }

        public IEnumerator<KeyValuePair<Page, string>> GetEnumerator()
        {
            foreach (KeyValuePair<Page, string> entry in PagesWithCategories)
            {
                yield return entry;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
