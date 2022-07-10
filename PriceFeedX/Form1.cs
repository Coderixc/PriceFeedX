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

namespace PriceFeedX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Read NSE Symbol List OF TOP 200 ";
                //ofd.Filter = "Text Files (*.csv) | *.csv | All Files(*.*) | *.*"; //Here you can filter which all files you wanted allow to open
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    //StreamReader sr = new StreamReader(ofd.FileName);
                    string path  = ofd.FileName.ToString();

                    textBox1_Load_BhavCopy_NSE.Text = path;
                    
                }
            }
            catch (Exception ex)
            {
                textBox1_Load_BhavCopy_NSE.Text = "Failed to Load NSE TOP 200 list";
            }
        }
    }
}
