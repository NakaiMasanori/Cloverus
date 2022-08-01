namespace CloverusSys.Controls.MenuPanel
{
    partial class MenuBasicBusiness
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnEditCustomer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvCustomer = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKeyword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEditCustomer
            // 
            this.BtnEditCustomer.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnEditCustomer.Location = new System.Drawing.Point(24, 48);
            this.BtnEditCustomer.Name = "BtnEditCustomer";
            this.BtnEditCustomer.Size = new System.Drawing.Size(767, 69);
            this.BtnEditCustomer.TabIndex = 0;
            this.BtnEditCustomer.Text = "顧客マスター";
            this.BtnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(424, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(367, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "定期売上パターンマスター";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(24, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(367, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "売上予定登録";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "《 予定の登録～確認・修正 》";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(424, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(367, 69);
            this.button4.TabIndex = 4;
            this.button4.Text = "売上予定生成（個別）";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.Location = new System.Drawing.Point(24, 392);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(767, 69);
            this.button5.TabIndex = 5;
            this.button5.Text = "売上予定修正・確認";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DgvCustomer);
            this.panel1.Location = new System.Drawing.Point(818, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 926);
            this.panel1.TabIndex = 6;
            // 
            // DgvCustomer
            // 
            this.DgvCustomer.AllowUserToAddRows = false;
            this.DgvCustomer.AllowUserToDeleteRows = false;
            this.DgvCustomer.AllowUserToResizeColumns = false;
            this.DgvCustomer.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCustomer.GridColor = System.Drawing.SystemColors.Control;
            this.DgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.DgvCustomer.Name = "DgvCustomer";
            this.DgvCustomer.ReadOnly = true;
            this.DgvCustomer.RowHeadersVisible = false;
            this.DgvCustomer.RowTemplate.Height = 21;
            this.DgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCustomer.Size = new System.Drawing.Size(808, 924);
            this.DgvCustomer.TabIndex = 0;
            this.DgvCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvCustomer_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 676);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "《 その他 》";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.Location = new System.Drawing.Point(24, 705);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(367, 69);
            this.button6.TabIndex = 8;
            this.button6.Text = "予定金額集計表";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button7.Location = new System.Drawing.Point(24, 797);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(367, 69);
            this.button7.TabIndex = 9;
            this.button7.Text = "売上生成処理";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button8.Location = new System.Drawing.Point(24, 888);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(367, 69);
            this.button8.TabIndex = 10;
            this.button8.Text = "予定・売上差額チェックリスト";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button9.Location = new System.Drawing.Point(424, 705);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(367, 69);
            this.button9.TabIndex = 11;
            this.button9.Text = "予定明細確認リスト";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button10.Location = new System.Drawing.Point(424, 797);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(367, 69);
            this.button10.TabIndex = 12;
            this.button10.Text = "配送表";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(815, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "キーワード検索：";
            // 
            // TxtKeyword
            // 
            this.TxtKeyword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TxtKeyword.Location = new System.Drawing.Point(949, 9);
            this.TxtKeyword.Name = "TxtKeyword";
            this.TxtKeyword.Size = new System.Drawing.Size(679, 31);
            this.TxtKeyword.TabIndex = 14;
            // 
            // MenuBasicBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.TxtKeyword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnEditCustomer);
            this.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MenuBasicBusiness";
            this.Size = new System.Drawing.Size(1644, 991);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEditCustomer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKeyword;
    }
}
