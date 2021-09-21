using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("int number = 10 int result = 10 + ++number;");
            //int number = 10;
            //int result = 10 + ++number;//number先自加1再与10相加
            //Console.WriteLine(number);
            //Console.WriteLine(result);
            //Console.ReadKey(true);
            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;//5+7*2+6+6
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadKey(true);
        }
    }
}
