namespace AlstomApp
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
            this.project_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gyariszam_TB = new System.Windows.Forms.TextBox();
            this.cikkszam_TB = new System.Windows.Forms.TextBox();
            this.wbs_TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.megrendeles_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.so_TB = new System.Windows.Forms.TextBox();
            this.excelSearch_BT = new System.Windows.Forms.Button();
            this.search_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // project_TB
            // 
            this.project_TB.Location = new System.Drawing.Point(12, 38);
            this.project_TB.Name = "project_TB";
            this.project_TB.Size = new System.Drawing.Size(288, 22);
            this.project_TB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Projekt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gyáriszám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cikkszám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "WBS";
            // 
            // gyariszam_TB
            // 
            this.gyariszam_TB.Location = new System.Drawing.Point(15, 91);
            this.gyariszam_TB.Name = "gyariszam_TB";
            this.gyariszam_TB.Size = new System.Drawing.Size(288, 22);
            this.gyariszam_TB.TabIndex = 5;
            // 
            // cikkszam_TB
            // 
            this.cikkszam_TB.Location = new System.Drawing.Point(15, 146);
            this.cikkszam_TB.Name = "cikkszam_TB";
            this.cikkszam_TB.Size = new System.Drawing.Size(288, 22);
            this.cikkszam_TB.TabIndex = 6;
            // 
            // wbs_TB
            // 
            this.wbs_TB.Location = new System.Drawing.Point(15, 199);
            this.wbs_TB.Name = "wbs_TB";
            this.wbs_TB.Size = new System.Drawing.Size(288, 22);
            this.wbs_TB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Megrendelés";
            // 
            // megrendeles_TB
            // 
            this.megrendeles_TB.Location = new System.Drawing.Point(15, 253);
            this.megrendeles_TB.Name = "megrendeles_TB";
            this.megrendeles_TB.Size = new System.Drawing.Size(288, 22);
            this.megrendeles_TB.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "SÓ";
            // 
            // so_TB
            // 
            this.so_TB.Location = new System.Drawing.Point(15, 310);
            this.so_TB.Name = "so_TB";
            this.so_TB.Size = new System.Drawing.Size(288, 22);
            this.so_TB.TabIndex = 11;
            // 
            // excelSearch_BT
            // 
            this.excelSearch_BT.Location = new System.Drawing.Point(15, 349);
            this.excelSearch_BT.Name = "excelSearch_BT";
            this.excelSearch_BT.Size = new System.Drawing.Size(285, 23);
            this.excelSearch_BT.TabIndex = 12;
            this.excelSearch_BT.Text = "Excel Munkalap Megnyitás";
            this.excelSearch_BT.UseVisualStyleBackColor = true;
            this.excelSearch_BT.Click += new System.EventHandler(this.search_BT_Click);
            // 
            // search_BT
            // 
            this.search_BT.Location = new System.Drawing.Point(18, 415);
            this.search_BT.Name = "search_BT";
            this.search_BT.Size = new System.Drawing.Size(285, 23);
            this.search_BT.TabIndex = 13;
            this.search_BT.Text = "Keresés Gyáriszám alapján";
            this.search_BT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 450);
            this.Controls.Add(this.search_BT);
            this.Controls.Add(this.excelSearch_BT);
            this.Controls.Add(this.so_TB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.megrendeles_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wbs_TB);
            this.Controls.Add(this.cikkszam_TB);
            this.Controls.Add(this.gyariszam_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.project_TB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox project_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gyariszam_TB;
        private System.Windows.Forms.TextBox cikkszam_TB;
        private System.Windows.Forms.TextBox wbs_TB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox megrendeles_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox so_TB;
        private System.Windows.Forms.Button excelSearch_BT;
        private System.Windows.Forms.Button search_BT;
    }
}

