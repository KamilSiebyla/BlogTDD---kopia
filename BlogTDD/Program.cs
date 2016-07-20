using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogHelper BlogClient = new BlogHelper();

            while (true)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("MAIN MENU");
                Console.WriteLine("1. ADD POST");
                Console.WriteLine("2. DISPLAY LAST 10 POSTS ");
                Console.WriteLine("3. UPDATE SELECTED POST ");
                Console.WriteLine("4. REMOVE SELECTED POST ");
                Console.WriteLine("----------------------------");
                Console.WriteLine("------ CHOOSE OPTION ------");
                int OptionChoice = Convert.ToInt32(Console.ReadLine());

                switch (OptionChoice)
                {
                    case 1:
                        Console.WriteLine("------ GIVE ME NUMBER OF ACTUAL POST -----");
                        BlogClient.Id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("----- WRITE SOME CONTENT IN THIS POST ------");
                        BlogClient.PostContent = Console.ReadLine();

                        BlogClient.AddBlogPost(BlogClient.Id, BlogClient.PostContent);
                        break;

                    case 2:
                        BlogClient.ShowBlogPosts();
                        break;

                    case 3:
                        Console.WriteLine("------ GIVE ME THE NUMBER OF POST YOU WANT TO UPDATE -----");
                        BlogClient.Id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("----- WRITE SOME NEW CONTENT IN THIS POST ------");
                        BlogClient.PostContent = Console.ReadLine();

                        BlogClient.UpdateBlogPost(BlogClient.Id, BlogClient.PostContent);
                        break;

                    case 4:
                        Console.WriteLine("------ GIVE ME THE NUMBER OF POST YOU WANT TO REMOVE -----");
                        BlogClient.Id = Convert.ToInt32(Console.ReadLine());

                        BlogClient.RemoveBlogPost(BlogClient.Id);
                        break;

                    default:
                        Console.WriteLine("I KNOW NOTHING ABOUT THIS OPTION. TRY AGAIN !");
                        Console.Clear();
                        break;
                }



                Console.ReadLine();
            }

        }
    }
}
