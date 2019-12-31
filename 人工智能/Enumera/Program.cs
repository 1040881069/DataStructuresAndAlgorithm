using System;
using System.Collections;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;

namespace Enumera
{
    public  class MainClass
    {
        public static void Main(string[] args)
        {
            var Kestring = "人工智能";
            TestReadingFile(Kestring);
            Console.WriteLine("叶公子高好龙，钩以写龙，凿以写龙，屋室雕文以写龙。于是天龙闻而下之，窥头于牖，施尾于堂。 叶公见之，弃而还走，失其魂魄，五色无主。是叶公非好龙也，好夫似龙而非龙者也。");
            TestStreamReaderEnumerable(Kestring);
            Console.ReadKey();

            Console.WriteLine("Hello World!");
            Console.Read();
        }

        private static void TestStreamReaderEnumerable(string kestring)
        {
            //throw new NotImplementedException();
        }

        private static void TestReadingFile(string kestring)
        {
            Console.WriteLine("数量");
            //throw new NotImplementedException();
        }

       
    }
}
