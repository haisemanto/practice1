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
        {
            Console.WriteLine("10除以3取余与取模的结果,按回车键展示");
            Console.ReadKey(true);
            int n1 = 10;
            int n2 = 3;
            int result1 = n1 % n2;
            int result2 = n1 / n2;
            Console.WriteLine("取余的结果是{0}，取模的结果是{1}", result1, result2);
            Console.ReadKey(true);
            Console.WriteLine("请输入圆的半径");
            string str1 = Console.ReadLine();//获取用户输入
            int r = Convert.ToInt32(str1);
            double pi = 3.14;
            Console.WriteLine("周长等于{0}，面积等于{1}", 2 * pi * r, pi * r * r);
            Console.ReadKey(true);


            //计算三件Tshirt 给定价格 2条裤子 给定价格的总价格 以及打8.8折后的实际价格。

            //Console.WriteLine("请输入裤子的价格 以任意键结束");
            //Console.ReadKey(true);
            //string pants = Console.ReadLine();
            //int n1 = Convert.ToInt32(pants);
            //Console.WriteLine("请输入Tshirt的价格 以任意键结束");
            //Console.ReadKey(true);
            //string tshirts = Console.ReadLine();
            //int n2 = Convert.ToInt32(tshirts);
            //Console.WriteLine("三件衣服两条裤子的价格是{0}", 3 * n2 + 2 * n1);
            //Console.ReadKey(true);
            //double realmoney = (3 * n2 + 2 * n1) * 0.88;
            //Console.WriteLine("打8.8折后的价格是{0}", realmoney);
            //Console.ReadKey(true);


            //类型转换
            //double d = 303.6;
            //int n = (int)d;
            //Console.WriteLine(n);
            //Console.ReadKey(true);

            //int n1 = 10;
            //double n1 = 10;
            //int n2 = 3;
            //double d = n1 / n2;
            ////double c = n1 * 1.0 / n2;
            //Console.WriteLine("{0:0.00}",d);//占位符后面0.00表示小数点后留两位
            ////Console.WriteLine(c);
            //Console.ReadKey(true);

        }
    }
}
