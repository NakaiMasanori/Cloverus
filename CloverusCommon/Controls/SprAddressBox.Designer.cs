namespace SprCommon.Controls
{
    partial class SprAddressBox
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
            this.PnlPost = new System.Windows.Forms.Panel();
            this.BtnPreviewAddress = new System.Windows.Forms.Button();
            this.TxtPostCode = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlSplit = new System.Windows.Forms.Panel();
            this.PnlAddress = new System.Windows.Forms.Panel();
            this.TxtTownArea = new System.Windows.Forms.TextBox();
            this.TxtMunicipalities = new System.Windows.Forms.TextBox();
            this.TxtPrefectures = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlPost.SuspendLayout();
            this.PnlAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPost
            // 
            this.PnlPost.Controls.Add(this.BtnPreviewAddress);
            this.PnlPost.Controls.Add(this.TxtPostCode);
            this.PnlPost.Controls.Add(this.LblTitle);
            this.PnlPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlPost.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PnlPost.Location = new System.Drawing.Point(0, 0);
            this.PnlPost.Name = "PnlPost";
            this.PnlPost.Size = new System.Drawing.Size(468, 27);
            this.PnlPost.TabIndex = 4;
            // 
            // BtnPreviewAddress
            // 
            this.BtnPreviewAddress.Location = new System.Drawing.Point(259, 0);
            this.BtnPreviewAddress.Name = "BtnPreviewAddress";
            this.BtnPreviewAddress.Size = new System.Drawing.Size(75, 27);
            this.BtnPreviewAddress.TabIndex = 2;
            this.BtnPreviewAddress.Text = "住所表示";
            this.BtnPreviewAddress.UseVisualStyleBackColor = true;
            this.BtnPreviewAddress.Click += new System.EventHandler(this.BtnPreviewAddress_Click);
            // 
            // TxtPostCode
            // 
            this.TxtPostCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtPostCode.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtPostCode.Location = new System.Drawing.Point(122, 0);
            this.TxtPostCode.Name = "TxtPostCode";
            this.TxtPostCode.Size = new System.Drawing.Size(135, 27);
            this.TxtPostCode.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Navy;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTitle.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(122, 27);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "項目名４５６７";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlSplit
            // 
            this.PnlSplit.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSplit.Location = new System.Drawing.Point(0, 27);
            this.PnlSplit.Name = "PnlSplit";
            this.PnlSplit.Size = new System.Drawing.Size(468, 4);
            this.PnlSplit.TabIndex = 5;
            // 
            // PnlAddress
            // 
            this.PnlAddress.Controls.Add(this.TxtTownArea);
            this.PnlAddress.Controls.Add(this.TxtMunicipalities);
            this.PnlAddress.Controls.Add(this.TxtPrefectures);
            this.PnlAddress.Controls.Add(this.label1);
            this.PnlAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlAddress.Location = new System.Drawing.Point(0, 31);
            this.PnlAddress.Name = "PnlAddress";
            this.PnlAddress.Size = new System.Drawing.Size(468, 87);
            this.PnlAddress.TabIndex = 6;
            // 
            // TxtTownArea
            // 
            this.TxtTownArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTownArea.Location = new System.Drawing.Point(122, 60);
            this.TxtTownArea.Name = "TxtTownArea";
            this.TxtTownArea.Size = new System.Drawing.Size(345, 27);
            this.TxtTownArea.TabIndex = 3;
            // 
            // TxtMunicipalities
            // 
            this.TxtMunicipalities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMunicipalities.Location = new System.Drawing.Point(122, 30);
            this.TxtMunicipalities.Name = "TxtMunicipalities";
            this.TxtMunicipalities.Size = new System.Drawing.Size(345, 27);
            this.TxtMunicipalities.TabIndex = 2;
            // 
            // TxtPrefectures
            // 
            this.TxtPrefectures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrefectures.Location = new System.Drawing.Point(122, 0);
            this.TxtPrefectures.Name = "TxtPrefectures";
            this.TxtPrefectures.Size = new System.Drawing.Size(345, 27);
            this.TxtPrefectures.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "項目名４５６７";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SprAddressBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PnlAddress);
            this.Controls.Add(this.PnlSplit);
            this.Controls.Add(this.PnlPost);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "SprAddressBox";
            this.Size = new System.Drawing.Size(468, 118);
            this.PnlPost.ResumeLayout(false);
            this.PnlPost.PerformLayout();
            this.PnlAddress.ResumeLayout(false);
            this.PnlAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlPost;
        private System.Windows.Forms.TextBox TxtPostCode;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnPreviewAddress;
        private System.Windows.Forms.Panel PnlSplit;
        private System.Windows.Forms.Panel PnlAddress;
        private System.Windows.Forms.TextBox TxtTownArea;
        private System.Windows.Forms.TextBox TxtMunicipalities;
        private System.Windows.Forms.TextBox TxtPrefectures;
        private System.Windows.Forms.Label label1;
    }
}
