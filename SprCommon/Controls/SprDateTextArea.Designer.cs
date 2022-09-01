namespace SprCommon.Controls
{
    partial class SprDateTextArea
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblFrom = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
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
            this.LblTitle.TabIndex = 4;
            this.LblTitle.Text = "項目名４５６７";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd(ddd)";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePicker1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(564, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 43);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // LblFrom
            // 
            this.LblFrom.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblFrom.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblFrom.Location = new System.Drawing.Point(533, 0);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(31, 43);
            this.LblFrom.TabIndex = 9;
            this.LblFrom.Text = "～";
            this.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "yyyy/MM/dd(ddd)";
            this.DatePicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.DatePicker.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DatePicker.Location = new System.Drawing.Point(238, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.ShowCheckBox = true;
            this.DatePicker.Size = new System.Drawing.Size(295, 43);
            this.DatePicker.TabIndex = 8;
            // 
            // SprDateTextArea
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LblFrom);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.LblTitle);
            this.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "SprDateTextArea";
            this.Size = new System.Drawing.Size(865, 43);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblFrom;
        private System.Windows.Forms.DateTimePicker DatePicker;
    }
}
