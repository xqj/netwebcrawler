using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebCrawler.Model
{
    public class TextContainer
    {
        private List<string> _TextCollections = new List<string>();
        private TextContainer _Instance = new TextContainer();
        public TextContainer Instance
        {
            get { return _Instance; }
        }
        public List<String> TextCollections
        {
            get
            {
                return _TextCollections;
            }           
        }
        public string Get()
        {
            if(_TextCollections.Count>0)
                return _TextCollections[0];
            else
                return null;
        }
        public void Add(string newText)
        {
            _TextCollections.Add(newText);
        }
    }
}
