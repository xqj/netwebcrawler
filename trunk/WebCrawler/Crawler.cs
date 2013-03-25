using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using WebCrawler.Configuration;

namespace WebCrawler
{
    public class Crawler
    {
        private static Crawler _Instance = new Crawler();
        private Timer _timer;
        public static Crawler Instance
        {
            get { return _Instance; }
        }
        private Crawler()
        {
            _timer = new Timer(DefineTable.timerInterval);
            OnTimedEvent = Run;
            _timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);            
        }
        public void SetInterval(double interval)
        {
            _timer.Interval = interval;
        }
        public void Start()
        {
            _timer.Start();
        }
        public void Stop()
        {
            _timer.Stop();
        }
        private void Run(object sender, ElapsedEventArgs e)
        {
            //Console.WriteLine("Hello World!");
        }

        public ElapsedEventHandler OnTimedEvent { get; set; }
    }
}
