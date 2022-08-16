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
using CustomDataBase;
using System.Reflection;
using PriceFeedX.Import_Bhav_Copy_NSE.RequestApiToNseForBhavCopy;
using PriceFeedX.Import_Bhav_Copy_NSE.ShowImportStatusToConsole_UserControl;
using PriceFeedX.Extract_BhavCopy;
using PriceFeedX.FolderStats;

namespace PriceFeedX
{
    public partial class Form1 : Form
    {
        #region Declare Variable
        private ReadFileFromNSE_EQUITY readFileFromNSE_EQUITY;

        private List<string> List_Symbol;
        private List<string> List_BhavCopy_Prev5;

        private UnzippingFunc _UnzippingFunc;



        #endregion

        #region Ctr
        public Form1()
        {

            this.INIT();

            InitializeComponent();

            string List5days = string.Join(",  ", this.List_BhavCopy_Prev5.ToArray());

            this.textBox1_BhavCopyLast5Date.Text = List5days;

            //Initilize Unzipping Object
            this._UnzippingFunc  = new UnzippingFunc();
        }
        #endregion

        private void INIT()
        {
            try
            {
                //variable
                this.List_Symbol = new List<string>();
                this.List_BhavCopy_Prev5 = new List<string>();



                //function
                this.TaskProcess_001();
                this.TaskProcess_002(); 
            }
            catch (Exception ex)
            {
                string msg  = "INIT Process Failed with " + ex.Message;
                MessageBox.Show(msg);
            }
        }

        private void Refresh()
        {

            try
            {
                this.TaskProcess_002();
                string List5days = string.Join(",  ", this.List_BhavCopy_Prev5.ToArray());

                this.textBox1_BhavCopyLast5Date.Text = List5days;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            


        }
        private void TaskProcess_001()
        {
            DataBase _user_1 = null;
            try
            {
                _user_1 = new DataBase();
                _user_1.OpenConnection();
                DataTable dt = new DataTable();
                string query = " SELECT Symbol FROM " + Credential.mSchema + "." + Credential.mTable_Symbol + " order by Symbol; ";

                // Fetch symbol name from Table
                _user_1.ExecuteReader(query, ref dt);

                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show($" No Symbol found in Table: {Credential.mTable_Symbol} ");
                }

                //convert datatble symboil to List

                var list = dt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>(NSE_EQ_BHAVCOPY.mSYMBOL)).ToList();

                this.List_Symbol = list;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to  Load SymbolList");
            }
            finally
            {
                _user_1.Reset();
            }

        }


        private void TaskProcess_002()
        {
            DataBase _user_1 = null;
            try
            {
                _user_1 = new DataBase();
                _user_1.OpenConnection();
                DataTable dt = new DataTable();
                //SELECT distinct  Timestamp FROM pricedata.bhavcopyprice   order by `timestamp` Desc;
                string query = " SELECT  distinct  Timestamp FROM " + Credential.mSchema + "." + Credential.mTable_BhavCopyPrice + " order by `timestamp` Desc; ";

                // Fetch symbol name from Table
                _user_1.ExecuteReader(query, ref dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($" Bhav Copy table is Empty in : {Credential.mTable_BhavCopyPrice} ");
                }

                //convert datatble symboil to List

                var list = dt.Rows.OfType<DataRow>().Select(dr => dr.Field<string>(NSE_EQ_BHAVCOPY.mTIMESTAMP)).ToList();

                this.List_BhavCopy_Prev5 = list;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to  Load SymbolList");
            }
            finally
            {
                _user_1.Reset();
            }

        }

        private void TaskProces_003()
        {
            

        }




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
            if (!this.readFileFromNSE_EQUITY.STARTPROCESS_BHAVCOPY(this.List_Symbol))
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
                        this.TaskProcess2(path);
                    }

                    this.Refresh(); //Refresh

                }
            }
            catch (Exception ex)
            {
                textBox1_Nse_TOP_XX_LIST.Text = "Failed to Load Bhav copy";
            }

        }

        private void label5_AuTODownload_Click(object sender, EventArgs e)
        {
            //AUTO IMPORTER
            ImportNseBhavCopy _ImportNseBhavCopy = new ImportNseBhavCopy();

            _ImportNseBhavCopy.BulkImporter();
            MessageBox_Show_UserControl uc_Panel = new MessageBox_Show_UserControl();

            this.panel3_Progressbar.Controls.Add(uc_Panel);
            uc_Panel.listBox1_progressbar.DataSource = _ImportNseBhavCopy.WorKlog().ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {




            //uc_Panel.listBox1_progressbar.DataSource



        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Unzipping  features
            this._UnzippingFunc.unziping_Main();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Present All Folder Which contain all Bhav copy

            //Tree view 
            Form1_Folder_Stats _FolderStats = new Form1_Folder_Stats();   

            //DataGridView


            //visualize Form

            _FolderStats.ShowDialog();  

        }


    }
}
