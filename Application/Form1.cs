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
            fileCounter = 0;
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
            if(!chkProxy.Checked)
            {
                crawler.Credentials = new System.Net.NetworkCredential
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                };
            }

            crawler.DownloadingEvent += new Crawler.DownloadingEventHandler(crawler_Downloading);


            try
            {
                crawler.Crawl();
                MessageBox.Show("Finished crawling", "Notification");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        private void crawler_Downloading(object sender, DownloadingEventArgs e)
        {
            txtLog.Text += string.Format("\r\nDownloading {1}:\r\n{0}\r\n", e.Url, fileCounter++);
        }

        private void chkProxy_CheckedChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = !txtUserName.Enabled;
            txtPassword.Enabled = !txtPassword.Enabled;
        }
    }
}
