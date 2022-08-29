namespace CloverusCommon.Controls
{
    partial class ClvsRouteSelect
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
            this.TxtData = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblRouteName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtData
            // 
            this.TxtData.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtData.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtData.Location = new System.Drawing.Point(122, 0);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(53, 27);
            this.TxtData.TabIndex = 3;
            this.TxtData.Text = "1234";
            this.TxtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "項目名４５６７";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblRouteName
            // 
            this.LblRouteName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblRouteName.Location = new System.Drawing.Point(175, 0);
            this.LblRouteName.Name = "LblRouteName";
            this.LblRouteName.Size = new System.Drawing.Size(293, 27);
            this.LblRouteName.TabIndex = 4;
            this.LblRouteName.Text = "昼①";
            this.LblRouteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClvsRouteSelect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LblRouteName);
            this.Controls.Add(this.TxtData);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClvsRouteSelect";
            this.Size = new System.Drawing.Size(468, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtData;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblRouteName;
    }
}
