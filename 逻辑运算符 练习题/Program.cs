using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 逻辑运算符_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的语文成绩");
            //string strChinese = Console.ReadLine();//这条代码负责接收用户的输入
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入你的输数学成绩");
            int math = Convert.ToInt32(Console.ReadLine());
            bool c = chinese > 90 && math > 90;
            if (c)
            {
                Console.WriteLine("语文和数学成绩都大于90");
            }
            else
            {
                Console.WriteLine("语文和数学成绩至少有一门不大于90");
            }
            Console.ReadKey(true);

            bool d = chinese > 90 || math > 90;
            if (d)
            {
                Console.WriteLine("语文和数学成绩至少有一门大于90");
            }
            else
            {
                Console.WriteLine("语文和数学成绩都不大于90");
            }
            //Console.WriteLine(d);
            Console.ReadKey(true);



        }
    }
}
