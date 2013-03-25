using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using WebCrawler;
using WebCrawler.Model;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Crawler.Instance.OnTimedEvent = RunTest;
            Crawler.Instance.IndexUrl = "http://www.cnblogs.com/";
            Crawler.Instance.Interval=10000.0;
            //Crawler.Instance.Start();
            Crawler.Instance.Run();           
            Console.ReadLine();
        }
        public static void RunTest(object sender, ElapsedEventArgs e)
        {
            TextContainer.Instance.TextCollections.ForEach(a =>
            {
                Console.WriteLine(a);
            });
        }
    }
}
