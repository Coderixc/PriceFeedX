namespace PriceFeedX
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3_LOAD_BHAVCOPY_TOPXX = new System.Windows.Forms.Panel();
            this.Label_BHAVCOPYPATH = new System.Windows.Forms.Label();
            this.textBox1_Load_BhavCopy_NSE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3_LOAD_BHAVCOPY_TOPXX.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(10, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 187);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Location = new System.Drawing.Point(10, 267);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 187);
            this.panel2.TabIndex = 1;
            // 
            // panel3_LOAD_BHAVCOPY_TOPXX
            // 
            this.panel3_LOAD_BHAVCOPY_TOPXX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3_LOAD_BHAVCOPY_TOPXX.Controls.Add(this.label1);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Controls.Add(this.button1);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Controls.Add(this.textBox1_Load_BhavCopy_NSE);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Controls.Add(this.Label_BHAVCOPYPATH);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Location = new System.Drawing.Point(13, 466);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Margin = new System.Windows.Forms.Padding(2);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Name = "panel3_LOAD_BHAVCOPY_TOPXX";
            this.panel3_LOAD_BHAVCOPY_TOPXX.Size = new System.Drawing.Size(787, 187);
            this.panel3_LOAD_BHAVCOPY_TOPXX.TabIndex = 2;
            // 
            // Label_BHAVCOPYPATH
            // 
            this.Label_BHAVCOPYPATH.AutoSize = true;
            this.Label_BHAVCOPYPATH.Location = new System.Drawing.Point(19, 21);
            this.Label_BHAVCOPYPATH.Name = "Label_BHAVCOPYPATH";
            this.Label_BHAVCOPYPATH.Size = new System.Drawing.Size(101, 13);
            this.Label_BHAVCOPYPATH.TabIndex = 0;
            this.Label_BHAVCOPYPATH.Text = "NSE TOP 200 LIST";
            // 
            // textBox1_Load_BhavCopy_NSE
            // 
            this.textBox1_Load_BhavCopy_NSE.Location = new System.Drawing.Point(148, 18);
            this.textBox1_Load_BhavCopy_NSE.Name = "textBox1_Load_BhavCopy_NSE";
            this.textBox1_Load_BhavCopy_NSE.Size = new System.Drawing.Size(499, 20);
            this.textBox1_Load_BhavCopy_NSE.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 20);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "* Press Enter to load text file from location(ind_nifty200list_xx.csv)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 670);
            this.Controls.Add(this.panel3_LOAD_BHAVCOPY_TOPXX);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3_LOAD_BHAVCOPY_TOPXX.ResumeLayout(false);
            this.panel3_LOAD_BHAVCOPY_TOPXX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3_LOAD_BHAVCOPY_TOPXX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_Load_BhavCopy_NSE;
        private System.Windows.Forms.Label Label_BHAVCOPYPATH;
    }
}

