using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Windows.Forms;

using PriceFeedX.Import_Bhav_Copy_NSE;
using PriceFeedX.Import_Bhav_Copy_NSE.ShowImportStatusToConsole_UserControl;
namespace PriceFeedX.Import_Bhav_Copy_NSE.RequestApiToNseForBhavCopy
{

    internal enum E_Month
    {
        JAN = 1,
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
        private Queue<string> Queue_Saturday_sunday;

        public DumpFolder _DumpFolder;
        //public MessageBox_Show_UserControl userControl_MessageProgressBar;
        public ImportNseBhavCopy()
        {
            Rawdata();

            this._DumpFolder = new DumpFolder();
            this.Queue_Saturday_sunday = new Queue<string>();

            //this.userControl_MessageProgressBar = new MessageBox_Show_UserControl();

           // userControl_MessageProgressBar.Show();  


        }

        private void Rawdata()
        {

            this.Url = "https://www1.nseindia.com/ArchieveSearch?h_filetype=eqbhav&date=20-07-2022&section=EQ";
        }


        private bool ExclueSaturday_Sunday(string yyyy,int month,int day)
        {
            bool result = false;
            try
            {
                var date = new DateTime(Convert.ToInt32(yyyy), month, day);
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    this.Queue_Saturday_sunday.Enqueue(yyyy + @"\" + month + @"\" + day);
                    
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }


        private bool ExtractRequesttillToday(string yyyy, int month, int day)
        {

            DateTime dtnow = DateTime.Now;

            var date = new DateTime(Convert.ToInt32(yyyy), month, day);

            if (dtnow < DateTime.Now)
            {
                MessageBox.Show("Completed Till "   + dtnow);
                return true;
            }


            return false;
        }
        public void BulkImporter()
        {

            string[] yearList = new string[1] { "2022" };

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
                        for (int day = 1; day <= days; day++)
                        {
                            string tempurl = @"https://www1.nseindia.com/content/historical/EQUITIES" + "/" + year + "/" + month + "/";

                            if (this.ExclueSaturday_Sunday(year, count, day)) 
                                continue;


                            if (this.ExtractRequesttillToday(year, count, day))
                                break;




                            string twodigitdate = day.ToString();
                            if (day.ToString().Length == 1)
                            {
                                twodigitdate = "0" + day;
                            }
                            else
                            {
                                twodigitdate = day.ToString();
                            }
                            string outputfolder = f1_Prefix + twodigitdate + month + year + f1_Suffix;

                            tempurl += outputfolder;
                            string f1 = String.Empty;


                            WebClient webClient = new WebClient();
                            webClient.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
                            webClient.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
                            //string url_Direct = @"https://www1.nseindia.com/content/historical/EQUITIES/2022/JUL/cm20JUL2022bhav.csv.zip";
                            Uri uri_t = new Uri(tempurl);

                            string Outputwithfolder = DumpFolder.Dump_Path + "/" + outputfolder;
                            webClient.DownloadFileAsync(uri_t, Outputwithfolder);
                        }
                        ///<a href="/content/historical/EQUITIES/2022/JUL/cm20JUL2022bhav.csv.zip" target="new">cm20JUL2022bhav.csv.zip</a>
                    }
                    catch (Exception ex)
                    {
                    }
                }

            }

        }
    }

}

