namespace CloverusSys.MasterMaintenance.Customers
{
    partial class Preview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlCondition = new System.Windows.Forms.Panel();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.TxtCustomerCode = new System.Windows.Forms.TextBox();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PnlResult = new System.Windows.Forms.Panel();
            this.DgvCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKeyword = new System.Windows.Forms.TextBox();
            this.PnlCondition.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.PnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCondition
            // 
            this.PnlCondition.Controls.Add(this.TxtKeyword);
            this.PnlCondition.Controls.Add(this.label1);
            this.PnlCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCondition.Location = new System.Drawing.Point(0, 0);
            this.PnlCondition.Name = "PnlCondition";
            this.PnlCondition.Size = new System.Drawing.Size(1008, 36);
            this.PnlCondition.TabIndex = 0;
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.TxtCustomerCode);
            this.PnlButtons.Controls.Add(this.BtnAccept);
            this.PnlButtons.Controls.Add(this.BtnCancel);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtons.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PnlButtons.Location = new System.Drawing.Point(0, 681);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(1008, 48);
            this.PnlButtons.TabIndex = 2;
            // 
            // TxtCustomerCode
            // 
            this.TxtCustomerCode.Location = new System.Drawing.Point(7, 6);
            this.TxtCustomerCode.Name = "TxtCustomerCode";
            this.TxtCustomerCode.Size = new System.Drawing.Size(100, 36);
            this.TxtCustomerCode.TabIndex = 5;
            this.TxtCustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(732, 6);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(133, 36);
            this.BtnAccept.TabIndex = 3;
            this.BtnAccept.Text = "決定";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnCancel.Location = new System.Drawing.Point(870, 6);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(133, 36);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "閉じる";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PnlResult
            // 
            this.PnlResult.Controls.Add(this.DgvCustomer);
            this.PnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlResult.Location = new System.Drawing.Point(0, 36);
            this.PnlResult.Name = "PnlResult";
            this.PnlResult.Size = new System.Drawing.Size(1008, 645);
            this.PnlResult.TabIndex = 3;
            // 
            // DgvCustomer
            // 
            this.DgvCustomer.AllowUserToAddRows = false;
            this.DgvCustomer.AllowUserToDeleteRows = false;
            this.DgvCustomer.AllowUserToResizeColumns = false;
            this.DgvCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCustomer.GridColor = System.Drawing.SystemColors.Control;
            this.DgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.DgvCustomer.Name = "DgvCustomer";
            this.DgvCustomer.ReadOnly = true;
            this.DgvCustomer.RowHeadersVisible = false;
            this.DgvCustomer.RowTemplate.Height = 21;
            this.DgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCustomer.Size = new System.Drawing.Size(1008, 645);
            this.DgvCustomer.TabIndex = 1;
            this.DgvCustomer.SelectionChanged += new System.EventHandler(this.DgvCustomer_SelectionChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "キーワード";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtKeyword
            // 
            this.TxtKeyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKeyword.Location = new System.Drawing.Point(135, 0);
            this.TxtKeyword.Name = "TxtKeyword";
            this.TxtKeyword.Size = new System.Drawing.Size(873, 36);
            this.TxtKeyword.TabIndex = 2;
            // 
            // Preview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.PnlResult);
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.PnlCondition);
            this.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinimizeBox = false;
            this.Name = "Preview";
            this.Text = "顧客マスター検索";
            this.PnlCondition.ResumeLayout(false);
            this.PnlCondition.PerformLayout();
            this.PnlButtons.ResumeLayout(false);
            this.PnlButtons.PerformLayout();
            this.PnlResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCondition;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Panel PnlResult;
        private System.Windows.Forms.DataGridView DgvCustomer;
        private System.Windows.Forms.TextBox TxtCustomerCode;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtKeyword;
        private System.Windows.Forms.Label label1;
    }
}