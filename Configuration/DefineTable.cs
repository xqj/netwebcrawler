using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler.Configuration
{
    public static class DefineTable
    {
        public const string urlPatten = @"([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
        public const string aUrlPatten = @"href\s*=\s*(?:[\'\""\s](?<1>[^\""\']*)[\'\""])";
        public const string scriptPatten = @"<script[^>]*?>.*?<\/script>";
        public const string stylePatten = @"<style[^>]*?>.*?</style>";
        public const string htmlLabelPatten = @"<(.[^>]*)>";
        public const string rnPatten = @"([\r\n])[\s]+";
        public const string rightNotePatten = @"-->";
        public const string leftNotePatten = @"<!--.*";
        public const string quotPatten = @"&(quot|#34);";
        public const string ampPatten = @"&(amp|#38);";
        public const string ltPatten = @"&(lt|#60);";
        public const string gtPatten = @"&(gt|#62);";
        public const string nbspPatten = @"&(nbsp|#160);";
        public const string iexclPatten = @"&(iexcl|#161);";
        public const string centPatten = @"&(cent|#162);";
        public const string poundPatten = @"&(pound|#163);";
        public const string copyPatten = @"&(copy|#169);";
        public const string lablePatten = @"&#(\d+);";
        public const string imgPatten = @"<img[^>]*>;";
    }
}
