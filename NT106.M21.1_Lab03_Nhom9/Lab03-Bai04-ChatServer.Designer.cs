
namespace NT106.M21._1_Lab03_Nhom9
{
    partial class Lab03_Bai04_ChatServer
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
            this.btnB4Listen = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListView();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Log";
            // 
            // btnB4Listen
            // 
            this.btnB4Listen.Location = new System.Drawing.Point(321, 27);
            this.btnB4Listen.Name = "btnB4Listen";
            this.btnB4Listen.Size = new System.Drawing.Size(107, 33);
            this.btnB4Listen.TabIndex = 2;
            this.btnB4Listen.Text = "Listen";
            this.btnB4Listen.UseVisualStyleBackColor = true;
            this.btnB4Listen.Click += new System.EventHandler(this.btnB4Listen_Click);
            // 
            // listLog
            // 
            this.listLog.Enabled = false;
            this.listLog.HideSelection = false;
            this.listLog.Location = new System.Drawing.Point(12, 75);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(429, 321);
            this.listLog.TabIndex = 3;
            this.listLog.UseCompatibleStateImageBehavior = false;
            this.listLog.View = System.Windows.Forms.View.List;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(208, 27);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(107, 33);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop Listen";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Lab03_Bai04_ChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 408);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.btnB4Listen);
            this.Controls.Add(this.label1);
            this.Name = "Lab03_Bai04_ChatServer";
            this.Text = "Lab03_Bai04_ChatServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lab03_Bai04_ChatServer_FormClosing);
            this.Load += new System.EventHandler(this.Lab03_Bai04_ChatServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnB4Listen;
        private System.Windows.Forms.ListView listLog;
        private System.Windows.Forms.Button btnStop;
    }
}