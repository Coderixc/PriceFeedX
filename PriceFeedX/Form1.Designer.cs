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
            this.panel2_BHavCopyPanel = new System.Windows.Forms.Panel();
            this.textBox1_BhavCopyLast5Date = new System.Windows.Forms.TextBox();
            this.label6_Last5PrevPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1_BHAVCOPY_EQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3_LOAD_BHAVCOPY_TOPXX = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1_Nse_TOP_XX_LIST = new System.Windows.Forms.TextBox();
            this.Label_BHAVCOPYPATH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2_BHavCopyPanel.SuspendLayout();
            this.panel3_LOAD_BHAVCOPY_TOPXX.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2_BHavCopyPanel
            // 
            this.panel2_BHavCopyPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2_BHavCopyPanel.Controls.Add(this.textBox1_BhavCopyLast5Date);
            this.panel2_BHavCopyPanel.Controls.Add(this.label6_Last5PrevPrice);
            this.panel2_BHavCopyPanel.Controls.Add(this.label3);
            this.panel2_BHavCopyPanel.Controls.Add(this.button2);
            this.panel2_BHavCopyPanel.Controls.Add(this.textBox1_BHAVCOPY_EQ);
            this.panel2_BHavCopyPanel.Controls.Add(this.label2);
            this.panel2_BHavCopyPanel.Location = new System.Drawing.Point(0, 69);
            this.panel2_BHavCopyPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2_BHavCopyPanel.Name = "panel2_BHavCopyPanel";
            this.panel2_BHavCopyPanel.Size = new System.Drawing.Size(1060, 180);
            this.panel2_BHavCopyPanel.TabIndex = 1;
            // 
            // textBox1_BhavCopyLast5Date
            // 
            this.textBox1_BhavCopyLast5Date.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1_BhavCopyLast5Date.Location = new System.Drawing.Point(197, 129);
            this.textBox1_BhavCopyLast5Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1_BhavCopyLast5Date.Name = "textBox1_BhavCopyLast5Date";
            this.textBox1_BhavCopyLast5Date.Size = new System.Drawing.Size(836, 22);
            this.textBox1_BhavCopyLast5Date.TabIndex = 5;
            this.textBox1_BhavCopyLast5Date.Text = "BhavCopyDate";
            // 
            // label6_Last5PrevPrice
            // 
            this.label6_Last5PrevPrice.AutoSize = true;
            this.label6_Last5PrevPrice.Location = new System.Drawing.Point(24, 133);
            this.label6_Last5PrevPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6_Last5PrevPrice.Name = "label6_Last5PrevPrice";
            this.label6_Last5PrevPrice.Size = new System.Drawing.Size(104, 16);
            this.label6_Last5PrevPrice.TabIndex = 4;
            this.label6_Last5PrevPrice.Text = "Last 5 Prev Day:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "* Press Enter to load text files from Location(Equity csv file)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(947, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1_BHAVCOPY_EQ
            // 
            this.textBox1_BHAVCOPY_EQ.Location = new System.Drawing.Point(201, 34);
            this.textBox1_BHAVCOPY_EQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1_BHAVCOPY_EQ.Name = "textBox1_BHAVCOPY_EQ";
            this.textBox1_BHAVCOPY_EQ.Size = new System.Drawing.Size(724, 22);
            this.textBox1_BHAVCOPY_EQ.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "BHAV COPY NSE EQ(.csv)";
            // 
            // panel3_LOAD_BHAVCOPY_TOPXX
            // 
            this.panel3_LOAD_BHAVCOPY_TOPXX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3_LOAD_BHAVCOPY_TOPXX.Controls.Add(this.label1);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Controls.Add(this.button1);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Controls.Add(this.textBox1_Nse_TOP_XX_LIST);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Controls.Add(this.Label_BHAVCOPYPATH);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Location = new System.Drawing.Point(0, 254);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3_LOAD_BHAVCOPY_TOPXX.Name = "panel3_LOAD_BHAVCOPY_TOPXX";
            this.panel3_LOAD_BHAVCOPY_TOPXX.Size = new System.Drawing.Size(1060, 119);
            this.panel3_LOAD_BHAVCOPY_TOPXX.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "* Press Enter to load text file from location(ind_nifty200list_xx.csv)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(945, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_Nse_TOP_XX_LIST
            // 
            this.textBox1_Nse_TOP_XX_LIST.Location = new System.Drawing.Point(197, 22);
            this.textBox1_Nse_TOP_XX_LIST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1_Nse_TOP_XX_LIST.Name = "textBox1_Nse_TOP_XX_LIST";
            this.textBox1_Nse_TOP_XX_LIST.Size = new System.Drawing.Size(727, 22);
            this.textBox1_Nse_TOP_XX_LIST.TabIndex = 1;
            // 
            // Label_BHAVCOPYPATH
            // 
            this.Label_BHAVCOPYPATH.AutoSize = true;
            this.Label_BHAVCOPYPATH.Location = new System.Drawing.Point(4, 26);
            this.Label_BHAVCOPYPATH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_BHAVCOPYPATH.Name = "Label_BHAVCOPYPATH";
            this.Label_BHAVCOPYPATH.Size = new System.Drawing.Size(121, 16);
            this.Label_BHAVCOPYPATH.TabIndex = 0;
            this.Label_BHAVCOPYPATH.Text = "NSE TOP 200 LIST";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 59);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "NSE BHAV COPY TOOL 1.0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3_LOAD_BHAVCOPY_TOPXX);
            this.Controls.Add(this.panel2_BHavCopyPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "NSE BHAV COPY 1.0.1";
            this.panel2_BHavCopyPanel.ResumeLayout(false);
            this.panel2_BHavCopyPanel.PerformLayout();
            this.panel3_LOAD_BHAVCOPY_TOPXX.ResumeLayout(false);
            this.panel3_LOAD_BHAVCOPY_TOPXX.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2_BHavCopyPanel;
        private System.Windows.Forms.Panel panel3_LOAD_BHAVCOPY_TOPXX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1_Nse_TOP_XX_LIST;
        private System.Windows.Forms.Label Label_BHAVCOPYPATH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1_BHAVCOPY_EQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6_Last5PrevPrice;
        private System.Windows.Forms.TextBox textBox1_BhavCopyLast5Date;
    }
}

