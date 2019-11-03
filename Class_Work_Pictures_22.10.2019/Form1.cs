using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Work_Pictures_22._10._2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdatePanel();
            //UpdateTrackBarScroll(sender);
        }

        void UpdatePanel()
        {
            //TrackBar tb = sender as TrackBar;
            splitContainer1.Panel2.BackColor = Color.FromArgb(trackBar1.Value,trackBar2.Value,trackBar3.Value);
            toolStripStatusLabel1.Text = $"RGB{trackBar1.Value}," +
                $" {trackBar2.Value}," +
                $" {trackBar3.Value}";
        }
        bool color1 = false;
        bool color2 = false;
        bool color3 = false;
        
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //trackBar1.BackColor = Color.Red;
            ToolStripMenuItem ts = sender as ToolStripMenuItem;
            switch (ts.Text)
            {
                case "Red":
                    trackBar1.BackColor = Color.FromName(ts.Text);
                    break;
                case "Green":
                    trackBar2.BackColor = Color.FromName(ts.Text);
                    break;
                case "Blue":
                    trackBar3.BackColor = Color.FromName(ts.Text);
                    break;
                default:
                    break;
            }
            if (ts.Text == "Red" && color1==false)
            {
                color1 = true;
                trackBar1.BackColor = Color.FromName(ts.Text);
            }
            else
            {
                trackBar1.BackColor = Color.White;
                color1 = false;
            }
            if (ts.Text == "Green" && color2==false)   
            {
                color2 = true;
                trackBar2.BackColor = Color.FromName(ts.Text);
            }
            else
            {
                trackBar2.BackColor = Color.White;
                color2 = false;
            }
            if (ts.Text == "Blue" && color3 == false)
            {
                color3 = true;
            }
            else
            {
                trackBar2.BackColor = Color.White;
            }
        }

        //private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    trackBar2.BackColor = Color.Green;
        //}

        //private void redToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    trackBar3.BackColor = Color.Blue;
        //}


    }
}
