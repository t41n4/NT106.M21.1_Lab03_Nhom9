
namespace NT106.M21._1_Lab03_Nhom9
{
    partial class Control
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
            this.btnBai01 = new System.Windows.Forms.Button();
            this.btnBai02 = new System.Windows.Forms.Button();
            this.FormControl = new System.Windows.Forms.Button();
            this.btnBai03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBai01
            // 
            this.btnBai01.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai01.Location = new System.Drawing.Point(79, 30);
            this.btnBai01.Name = "btnBai01";
            this.btnBai01.Size = new System.Drawing.Size(142, 47);
            this.btnBai01.TabIndex = 0;
            this.btnBai01.Text = "Bài 01";
            this.btnBai01.UseVisualStyleBackColor = true;
            this.btnBai01.Click += new System.EventHandler(this.btnBai01_Click);
            // 
            // btnBai02
            // 
            this.btnBai02.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai02.Location = new System.Drawing.Point(79, 83);
            this.btnBai02.Name = "btnBai02";
            this.btnBai02.Size = new System.Drawing.Size(142, 47);
            this.btnBai02.TabIndex = 1;
            this.btnBai02.Text = "Bài 02";
            this.btnBai02.UseVisualStyleBackColor = true;
            this.btnBai02.Click += new System.EventHandler(this.btnBai02_Click);
            // 
            // FormControl
            // 
            this.FormControl.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormControl.Location = new System.Drawing.Point(79, 189);
            this.FormControl.Name = "FormControl";
            this.FormControl.Size = new System.Drawing.Size(142, 47);
            this.FormControl.TabIndex = 3;
            this.FormControl.Text = "Bài 04";
            this.FormControl.UseVisualStyleBackColor = true;
            this.FormControl.Click += new System.EventHandler(this.btnBai04_Click);
            // 
            // btnBai03
            // 
            this.btnBai03.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai03.Location = new System.Drawing.Point(79, 136);
            this.btnBai03.Name = "btnBai03";
            this.btnBai03.Size = new System.Drawing.Size(142, 47);
            this.btnBai03.TabIndex = 2;
            this.btnBai03.Text = "Bài 03";
            this.btnBai03.UseVisualStyleBackColor = true;
            this.btnBai03.Click += new System.EventHandler(this.btnBai03_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 278);
            this.Controls.Add(this.FormControl);
            this.Controls.Add(this.btnBai03);
            this.Controls.Add(this.btnBai02);
            this.Controls.Add(this.btnBai01);
            this.Name = "Control";
            this.Text = "Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBai01;
        private System.Windows.Forms.Button btnBai02;
        private System.Windows.Forms.Button FormControl;
        private System.Windows.Forms.Button btnBai03;
    }
}