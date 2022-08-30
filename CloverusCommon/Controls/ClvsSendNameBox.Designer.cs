namespace CloverusCommon.Controls
{
    partial class ClvsSendNameBox
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlData = new System.Windows.Forms.Panel();
            this.TxtLower = new System.Windows.Forms.TextBox();
            this.TxtUpper = new System.Windows.Forms.TextBox();
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlData.SuspendLayout();
            this.PnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlData
            // 
            this.PnlData.Controls.Add(this.TxtLower);
            this.PnlData.Controls.Add(this.TxtUpper);
            this.PnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlData.Location = new System.Drawing.Point(238, 0);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(689, 88);
            this.PnlData.TabIndex = 22;
            // 
            // TxtLower
            // 
            this.TxtLower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLower.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLower.Location = new System.Drawing.Point(0, 45);
            this.TxtLower.Name = "TxtLower";
            this.TxtLower.Size = new System.Drawing.Size(689, 43);
            this.TxtLower.TabIndex = 20;
            // 
            // TxtUpper
            // 
            this.TxtUpper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUpper.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtUpper.Location = new System.Drawing.Point(0, 0);
            this.TxtUpper.Name = "TxtUpper";
            this.TxtUpper.Size = new System.Drawing.Size(689, 43);
            this.TxtUpper.TabIndex = 19;
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.LblTitle);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(238, 88);
            this.PnlTitle.TabIndex = 21;
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Navy;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblTitle.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(238, 88);
            this.LblTitle.TabIndex = 19;
            this.LblTitle.Text = "項目名４５６７";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClvsSendNameBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PnlData);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "ClvsSendNameBox";
            this.Size = new System.Drawing.Size(927, 88);
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            this.PnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.TextBox TxtLower;
        private System.Windows.Forms.TextBox TxtUpper;
        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Label LblTitle;
    }
}
