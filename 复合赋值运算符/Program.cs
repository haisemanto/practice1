using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复合赋值运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //复合赋值运算符 += -= *= /= %=
            int number = 10;
            //number += 20;//number=number+20
            //number -= 5;
            //number /= 5;//number=number/5
            //number %= 3;
            number *= 5;
            Console.WriteLine(number);
            Console.ReadKey(true);


        }
    }
}
