using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using WebCrawler;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crawler.Instance.OnTimedEvent = RunTest;
            Crawler.Instance.IndexUrl = "http://www.baidu.com";
            Crawler.Instance.Start();
            Console.ReadLine();
        }
        public static void RunTest(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
