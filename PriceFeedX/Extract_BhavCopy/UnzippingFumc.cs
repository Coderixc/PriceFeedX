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



        public List<string> Glob(out List<string> list)
        {

            //Set Out parameters
            list = new List<string> ();    
            try
            {
                string[] files = Directory.GetDirectories(this.m_unZippingPath  );

                return list = RemoveUnwantedFolder(files);// files.ToList();
            }
            catch (Exception ex)
            {

                return new List<string>();

            }


        }


        private List<String> RemoveUnwantedFolder(string  [] Inputfiles)
        {
            List<string> files = new List<string>();
            try
            {
                for(int i = 0; i < Inputfiles.Length; i++)
                {
                    if(Inputfiles[i].Contains("NSE_"))
                    {
                        files.Add(Inputfiles[i]);
                    }
                }

                return files;
            }
            catch
            {
                return new List<string>(); ;
            }


        }


        public List<string> Glob(out List<string> list, string location)
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
        public void ExtractAll(string path_with_filename,  string output)
        {
            try
            {


                if(File.Exists(output))
                {
                    File.Delete(output);
                }


                ZipFile.ExtractToDirectory(path_with_filename, output);

            }
            catch(Exception ex)
            {
                //TODO : Exception ocuured In Zipfile "ExtractToDirectory";
            }
        }

        private void ProcessExtractAllOneByOne(List<string> ListMultipleFolder,int IdxNo)
        {

            try
            {


                string loc = ListMultipleFolder.ElementAt(IdxNo);
                if (loc.Contains("NSE_")) //Compute folder ,Prefix By  "NSE_"
                {

                    //Generate path for individual bhav copy, where its is located 


                    List<string> List_Bahv_Copy;

                    // string _bhavcopypath = 

                    this.Glob(out List_Bahv_Copy, loc);

                    //Check is no bhav copy present
                    if (List_Bahv_Copy.Count == 0)
                    {
                        return;

                    }

                    //Extract folder wich is present on path location List_Bahv_Copy

                    for (int i = 0; i < List_Bahv_Copy.Count; i++)
                    {
                        string zipfolder = List_Bahv_Copy.ElementAt(i);
                        //set Output files
                        string[] splitpath = zipfolder.Split(this.separators, StringSplitOptions.None); //.\1_Dump_BhavCopy\NSE_2022_08_08\cm04JUL2022bhav.csv.zip

                        //Create Output folder with Prefix ""  -- will decide

                        string outpath = "." + splitpath[1] + "cm" + splitpath[2] + ".csv";

                        this.ExtractAll(zipfolder, outpath);

                    }

                }
                else
                {
                    // Ignore this folder path;
                }






            }
            catch {
            //TODO : Failed to Extract Indivual Folder
            }


        }




        // Method : Which will be  called by object , and This Method will trigger whole Unzippping Activitie  which is mentioned above
        public string unziping_Main(int ListIndex = -1)
        {
            string result = string.Empty;

            int index = 0;
            if(ListIndex != -1)
            {

                index = ListIndex;
                //index = 1;
            }

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
                            ProcessExtractAllOneByOne(List_Directory_Present, index);
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
