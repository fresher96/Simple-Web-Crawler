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
                if(Credentials == null)
                {
                    wc.Proxy = null;
                }
                else
                {
                    wc.Proxy = new WebProxy(Config.proxyIp, Config.proxyPort);
                    //wc.Proxy.Credentials = Credentials;
                    //wc.UseDefaultCredentials = false;
                    //wc.Proxy.Credentials = false;


                    //string credentials;
                    //credentials = string.Format("{0}:{1}", Credentials.UserName, Credentials.Password);
                    //credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials));
                    ////wc.Headers[HttpRequestHeader.ProxyAuthorization] = string.Format("Basic {0}", credentials);
                    //wc.Headers.Add("Proxy-Authorization", string.Format("Basic {0}", credentials));

                    //wc.Headers.Add("Cache-Control", "no-cache");
                    wc.Headers.Add("Proxy-Authorization", "Digest username=\"farouk.hjabo\", password=\"1234.qwer\"");
                }

                //var tmp = wc.Headers;

                string page = wc.DownloadString(Seed);
                string file = Config.filesDirectory + "/f.html";
                File.WriteAllText(file, page);

                //wc.Proxy.Credentials = null;

                
            }
        }
    }
}
