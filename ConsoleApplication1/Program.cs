using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 test = new Class2();

            test.Xxx = 3;

            Console.WriteLine(test.Xxx);
            Console.ReadKey();
        }
    }


}
