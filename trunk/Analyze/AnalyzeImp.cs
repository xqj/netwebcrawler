using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebCrawler.CrawlerServiceInterface;

namespace WebCrawler.Analyze
{
    public class AnalyzeImp : Analyze, AnalyzeInterface
    {
        private AnalyzeImp _Instance = new AnalyzeImp();
        public AnalyzeImp Instance
        {
            get { return _Instance; }
        }
        public void GetUrls()
        {
            throw new NotImplementedException();
        }

        public void GetText()
        {
            throw new NotImplementedException();
        }
    }
}
