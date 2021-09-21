using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入数字，并输出这个数字的两倍");
            //string strnum = Console.ReadLine();//这条代码负责接收用户的输入
            int num = Convert.ToInt32(Console.ReadLine());//直接将用户的输入放进去转换为int
            Console.WriteLine(num * 2);
            Console.ReadKey();

        }
    }
}
