using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDataBase;
using System.Data;
using PriceFeedX.LoadSymbolFromFiles;
using System.Windows.Forms;

namespace PriceFeedX
{
    internal class InsertSymbolToDB
    {
        #region Declare variable
        private List<string> List_Symbol;

        private DataBase _DataBase_user_1;

        #endregion

        #region Constructor
        public InsertSymbolToDB(List<string> listSymbol)
        {
            this.List_Symbol = listSymbol.ToList();

            this._DataBase_user_1 = new DataBase(); 

        }

        #endregion
        public bool PrepareInsertQuery()  
        {

            _DataBase_user_1.OpenConnection();

            //Validate Symbol before inserting to Db

            List<string> ListDb = new List<string>();
            this.validate_1_Read_DB(ref ListDb);
            List<string> ListTOENter = this.validate_2_Match_both_list(ListDb, List_Symbol);


            if(ListTOENter.Count == 0)
            {
                MessageBox.Show("No New Sybols found");
                return true;
            }


            string ltp = "0.0";
            string Class = "200";
            string prev1 = "0.0";
            string prev2 = "0.0";
            string prev3 = "0.0";
            string prev4 = "0.0";
            string prev5 = "0.0";
            try
            {
                string query = @" INSERT INTO `" + Credential.mSchema + @"`.`" + Credential.mTable_Symbol + @"`
                                     (
                                     `Class`,
                                     `Symbol`,
                                     `Ltp`,
                                     `prev1`,
                                     `prev2`,
                                     `prev3`,
                                     `prev4`,
                                     `prev5`)
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
        #region Finally after all Calculation , Entering symbols to Table with some default values
        public bool Insert_2_Db(string Query)
        {
            try
            {


                bool x = false;
                if(_DataBase_user_1.ISConnectionOpen())
                {
                   x =  _DataBase_user_1.ExecuteNonQuery(Query);
                }
                return x; ;
            }
            catch {

                return false;
            }
        }
        #endregion

         ///
         //// Validating Symbols 
         

        #region IF Symbol is already Present into table,Dont insert Into table
        private bool validate_1_Read_DB(ref List<string> ListOut )
        {
            bool x = false;
            try
            {
                string query = @"SELECT Symbol FROM `" + Credential.mSchema + @"`.`" + Credential.mTable_Symbol + @" order by Symbol";
                DataTable dt = new DataTable();

                if(_DataBase_user_1.ISConnectionOpen())
                {
                    x = _DataBase_user_1.ExecuteReader(query,ref dt);
                }

                if(dt.Rows.Count != 0)
                {
                    var list = dt.Rows.OfType<DataRow>()
                    .Select(dr => dr.Field<string>(NSE_TOP_XX_SYMBOLLIST.mSymbol)).ToList();

                    ListOut = list.ToList();
                }


                return x;
            }
            catch(Exception ex)
            {
                return x;
            }
        }


        private List<string> validate_2_Match_both_list(List<string> List1DB, List<string> list2CSV)
        {
            bool x = false;
            try
            {
                List<string> listbuff = new List<string>();

                listbuff = (List<string>)List1DB.Except(list2CSV);    
                return listbuff;
            }
            catch (Exception ex)
            {
                return new List<string>();
            }
        }

        #endregion
    }
}
