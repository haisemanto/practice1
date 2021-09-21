using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 加加减减_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2 = 5, var3 = 6;
            var1 = ++var2 * --var3;//前加用加了之后的参与乘的运算 后加用加之前的数参与运算
            Console.WriteLine(var1);
            Console.ReadKey(true);

        }
    }
}
