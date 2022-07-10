using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDataBase;


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
            string ltp = "0.0";
            string Class = "200";
            string prev1 = "0.0";
            string prev2 = "0.0";
            string prev3 = "0.0";
            string prev4 = "0.0";
            string prev5 = "0.0";
            try
            {
                string query = @" INSERT INTO `" + Credential.mSchema + @"`.`" + Credential.mTable + @"`
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

                for (int i = 0; i < this.List_Symbol.Count; i++)
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
    }
}
