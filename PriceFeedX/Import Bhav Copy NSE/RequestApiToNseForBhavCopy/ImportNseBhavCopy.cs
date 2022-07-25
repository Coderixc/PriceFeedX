using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;

namespace PriceFeedX.Import_Bhav_Copy_NSE.RequestApiToNseForBhavCopy
{
    internal class ImportNseBhavCopy
    {

        private string Url = string.Empty;  
        public ImportNseBhavCopy()
        {
            Rawdata();

        }

        private void Rawdata()
        {
            this.Url = "https://www1.nseindia.com/ArchieveSearch?h_filetype=eqbhav&date=20-07-2022&section=EQ";


        }

        public void BulkImporter()
        {
            string[] monthList = new string[3] { "JUN", "JUL", "AUG" };
            try
            {
                //Uri uri = new Uri(@"http://www.nse-india.com/content/historical/EQUITIES/2007/");
                Uri uri = new Uri(this.Url);

                Uri tempUri;
                foreach (string month in monthList)
                {
                    WebClient client = new WebClient();
                    FileStream writer;

                    for (int i = 1; i < 31; i++)
                    {
                        try
                        {
                            string iStr = (i <= 9) ? "0" + i.ToString() : i.ToString();
                            //tempUri = new Uri(uri, month + "/cm" + iStr + month + "2007bhav.csv");
                            //Debug.WriteLine("Downloading " + tempUri.ToString());
                            //byte[] data = client.DownloadData(tempUri);
                           // byte[] data = client.DownloadData(this.Url);

                            client.DownloadFile(this.Url, "cm19JUL2022bhav.csv.zip");

                            //using (writer = File.Create(@"C:\NSE\cm" + i.ToString() + month + "2007bhav.csv"))
                            //{
                            //    try
                            //    {
                            //        writer.Write(data, 0, data.Length);
                            //    }
                            //    finally
                            //    {
                            //        if (writer != null)
                            //            writer.Close();
                            //    }
                            //}
                        }
                        catch (WebException ex)
                        {
                            if (ex.Status == WebExceptionStatus.ProtocolError && ex.Message.Contains("404"))
                                //Debug.WriteLine("FileNotFound");
                            continue;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                //Debug.WriteLine("Failed");
            }



        }





    }
}
