using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using WebCrawler.Configuration;
using WebCrawler.CrawlerServiceInterface;
using WebCrawler.Model;

namespace WebCrawler.Analyze
{
    public class AnalyzeImp : Analyze, AnalyzeInterface
    {
        private static AnalyzeImp _Instance = new AnalyzeImp();
        public static AnalyzeInterface Instance
        {
            get { return _Instance; }
        }
        public void GetUrls()
        {
            string pattern = DefineTable.aUrlPatten;
            string urlpatten = DefineTable.urlPatten;
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            string input=HtmlContainer.Instance.GetForUrl();
            if (string.IsNullOrEmpty(input))
                return;
            MatchCollection matches = rgx.Matches(input);
            foreach (Match match in matches)
            {
                var temp = match.Value.Replace("<a", "").Replace("href=\"", "").Replace("\"", "");
                if (Regex.IsMatch(temp, urlpatten))
                    UrlContainer.Instance.Add(temp);
            }
        }

        public void GetText()
        {
            var temp = HtmlContainer.Instance.GetForContent();
            TextContainer.Instance.Add(HtmlAnalyze.GetCoreText(temp));
        }
       
    }
}
