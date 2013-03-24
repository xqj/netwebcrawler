using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler.Analyze
{
    public class AnalyzeAdapter
    {
        private AnalyzeAdapter _Instance = new AnalyzeAdapter();
        public AnalyzeAdapter Instance
        {
            get { return _Instance; }
        }
    }
}
