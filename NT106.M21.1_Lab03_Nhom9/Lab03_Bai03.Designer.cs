
namespace NT106.M21._1_Lab03_Nhom9
{
    partial class FormBai3
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
            this.OpenTCPServer = new System.Windows.Forms.Button();
            this.OpenClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenTCPServer
            // 
            this.OpenTCPServer.Location = new System.Drawing.Point(16, 33);
            this.OpenTCPServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenTCPServer.Name = "OpenTCPServer";
            this.OpenTCPServer.Size = new System.Drawing.Size(248, 28);
            this.OpenTCPServer.TabIndex = 0;
            this.OpenTCPServer.Text = "Open TCP Server";
            this.OpenTCPServer.UseVisualStyleBackColor = true;
            this.OpenTCPServer.Click += new System.EventHandler(this.OpenTCPServer_Click);
            // 
            // OpenClient
            // 
            this.OpenClient.Location = new System.Drawing.Point(16, 85);
            this.OpenClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenClient.Name = "OpenClient";
            this.OpenClient.Size = new System.Drawing.Size(248, 28);
            this.OpenClient.TabIndex = 1;
            this.OpenClient.Text = "Open new TCP Client";
            this.OpenClient.UseVisualStyleBackColor = true;
            this.OpenClient.Click += new System.EventHandler(this.OpenClient_Click);
            // 
            // FormBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 143);
            this.Controls.Add(this.OpenClient);
            this.Controls.Add(this.OpenTCPServer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBai3";
            this.Text = "Lab03-Bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenTCPServer;
        private System.Windows.Forms.Button OpenClient;
    }
}