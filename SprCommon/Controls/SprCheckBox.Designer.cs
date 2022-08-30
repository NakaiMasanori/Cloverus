namespace SprCommon.Controls
{
    partial class SprCheckBox
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
            this.ChkBox = new System.Windows.Forms.CheckBox();
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
            // ChkBox
            // 
            this.ChkBox.AutoSize = true;
            this.ChkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChkBox.Location = new System.Drawing.Point(122, 0);
            this.ChkBox.Name = "ChkBox";
            this.ChkBox.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ChkBox.Size = new System.Drawing.Size(346, 30);
            this.ChkBox.TabIndex = 3;
            this.ChkBox.Text = "checkBox1";
            this.ChkBox.UseVisualStyleBackColor = true;
            // 
            // SprCheckBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ChkBox);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "SprCheckBox";
            this.Size = new System.Drawing.Size(468, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.CheckBox ChkBox;
    }
}
