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
       private Crawler _Instance = new Crawler();
       private Timer _timer;
       private Crawler()
       {
           _timer = new Timer(DefineTable.timerInterval);         
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
    }
}
