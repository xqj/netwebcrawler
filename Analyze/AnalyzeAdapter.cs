using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebCrawler.Model;

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
            while (!HtmlContainer.Instance.IsEmpty)
            {
                AnalyzeImp.Instance.GetText();
            }
        }

        public void ProcessingUrls()
        {
            while (!HtmlContainer.Instance.IsEmpty)
            {
                AnalyzeImp.Instance.GetUrls();
            }
        }
    }
}
