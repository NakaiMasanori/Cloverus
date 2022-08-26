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
            this.TxtKeyword = new SprCommon.Controls.SprTextBox();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.DialogButtons = new SprCommon.Controls.SprDialogButtonsOkCancel();
            this.PnlResult = new System.Windows.Forms.Panel();
            this.DgvCustomer = new System.Windows.Forms.DataGridView();
            this.PnlCondition.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.PnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCondition
            // 
            this.PnlCondition.Controls.Add(this.TxtKeyword);
            this.PnlCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlCondition.Location = new System.Drawing.Point(0, 0);
            this.PnlCondition.Name = "PnlCondition";
            this.PnlCondition.Size = new System.Drawing.Size(800, 30);
            this.PnlCondition.TabIndex = 0;
            // 
            // TxtKeyword
            // 
            this.TxtKeyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKeyword.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtKeyword.Location = new System.Drawing.Point(0, 0);
            this.TxtKeyword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtKeyword.Name = "TxtKeyword";
            this.TxtKeyword.Size = new System.Drawing.Size(800, 27);
            this.TxtKeyword.TabIndex = 0;
            this.TxtKeyword.TextBoxWidth = 646;
            this.TxtKeyword.TextImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtKeyword.TextValue = "";
            this.TxtKeyword.TitleText = "キーワード(検索＝F3)";
            this.TxtKeyword.TitleWidth = 154;
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.DialogButtons);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtons.Location = new System.Drawing.Point(0, 413);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(800, 37);
            this.PnlButtons.TabIndex = 2;
            // 
            // DialogButtons
            // 
            this.DialogButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DialogButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DialogButtons.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DialogButtons.Location = new System.Drawing.Point(0, 0);
            this.DialogButtons.Name = "DialogButtons";
            this.DialogButtons.Size = new System.Drawing.Size(800, 37);
            this.DialogButtons.TabIndex = 0;
            // 
            // PnlResult
            // 
            this.PnlResult.Controls.Add(this.DgvCustomer);
            this.PnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlResult.Location = new System.Drawing.Point(0, 30);
            this.PnlResult.Name = "PnlResult";
            this.PnlResult.Size = new System.Drawing.Size(800, 383);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
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
            this.DgvCustomer.Size = new System.Drawing.Size(800, 383);
            this.DgvCustomer.TabIndex = 1;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlResult);
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.PnlCondition);
            this.MinimizeBox = false;
            this.Name = "Preview";
            this.Text = "顧客マスター検索";
            this.PnlCondition.ResumeLayout(false);
            this.PnlButtons.ResumeLayout(false);
            this.PnlResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlCondition;
        private SprCommon.Controls.SprTextBox TxtKeyword;
        private System.Windows.Forms.Panel PnlButtons;
        private SprCommon.Controls.SprDialogButtonsOkCancel DialogButtons;
        private System.Windows.Forms.Panel PnlResult;
        private System.Windows.Forms.DataGridView DgvCustomer;
    }
}