using System.Net;
using System.IO;
using System.Collections.Generic;
using System;

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
        }

        public void Crawl()
        {
            RunTest();

            HashSet<string> visited = new HashSet<string>();
            Queue<string> queue = new Queue<string>();

            int counter = 1;
            string url = Seed;
            visited.Add(url);
            queue.Enqueue(url);
            //while(counter < MaxNbrOfLinks && queue.Count > 0)
            {
                
            }
        }

        private void RunTest()
        {
            using (WebClient wc = new WebClient())
            {
                if(Credentials != null)
                {
                    wc.Proxy = new WebProxy(Config.proxyIp, Config.proxyPort);
                    wc.Proxy.Credentials = Credentials;
                }

                string page = wc.DownloadString(Seed);
                string file = Config.filesDirectory + "/f.html";
                File.WriteAllText(file, page);
            }
        }
    }
}
