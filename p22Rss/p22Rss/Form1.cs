using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace p22Rss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void rssreader()
        {
            string okuyucu;
            okuyucu = txtLink.Text;
            listBox1.Items.Clear();
            XmlTextReader reader = new XmlTextReader(okuyucu);
            while (reader.Read())
            {
                if (reader.Name == "title")
                {
                    listBox1.Items.Add(reader.ReadString());
                }
            }
        }
        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();    
            XmlTextReader reader = new XmlTextReader("https://www.cnnturk.com/feed/rss/news");
            while (reader.Read())
            {
                if (reader.Name == "title")
                {
                    listBox1.Items.Add(reader.ReadString());
                }
            }
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
       
            listBox1.Items.Clear();
            XmlTextReader reader1 = new XmlTextReader("https://www.milliyet.com.tr/rss/rssnew/dunyarss.xml");
            while (reader1.Read())
            {
                if (reader1.Name == "title")
                {
                    listBox1.Items.Add(reader1.ReadString());
                }
            }
        }

        private void btnSabah_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader reader2 = new XmlTextReader("https://feeds.bbci.co.uk/turkce/rss.xml");
            while (reader2.Read())
            {
                if (reader2.Name == "title")
                {
                    listBox1.Items.Add(reader2.ReadString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rssreader();
        }

        private void btnCnn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader reader2 = new XmlTextReader("http://rss.cnn.com/rss/edition.rss");
            while (reader2.Read())
            {
                if (reader2.Name == "title")
                {
                    listBox1.Items.Add(reader2.ReadString());
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            listBox1.Items.Clear();
            XmlTextReader reader2 = new XmlTextReader("https://www.milliyet.com.tr/rss/rssnew/dunyarss.xml");
            while (reader2.Read())
            {
                if (reader2.Name == "title")
                {
                    listBox1.Items.Add(reader2.ReadString());
                }
            }
        }

        private void btnNTV_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader reader2 = new XmlTextReader("https://www.ntv.com.tr/gundem.rss");
            while (reader2.Read())
            {
                if (reader2.Name == "title")
                {
                    listBox1.Items.Add(reader2.ReadString());
                }
            }
        }

        private void btnFox_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader reader2 = new XmlTextReader("https://moxie.foxnews.com/google-publisher/world.xml");
            while (reader2.Read())
            {
                if (reader2.Name == "title")
                {
                    listBox1.Items.Add(reader2.ReadString());
                }
            }
        }
    }
}
