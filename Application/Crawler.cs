using System.Net;
using System.IO;
using System.Collections.Generic;

namespace Application
{
    class Crawler
    {
        public string Seed { get; set; }
        public int MaxNbrOfLinks { get; set; }
        public Crawler(string seed, int maxNbrOfLinks)
        {
            Seed = seed;
            MaxNbrOfLinks = maxNbrOfLinks;
        }

        public void Crawl()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Proxy = new WebProxy(Config.proxyIp, Config.proxyPort);
                wc.Proxy.Credentials = new NetworkCredential()
                {
                    UserName = Config.proxyUserName,
                    Password = Config.proxyPassword,
                };

                string page = wc.DownloadString(Seed);
                string file = Config.filesDirectory + "/f.txt";
                //File.Create(file);
                File.WriteAllText(file, page);
            }

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
    }
}
