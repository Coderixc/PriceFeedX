using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            List<string> List_BhavCopy_collectioin;   
            try
            {

               this.Glob(out List_BhavCopy_collectioin);

                return "Sucessfully";
            }
            catch (Exception ex)
            {

                return "failed to load";

            }

        }



        private List<string> Glob(out List<string> list)
        {
            //Set Out parameters
            list = new List<string> ();    
            try
            {
                string[] files = Directory.GetFiles(this.m_unZippingPath);

                return list  =files.ToList();
            }
            catch (Exception ex)
            {

                return new List<string>();

            }


        }
  





    }
}
