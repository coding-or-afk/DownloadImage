using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace sdwByteToImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Image ByteArrayToImage(byte[] bytes)
        {
            MemoryStream ms = new MemoryStream(bytes);
            Image recImg = Image.FromStream(ms);
            return recImg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"c:\temp\test.jpg") == false)
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(new Uri("http://cfile222.uf.daum.net/image/9971FC445D6A8A3C30CE75"), @"c:\temp\test.jpg");
                    // OR 
                    //client.DownloadFileAsync(new Uri("http://cfile222.uf.daum.net/image/9971FC445D6A8A3C30CE75"), @"c:\temp\image35.png");
                    MessageBox.Show("Download Complete");
                }
            }
            else
            {
                MessageBox.Show("Already Exists!");
            }
        }
    }
}
