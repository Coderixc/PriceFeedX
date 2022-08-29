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
            this.panel1_lower = new System.Windows.Forms.Panel();
            this.panel1_upper = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1_FileProperties = new System.Windows.Forms.Panel();
            this.panel1_lower.SuspendLayout();
            this.panel1_upper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_lower
            // 
            this.panel1_lower.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1_lower.Controls.Add(this.panel1_upper);
            this.panel1_lower.Location = new System.Drawing.Point(75, 107);
            this.panel1_lower.Name = "panel1_lower";
            this.panel1_lower.Size = new System.Drawing.Size(674, 331);
            this.panel1_lower.TabIndex = 0;
            // 
            // panel1_upper
            // 
            this.panel1_upper.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1_upper.Controls.Add(this.splitContainer1);
            this.panel1_upper.Location = new System.Drawing.Point(173, 8);
            this.panel1_upper.Name = "panel1_upper";
            this.panel1_upper.Size = new System.Drawing.Size(495, 314);
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
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // panel1_FileProperties
            // 
            this.panel1_FileProperties.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1_FileProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1_FileProperties.Location = new System.Drawing.Point(12, 15);
            this.panel1_FileProperties.Name = "panel1_FileProperties";
            this.panel1_FileProperties.Size = new System.Drawing.Size(300, 97);
            this.panel1_FileProperties.TabIndex = 0;
            // 
            // Form1_Folder_Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.panel1_lower);
            this.Name = "Form1_Folder_Stats";
            this.Text = "Form1_Folder_Stats";
            this.panel1_lower.ResumeLayout(false);
            this.panel1_upper.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_lower;
        private System.Windows.Forms.Panel panel1_upper;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1_FileProperties;
    }
}