using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceFeedX.Import_Bhav_Copy_NSE;
using System.IO;
using  PriceFeedX.Extract_BhavCopy;

namespace PriceFeedX.FolderStats
{
    public partial class Form1_Folder_Stats : Form
    {

        UnzippingFunc UnzipObj;
        string[] separators = { "\\", "." };

        public Form1_Folder_Stats()
        {
            InitializeComponent();

            _main();
        }

        //Partial Main
        //1. Load All folder in Current Directory
        //2. Locate Path in GUi if Required
        public  void _main()
        {
            UnzipObj = new UnzippingFunc();
            Locate_Directory();

        }

        private void Locate_Directory()
        {

            List<string> ListRootFolderList;

            this.UnzipObj.Glob(out ListRootFolderList);
            AddListToTreeNode(ListRootFolderList);

        }

        private void AddListToTreeNode(List<String> ListInput)
        {
            try
            {
                TreeNode root = treeView1.Nodes.Add("Items");
                TreeNode workingNode = root;


                foreach (string file in ListInput)
                {
                    if (file.Contains("NSE_"))
                    {
                        //.\1_Dump_BhavCopy\NSE_2022_08_04


                        string [] files = file.Split(separators, StringSplitOptions.None);    


                        treeView1.Nodes.Add(files[3]);



                        //sub node



                    }
                   // LoadSubDirectories(file, workingNode);


                }



            }
            catch (Exception ex)
            {

            }

        }


        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetFiles(dir, "*.zip");
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {

                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;

                //List<string> List_SubFolder;
                //this.UnzipObj.Glob(out List_SubFolder, dir);


            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
