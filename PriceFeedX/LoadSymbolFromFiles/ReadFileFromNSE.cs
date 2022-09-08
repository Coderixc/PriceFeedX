using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PriceFeedX.InsertBhavCopyPriceToDB;


using System.Data;
namespace PriceFeedX.LoadSymbolFromFiles
{

    internal class NSE_EQ_BHAVCOPY
    {

        public const string mSYMBOL	       = "SYMBOL";
        public const string mSERIES	       = "SERIES";
        public const string mOPEN	       = "OPEN";
        public const string mHIGH	       = "HIGH";
        public const string mLOW	       = "LOW";
        public const string mCLOSE	       = "CLOSE";
        public const string mLAST	       = "LAST";
        public const string mPREVCLOSE	   = "PREVCLOSE";
        public const string mTOTTRDQTY	   = "TOTTRDQTY";
        public const string mTOTTRDVAL     = "TOTTRDVAL";
        public const string mTIMESTAMP	   = "TIMESTAMP";
        public const string mTOTALTRADES = "TOTALTRADES";
        public const string mISIN          = "ISIN";
                                           
    }



    internal class NSE_TOP_XX_SYMBOLLIST
    {

        public const string mCompany      = "Company Name";
        //public const string mName	      = "Name";
        public const string mIndustry	  = "Industry";
        public const string mSymbol	      = "Symbol";
        public const string mSeries	      = "Series";
        public const string mISINCode     ="ISIN Code";


    }


   

    internal class ReadFileFromNSE_EQUITY
    {
        string INPUTTFILE = null;
        DataTable Dt_NSE_Symbol_File;
        DataTable Dt_NSE_BHAV_COPY;
        InsertSymbolToDB _InsertSymbolToDB;
        InsertBhavCopyPrice _InsertBhavCopyPriceToDB;   
        

        #region Create GUI Panel to load Textf file
        public ReadFileFromNSE_EQUITY( string inputSymbolCsvPath)
        {
            this.INPUTTFILE = inputSymbolCsvPath; 
            this.Dt_NSE_Symbol_File = new DataTable();


            //Initilise all Necessary Method/Fuymction
            this.Prepare_Datatable_Coloumn_Fraom_NIFTYLIST(ref this.Dt_NSE_Symbol_File);

        }
        #endregion



        #region Create GUI Panel to load BHAV COPY file
        public ReadFileFromNSE_EQUITY(string inputBhavCopyCsvPath,String BHAVCOPY = "1/0 -- > Symbol/Bhavcopy", bool Bhavcopy = true)
        {
            if (Bhavcopy)
            {


                this.INPUTTFILE = inputBhavCopyCsvPath;
                this.Dt_NSE_BHAV_COPY = new DataTable();


                //Initilise all Necessary Method/Fuymction
                this.Prepare_Datatable_Coloumn_FOR_BHAV_COPY(ref this.Dt_NSE_Symbol_File);
            }

        }
        #endregion


        #region Prepare Datatable Shape with column name for EQ Bhv Copy
        private void Prepare_Datatable_Coloumn_FOR_BHAV_COPY(ref DataTable dt)
        {
            try
            {
               this.Dt_NSE_BHAV_COPY.Columns.Clear();

                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mSYMBOL,typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mSERIES, typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mOPEN,typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mHIGH,typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mLOW,typeof(string));    
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mCLOSE,typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mLAST,typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mPREVCLOSE,typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mTOTTRDQTY,typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mTOTTRDVAL,typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mTIMESTAMP, typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mTOTALTRADES, typeof(string));
                this.Dt_NSE_BHAV_COPY.Columns.Add(NSE_EQ_BHAVCOPY.mISIN, typeof(string));


                //dt = this.Dt_NSE_Symbol_File;

            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region Prepare Datatable Shape with column name for Symbol name 
        private void Prepare_Datatable_Coloumn_Fraom_NIFTYLIST(ref DataTable dt)  //ind_nifty200list
        {
            try
            {
                this.Dt_NSE_Symbol_File.Columns.Clear();

                this.Dt_NSE_Symbol_File.Columns.Add(NSE_TOP_XX_SYMBOLLIST.mCompany, typeof(string));
                //this.Dt_NSE_Symbol_File.Columns.Add(NSE_TOP_XX_SYMBOLLIST.mName, typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_TOP_XX_SYMBOLLIST.mIndustry, typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_TOP_XX_SYMBOLLIST.mSymbol, typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_TOP_XX_SYMBOLLIST.mSeries, typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_TOP_XX_SYMBOLLIST.mISINCode, typeof(string));



                dt = this.Dt_NSE_Symbol_File;

            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region   Read NIFTY TOP 200 XX file And Load to Local Internal Structure
        public DataTable ReadTextfile( DataTable Dt_Input_With_ColoumName)
        {
            try
            {
                if (this.INPUTTFILE == null)
                    return  new DataTable();

                //START TASK
                

                string[] Lines = File.ReadAllLines(this.INPUTTFILE);

                string[] Fields;
                for (int i = 1; i < Lines.GetLength(0); i++)
                {
                    DataRow Row = Dt_Input_With_ColoumName.NewRow();
                    Fields = Lines[i].Split(new char[] { ',' });
                    for (int f = 0; f < Dt_Input_With_ColoumName.Columns.Count; f++)
                        Row[f] = Fields[f];
                    Dt_Input_With_ColoumName.Rows.Add(Row);
                }

                return Dt_Input_With_ColoumName;

            }
            catch(Exception ex)
            {
                return Dt_Input_With_ColoumName;
            }
        }
        #endregion

        public bool STARTPROCESS()
        {
            try
            {
                DataTable DT_Result = new DataTable();

                DT_Result = this.ReadTextfile(this.Dt_NSE_Symbol_File);

                this.InsertDt2DB(DT_Result);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool STARTPROCESS_BHAVCOPY(List<string> ListSymbol,bool BulkInsert =false)
        {
            try
            {
                DataTable DT_Result = new DataTable();

                DT_Result = this.ReadTextfile(this.Dt_NSE_BHAV_COPY);

                this.InsertDt2DB_BhavCopy(DT_Result,ListSymbol,BulkInsert);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        private bool InsertDt2DB(DataTable dt)
        {
            try
            {
                bool x = false;
                if(dt.Rows.Count ==0)
                {
                    return true;
                }

                string box_msg_y_n_c = "Do you want to enter new Symbol to DB?";

                string box_title_y_n_c = "Confirmation Box";

                //MessageBox.Show(box_msg_y_n_c, box_title_y_n_c, MessageBoxButtons.YesNoCancel;

                DialogResult result = MessageBox.Show(box_msg_y_n_c, "caption", MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Yes)
                {
                    try
                    {


                        var list = dt.Rows.OfType<DataRow>()
                        .Select(dr => dr.Field<string>(NSE_TOP_XX_SYMBOLLIST.mSymbol)).ToList();

                        _InsertSymbolToDB = new InsertSymbolToDB(list.ToList());

                       x = _InsertSymbolToDB.PrepareInsertQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error(s) Occured in Converting Datatable to List while inserting Symbol to DB.");
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show(" Symbol Not Inserted/Updated ");
                }
                else
                {

                }

                return x;
            }
            catch (Exception ex)
            {

                return false;
            }
        }



        #region Insert Bhav Copy Csv Files to Database

        private bool InsertDt2DB_BhavCopy(DataTable dt,List<string> ListSymbol, bool BulkInsert )
        {
            try
            {
                bool x = false;
                if (dt.Rows.Count == 0)
                {
                    return true;
                }
                if( BulkInsert ) //if Bulk insert is Passesd True
                {
                    try
                    {
                        _InsertBhavCopyPriceToDB = new InsertBhavCopyPrice(dt, ListSymbol );

                        x = _InsertBhavCopyPriceToDB.PrepareInsertQuery(BulkInsert);
                    }
                    catch (Exception ex)
                    {
                        //("Error(s) Occured in Converting Datatable to List while inserting Symbol to DB.");
                    }

                    return x;

                }

                        

                string box_msg_y_n_c = "Do you want to Insert new BhavCopy to DB?";

                string box_title_y_n_c = "Confirmation Box";

                //MessageBox.Show(box_msg_y_n_c, box_title_y_n_c, MessageBoxButtons.YesNoCancel;

                DialogResult result = MessageBox.Show(box_msg_y_n_c, "caption", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    try
                    {


                        //var list = dt.Rows.OfType<DataRow>()
                        //.Select(dr => dr.Field<string>(NSE_TOP_XX_SYMBOLLIST.mSymbol)).ToList();

                        _InsertBhavCopyPriceToDB = new InsertBhavCopyPrice(dt, ListSymbol);

                        x = _InsertBhavCopyPriceToDB.PrepareInsertQuery( BulkInsert);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error(s) Occured in Converting Datatable to List while inserting Symbol to DB.");
                    }
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show(" Symbol Not Inserted/Updated ");
                }
                else
                {

                }

                return x;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        #endregion

    }
}


// use Bhav copy (.csv) https://www.nseindia.com/all-reports  -- ye wala Bhav copy ka hain

//NSE TOP 200 Stocks Use https://www.nseindia.com/products-services/indices-nifty200-index