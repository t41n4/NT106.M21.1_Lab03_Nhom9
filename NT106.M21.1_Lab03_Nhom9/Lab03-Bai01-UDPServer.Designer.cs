namespace NT106.M21._1_Lab03_Nhom9
{
    partial class Lab03B1UDPServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnB1Listen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerPortB1 = new System.Windows.Forms.TextBox();
            this.messagelist1 = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // btnB1Listen
            // 
            this.btnB1Listen.Location = new System.Drawing.Point(346, 31);
            this.btnB1Listen.Name = "btnB1Listen";
            this.btnB1Listen.Size = new System.Drawing.Size(102, 31);
            this.btnB1Listen.TabIndex = 1;
            this.btnB1Listen.Text = "Listen";
            this.btnB1Listen.UseVisualStyleBackColor = true;
            this.btnB1Listen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Received Message";
            // 
            // ServerPortB1
            // 
            this.ServerPortB1.Location = new System.Drawing.Point(72, 40);
            this.ServerPortB1.Name = "ServerPortB1";
            this.ServerPortB1.Size = new System.Drawing.Size(100, 22);
            this.ServerPortB1.TabIndex = 3;
            // 
            // messagelist1
            // 
            this.messagelist1.HideSelection = false;
            this.messagelist1.Location = new System.Drawing.Point(34, 151);
            this.messagelist1.Name = "messagelist1";
            this.messagelist1.Size = new System.Drawing.Size(400, 191);
            this.messagelist1.TabIndex = 4;
            this.messagelist1.UseCompatibleStateImageBehavior = false;
            this.messagelist1.View = System.Windows.Forms.View.List;
            this.messagelist1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(371, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab03B1UDPServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 381);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.messagelist1);
            this.Controls.Add(this.ServerPortB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnB1Listen);
            this.Controls.Add(this.label1);
            this.Name = "Lab03B1UDPServer";
            this.Text = "UDP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnB1Listen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ServerPortB1;
        private System.Windows.Forms.ListView messagelist1;
        private System.Windows.Forms.Button btnExit;
    }
}