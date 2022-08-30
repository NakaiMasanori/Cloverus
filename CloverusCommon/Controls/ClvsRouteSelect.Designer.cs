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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblDay = new System.Windows.Forms.Label();
            this.LblNameDay = new System.Windows.Forms.Label();
            this.TxtDay = new System.Windows.Forms.TextBox();
            this.LblNameNight = new System.Windows.Forms.Label();
            this.TxtNight = new System.Windows.Forms.TextBox();
            this.lblNight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Navy;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTitle.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(122, 30);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "項目名４５６７";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDay
            // 
            this.LblDay.BackColor = System.Drawing.Color.Gold;
            this.LblDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblDay.Location = new System.Drawing.Point(122, 0);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(29, 30);
            this.LblDay.TabIndex = 3;
            this.LblDay.Text = "昼";
            this.LblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNameDay
            // 
            this.LblNameDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblNameDay.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblNameDay.Location = new System.Drawing.Point(204, 0);
            this.LblNameDay.Name = "LblNameDay";
            this.LblNameDay.Size = new System.Drawing.Size(96, 30);
            this.LblNameDay.TabIndex = 6;
            this.LblNameDay.Text = "昼コスモ用";
            this.LblNameDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtDay
            // 
            this.TxtDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtDay.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtDay.Location = new System.Drawing.Point(151, 0);
            this.TxtDay.Name = "TxtDay";
            this.TxtDay.Size = new System.Drawing.Size(53, 30);
            this.TxtDay.TabIndex = 5;
            this.TxtDay.Text = "1234";
            this.TxtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNameNight
            // 
            this.LblNameNight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNameNight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblNameNight.Location = new System.Drawing.Point(382, 0);
            this.LblNameNight.Name = "LblNameNight";
            this.LblNameNight.Size = new System.Drawing.Size(86, 30);
            this.LblNameNight.TabIndex = 10;
            this.LblNameNight.Text = "昼コスモ用";
            this.LblNameNight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtNight
            // 
            this.TxtNight.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtNight.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtNight.Location = new System.Drawing.Point(329, 0);
            this.TxtNight.Name = "TxtNight";
            this.TxtNight.Size = new System.Drawing.Size(53, 30);
            this.TxtNight.TabIndex = 9;
            this.TxtNight.Text = "1234";
            this.TxtNight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNight
            // 
            this.lblNight.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblNight.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNight.Location = new System.Drawing.Point(300, 0);
            this.lblNight.Name = "lblNight";
            this.lblNight.Size = new System.Drawing.Size(29, 30);
            this.lblNight.TabIndex = 8;
            this.lblNight.Text = "夜";
            this.lblNight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClvsRouteSelect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LblNameNight);
            this.Controls.Add(this.TxtNight);
            this.Controls.Add(this.lblNight);
            this.Controls.Add(this.LblNameDay);
            this.Controls.Add(this.TxtDay);
            this.Controls.Add(this.LblDay);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClvsRouteSelect";
            this.Size = new System.Drawing.Size(468, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblDay;
        private System.Windows.Forms.Label LblNameDay;
        private System.Windows.Forms.TextBox TxtDay;
        private System.Windows.Forms.Label LblNameNight;
        private System.Windows.Forms.TextBox TxtNight;
        private System.Windows.Forms.Label lblNight;
    }
}
