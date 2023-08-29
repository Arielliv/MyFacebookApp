using FacebookWrapper.ObjectModel;


namespace MyFacebookAppUI
{
    public class PostProxy: FacebookObject
    {
        private readonly Post r_Post;

        public PostProxy(Post i_Post)
        {
            this.r_Post = i_Post;
        }

        public override string ToString()
        {
            string text;

            if (r_Post.Message != null)
            {
                text = $"Post message: [{r_Post.Message}]";
            }
            else if (r_Post.Caption != null)
            {
                text = $"Post caption: [{r_Post.Caption}]"; ;
            }
            else
            {
                text = $"Post type: [{r_Post.Type}]";
            }

            return text;
        }
    }
}
