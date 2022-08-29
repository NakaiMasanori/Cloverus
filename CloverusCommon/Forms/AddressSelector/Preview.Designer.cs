namespace CloverusCommon.Forms.AddressSelector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlResult = new System.Windows.Forms.Panel();
            this.DgvAddress = new System.Windows.Forms.DataGridView();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.DialogButtons = new SprCommon.Controls.SprDialogButtonsOkCancel();
            this.PnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddress)).BeginInit();
            this.PnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlResult
            // 
            this.PnlResult.Controls.Add(this.DgvAddress);
            this.PnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlResult.Location = new System.Drawing.Point(0, 0);
            this.PnlResult.Name = "PnlResult";
            this.PnlResult.Size = new System.Drawing.Size(800, 413);
            this.PnlResult.TabIndex = 5;
            // 
            // DgvAddress
            // 
            this.DgvAddress.AllowUserToAddRows = false;
            this.DgvAddress.AllowUserToDeleteRows = false;
            this.DgvAddress.AllowUserToResizeColumns = false;
            this.DgvAddress.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvAddress.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvAddress.GridColor = System.Drawing.SystemColors.Control;
            this.DgvAddress.Location = new System.Drawing.Point(0, 0);
            this.DgvAddress.Name = "DgvAddress";
            this.DgvAddress.ReadOnly = true;
            this.DgvAddress.RowHeadersVisible = false;
            this.DgvAddress.RowTemplate.Height = 21;
            this.DgvAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAddress.Size = new System.Drawing.Size(800, 413);
            this.DgvAddress.TabIndex = 1;
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.DialogButtons);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtons.Location = new System.Drawing.Point(0, 413);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(800, 37);
            this.PnlButtons.TabIndex = 4;
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
            // Preview
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlResult);
            this.Controls.Add(this.PnlButtons);
            this.Name = "Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "郵便番号検索";
            this.PnlResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddress)).EndInit();
            this.PnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlResult;
        private System.Windows.Forms.DataGridView DgvAddress;
        private System.Windows.Forms.Panel PnlButtons;
        private SprCommon.Controls.SprDialogButtonsOkCancel DialogButtons;
    }
}