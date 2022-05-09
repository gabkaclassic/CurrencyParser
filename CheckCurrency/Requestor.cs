using System;
using System.IO;
using System.Net;

namespace CheckCurrency
{
    public class Requestor
    {
        public static string url
        {
            set
            {
                if (!String.IsNullOrEmpty(value))
                    url = value;
            }
            get => url;
        }

        public string GetRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using(Stream stream = response.GetResponseStream())
            using(StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        
        public string GetRequest(string url)
        {
            if (String.IsNullOrEmpty(url))
                throw new NullReferenceException("Given URL is null or empty");
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            {
                return reader.ReadToEnd();
            }
        }

    }
}