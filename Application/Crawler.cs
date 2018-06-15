using System.Net;
using System.IO;
using System.Collections.Generic;
using System;
using System.Text;

namespace Application
{
    public class Crawler
    {
        #region standard stuff

        private int currentFileIndex;
        private int noOfErrors;
        public int CurrentFileIndex { get { return currentFileIndex; } }
        public int NoOfErrors { get { return noOfErrors; } }
        public string Seed { get; set; }
        public int MaxNbrOfLinks { get; set; }
        public NetworkCredential Credentials { get; set; }
        public string FilesPrefix { get; set; }
        public Crawler(string seed, int maxNbrOfLinks)
        {
            Seed = seed;
            MaxNbrOfLinks = maxNbrOfLinks;
            Credentials = null;
            FilesPrefix = "file_";
        }

        #endregion

        public void Crawl()
        {
            currentFileIndex = 0;
            noOfErrors = 0;
            using (WebClient wc = new WebClient())
            {
                SetProxy(wc);

                HashSet<string> visited = new HashSet<string>();
                Queue<string> queue = new Queue<string>();

                int counter = 0;
                string url = Seed;
                visited.Add("");
                visited.Add(url);
                queue.Enqueue(url);
                counter++;

                while (queue.Count > 0)
                {
                    url = queue.Dequeue();

                    string page = Download(wc, url);

                    foreach (LinkItem link in LinkFinder.Find(page))
                    {
                        string newUrl = GetNewUrl(url, link.Href);

                        if (counter >= MaxNbrOfLinks) break;
                        if (visited.Contains(newUrl)) continue;

                        visited.Add(newUrl);
                        queue.Enqueue(newUrl);
                        counter++;
                    }
                }
            }
        }

        #region helper methods

        private string GetNewUrl(string url, string link)
        {
            string newUrl = "";
            foreach (string pattern in Config.absoluteLinkPatterns)
            {
                if (link.StartsWith(pattern))
                {
                    newUrl = link;
                    if (link == "//") newUrl = "http:" + newUrl;
                    break;
                }
            }

            if (newUrl == "" && !link.StartsWith("#"))
            {
                newUrl = "http://" + new Uri(url).Host;
                if (!link.StartsWith("/")) newUrl += "/";
                newUrl += link;
            }

            return newUrl;
        }

        private string Download(WebClient wc, string url)
        {
            OnDownload(new DownloadingEventArgs(url));

            string page = "";
            try
            {
                //page = wc.DownloadString(url);

                byte[] data = wc.DownloadData(url);
                string contentType = wc.ResponseHeaders[HttpResponseHeader.ContentType];

                // some links may be for downloading (e.g. PDF files)
                if (!contentType.StartsWith("text/html")) throw new Exception();
                
                page = Encoding.UTF8.GetString(data);
                string filePath = string.Format("{0}/{1}{2}.html", Config.filesDirectory, FilesPrefix, currentFileIndex);
                File.WriteAllText(filePath, page);
            }
            catch (Exception)
            {
                noOfErrors++;
            }

            currentFileIndex++;
            return page;
        }

        private void SetProxy(WebClient wc)
        {
            if (Credentials != null)
            {
                wc.Proxy = new WebProxy(Config.proxyIp, Config.proxyPort);
                wc.Proxy.Credentials = Credentials;
            }
            else
            {
                WebRequest.DefaultWebProxy = null;
            }
        }

        #endregion

        public void RunTest()
        {
            using (WebClient wc = new WebClient())
            {
                if (Credentials != null)
                {
                    wc.Proxy = new WebProxy(Config.proxyIp, Config.proxyPort);
                    wc.Proxy.Credentials = Credentials;
                }
                else
                {
                    WebRequest.DefaultWebProxy = null;
                }

                string page = wc.DownloadString(Seed);
                string file = Config.filesDirectory + "/test.html";
                File.WriteAllText(file, page);

                foreach (LinkItem i in LinkFinder.Find(page))
                {
                    string s = i.ToString();
                }
            }
        }

        #region DownloadingEvent stuff

        public delegate void DownloadingEventHandler(object sender, DownloadingEventArgs e);
        public event DownloadingEventHandler DownloadingEvent;
        protected void OnDownload(DownloadingEventArgs e)
        {
            if (DownloadingEvent != null)
                DownloadingEvent(this, e);
        }
        public class DownloadingEventArgs : EventArgs
        {
            public DownloadingEventArgs(string url)
            {
                Url = url;
            }
            public string Url { get; }
        }

        #endregion
    }

}
