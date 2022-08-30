namespace CloverusCommon.Controls
{
    partial class ClvsAddressBox
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
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.LblTitleAddress = new System.Windows.Forms.Label();
            this.LblTitlePost = new System.Windows.Forms.Label();
            this.PnlData = new System.Windows.Forms.Panel();
            this.TxtTownArea = new System.Windows.Forms.TextBox();
            this.TxtMunicipalities = new System.Windows.Forms.TextBox();
            this.TxtPrefectures = new System.Windows.Forms.TextBox();
            this.BtnPreviewAddress = new System.Windows.Forms.Button();
            this.TxtPostCode = new System.Windows.Forms.TextBox();
            this.PnlTitle.SuspendLayout();
            this.PnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.Controls.Add(this.LblTitleAddress);
            this.PnlTitle.Controls.Add(this.LblTitlePost);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(238, 182);
            this.PnlTitle.TabIndex = 19;
            // 
            // LblTitleAddress
            // 
            this.LblTitleAddress.BackColor = System.Drawing.Color.Navy;
            this.LblTitleAddress.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTitleAddress.ForeColor = System.Drawing.Color.White;
            this.LblTitleAddress.Location = new System.Drawing.Point(0, 46);
            this.LblTitleAddress.Name = "LblTitleAddress";
            this.LblTitleAddress.Size = new System.Drawing.Size(238, 43);
            this.LblTitleAddress.TabIndex = 20;
            this.LblTitleAddress.Text = "項目名４５６７";
            this.LblTitleAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblTitlePost
            // 
            this.LblTitlePost.BackColor = System.Drawing.Color.Navy;
            this.LblTitlePost.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitlePost.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTitlePost.ForeColor = System.Drawing.Color.White;
            this.LblTitlePost.Location = new System.Drawing.Point(0, 0);
            this.LblTitlePost.Name = "LblTitlePost";
            this.LblTitlePost.Size = new System.Drawing.Size(238, 43);
            this.LblTitlePost.TabIndex = 19;
            this.LblTitlePost.Text = "項目名４５６７";
            this.LblTitlePost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PnlData
            // 
            this.PnlData.Controls.Add(this.TxtTownArea);
            this.PnlData.Controls.Add(this.TxtMunicipalities);
            this.PnlData.Controls.Add(this.TxtPrefectures);
            this.PnlData.Controls.Add(this.BtnPreviewAddress);
            this.PnlData.Controls.Add(this.TxtPostCode);
            this.PnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlData.Location = new System.Drawing.Point(238, 0);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(689, 182);
            this.PnlData.TabIndex = 20;
            // 
            // TxtTownArea
            // 
            this.TxtTownArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTownArea.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtTownArea.Location = new System.Drawing.Point(0, 139);
            this.TxtTownArea.Name = "TxtTownArea";
            this.TxtTownArea.Size = new System.Drawing.Size(689, 43);
            this.TxtTownArea.TabIndex = 21;
            // 
            // TxtMunicipalities
            // 
            this.TxtMunicipalities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMunicipalities.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtMunicipalities.Location = new System.Drawing.Point(0, 92);
            this.TxtMunicipalities.Name = "TxtMunicipalities";
            this.TxtMunicipalities.Size = new System.Drawing.Size(689, 43);
            this.TxtMunicipalities.TabIndex = 20;
            // 
            // TxtPrefectures
            // 
            this.TxtPrefectures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPrefectures.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtPrefectures.Location = new System.Drawing.Point(0, 46);
            this.TxtPrefectures.Name = "TxtPrefectures";
            this.TxtPrefectures.Size = new System.Drawing.Size(689, 43);
            this.TxtPrefectures.TabIndex = 19;
            // 
            // BtnPreviewAddress
            // 
            this.BtnPreviewAddress.Location = new System.Drawing.Point(181, 0);
            this.BtnPreviewAddress.Name = "BtnPreviewAddress";
            this.BtnPreviewAddress.Size = new System.Drawing.Size(161, 43);
            this.BtnPreviewAddress.TabIndex = 18;
            this.BtnPreviewAddress.Text = "住所表示";
            this.BtnPreviewAddress.UseVisualStyleBackColor = true;
            this.BtnPreviewAddress.Click += new System.EventHandler(this.BtnPreviewAddress_Click);
            // 
            // TxtPostCode
            // 
            this.TxtPostCode.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtPostCode.Location = new System.Drawing.Point(0, 0);
            this.TxtPostCode.Name = "TxtPostCode";
            this.TxtPostCode.Size = new System.Drawing.Size(155, 43);
            this.TxtPostCode.TabIndex = 17;
            this.TxtPostCode.Text = "123-4567";
            // 
            // ClvsAddressBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PnlData);
            this.Controls.Add(this.PnlTitle);
            this.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "ClvsAddressBox";
            this.Size = new System.Drawing.Size(927, 182);
            this.PnlTitle.ResumeLayout(false);
            this.PnlData.ResumeLayout(false);
            this.PnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Label LblTitleAddress;
        private System.Windows.Forms.Label LblTitlePost;
        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.TextBox TxtTownArea;
        private System.Windows.Forms.TextBox TxtMunicipalities;
        private System.Windows.Forms.TextBox TxtPrefectures;
        private System.Windows.Forms.Button BtnPreviewAddress;
        private System.Windows.Forms.TextBox TxtPostCode;
    }
}
