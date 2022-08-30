namespace SprCommon.Controls
{
    partial class SprTreeItemsRadioButton
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
            this.RdoLeft = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdoCenter = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RdoRight = new System.Windows.Forms.RadioButton();
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
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "項目名４５６７";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RdoLeft
            // 
            this.RdoLeft.AutoSize = true;
            this.RdoLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.RdoLeft.Location = new System.Drawing.Point(122, 0);
            this.RdoLeft.Name = "RdoLeft";
            this.RdoLeft.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RdoLeft.Size = new System.Drawing.Size(127, 30);
            this.RdoLeft.TabIndex = 5;
            this.RdoLeft.TabStop = true;
            this.RdoLeft.Text = "radioButton1";
            this.RdoLeft.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(249, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 30);
            this.panel1.TabIndex = 6;
            // 
            // RdoCenter
            // 
            this.RdoCenter.AutoSize = true;
            this.RdoCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.RdoCenter.Location = new System.Drawing.Point(265, 0);
            this.RdoCenter.Name = "RdoCenter";
            this.RdoCenter.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RdoCenter.Size = new System.Drawing.Size(127, 30);
            this.RdoCenter.TabIndex = 8;
            this.RdoCenter.TabStop = true;
            this.RdoCenter.Text = "radioButton2";
            this.RdoCenter.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(392, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 30);
            this.panel2.TabIndex = 9;
            // 
            // RdoRight
            // 
            this.RdoRight.AutoSize = true;
            this.RdoRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RdoRight.Location = new System.Drawing.Point(408, 0);
            this.RdoRight.Name = "RdoRight";
            this.RdoRight.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.RdoRight.Size = new System.Drawing.Size(60, 30);
            this.RdoRight.TabIndex = 10;
            this.RdoRight.TabStop = true;
            this.RdoRight.Text = "radioButton3";
            this.RdoRight.UseVisualStyleBackColor = true;
            // 
            // SprTreeItemsRadioButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.RdoRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RdoCenter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RdoLeft);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "SprTreeItemsRadioButton";
            this.Size = new System.Drawing.Size(468, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.RadioButton RdoLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RdoCenter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RdoRight;
    }
}
