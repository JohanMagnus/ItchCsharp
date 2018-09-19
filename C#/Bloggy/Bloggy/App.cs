using Bloggy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloggy
{
    public class App
    {
        DataAccess dataaccess = new DataAccess();

        public void Run()
        {
            PageMainMenu();
        }

        private void PageMainMenu()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Välkommen till huvudmenyn");
            Console.ResetColor();
            ShowAllBlogPosts();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Vad vill du göra?");
            Console.ResetColor();
            Console.WriteLine("a) Gå till huvudmenyn");
            Console.WriteLine("b) Uppdatera en bloggpost");
            Console.WriteLine("c) Se kommentarer");
            
            

            var command = Console.ReadKey().Key;

            switch (command)
            {
                case ConsoleKey.A: PageMainMenu(); break;
                case ConsoleKey.B: PageUpdatePost(); break;
                case ConsoleKey.C: SeeComments(); break;

            }

        }

        private void SeeComments()
        {
            Console.Clear();

            ShowAllBlogPosts();
            Console.Write("Från vilket inlägg vill du se kommentarer?");
            int postId = int.Parse(Console.ReadLine());

            List<Comment> comments = dataaccess.GetComments(postId);

            foreach (Comment comment in comments)
            {
                Console.WriteLine(comment.Text);
            }
            

        }

        private void PageUpdatePost()
        {
            Console.Clear();

            ShowAllBlogPosts();
            Console.Write("Vilken bloggpost vill du uppdatera?");
            int postId = int.Parse(Console.ReadLine());

            BlogPost post = dataaccess.GetBlogPostById(postId);

            Console.WriteLine("Skriv in ny titel: ");

            string newTitle = Console.ReadLine();
            post.Title = newTitle;

            dataaccess.UpdateBlogPost(post);

            Console.WriteLine("Bloggposten uppdaterad. Tryck på valfri knapp för att komma till huvudmenyn");
            Console.ReadKey();
            PageMainMenu();
        }

        private void ShowAllBlogPosts()
        {

            List<BlogPost> allPosts = dataaccess.GetAllBlogPost();

            foreach (BlogPost bp in allPosts)
            {
                Console.WriteLine(bp.Id.ToString().PadRight(10) + bp.Title.PadRight(30) + bp.Author.PadRight(30));
            }
        }
    }
}
