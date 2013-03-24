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
        private AnalyzeImp _Instance = new AnalyzeImp();
        public AnalyzeImp Instance
        {
            get { return _Instance; }
        }
        public void GetUrls()
        {
            string pattern = DefineTable.aUrlPatten;
            string urlpatten = DefineTable.urlPatten;
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            string input=HtmlContainer.Instance.Get();
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
            var temp = HtmlContainer.Instance.Get();
            TextContainer.Instance.Add(NoHTML(temp));
        }
        private string NoHTML(string htmlstring)  //替换HTML标记
        {
            htmlstring = Regex.Replace(htmlstring, DefineTable.scriptPatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.htmlLabelPatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.rnPatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.rightNotePatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.leftNotePatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.quotPatten, "\"", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.ampPatten, "&", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.ltPatten, "<", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.gtPatten, ">", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.nbspPatten, " ", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.iexclPatten, "\xa1", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.centPatten, "\xa2", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.poundPatten, "\xa3", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.copyPatten, "\xa9", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.lablePatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.imgPatten, "", RegexOptions.IgnoreCase);
            htmlstring = htmlstring.Replace("<", "");
            htmlstring = htmlstring.Replace(">", "");
            htmlstring = htmlstring.Replace("\r\n", "");
            return htmlstring;
        }
    }
}
