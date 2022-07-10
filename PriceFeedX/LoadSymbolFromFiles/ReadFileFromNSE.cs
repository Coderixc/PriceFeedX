using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        #region Create GUI Panel to load Textf file
        public ReadFileFromNSE_EQUITY( string inputCsvPath)
        {
            this.INPUTTFILE = inputCsvPath; 
            this.Dt_NSE_Symbol_File = new DataTable();


            //Initilise all Necessary Method/Fuymction
            this.Prepare_Datatable_Coloumn_Fraom_NIFTYLIST(ref this.Dt_NSE_Symbol_File);

        }
        #endregion

        #region Prepare Datatable Shape with column name for EQ Bhv Copy
        private void Prepare_Datatable_Coloumn_FOR_BHAV_COPY(ref DataTable dt)
        {
            try
            {
               this.Dt_NSE_Symbol_File.Columns.Clear();

                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mSYMBOL,typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mSERIES, typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mOPEN,typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mHIGH,typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mLOW,typeof(string));    
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mCLOSE,typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mLAST,typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mPREVCLOSE,typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mTOTTRDQTY,typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mTOTTRDVAL,typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mTIMESTAMP, typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mTOTALTRADES, typeof(string));
                this.Dt_NSE_Symbol_File.Columns.Add(NSE_EQ_BHAVCOPY.mISIN, typeof(string));


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



        #region 
        public void  Load_NSE_File_To_DataTable(ref DataTable dt)
        {
            try
            {

            }catch (Exception ex)
            {
               
            }
        }
        #endregion

        #region  
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
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}


// use Bhav copy (.csv) https://www.nseindia.com/all-reports  -- ye wala Bhav copy ka hain

//NSE TOP 200 Stocks Use https://www.nseindia.com/products-services/indices-nifty200-index