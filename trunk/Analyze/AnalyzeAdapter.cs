using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler.Analyze
{
    public class AnalyzeAdapter
    {
        private static AnalyzeAdapter _Instance = new AnalyzeAdapter();
        public static AnalyzeAdapter Instance
        {
            get { return _Instance; }
        }

        public void ProcessingContent()
        {
            AnalyzeImp
        }

        public void ProcessingUrls()
        {
            throw new NotImplementedException();
        }
    }
}
