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
using PriceFeedX.LoadSymbolFromFiles;

namespace PriceFeedX
{
    public partial class Form1 : Form
    {
        #region Declare Variable
        private ReadFileFromNSE_EQUITY readFileFromNSE_EQUITY;

        #endregion

        #region Ctr
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Load NSE TOP XX files
        private void TaskProcess1(string path)
        {
            this.readFileFromNSE_EQUITY =new ReadFileFromNSE_EQUITY(path);
            if(!this.readFileFromNSE_EQUITY.STARTPROCESS())
            {
                MessageBox.Show("Failed To load  file from csv");
            }


        }
        #endregion



        #region Load NSE BHAV COPY FOR EQ
        private void TaskProcess2(string path)
        {
            this.readFileFromNSE_EQUITY = new ReadFileFromNSE_EQUITY(path,"0",true);
            if (!this.readFileFromNSE_EQUITY.STARTPROCESS())
            {
                MessageBox.Show("Failed To load  file from csv");
            }


        }
        #endregion



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

                    textBox1_Nse_TOP_XX_LIST.Text = path;

                    if(textBox1_Nse_TOP_XX_LIST.Text !=null)
                    {
                        this.TaskProcess1(path);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                textBox1_Nse_TOP_XX_LIST.Text = "Failed to Load NSE TOP 200 list";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Read NSE Bhav Copy EQ ";
                //ofd.Filter = "Text Files (*.csv) | *.csv | All Files(*.*) | *.*"; //Here you can filter which all files you wanted allow to open
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    //StreamReader sr = new StreamReader(ofd.FileName);
                    string path = ofd.FileName.ToString();

                    textBox1_BHAVCOPY_EQ.Text = path;

                    if (textBox1_Nse_TOP_XX_LIST.Text != null)
                    {
                        this.TaskProcess1(path);
                    }

                }
            }
            catch (Exception ex)
            {
                textBox1_Nse_TOP_XX_LIST.Text = "Failed to Load Bhav copy";
            }

        }




        //Create Txt files, to record last update

    }
}
