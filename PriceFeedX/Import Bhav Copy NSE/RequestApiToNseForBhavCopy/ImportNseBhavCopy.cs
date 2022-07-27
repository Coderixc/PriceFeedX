using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;

using PriceFeedX.Import_Bhav_Copy_NSE;
namespace PriceFeedX.Import_Bhav_Copy_NSE.RequestApiToNseForBhavCopy
{

    internal enum E_Month
    {
         JAN =1,
         FEB,
         MAR,
         APR,
         MAY, 
         JUN, 
         JUL, 
         AUG, 
         SEP,
         OCT, 
         NOV, 
         DEC
    }

    internal class ImportNseBhavCopy
    {

        private string Url = string.Empty;
        private E_Month EMonth;

        DumpBhavCopyToLoacal _DumpBhavCopyToLocal;
        public ImportNseBhavCopy()
        {
            Rawdata();
            this._DumpBhavCopyToLocal  = new DumpBhavCopyToLoacal();
        }

        private void Rawdata()
        {
            this.Url = "https://www1.nseindia.com/ArchieveSearch?h_filetype=eqbhav&date=20-07-2022&section=EQ";
        }

        public void BulkImporter()
        {
            //string[] monthList = new string[12] { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
            string[] yearList = new string[1] {  "2022" };


            string f1_Prefix = "cm";
            string f1_Suffix = "bhav.csv.zip";

            foreach (string year in yearList)
            {
                int count = 0;
                foreach (string month in Enum.GetNames(typeof(E_Month)))
                {
                    count++;
                    string link = year + month;


                    int days = -1;
                    try
                    {
                        days = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(Convert.ToInt32(year), count);
                    }
                    catch { }
                    {
                    //TODO ERROR

                    }

                    if (days == -1)
                        continue;


                    try
                    {

                        for(int day =1; day <=days;day++)
                        {


                            string tempurl = @"https://www1.nseindia.com/content/historical/EQUITIES"+"/" + year + "/" + month + "/";
                            string outputfolder = f1_Prefix + day + month + year + f1_Suffix;
                            tempurl += outputfolder;
                            string f1 = String.Empty;

                            WebClient webClient = new WebClient();
                            webClient.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
                            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");

                            //string url_Direct = @"https://www1.nseindia.com/content/historical/EQUITIES/2022/JUL/cm20JUL2022bhav.csv.zip";
                            Uri uri_t = new Uri(tempurl);
                            webClient.DownloadFileAsync(uri_t, outputfolder);
                        }

                        ///<a href="/content/historical/EQUITIES/2022/JUL/cm20JUL2022bhav.csv.zip" target="new">cm20JUL2022bhav.csv.zip</a>

                    }
                    catch (Exception ex)
                    {

                    }






               }

            }

            //try
            //{
            //    //Uri uri = new Uri(@"http://www.nse-india.com/content/historical/EQUITIES/2007/");
            //    Uri uri = new Uri(this.Url);

            //    Uri tempUri;



            //    ////foreach (string month in monthList)
            //    //{
            //    //    WebClient client = new WebClient();
            //    //    FileStream writer;



            //    //    for (int i = 1; i < 31; i++)
            //    //    {
            //    //        try
            //    //        //{
            //    //        //    //string f1 = String.Empty;
            //    //        //    //string f1_Prefix = "cm";
            //    //        //    //string f1_Suffix = "bhav.csv.zip";





            //    //        //    WebClient webClient = new WebClient();
            //    //        //    webClient.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
            //    //        //    webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");

            //    //        //    string url_Direct = @"https://www1.nseindia.com/content/historical/EQUITIES/2022/JUL/cm20JUL2022bhav.csv.zip";
            //    //        //    Uri uri_t = new Uri(url_Direct);
            //    //        //    webClient.DownloadFileAsync(uri_t, "cm19JUL2022bhav.csv.zip");

            //    //        //    ///<a href="/content/historical/EQUITIES/2022/JUL/cm20JUL2022bhav.csv.zip" target="new">cm20JUL2022bhav.csv.zip</a>

            //    //        }
            //    //        catch (WebException ex)
            //    //        {
            //    //            if (ex.Status == WebExceptionStatus.ProtocolError && ex.Message.Contains("404"))
            //    //                //Debug.WriteLine("FileNotFound");
            //    //                continue;
            //    //        }
            //    //    }

            //    }
            //}
            //catch (Exception ex)
            //{
            //    //Debug.WriteLine("Failed");
            //}



        }





    }
}
