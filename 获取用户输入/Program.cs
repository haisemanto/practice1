using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算术运算符
{
    class Program
    {
        static void Main(string[] args)
        {//求给定半径圆的周长以及面积           
            Console.WriteLine("请输入圆的半径");
            string str1 = Console.ReadLine();//获取用户输入
            int r = Convert.ToInt32(str1);//Convert.ToInt32 将指定的值转换为 32 位有符号整数
            double pi = 3.14;
            Console.WriteLine("周长等于{0}，面积等于{1}", 2 * pi * r, pi * r * r);
            Console.ReadKey(true);

        }
    }
}
