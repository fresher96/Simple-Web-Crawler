using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Application
{
    public partial class Form1 : Form
    {
        private int fileCounter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSeed.Text = Config.seed;
            txtNbr.Text = Config.maxNbrOfLinks.ToString();
            txtUserName.Text = Config.proxyUserName;
            txtPassword.Text = Config.proxyPassword;
            txtPrefix.Text = Config.filesPrefix;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Directory.Delete(Config.filesDirectory, true);
            txtLog.Clear();
        }

        private void btnCrawl_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Config.filesDirectory))
            {
                Directory.CreateDirectory(Config.filesDirectory);
            }

            Crawler crawler = new Crawler(txtSeed.Text, int.Parse(txtNbr.Text));
            crawler.FilesPrefix = txtPrefix.Text;
            if(!chkProxy.Checked)
            {
                crawler.Credentials = new System.Net.NetworkCredential
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                };
            }

            fileCounter = 0;
            crawler.DownloadingEvent += new Crawler.DownloadingEventHandler(crawler_Downloading);
            crawler.Crawl();
            crawler.Crawl();

            string msg = "Finished crawling\r\n";
            msg += string.Format("couldn't download {0} pages\r\n", crawler.NoOfErrors);
            msg += string.Format("from a total of {0} pages", crawler.CurrentFileIndex);
            MessageBox.Show(msg, "Notification");
        }

        private void crawler_Downloading(object sender, Crawler.DownloadingEventArgs e)
        {
            txtLog.AppendText(string.Format("\r\nDownloading {2}{1}:\r\n{0}\r\n", e.Url, fileCounter++, txtPrefix.Text));
        }

        private void chkProxy_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = !txtUserName.Enabled;
            txtPassword.Enabled = !txtPassword.Enabled;
        }
    }
}
