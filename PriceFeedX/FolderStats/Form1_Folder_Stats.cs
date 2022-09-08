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
                treeView1.Nodes.Add("Directory");
                //TreeNode workingNode = root;

                int idx = 1;

                foreach (string file in ListInput)
                {
                    if (file.Contains("NSE_"))
                    {
                        //.\1_Dump_BhavCopy\NSE_2022_08_04
                        string [] files = file.Split(separators, StringSplitOptions.None);
                        this.treeView1.Nodes.Add(files[3]);
                        string dir = DumpFolder.Dump_Path + @"\" + files[3].ToString();
                        LoadSubDirectories(dir, this.treeView1, idx);

                    }
                    idx++;
                }

            }
            catch (Exception ex)
            {
            //TODO
            }

        }


        private void LoadSubDirectories(string dir, TreeView TreeV,int IDX_InsertSubNode)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetFiles(dir, "*.zip");
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(subdirectory);

                    TreeV.Nodes[IDX_InsertSubNode].Nodes.Add(di.Name);
                }
                catch
                {
                    //Failed To add Sub Node iN Main Root
                }


            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                contextMenuStrip1_RightMouse.Show(this, new Point(e.X, e.Y));


            }

            //panel1_lower.ContextMenu = cm;
            //panel1_lower.Show();
        }



     

        //Read All Folder which is Extracted
        private void ExtractedFolder(string InputDirectoryPath, out  List<string>  List_Extracted_BhavCopyFolder)
        {
            List_Extracted_BhavCopyFolder = new List<string>();
            try
            {
                List_Extracted_BhavCopyFolder = Directory.GetDirectories(InputDirectoryPath).Where (f => f.Contains("*.Zip") == false).ToList();

                List<string> List_Zipped_BhavCopyFolder = new List<string>();
                List_Zipped_BhavCopyFolder = Directory.GetDirectories(InputDirectoryPath).Where(f => f.Contains("*.Zip") == true).ToList();

                PopulateDatagridView(List_Extracted_BhavCopyFolder, List_Zipped_BhavCopyFolder);
            }
            catch
            {
                //TODO: Fialed TO Extract all folder
            }

        }

        private void PopulateDatagridView(List<string> ListInput, List<string> ListZippedFOlder)
        {
            try
            {
                dataGridView1_direc.Rows.Clear();
                dataGridView1_direc.DataSource = List2DataTable(ListInput, ListZippedFOlder);
               // dataGridView1_direc.DataSource = ListInput.ToArray();   
            }
            catch
            {
                //TODO: Fialed To Add List TO Dgv
            }

        }

        private DataTable List2DataTable(List<string> ListInput_Extracted , List<string> ListInput_ZippedFolder)
        {
            ListInput_Extracted.Sort();
            ListInput_ZippedFolder.Sort();  

               DataTable dt = new DataTable();
            dt.Columns.Add("Extracted Folder");
            dt.Columns.Add("Zipped Folder");
            string ZippFoilder = "";
           
            try
            {
                for (int i = 0; i < ListInput_Extracted.Count; i++)
                {
                    string folder = ListInput_Extracted[i]; 
                    for(int j =0; j < ListInput_ZippedFolder.Count; j++)
                    {
                        if(folder == ListInput_ZippedFolder[i])
                        {
                            DirectoryInfo diZipp = new DirectoryInfo(ListInput_ZippedFolder[i]);
                            ZippFoilder  = diZipp.Name;
                            break;


                        }

                    }


                    DirectoryInfo di = new DirectoryInfo(ListInput_Extracted[i]);

                    
                    dt.Rows.Add(di.Name, ZippFoilder);


                }

                return dt;
            }
            catch (Exception ex)
            {
                return null;
                    }

        }

        private void ExtractAllfromSelectedDirectory(string DirectoryHeadern,Int32 IndexSelected)
        {
            try
            {
                this.UnzipObj.unziping_Main(IndexSelected);
            }
            catch { }


        }

        private void progressBar1_AutoInsert_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {


            //Parse FUntion Only If Left mouse Button Is Clicked as Input
            if (e.Button == MouseButtons.Left)
            {

                // Get the node at the current mouse pointer location.  
                TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);

                // Set a ToolTip only if the mouse pointer is actually paused on a node.  


                if (theNode != null && theNode.Text.Contains("NSE_"))
                {
                    string dir = DumpFolder.Dump_Path + @"\" + theNode.Text.ToString();

                    TreeNode MyTreeView = (treeView1.SelectedNode);

                    ExtractAllfromSelectedDirectory(dir, theNode.Index);

                    List<string> ListFolder;
                    ExtractedFolder(dir, out ListFolder);


                }
                else     // Pointer is not over a node so clear the ToolTip.  
                {
                    // this.toolTip1.SetToolTip(this.treeView1, "");
                }
            }
        }
    }
}
