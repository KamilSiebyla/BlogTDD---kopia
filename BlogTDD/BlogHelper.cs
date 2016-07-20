using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTDD
{
    class BlogHelper: IBlogItemRepository
    {

        Dictionary<int, string> BlogItem = new Dictionary<int, string>();

        public int Id { get; set; } //Tutaj trzeba pomyslec nad implementacja geterow i seterow.//
        public string PostContent { get; set; } //Tutaj też.//

        public void AddBlogPost(int key, string value)
        {
            try
            {
                BlogItem.Add(key, value);
            }
            catch
            {
                Console.WriteLine("POST WITH THIS ID ALREDY EXIST. GIVE ME DIFFERENT ID !");

            }
            Console.Clear();
        }

        public void RemoveBlogPost(int keyToRemove)
        {
            BlogItem.Remove(keyToRemove);

            if (!BlogItem.ContainsKey(keyToRemove))
            {
                Console.WriteLine("KEY {0} KEY IS NOT FOUND.", keyToRemove);
            }
            Console.Clear();
        }

        public void ShowBlogPosts()
        {
            Dictionary<int, string>.ValueCollection valueColl = BlogItem.Values;

            foreach (string s in valueColl)
            {
              Console.WriteLine(s); 
            }
            Console.Clear();
        }

        public void UpdateBlogPost(int key, string updateValue)
        {
            BlogItem[key] = updateValue;

            try
            {
                 Console.WriteLine("FOR KEY = {0},  VALUE = {1}.", key , BlogItem[key]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("KEY = {0} IS NOT FOUND.", key);
            }
            Console.Clear();

        }
    }
}
