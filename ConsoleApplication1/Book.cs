using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Book
    {
        private String title;
        public Author[] Authors { get; set; } = new Author[10]; 
        private Publisher publisher;
        private int nbAuthor = 0;
        public BookCategory Category { get; set; }

        public int NbAuthor { get; set; }

        public string  Title { get; set; }

        public string Publisher { get; set; }

        public void addAuthor(Author a) { this.Authors[nbAuthor] = a; nbAuthor++; }
        public void addPublisher(Publisher p) { this.publisher = p; }

    }
}
