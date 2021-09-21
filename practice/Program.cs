using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            string fruit = Console.ReadLine();
            Console.WriteLine("这么巧啊，我也喜欢{0}", fruit);
            Console.ReadKey(true);
        }
    }
}
