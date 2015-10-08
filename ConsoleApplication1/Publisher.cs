using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Publisher
    {

        private int id;
        private String name;

        public int Id
        {
            get; set;
        }

        public String Name
        {
            get; set;
        }

        public String toString()
        {
            return "valeur de x: " + Id + "valeur de y:" + Name;
        }

    }
}

