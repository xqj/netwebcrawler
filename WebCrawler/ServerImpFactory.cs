using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebCrawler.CrawlerServiceInterface;
using WebCrawler.Model;

namespace WebCrawler
{
   public class ServerImpFactory
    {


       internal static DetectorInterface GetDetectorInterface()
        {
            return Detector.DetectorImp.Instance;
        }
    }
}
