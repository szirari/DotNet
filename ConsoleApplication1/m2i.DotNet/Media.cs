using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2i.DotNEt
{
    public abstract class Media : Item

    {
         public  MediaCategory Category {get; set;}


        public abstract double VATPrice { get; }
    }

}

