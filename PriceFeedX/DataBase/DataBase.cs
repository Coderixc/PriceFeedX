using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using MySql.Data;
using System.Data;

namespace CustomDataBase
{
    public class DataBase
    {
        //string cs = @"server=localhost;userid=dbuser;password=s$cret;database=testdb";
         private string  ConnectionString = @"server="+ Credential.mHost
                                    +";userid="+ Credential.mUser 
                                    +";password="+ Credential.mPassword
                                    +";database=" + Credential.mSchema;

        private MySqlConnection Connection;


        public DataBase() //constructor
        {
            Connection = new MySqlConnection(ConnectionString);//initialise SqlConnection 
        }

        public void  Reset() // Flush + Kill current Connection
        {

        }

        public bool OpenConnection()
        {
            bool x = false;
            try
            {
                Connection.Open();
                return x;
            }
            catch (Exception ex)
            {
                
                return x;
            }
        }
        //Check connection to databse
        public bool ISConnectionOpen()
        {
            try
            {
                if(Connection.State.ToString() =="Open")
                {
                    return true;
                }
                else
                {
                    return false;
                }
                   


            }
            catch(MySqlException ex)
            {
                //If needed Mysql Error in exception
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        string Err0 =("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        string Err1 = ("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        //Close connection to database
        public  bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        //Working with DML (Insert, Update, Select, Delete)
        public bool ExecuteReader(string sqlQuery,ref DataTable dtOut)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery,Connection);
                dtOut.Load(cmd.ExecuteReader());
                return true;
            }
            catch(MySqlException ex)
            {
                string err = ex.Message;
                return false;
            }
        }
        public bool ExecuteNonQuery(string sqlQuery,int out_rowsmodified =0)
        {
            int rowmodified = 0;
            try {
                MySqlCommand cmd = new MySqlCommand(sqlQuery,Connection);
                try
                {
                    rowmodified = (int)cmd.ExecuteNonQuery();
                }
                catch(MySqlException ex)
                {
                    //;
                }
                out_rowsmodified = rowmodified;
                return true;
            }
            catch(MySqlException ex) {
                switch (ex.Number)
                {
                    case 0:
                        string Err0 = ("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        string Err1 = ("Invalid username/password, please try again");
                        break;

                    case 1586:
                        
                        //public static final int ER_DUP_ENTRY_WITH_KEY_NAME = 1586;
                        //out_rowsmodified= ex.
                        break;




    }
                string err = ex.Message;
                return false;
            }
        }
    }
}


/* Reference from 
 * 
 * https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */