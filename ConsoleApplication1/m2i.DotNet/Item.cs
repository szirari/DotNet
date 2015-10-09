using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2i.DotNEt
{
    public abstract class Item : IItem
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public double Price { get; set; }
    }
}
