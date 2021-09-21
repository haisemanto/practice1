using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //逻辑运算符两边放的都是关系表达式或者bool类型的值
            //非!与&& 或|| 
            //bool a=5 > 3 && true;
            bool a = 3 > 5 || true;
            bool c = !a;//c为非a
            //int b = Convert.ToInt32(a);//将a转换为int型
            Console.WriteLine("a的bool型为{0}",a);
            Console.WriteLine("!a的bool型为{0}",c);
            Console.ReadKey();
        }
    }
}
