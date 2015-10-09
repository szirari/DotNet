using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2i.DotNEt
{
    public class Book : Media
    {
        public Author[] Authors { get; set; } = new Author[10]; 
        private int nbAuthor = 0;
        public BookCategory Category { get; set; }

        public int NbAuthor { get; set; }

        public string  Title { get; set; }

        public Publisher Publisher { get; set; }

        public void addAuthor(Author a) { this.Authors[nbAuthor] = a; nbAuthor++; }
        public void addPublisher(Publisher p) { this.publisher = p; }

        public override double VATPrice
        {
            get
            {
                return Price * 1.05;
            }
        }
    }
}
