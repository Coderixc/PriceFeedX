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
using PriceFeedX.LoadSymbolFromFiles;

namespace PriceFeedX.FolderStats
{
    public partial class Form1_Folder_Stats : Form
    {

        UnzippingFunc UnzipObj;
        string[] separators = { "\\", "." };
        private ReadFileFromNSE_EQUITY readFileFromNSE_EQUITY;
        private List<string> List_Symbol;


        private int X_Note_loc = 0;
        private int Y_Note_loc = 0; 

        private int Max_date = 0;   


        public Form1_Folder_Stats(List<string> List_Symbol,string Max_BhavCopyDate)
        {
            InitializeComponent();

            _main(List_Symbol, Max_BhavCopyDate);
        }

        //Partial Main
        //1. Load All folder in Current Directory
        //2. Locate Path in GUi if Required
        public  void _main(List<string> ListSymbol, string Max_BhavCopyDate)
        {
            try
            {
                this.Max_date = Convert.ToInt32(Max_BhavCopyDate);
            }
            catch (Exception ex)
            {
                this.Max_date = 0;  
            }

            UnzipObj = new UnzippingFunc();
            Locate_Directory();

            this.List_Symbol = new List<string>();
            this.List_Symbol = ListSymbol;//Copy

        }

        private void Locate_Directory()
        {

            List<string> ListRootFolderList;
            this.UnzipObj.Glob(out ListRootFolderList);
            AddListToTreeNode(ListRootFolderList);

        }


        private void Refresh()
        {
            this.Locate_Directory();
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

                this.X_Note_loc = e.X;
                this.Y_Note_loc= e.Y;

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
                List_Extracted_BhavCopyFolder = Directory.GetDirectories(InputDirectoryPath).Where (f => f.Contains("cm") == true).ToList();


                List<string> List_Zipped_BhavCopyFolder = new List<string>();
                List_Zipped_BhavCopyFolder = Directory.GetFiles(InputDirectoryPath, "*.zip").ToList();

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

                //dataGridView1_direc.Rows.Clear();
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
            string ZippFoilder1 = "";
            string ZippFoilder2 = "";

            bool Lock_Diplay_as_left_out = false;

            try
            {
                for (int i = 0; i < ListInput_Extracted.Count; i++)
                {
                    string folder = ListInput_Extracted[i];

                    DirectoryInfo diZipp1 = new DirectoryInfo(ListInput_Extracted[i]);
                    ZippFoilder1 = diZipp1.Name.Replace("_", "") + ".zip";
                        ;



                    for (int j =0; j < ListInput_ZippedFolder.Count; j++)
                    {
                        DirectoryInfo diZipp2 = new DirectoryInfo(ListInput_ZippedFolder[j]);
                        ZippFoilder2 = diZipp2.Name;

                        if (ZippFoilder1 == ZippFoilder2)
                        {
                            DirectoryInfo diZipp = new DirectoryInfo(ListInput_ZippedFolder[j]);
                            ZippFoilder  = diZipp.Name;

                            Lock_Diplay_as_left_out = true; 
                            break;


                        }

                    }


                    DirectoryInfo di = new DirectoryInfo(ListInput_Extracted[i]);

                    if(Lock_Diplay_as_left_out == true)
                    {
                        dt.Rows.Add(di.Name, ZippFoilder);
                        Lock_Diplay_as_left_out = false;    
                    }
                    else
                    {
                        dt.Rows.Add(di.Name, "NA");
                    }
                    



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

        private void insertToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the node at the current mouse pointer location.  
                TreeNode theNode = this.treeView1.GetNodeAt( X_Note_loc,Y_Note_loc);

                // Set a ToolTip only if the mouse pointer is actually paused on a node.  


                if (theNode != null && theNode.Text.Contains("NSE_"))
                {
                    string dir = DumpFolder.Dump_Path + @"\" + theNode.Text.ToString();

                    TreeNode MyTreeView = (treeView1.SelectedNode);

                    

                    List<string> ListFolder;
                    ExtractedFolder(dir, out ListFolder);


                    for(int i = 0; i < ListFolder.Count;i++)
                    {
                        int max_date = 0;

                        try
                        {
                            string path = ListFolder[i].ToString();
                            string[] files = Directory.GetFiles(path);

                            //Read Bhav Copy Data

                            //".\\1_Dump_BhavCopy\\NSE_2022_09_12\\cm_01APR2022bhav.csv\\cm01APR2022bhav.csv"

                            for (int folderidx = 0; folderidx < files.Length; folderidx++)
                            {
                                try
                                {
                                    string[] data = files[folderidx].Split(separators, StringSplitOptions.None);
                                    //string[] data1 = data[4].Split(new char[] { '_', '.' });
                                    string[] data1 = data[4].Replace("cm","").Split(new char[] { '.' });
                                    string aidate = data1[0].Substring(0, 9);
                                    string dt = DateTime.ParseExact(aidate, "ddMMMyyyy", null).ToString("yyyyMMdd");

                                    max_date = Convert.ToInt32(dt);

                                }
                                catch
                                {
                                    //TODO
                                }
                                if (max_date > this.Max_date)
                                {
                                    this.AutoInsertBhavCopyToDB(files[folderidx]);

                                    MessageBox.Show($"Bhav Copy {max_date} Price inserted to DB ");

                                }
                                else
                                {
                                    //TODO: ADD Confirmatioin Signal to GUI
                                }


                            }

                        }
                        catch
                        {

                        }

                    }

                }
                else     // Pointer is not over a node so clear the ToolTip.  
                {
                    // this.toolTip1.SetToolTip(this.treeView1, "");
                }


            }
            catch
            {

            }
        }

        private void AutoInsertBhavCopyToDB(string Path, bool Automatic = true)
        {
            try
            {
                this.readFileFromNSE_EQUITY = new ReadFileFromNSE_EQUITY(Path, "0", true);
                if (!this.readFileFromNSE_EQUITY.STARTPROCESS_BHAVCOPY(this.List_Symbol , Automatic))
                {
                    MessageBox.Show("Failed To load  file from csv");
                }
            }
            catch
            {

            }
            finally
            {
                this.readFileFromNSE_EQUITY = null;
            }



        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeNode theNode = this.treeView1.GetNodeAt(X_Note_loc, Y_Note_loc);

            try
            {
               this.UnzipObj.unziping_Main(theNode.Index-1);
            }
            catch { }

            finally
            {
                MessageBox.Show($"Extract all Process Finshed for Seleted Node {theNode.Text}");

            }




        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {



                // Get the node at the current mouse pointer location.  
                TreeNode theNode = this.treeView1.GetNodeAt(X_Note_loc, Y_Note_loc);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.  

            try
            {

                if (theNode != null && theNode.Text.Contains("NSE_"))
                {
                    string dir = DumpFolder.Dump_Path + @"\" + theNode.Text.ToString();

                    Directory.Delete(dir,true);




                }
                else     // Pointer is not over a node so clear the ToolTip.  
                {
                    // this.toolTip1.SetToolTip(this.treeView1, "");
                }
            }
            catch {
            //TODO
            }
            finally
            {
                X_Note_loc = -2; Y_Note_loc = -2;

                //REFRSH GUI
                
                while (this.dataGridView1_direc.Rows.Count > 1)
                {
                    this.dataGridView1_direc.Rows.RemoveAt(0);
                }
                this.treeView1.Nodes.Clear();

                this.Refresh();
            }

        


        }
    }
}
