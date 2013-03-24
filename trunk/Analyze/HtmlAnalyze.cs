using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using WebCrawler.Configuration;

namespace WebCrawler.Analyze
{
    public class HtmlAnalyze
    {
        /// <summary>
        /// 替换HTML标记，代码中对符号的处理必须按照此顺序才能最终取得无html标签的全内容文本
        /// </summary>
        /// <param name="htmlstring"></param>
        /// <returns></returns>
        public static string NoHTML(string htmlstring)
        {
            htmlstring = Regex.Replace(htmlstring, DefineTable.rnPatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.stylePatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.scriptPatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.htmlLabelPatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.leftNotePatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.rightNotePatten, "", RegexOptions.IgnoreCase);
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
            htmlstring = htmlstring.Replace("<", "");
            htmlstring = htmlstring.Replace(">", "");
            return htmlstring;
        }
        /// <summary>
        /// 获取核心文本
        /// </summary>
        /// <param name="htmlstring"></param>
        /// <returns></returns>
        public static string GetCoreText(string htmlstring)
        {
            htmlstring = Regex.Replace(htmlstring, DefineTable.rnPatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.stylePatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.scriptPatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.aLablePatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.liLablePatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.hLablePatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.htmlLabelPatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.leftNotePatten, "", RegexOptions.IgnoreCase);
            htmlstring = Regex.Replace(htmlstring, DefineTable.rightNotePatten, "", RegexOptions.IgnoreCase);
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
            htmlstring = htmlstring.Replace("<", "");
            htmlstring = htmlstring.Replace(">", "");
            return htmlstring;
        }
    }
}
