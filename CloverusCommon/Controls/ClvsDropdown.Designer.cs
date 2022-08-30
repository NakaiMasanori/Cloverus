namespace CloverusCommon.Controls
{
    partial class ClvsDropdown
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
            this.DrpDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.BackColor = System.Drawing.Color.Navy;
            this.LblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblTitle.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(0, 0);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(122, 29);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "項目名４５６７";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DrpDown
            // 
            this.DrpDown.BackColor = System.Drawing.SystemColors.Window;
            this.DrpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrpDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrpDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DrpDown.FormattingEnabled = true;
            this.DrpDown.Location = new System.Drawing.Point(122, 0);
            this.DrpDown.Name = "DrpDown";
            this.DrpDown.Size = new System.Drawing.Size(344, 31);
            this.DrpDown.TabIndex = 3;
            // 
            // ClvsDropdown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DrpDown);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClvsDropdown";
            this.Size = new System.Drawing.Size(466, 29);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.ComboBox DrpDown;
    }
}
