namespace PriceFeedX.FolderStats
{
    partial class Form1_Folder_Stats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1_lower = new System.Windows.Forms.Panel();
            this.panel1_upper = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2_Progress = new System.Windows.Forms.Panel();
            this.progressBar1_AutoInsert = new System.Windows.Forms.ProgressBar();
            this.listBox1_AutoInsert = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1_FileProperties = new System.Windows.Forms.Panel();
            this.dataGridView1_direc = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1_RightMouse = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1_lower.SuspendLayout();
            this.panel1_upper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2_Progress.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel1_FileProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_direc)).BeginInit();
            this.contextMenuStrip1_RightMouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_lower
            // 
            this.panel1_lower.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1_lower.Controls.Add(this.panel1_upper);
            this.panel1_lower.Location = new System.Drawing.Point(6, 6);
            this.panel1_lower.Name = "panel1_lower";
            this.panel1_lower.Size = new System.Drawing.Size(676, 410);
            this.panel1_lower.TabIndex = 0;
            // 
            // panel1_upper
            // 
            this.panel1_upper.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1_upper.Controls.Add(this.splitContainer1);
            this.panel1_upper.Location = new System.Drawing.Point(5, 8);
            this.panel1_upper.Name = "panel1_upper";
            this.panel1_upper.Size = new System.Drawing.Size(657, 314);
            this.panel1_upper.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2_Progress);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1_FileProperties);
            this.splitContainer1.Size = new System.Drawing.Size(657, 314);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Tai Le", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(217, 314);
            this.treeView1.TabIndex = 0;
            this.treeView1.Tag = "Items";
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // panel2_Progress
            // 
            this.panel2_Progress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2_Progress.Controls.Add(this.progressBar1_AutoInsert);
            this.panel2_Progress.Controls.Add(this.listBox1_AutoInsert);
            this.panel2_Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2_Progress.Location = new System.Drawing.Point(3, 126);
            this.panel2_Progress.Name = "panel2_Progress";
            this.panel2_Progress.Size = new System.Drawing.Size(320, 124);
            this.panel2_Progress.TabIndex = 2;
            this.panel2_Progress.UseWaitCursor = true;
            // 
            // progressBar1_AutoInsert
            // 
            this.progressBar1_AutoInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1_AutoInsert.Location = new System.Drawing.Point(3, 111);
            this.progressBar1_AutoInsert.Name = "progressBar1_AutoInsert";
            this.progressBar1_AutoInsert.Size = new System.Drawing.Size(314, 10);
            this.progressBar1_AutoInsert.TabIndex = 2;
            this.progressBar1_AutoInsert.UseWaitCursor = true;
            // 
            // listBox1_AutoInsert
            // 
            this.listBox1_AutoInsert.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1_AutoInsert.FormattingEnabled = true;
            this.listBox1_AutoInsert.ItemHeight = 12;
            this.listBox1_AutoInsert.Location = new System.Drawing.Point(3, 4);
            this.listBox1_AutoInsert.Name = "listBox1_AutoInsert";
            this.listBox1_AutoInsert.Size = new System.Drawing.Size(314, 88);
            this.listBox1_AutoInsert.TabIndex = 0;
            this.listBox1_AutoInsert.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 55);
            this.panel1.TabIndex = 1;
            this.panel1.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Auto Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // panel1_FileProperties
            // 
            this.panel1_FileProperties.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1_FileProperties.Controls.Add(this.dataGridView1_direc);
            this.panel1_FileProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1_FileProperties.Location = new System.Drawing.Point(3, 5);
            this.panel1_FileProperties.Name = "panel1_FileProperties";
            this.panel1_FileProperties.Size = new System.Drawing.Size(320, 117);
            this.panel1_FileProperties.TabIndex = 0;
            // 
            // dataGridView1_direc
            // 
            this.dataGridView1_direc.AllowUserToOrderColumns = true;
            this.dataGridView1_direc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_direc.Location = new System.Drawing.Point(17, 14);
            this.dataGridView1_direc.Name = "dataGridView1_direc";
            this.dataGridView1_direc.RowHeadersVisible = false;
            this.dataGridView1_direc.RowHeadersWidth = 62;
            this.dataGridView1_direc.Size = new System.Drawing.Size(288, 90);
            this.dataGridView1_direc.TabIndex = 0;
            // 
            // contextMenuStrip1_RightMouse
            // 
            this.contextMenuStrip1_RightMouse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.contextMenuStrip1_RightMouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip1_RightMouse.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1_RightMouse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.insertToDBToolStripMenuItem});
            this.contextMenuStrip1_RightMouse.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1_RightMouse.Name = "contextMenuStrip1_RightMouse";
            this.contextMenuStrip1_RightMouse.Size = new System.Drawing.Size(181, 70);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // insertToDBToolStripMenuItem
            // 
            this.insertToDBToolStripMenuItem.Name = "insertToDBToolStripMenuItem";
            this.insertToDBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertToDBToolStripMenuItem.Text = "InsertToDB";
            // 
            // Form1_Folder_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 417);
            this.Controls.Add(this.panel1_lower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1_Folder_Stats";
            this.Tag = "Tree View Panel";
            this.Text = "Bhav Copy Directory";
            this.panel1_lower.ResumeLayout(false);
            this.panel1_upper.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2_Progress.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1_FileProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_direc)).EndInit();
            this.contextMenuStrip1_RightMouse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_lower;
        private System.Windows.Forms.Panel panel1_upper;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1_FileProperties;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2_Progress;
        private System.Windows.Forms.ListBox listBox1_AutoInsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1_AutoInsert;
        private System.Windows.Forms.DataGridView dataGridView1_direc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1_RightMouse;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToDBToolStripMenuItem;
    }
}