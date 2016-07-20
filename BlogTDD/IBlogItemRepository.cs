using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogTDD
{
    public interface IBlogItemRepository
    {
        void AddBlogPost(int key, string value);
        void RemoveBlogPost(int keyToRemove);
        void ShowBlogPosts();
        void UpdateBlogPost(int key, string updateValue);
    }
}
