using System.Net;
using System.IO;
using System.Collections.Generic;
using System;
using System.Text;

namespace Application
{
    class Crawler
    {
        public string Seed { get; set; }
        public int MaxNbrOfLinks { get; set; }
        public NetworkCredential Credentials { get; set; }
        public Crawler(string seed, int maxNbrOfLinks)
        {
            Seed = seed;
            MaxNbrOfLinks = maxNbrOfLinks;
            Credentials = null;
            WebRequest.DefaultWebProxy = null;
        }

        public void Crawl()
        {
            using (WebClient wc = new WebClient())
            {
                if (Credentials != null)
                {
                    wc.Proxy = new WebProxy(Config.proxyIp, Config.proxyPort);
                    wc.Proxy.Credentials = Credentials;
                }

                HashSet<string> visited = new HashSet<string>();
                Queue<string> queue = new Queue<string>();

                int counter = 1;
                string url = Seed;
                visited.Add(url);
                queue.Enqueue(url);

                while (counter <= MaxNbrOfLinks && queue.Count > 0)
                {
                    url = queue.Dequeue();

                    string page = Download(wc, url, counter);
                    counter++;

                    foreach (LinkItem link in LinkFinder.Find(page))
                    {
                        string newUrl = GetNewUrl(url, link.Href);
                        if (visited.Contains(newUrl)) continue;

                        visited.Add(newUrl);
                        queue.Enqueue(newUrl);
                    }
                }
            }
        }

        private string Download(WebClient wc, string url, int counter)
        {
            string page = wc.DownloadString(url);
            string filePath = string.Format("{0}/{1}{2}.html", Config.filesDirectory, Config.filesPrefix, counter);
            File.WriteAllText(filePath, page);
            return page;
        }

        private string GetNewUrl(string url, string link)
        {
            string newUrl = null;
            foreach (string pattern in Config.absoluteLinkPatterns)
            {
                if (link.StartsWith(pattern))
                {
                    newUrl = link;
                    break;
                }
            }

            if(newUrl == null)
            {
                newUrl = url;
                if (!link.StartsWith("/")) newUrl += "/";
                newUrl += link;
            }

            return newUrl;
        }

        public void RunTest()
        {
            using (WebClient wc = new WebClient())
            {
                if (Credentials != null)
                {
                    wc.Proxy = new WebProxy(Config.proxyIp, Config.proxyPort);
                    wc.Proxy.Credentials = Credentials;
                }

                string page = wc.DownloadString(Seed);
                string file = Config.filesDirectory + "/f.html";
                File.WriteAllText(file, page);

                foreach (LinkItem i in LinkFinder.Find(page))
                {
                    string s = i.ToString();
                }
            }
        }
    }
}
