using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_CW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            pictureBox1.Image = imageList1.Images[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            hScrollBar1.Maximum = imageList1.Images.Count - 1;
            hScrollBar1.LargeChange = 1;
            hScrollBar1.SmallChange = 1;

            LinkLabel.Link  link = new LinkLabel.Link();
            link.LinkData = "https://www.google.com";
            linkLabel1.Links.Add(link);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            //progressBar1.Increment(10);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Minimum;
            }
            else
            {
                //if merquee так не можна
                //progressBar1.PerformStep();

                progressBar1.Value += 7;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int i = hScrollBar1.Value;
            pictureBox1.Image = imageList1.Images[i];
            toolStripProgressBar1.Value = i+1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Links[0].LinkData as string);
        }
    }
}
