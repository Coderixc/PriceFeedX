using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PriceFeedX.Import_Bhav_Copy_NSE;
namespace PriceFeedX.Extract_BhavCopy
{
    //Object- YES
    //Inheritance  - NO
    sealed class UnzippingFunc
    {

         private string m_unZippingPath = String .Empty;    


        public UnzippingFunc() //HOW TO GET WHICH FOLDER THE LAST FOLDER WHICH WAS USED TO IMPORTING BHAV COPY
        {
            this.m_unZippingPath = DumpFolder.Dump_Path;  // using main path not exact path of bhav copy path

        }

        private  string Load_All_Directory_which_contain_Bhavcopy()
        {
            string result = string.Empty;   
            try
            {

                return result;
            }
            catch (Exception ex)
            {

                return string.Empty;

            }

        }




  





    }
}
