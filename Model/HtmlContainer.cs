using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler.Model
{
    public class HtmlContainer
    {
        private List<string> _HtmlContainer = new List<string>();
        private static HtmlContainer _Instance = new HtmlContainer();
        public static HtmlContainer Instance
        {
            get { return _Instance; }
        }
        public List<String> HtmlCollections
        {
            get
            {
                return _HtmlContainer;
            }           
        }
        public string Get()
        {
            if(_HtmlContainer.Count>0)
                return _HtmlContainer[0];
            else
                return null;
        }
        public void Add(string newText)
        {
            _HtmlContainer.Add(newText);
        }
    }
}
