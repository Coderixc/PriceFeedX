using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDataBase;

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
        public const string mTOTTRDQTY   = @"TOTTRDQTY";
        public const string mTOTTRDVAL   = @"TOTTRDVAL";
        public const string mTOTALTRADES = @"TOTALTRADES";



    }

    internal class InsertBhavCopyPrice
    {
        #region Declare Variable
        private DataBase _DataBase_user_1;


        #endregion

        #region ctor

        public InsertBhavCopyPrice()
        {

        }

        #endregion

        public bool PrepareInsertQuery()
        {

            _DataBase_user_1.OpenConnection();

            //Validate Symbol before inserting to Db

            //List<string> ListDb = new List<string>();
            //this.validate_1_Read_DB(ref ListDb);
            //List<string> ListTOENter = this.validate_2_Match_both_list(ListDb, List_Symbol);


            //if (ListTOENter.Count == 0)
            //{
            //    MessageBox.Show("No ");
            //    return true;
            //}


            string ltp = "0.0";
            string Class = "200";
            string prev1 = "0.0";
            string prev2 = "0.0";
            string prev3 = "0.0";
            string prev4 = "0.0";
            string prev5 = "0.0";

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
                                    `"+TABLE_NSE_BHAVCOPY.mTIMESTAMP   +@"`,
                                    `"+TABLE_NSE_BHAVCOPY.mCLOSE       +@"`,
                                    `"+TABLE_NSE_BHAVCOPY.mTOTTRDQTY   +@"`,
                                    `"+TABLE_NSE_BHAVCOPY.mTOTTRDVAL   +@"`,
                                    "+TABLE_NSE_BHAVCOPY.mTOTALTRADES + @"`
                                     )
                                    VALUES  ";
                string insertquery_values = "";

                for (int i = 0; i < ListTOENter.Count; i++)
                {
                    insertquery_values += "('" + Class + "' ,"
                                       + "'" + this.List_Symbol[i].ToString() + "',"
                                       + ltp + ","
                                       + prev1 + ","
                                       + prev2 + ","
                                       + prev3 + ","
                                       + prev4 + ","
                                        + prev5 + "),";
                }
                query += insertquery_values;

                query = query.Remove(query.Length - 1);

                return this.Insert_2_Db(query);

            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
