﻿namespace PriceFeedX.FolderStats
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
            this.panel1_lower = new System.Windows.Forms.Panel();
            this.panel1_upper = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1_FileProperties = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2_Progress = new System.Windows.Forms.Panel();
            this.listBox1_AutoInsert = new System.Windows.Forms.ListBox();
            this.progressBar1_AutoInsert = new System.Windows.Forms.ProgressBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1_lower.SuspendLayout();
            this.panel1_upper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel1_FileProperties.SuspendLayout();
            this.panel2_Progress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_lower
            // 
            this.panel1_lower.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1_lower.Controls.Add(this.panel1_upper);
            this.panel1_lower.Location = new System.Drawing.Point(1, 6);
            this.panel1_lower.Name = "panel1_lower";
            this.panel1_lower.Size = new System.Drawing.Size(674, 331);
            this.panel1_lower.TabIndex = 0;
            this.panel1_lower.UseWaitCursor = true;
            // 
            // panel1_upper
            // 
            this.panel1_upper.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1_upper.Controls.Add(this.splitContainer1);
            this.panel1_upper.Location = new System.Drawing.Point(173, 8);
            this.panel1_upper.Name = "panel1_upper";
            this.panel1_upper.Size = new System.Drawing.Size(495, 314);
            this.panel1_upper.TabIndex = 0;
            this.panel1_upper.UseWaitCursor = true;
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
            this.splitContainer1.Size = new System.Drawing.Size(495, 314);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Tai Le", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(159, 308);
            this.treeView1.TabIndex = 0;
            this.treeView1.Tag = "Items";
            this.treeView1.UseWaitCursor = true;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(3, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 55);
            this.panel1.TabIndex = 1;
            // 
            // panel1_FileProperties
            // 
            this.panel1_FileProperties.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1_FileProperties.Controls.Add(this.dataGridView1);
            this.panel1_FileProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1_FileProperties.Location = new System.Drawing.Point(3, 5);
            this.panel1_FileProperties.Name = "panel1_FileProperties";
            this.panel1_FileProperties.Size = new System.Drawing.Size(320, 117);
            this.panel1_FileProperties.TabIndex = 0;
            this.panel1_FileProperties.UseWaitCursor = true;
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
            // 
            // listBox1_AutoInsert
            // 
            this.listBox1_AutoInsert.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBox1_AutoInsert.FormattingEnabled = true;
            this.listBox1_AutoInsert.ItemHeight = 12;
            this.listBox1_AutoInsert.Location = new System.Drawing.Point(3, 4);
            this.listBox1_AutoInsert.Name = "listBox1_AutoInsert";
            this.listBox1_AutoInsert.Size = new System.Drawing.Size(314, 100);
            this.listBox1_AutoInsert.TabIndex = 0;
            // 
            // progressBar1_AutoInsert
            // 
            this.progressBar1_AutoInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar1_AutoInsert.Location = new System.Drawing.Point(3, 111);
            this.progressBar1_AutoInsert.Name = "progressBar1_AutoInsert";
            this.progressBar1_AutoInsert.Size = new System.Drawing.Size(314, 10);
            this.progressBar1_AutoInsert.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 90);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1_Folder_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 338);
            this.Controls.Add(this.panel1_lower);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1_Folder_Stats";
            this.Tag = "Tree View Panel";
            this.Text = "Form1_Folder_Stats";
            this.panel1_lower.ResumeLayout(false);
            this.panel1_upper.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1_FileProperties.ResumeLayout(false);
            this.panel2_Progress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}