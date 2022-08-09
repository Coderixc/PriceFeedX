using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

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



        private string Unzip_Task001()
        {
            string result = String.Empty;
            try
            {

                //Read all file in located Directory


                return result;
            }
            catch (Exception ex)
            {

                return result;
            }

        }


        private string Load_All_Directory_which_contain_Bhavcopy()
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
                string[] files = Directory.GetDirectories(this.m_unZippingPath);

                return list  =files.ToList();
            }
            catch (Exception ex)
            {

                return new List<string>();

            }


        }
  

        private void ExtractAll(string path_with_filename,  string output)
        {
            try
            {
                FileStream compressedFileStream = File.Open(path_with_filename, FileMode.Open);
                FileStream outputFileStream = File.Create(path_with_filename);
                var decompressor = new GZipStream(compressedFileStream, CompressionMode.Decompress);
                decompressor.CopyTo(outputFileStream);
            }
            catch
            {

            }
        }


        // Method : Which will be  called by object , and This Method will trigger whole Unzippping Activitie  which is mentioned above
        public string unziping_Main()
        {
            string result = string.Empty;
            try
            {
                List<string> List_BhavCopy_collectioin = new List<string>();

                //Read path where all bhav copy ois located
                this.Glob( out List_BhavCopy_collectioin);


                //Chec if curent direectory is Empty
                if(List_BhavCopy_collectioin.Count == 0)
                {
                    //Empty location  ---> return;
                }
                else  // Perfom  unzipping function
                {

                    try
                    {
                        for(int folder_idx= 0; folder_idx<  List_BhavCopy_collectioin.Count; folder_idx ++)
                        {

                            string loc = List_BhavCopy_collectioin.ElementAt(folder_idx);
                            if(loc.Contains("NSE_")) //Compute folder ,Prefix By  "NSE_"
                            {


                            }
                            else
                            {
                                // Ignore this folder path;
                            }


                        }

                    }
                    catch
                    {
                        // some uissue while iterating  folder for bhav copy
                    }


                }

                return result;

            }
            catch
            {

                return result;
            }



        }



    }
}
