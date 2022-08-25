namespace CloverusSys.Controls.MenuPanel
{
    partial class ClvsMenuButton
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
            this.BtnItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnItem
            // 
            this.BtnItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnItem.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnItem.Location = new System.Drawing.Point(0, 0);
            this.BtnItem.Name = "BtnItem";
            this.BtnItem.Size = new System.Drawing.Size(367, 69);
            this.BtnItem.TabIndex = 13;
            this.BtnItem.Text = "配送表";
            this.BtnItem.UseVisualStyleBackColor = true;
            this.BtnItem.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // ClvsMenuButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.BtnItem);
            this.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "ClvsMenuButton";
            this.Size = new System.Drawing.Size(367, 69);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnItem;
    }
}
