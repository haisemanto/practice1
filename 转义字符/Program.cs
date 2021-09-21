using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 转义字符
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = '\b';//\在这里起到了一个转义的作用 使char定义单个字符作用也能成功
            //char cc = 'bb'
            string path = @"F:\软件\音乐\古风\青花瓷.MP3";//@在此处可取消转义字符的转义作用。
                                                 //Console.WriteLine("{0}", path);
                                                 //Console.ReadKey();

            Console.WriteLine(@"天青色等烟雨
而我在等你");                               //@在此处可保留原格式输出
            Console.ReadKey();
        }
    }
}
