using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler.CrawlerServiceInterface
{
    public interface DetectorInterface
    {
        /// <param name="url">visit url</param>
        void Scan(string url);
    }
}
