using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习题_46天是几周零几天
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实习计算给定天数是几周零几天。
            //Console.WriteLine("请输入要计算的天数");
            //Console.ReadKey(true);
            //string days = Console.ReadLine();
            //int n1 = Convert.ToInt32(days);
            //int weeks = n1 / 7;
            //int day = n1 % 7;
            //Console.WriteLine("{0}天是{1}周零{2}天", n1, weeks, day);
            //Console.ReadKey(true);
            //编程实现给定秒数是几天零多少小时零多少分钟多少秒
            Console.WriteLine("输入秒数");
            Console.ReadKey(true);
            string seconds = Console.ReadLine();
            int secs = Convert.ToInt32(seconds);
            int days = secs / 3600 / 24;
            secs = secs % (3600 * 24);
            int hours = secs / 3600;
            secs = secs % 3600;
            int minutes = secs / 60;
            secs = secs % 60;
            Console.WriteLine("{0}秒是{1}天零{2}小时零{3}分钟零{4}秒", seconds, days, hours, minutes, secs);
            Console.ReadKey(true);

        }
    }
}
