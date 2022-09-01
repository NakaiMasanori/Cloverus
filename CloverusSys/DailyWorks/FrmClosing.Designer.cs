namespace CloverusSys.DailyWorks
{
    partial class FrmClosing
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
            this.DtpFromDate = new SprCommon.Controls.SprDateTimePicker();
            this.DtpTillDate = new SprCommon.Controls.SprDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChkSalesGeneration = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChkBeforeDocuments = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ChkAfterDocuments = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.LblArert = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "から";
            // 
            // DtpFromDate
            // 
            this.DtpFromDate.Location = new System.Drawing.Point(21, 25);
            this.DtpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpFromDate.Name = "DtpFromDate";
            this.DtpFromDate.Size = new System.Drawing.Size(172, 30);
            this.DtpFromDate.TabIndex = 4;
            this.DtpFromDate.Value = new System.DateTime(2022, 6, 24, 14, 11, 41, 692);
            // 
            // DtpTillDate
            // 
            this.DtpTillDate.Location = new System.Drawing.Point(247, 25);
            this.DtpTillDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpTillDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtpTillDate.Name = "DtpTillDate";
            this.DtpTillDate.Size = new System.Drawing.Size(172, 30);
            this.DtpTillDate.TabIndex = 6;
            this.DtpTillDate.Value = new System.DateTime(2022, 6, 24, 14, 11, 41, 692);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "まで";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.ChkSalesGeneration);
            this.panel1.Location = new System.Drawing.Point(21, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 40);
            this.panel1.TabIndex = 10;
            // 
            // ChkSalesGeneration
            // 
            this.ChkSalesGeneration.AutoSize = true;
            this.ChkSalesGeneration.BackColor = System.Drawing.Color.Navy;
            this.ChkSalesGeneration.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkSalesGeneration.ForeColor = System.Drawing.Color.White;
            this.ChkSalesGeneration.Location = new System.Drawing.Point(8, 6);
            this.ChkSalesGeneration.Name = "ChkSalesGeneration";
            this.ChkSalesGeneration.Size = new System.Drawing.Size(93, 28);
            this.ChkSalesGeneration.TabIndex = 8;
            this.ChkSalesGeneration.Text = "売上生成";
            this.ChkSalesGeneration.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.ChkBeforeDocuments);
            this.panel2.Location = new System.Drawing.Point(21, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 40);
            this.panel2.TabIndex = 11;
            // 
            // ChkBeforeDocuments
            // 
            this.ChkBeforeDocuments.AutoSize = true;
            this.ChkBeforeDocuments.BackColor = System.Drawing.Color.Navy;
            this.ChkBeforeDocuments.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkBeforeDocuments.ForeColor = System.Drawing.Color.White;
            this.ChkBeforeDocuments.Location = new System.Drawing.Point(8, 6);
            this.ChkBeforeDocuments.Name = "ChkBeforeDocuments";
            this.ChkBeforeDocuments.Size = new System.Drawing.Size(157, 28);
            this.ChkBeforeDocuments.TabIndex = 9;
            this.ChkBeforeDocuments.Text = "ルート変更前帳票";
            this.ChkBeforeDocuments.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.ChkAfterDocuments);
            this.panel3.Location = new System.Drawing.Point(21, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 40);
            this.panel3.TabIndex = 12;
            // 
            // ChkAfterDocuments
            // 
            this.ChkAfterDocuments.AutoSize = true;
            this.ChkAfterDocuments.BackColor = System.Drawing.Color.Navy;
            this.ChkAfterDocuments.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ChkAfterDocuments.ForeColor = System.Drawing.Color.White;
            this.ChkAfterDocuments.Location = new System.Drawing.Point(8, 6);
            this.ChkAfterDocuments.Name = "ChkAfterDocuments";
            this.ChkAfterDocuments.Size = new System.Drawing.Size(157, 28);
            this.ChkAfterDocuments.TabIndex = 10;
            this.ChkAfterDocuments.Text = "ルート変更後帳票";
            this.ChkAfterDocuments.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.checkBox4);
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Location = new System.Drawing.Point(197, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 113);
            this.panel4.TabIndex = 13;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 77);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(134, 27);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "ごはん量集計表";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 54);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(179, 27);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "種類別ルート別集計表";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(74, 27);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "カード";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 27);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "配送表";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.checkBox5);
            this.panel5.Controls.Add(this.checkBox6);
            this.panel5.Controls.Add(this.checkBox7);
            this.panel5.Location = new System.Drawing.Point(197, 286);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 90);
            this.panel5.TabIndex = 14;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 53);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(134, 27);
            this.checkBox5.TabIndex = 19;
            this.checkBox5.Text = "たんぱく食一覧";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 30);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(164, 27);
            this.checkBox6.TabIndex = 18;
            this.checkBox6.Text = "カロリー調整食一覧";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 5);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(119, 27);
            this.checkBox7.TabIndex = 17;
            this.checkBox7.Text = "種類別集計表";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // LblArert
            // 
            this.LblArert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblArert.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblArert.ForeColor = System.Drawing.Color.Red;
            this.LblArert.Location = new System.Drawing.Point(21, 61);
            this.LblArert.Name = "LblArert";
            this.LblArert.Size = new System.Drawing.Size(443, 51);
            this.LblArert.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "実行";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmClosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblArert);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DtpTillDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpFromDate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmClosing";
            this.Text = "日次締め処理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private SprCommon.Controls.SprDateTimePicker DtpFromDate;
        private SprCommon.Controls.SprDateTimePicker DtpTillDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ChkSalesGeneration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ChkBeforeDocuments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox ChkAfterDocuments;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label LblArert;
        private System.Windows.Forms.Button button1;
    }
}