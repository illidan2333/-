using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    class Crawler
    {
        public event Action<Crawler, string> PageDownloaded;

        public Hashtable urls = new Hashtable();
        private int count = 0;
        static public string startUrl = "";
        static public string startWith = "";

        public void Crawl()
        {
            string str = @"(www\.){0,1}.*?\..*?/";
            Regex r = new Regex(str);
            Match m = r.Match(startUrl);
            startWith = m.Value;


            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 20) break;

                string html = DownLoad(current); 
                urls[current] = true;
                count++;
                PageDownloaded(this, current);
                Parse(html, current);

            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
         
                return "";
            }
        }

        private void Parse(string html, string oldUrl)
        {

            
            string strRef = @"(href|HREF)[ ]*=[ ]*[""'](http|https)[^""'#>]+..html.*?[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0)
                    continue;
            
                if (url.Contains(startWith))
                {
                    if (urls[url] == null)
                        urls[url] = false;
                }
            }

  

            strRef = @"(href|HREF)[ ]*=[ ]*[""'][^(http|https)][^""'#>]+..html.*?[""']";
            matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                var url = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');
                if (url.Length == 0) continue;
                Uri baseUri = new Uri(oldUrl);
                Uri absoluteUri = new Uri(baseUri,url);
                Console.WriteLine("相对:" + url);
                Console.WriteLine("绝对:" + absoluteUri.ToString());
                if (urls[absoluteUri.ToString()] == null)
                    urls[absoluteUri.ToString()] = false;
            }
        }
    }
}
