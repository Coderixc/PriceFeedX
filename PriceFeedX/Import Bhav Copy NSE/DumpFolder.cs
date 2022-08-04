using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PriceFeedX.Import_Bhav_Copy_NSE
{
    internal class DumpFolder
    {

        public const string Dump_Path = @".\1_Dump_BhavCopy";
        public const string Dump_Buffer_Path = @"\2_Buffer";

        public string m_DatewiseFolder = String.Empty;

        public DumpFolder()
        {
 
            try
            {
                this.m_DatewiseFolder = Dump_Path;

                string localdate = DateTime.Now.ToString("yyyy_MM_dd");
                this.m_DatewiseFolder += @"\"+"NSE_" + localdate;
            }
            catch (Exception ex)
            {
                //TODO:
            }

            this.IsDumpFolderExist();


        }
        private void IsDumpFolderExist()
        {
            try
            {



                if (!Directory.Exists(Dump_Buffer_Path))
                {
                    Directory.CreateDirectory(Dump_Buffer_Path);
                    //TODO
                }



                if (!Directory.Exists(Dump_Path + Dump_Buffer_Path))
                {
                    Directory.CreateDirectory(Dump_Path + Dump_Buffer_Path);
                    //TODO
                }

                //Create local process date on local directory
                //Maintaining Previous Transaction Details

                

                if(!Directory.Exists(this.m_DatewiseFolder))
                {
                    Directory.CreateDirectory(this.m_DatewiseFolder);
                }

            }
            catch (Exception ex)
            {
            }
        }
    }
}
