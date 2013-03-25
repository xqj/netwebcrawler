using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler.Model
{
    public class HtmlContainer
    {
       // private List<string> _HtmlContainer = new List<string>();
        private List<string> _HtmlContainerForContent = new List<string>();
        private List<string> _HtmlContainerForUrls = new List<string>();
        private static HtmlContainer _Instance = new HtmlContainer();
        public static HtmlContainer Instance
        {
            get { return _Instance; }
        }
        //public List<String> HtmlCollections
        //{
        //    get
        //    {
        //        return _HtmlContainer;
        //    }           
        //}
        public bool IsEmpty
        {
            get
            {
                return (_HtmlContainerForUrls.Count==0) && (_HtmlContainerForContent.Count==0);
            }
        }
        public bool IsFull
        {
            get
            {
                return (_HtmlContainerForUrls.Count>=1024) && (_HtmlContainerForContent.Count>=1024);
            }
        }
        public string GetForUrl()
        {
            if (_HtmlContainerForUrls.Count > 0)
            {
                string temp = _HtmlContainerForUrls[0];
                _HtmlContainerForUrls.RemoveAt(0);
                return temp;
            }
            else
                return null;
        }
        public string GetForContent()
        {
            if (_HtmlContainerForContent.Count > 0)
            {
                string temp = _HtmlContainerForContent[0];
                _HtmlContainerForContent.RemoveAt(0);
                return temp;
            }
            else
                return null;
        }
        public void Add(string newText)
        {
           // _HtmlContainer.Add(newText);
             _HtmlContainerForContent.Add(newText);
             _HtmlContainerForUrls.Add(newText);
        }
    }
}
