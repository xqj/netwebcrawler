using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using WebCrawler.CrawlerServiceInterface;
using WebCrawler.Model;

namespace WebCrawler.Detector
{
    public class DetectorImp : Detector, DetectorInterface
    {
        private DetectorImp _Instance = new DetectorImp();
        public DetectorImp Instance
        {
            get { return _Instance; }
        }

        public void Scan(string url)
        {
            ScanContent(url);            
        }
        private void ScanContent(string url)
        {
            WebRequest request = WebRequest.Create(url);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response1 = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response1.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response1.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            //get document stream from url
            HtmlContainer.Instance.Add(responseFromServer);
        }
    }
}
