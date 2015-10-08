using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using m2i.DotNEt;

namespace m2i.DotNEt
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();
            Author author = new Author ();
            Publisher p = new Publisher();

            author.FirstName = "test";
            author.LastName = "test";
            book1.addAuthor(author);
            book1.Title = "Book ";
            book1.Category = BookCategory.Computer;

            p.Name="toto";
            p.Id = 12;
            book1.addPublisher(p);



            // book1.DateSortie = 12;
           Console.WriteLine(book1.Category);
           Console.ReadKey();
            //book2.addAuthor(author);
            //book2.Title = "Book ";
            //if (book1.Author.LastName == book2.Author.LastName)
            //  Console.WriteLine("OK !");
            //else
            //  Console.WriteLine("Deux objets sont forcement differents");

        

        }
    }


}
