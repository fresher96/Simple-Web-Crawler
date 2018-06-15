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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Directory.Delete(Config.filesDirectory, true);
        }

        private void btnCrawl_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Config.filesDirectory))
            {
                Directory.CreateDirectory(Config.filesDirectory);
            }


            Crawler crawler = new Crawler(txtSeed.Text, int.Parse(txtNbr.Text));

            // comment this if you don't want to use the proxy
            crawler.Credentials = new System.Net.NetworkCredential
            {
                UserName = txtUserName.Text,
                Password = txtPassword.Text,
            };


            try
            {
                crawler.Crawl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Finished crawling", "Notification");
        }
    }
}
