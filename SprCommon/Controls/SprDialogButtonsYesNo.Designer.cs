
namespace SprCommon.Controls
{
    partial class SprDialogButtonsYesNo
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
            this.BtnNo = new System.Windows.Forms.Button();
            this.BtnYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNo
            // 
            this.BtnNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNo.Location = new System.Drawing.Point(113, 0);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(101, 33);
            this.BtnNo.TabIndex = 3;
            this.BtnNo.Text = "いいえ";
            this.BtnNo.UseVisualStyleBackColor = true;
            // 
            // BtnYes
            // 
            this.BtnYes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnYes.Location = new System.Drawing.Point(0, 0);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(101, 33);
            this.BtnYes.TabIndex = 2;
            this.BtnYes.Text = "はい";
            this.BtnYes.UseVisualStyleBackColor = true;
            // 
            // SprDialogButtonsYesNo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "SprDialogButtonsYesNo";
            this.Size = new System.Drawing.Size(214, 33);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Button BtnYes;
    }
}
