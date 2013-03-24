using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler.Model
{
    public class UrlContainer
    {
        private List<String> _UrlConllections = new List<string>();
        public List<String> UrlConllections
        {
            get
            {
                return _UrlConllections;
            }
         
        }
        public string Get()
        {
            if (_UrlConllections.Count > 0)
                return _UrlConllections[0];
            else
                return null;
        }
        public void Add(string newText)
        {
            _UrlConllections.Add(newText);
        }
    }
}
