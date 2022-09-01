namespace SprCommon.Controls
{
    partial class SprCodeName
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
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtCode
            // 
            this.TxtCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtCode.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtCode.Location = new System.Drawing.Point(238, 0);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(120, 43);
            this.TxtCode.TabIndex = 3;
            this.TxtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Navy;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTitle.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(238, 43);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "項目名４５６７８";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblName.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LblName.Location = new System.Drawing.Point(358, 0);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(569, 43);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "項目名４５６７８";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SprCodeName
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "SprCodeName";
            this.Size = new System.Drawing.Size(927, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblName;
    }
}
