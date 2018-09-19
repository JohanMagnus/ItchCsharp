using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogg2
{
    public class App
    {
        DataAccess dataaccess = new DataAccess();

        internal void Run()
        {
            PageMainMenu();
        }

        private void PageMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Välkommmen till huvudmenyn");

            ShowAllBlogPosts();

            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("a) Gå till huvudmenyn");
            Console.WriteLine("b) Uppdatera en bloggpost");

            var command = Console.ReadLine().ToUpper().Trim();

            switch (command)
            {
                case "A":
                    PageMainMenu();
                    break;

                case "B":
                    UpdateBlogPost();
                    break;


            }




        }

        private void UpdateBlogPost()
        {
            Console.Clear();

            ShowAllBlogPosts();
            Console.WriteLine("Vilken bloggpost vill du uppdatera?");
            int postId = int.Parse(Console.ReadLine());

            

            BlogPost bp = dataaccess.GetBlogPostById(postId);

            Console.WriteLine("Skriv in ny titel");
            string newTitle = Console.ReadLine();
            bp.Title = newTitle;

            dataaccess.UpdateBlogPost(bp);

            Console.WriteLine("Bloggposten uppdaterad. Tryck på valfri knapp för att kommma till huvudmenyn");
            Console.ReadKey();
            PageMainMenu();
        }

        private void ShowAllBlogPosts()
        {
            List<BlogPost> allPosts = dataaccess.GetAllBlogPosts();

            foreach (BlogPost item in allPosts)
            {
                Console.WriteLine(item.Id.ToString().PadRight(20) + item.Title.PadRight(40) + item.Author.PadRight(10));
            }
        }
    }
}
