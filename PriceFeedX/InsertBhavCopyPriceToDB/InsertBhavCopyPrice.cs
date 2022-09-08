using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDataBase;
using System.Data;
using System.Windows.Forms;

namespace PriceFeedX.InsertBhavCopyPriceToDB
{
    internal class TABLE_NSE_BHAVCOPY
    {

        //ID,
        //Symbol,
        //TIMESTAMP,
        //CLOSE,
        //TOTTRDQTY,
        //TOTTRDVAL,
        //TOTALTRADES
        public const string mSymbol      = @"Symbol";
        public const string mTIMESTAMP   = @"TIMESTAMP";
        public const string mCLOSE       = @"CLOSE";
        public const string mOPEN = @"OPEN";

        public const string mHIGH = @"HIGH";
        public const string mLOW = @"LOW";
        public const string mTOTTRDQTY   = @"TOTTRDQTY";
        public const string mTOTTRDVAL   = @"TOTTRDVAL";
        public const string mTOTALTRADES = @"TOTALTRADES";





        //not required
        public const string mSERIES= @"SERIES";




    }

    internal class InsertBhavCopyPrice
    {
        #region Declare Variable
        private DataBase _DataBase_user_1;
        private DataTable dt_Bhav_copy;
        private List<string> List_Symbol;


        #endregion

        #region ctor

        public InsertBhavCopyPrice(DataTable dt,List<string> List_Symbol)
        {
            this._DataBase_user_1 = new DataBase();
            this.dt_Bhav_copy = new DataTable();
            this.dt_Bhav_copy = dt;

            this.List_Symbol = new List<string>();
            this.List_Symbol = List_Symbol;

        }

        #endregion

        public bool PrepareInsertQuery(bool BulkInsert)
        {

            _DataBase_user_1.OpenConnection();

            string _ID             =@"0";
            string _Symbol         =@"0";
            string _TIMESTAMP      =@"0";
            string _CLOSE          =@"0";
            string _TOTTRDQTY      =@"0";
            string _TOTTRDVAL      =@"0";
            string _TOTALTRADES = @"0";


            try
            {
                string query = @" INSERT INTO `" + Credential.mSchema + @"`.`" + Credential.mTable_BhavCopyPrice + @"`
                                     (
                                              
                                    `"+TABLE_NSE_BHAVCOPY.mSymbol      +@"`,
                                    `"+TABLE_NSE_BHAVCOPY.mTIMESTAMP   + @"`,
                                    `" + TABLE_NSE_BHAVCOPY.mOPEN + @"`, 
                                    `" + TABLE_NSE_BHAVCOPY.mHIGH + @"`,
                                    `" + TABLE_NSE_BHAVCOPY.mLOW + @"`,
                                    `" + TABLE_NSE_BHAVCOPY.mCLOSE       +@"`,
                                    `"+TABLE_NSE_BHAVCOPY.mTOTTRDQTY   +@"`,
                                    `"+TABLE_NSE_BHAVCOPY.mTOTTRDVAL   +@"`,
                                    `"+TABLE_NSE_BHAVCOPY.mTOTALTRADES + @"`
                                     )
                                    VALUES  ";
                string insertquery_values = "";

                for (int i = 0; i < this.dt_Bhav_copy.Rows.Count; i++)
                {
                    if (this.List_Symbol.Contains(this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mSymbol].ToString()))
                    {
                        string _series = string.Empty;

                        _series = this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mSERIES].ToString();
                        if (_series == "EQ")
                        {

                            insertquery_values += "("
                                               + "'" + this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mSymbol].ToString() + "',"
                                               + "'" + this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mTIMESTAMP].ToString() + "',"

                                               + "'" + this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mOPEN].ToString() + "',"
                                               + "'" + this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mHIGH].ToString() + "',"
                                                 + "'" + this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mLOW].ToString() + "',"

                                               + "'" + this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mCLOSE].ToString() + "',"
                                               + "'" + this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mTOTTRDQTY].ToString() + "',"
                                               + "'" + this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mTOTTRDVAL].ToString() + "',"
                                               + "'" + this.dt_Bhav_copy.Rows[i][TABLE_NSE_BHAVCOPY.mTOTALTRADES].ToString() + "') ,";


                        }
                    }

                }
                query += insertquery_values;

                query = query.Remove(query.Length - 1);

                return this.Insert_2_Db(query,  BulkInsert);

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #region Finally after all Calculation , Entering symbols to Table with some default values
        public bool Insert_2_Db(string Query,bool BulkInsert)
        {
            try
            {


                bool x = false;
                if (_DataBase_user_1.ISConnectionOpen())
                {
                    x = _DataBase_user_1.ExecuteNonQuery(Query);
                    if (x)
                    {
                        if(!BulkInsert)
                            MessageBox.Show("Trades inserted");
                    }


                }
                return x; ;
            }
            catch
            {

                return false;
            }
        }
        #endregion

    }
}
