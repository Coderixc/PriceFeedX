using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDataBase;


namespace PriceFeedX.InsertSymbolToDB
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
            try
            {
                string query = @" INSERT INTO `"+ Credential.mSchema+ @"`.`"  +Credential.mTable  +@"`
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

                for(int i  = 0; i  < this.List_Symbol.Count;i++)
                {
                    insertquery_values += "'2' ," + this.List_Symbol[i].ToString() 
                                            +"," +  ;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;   
            }
        }

    }
}
