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
         private string[] separators = { "cm","."};  //cm04JUL2022bhav


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
                string[] files = Directory.GetDirectories(this.m_unZippingPath );

                return list  =files.ToList();
            }
            catch (Exception ex)
            {

                return new List<string>();

            }


        }


        private List<string> Glob(out List<string> list, string location)
        {

      

            //Set Out parameters
            list = new List<string>();
            try
            {
                string[] files = Directory.GetFiles(location, "*.zip");  //.\1_Dump_BhavCopy\NSE_2022_08_08\cm04JUL2022bhav.csv.zip

                return list = files.ToList();
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
                //FileStream compressedFileStream = File.Open(path_with_filename, FileMode.Open);


                if(File.Exists(output))
                {
                    File.Delete(output);
                }

                //var bytes = File.ReadAllBytes(path_with_filename);
                //using (FileStream fs = new FileStream(output, FileMode.CreateNew))
                //using (GZipStream zipStream = new GZipStream(fs, CompressionMode.Decompress, false))
                //{
                //    zipStream.Write(bytes, 0, bytes.Length);
                //}

                ////using (GZipStream zipStream = new GZipStream(fs, CompressionMode.Compress, false))
                ////{
                ////    zipStream.Write(bytes, 0, bytes.Length);
                ////}


                //FileStream outputFileStream = File.Create(output);  //Issue
                //var decompressor = new GZipStream(compressedFileStream, CompressionMode.Decompress);
                //decompressor.CopyTo(outputFileStream);

                //D:\Project\PriceFeedX\PriceFeedX\PriceFeedX\bin\Debug\1_Dump_BhavCopy\NSE_2022_08_08\cm01APR2021bhav.csv.zip

                FileStream fs = File.OpenRead(path_with_filename);

                byte[] buf = new byte[1024];
                string result = String.Empty;
                int c;

                while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                {
                    Console.WriteLine(Encoding.UTF8.GetString(buf, 0, c));

                   result += Encoding.UTF8.GetString(buf, 0, c);
                }



                FileStream compressedFileStream = File.Open(path_with_filename, FileMode.Open);
                 FileStream outputFileStream = File.Create(output);
                 var decompressor = new GZipStream(compressedFileStream, CompressionMode.Decompress,false);
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
                List<string> List_Directory_Present = new List<string>();

                //Read path where all bhav copy ois located
                this.Glob( out List_Directory_Present);


                //Chec if curent direectory is Empty
                if(List_Directory_Present.Count == 0)
                {
                    //Empty location  ---> return;
                }
                else  // Perfom  unzipping function
                {

                    try
                    {
                        for(int folder_idx= 0; folder_idx<  List_Directory_Present.Count; folder_idx ++)
                        {

                            string loc = List_Directory_Present.ElementAt(folder_idx);
                            if(loc.Contains("NSE_")) //Compute folder ,Prefix By  "NSE_"
                            {

                                //Generate path for individual bhav copy, where its is located 

                                List<string> List_Bahv_Copy;

                               // string _bhavcopypath = 

                                this.Glob( out List_Bahv_Copy,loc);

                                //Check is no bhav copy present
                                if(List_Bahv_Copy.Count == 0)
                                {
                                    continue;
                                }

                                //Extract folder wich is present on path location List_Bahv_Copy

                                for (int i  = 0; i < List_Bahv_Copy.Count; i++)
                                {
                                    string zipfolder = List_Bahv_Copy.ElementAt(i);
                                    //set Output files
                                    string[] splitpath = zipfolder.Split(this.separators,StringSplitOptions.None); //.\1_Dump_BhavCopy\NSE_2022_08_08\cm04JUL2022bhav.csv.zip

                                    //Create Output folder with Prefix ""  -- will decide

                                    string outpath = "."+ splitpath[1]+ "cm_"+ splitpath[2]  +".csv";

                                    this.ExtractAll(zipfolder, outpath);

                                }

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
