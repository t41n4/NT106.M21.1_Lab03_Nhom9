namespace NT106.M21._1_Lab03_Nhom9
{
    partial class Lab03_Bai3_TcpServer
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
            this.btnListen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(386, 12);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 1;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(443, 277);
            this.listBox1.TabIndex = 2;
            // 
            // Lab03_Bai3_TcpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 371);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListen);
            this.Name = "Lab03_Bai3_TcpServer";
            this.Text = "Lab03_Bai3_TcpServer";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ListBox listBox1;
    }
}