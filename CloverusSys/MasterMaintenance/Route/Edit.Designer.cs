namespace CloverusSys.MasterMaintenance.Route
{
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sprTreeItemsRadioButton1 = new SprCommon.Controls.SprTreeItemsRadioButton();
            this.sprTextBox1 = new SprCommon.Controls.SprTextBox();
            this.sprTextBox2 = new SprCommon.Controls.SprTextBox();
            this.sprMultiTextBox1 = new SprCommon.Controls.SprMultiTextBox();
            this.SuspendLayout();
            // 
            // sprTreeItemsRadioButton1
            // 
            this.sprTreeItemsRadioButton1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sprTreeItemsRadioButton1.ItemsCount = 2;
            this.sprTreeItemsRadioButton1.Location = new System.Drawing.Point(13, 42);
            this.sprTreeItemsRadioButton1.Name = "sprTreeItemsRadioButton1";
            this.sprTreeItemsRadioButton1.RadioCenterText = "夜";
            this.sprTreeItemsRadioButton1.RadioCenterValue = 2;
            this.sprTreeItemsRadioButton1.RadioLeftText = "昼";
            this.sprTreeItemsRadioButton1.RadioLeftValue = 1;
            this.sprTreeItemsRadioButton1.RadioRightText = "radioButton3";
            this.sprTreeItemsRadioButton1.RadioRightValue = 0;
            this.sprTreeItemsRadioButton1.Size = new System.Drawing.Size(399, 44);
            this.sprTreeItemsRadioButton1.TabIndex = 0;
            this.sprTreeItemsRadioButton1.TableColumn = "CUSMA03004";
            this.sprTreeItemsRadioButton1.TitleBackColor = System.Drawing.Color.Navy;
            this.sprTreeItemsRadioButton1.TitleForeColor = System.Drawing.Color.White;
            this.sprTreeItemsRadioButton1.TitleText = "昼／夜区分";
            this.sprTreeItemsRadioButton1.TitleWidth = 238;
            this.sprTreeItemsRadioButton1.Value = 1;
            // 
            // sprTextBox1
            // 
            this.sprTextBox1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sprTextBox1.Location = new System.Drawing.Point(13, 103);
            this.sprTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sprTextBox1.Name = "sprTextBox1";
            this.sprTextBox1.Size = new System.Drawing.Size(439, 43);
            this.sprTextBox1.TabIndex = 1;
            this.sprTextBox1.TableColumn = "CUSMA03001";
            this.sprTextBox1.TextBackColor = System.Drawing.SystemColors.Window;
            this.sprTextBox1.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.sprTextBox1.TextImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sprTextBox1.TitleBackColor = System.Drawing.Color.Navy;
            this.sprTextBox1.TitleForeColor = System.Drawing.Color.White;
            this.sprTextBox1.TitleText = "ルートコード";
            this.sprTextBox1.TitleWidth = 238;
            this.sprTextBox1.Value = "";
            // 
            // sprTextBox2
            // 
            this.sprTextBox2.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sprTextBox2.Location = new System.Drawing.Point(13, 232);
            this.sprTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sprTextBox2.Name = "sprTextBox2";
            this.sprTextBox2.Size = new System.Drawing.Size(636, 43);
            this.sprTextBox2.TabIndex = 2;
            this.sprTextBox2.TableColumn = "CUSMA03002";
            this.sprTextBox2.TextBackColor = System.Drawing.SystemColors.Window;
            this.sprTextBox2.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.sprTextBox2.TextImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sprTextBox2.TitleBackColor = System.Drawing.Color.Navy;
            this.sprTextBox2.TitleForeColor = System.Drawing.Color.White;
            this.sprTextBox2.TitleText = "ルート名";
            this.sprTextBox2.TitleWidth = 238;
            this.sprTextBox2.Value = "";
            // 
            // sprMultiTextBox1
            // 
            this.sprMultiTextBox1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sprMultiTextBox1.Location = new System.Drawing.Point(12, 289);
            this.sprMultiTextBox1.Name = "sprMultiTextBox1";
            this.sprMultiTextBox1.Size = new System.Drawing.Size(637, 104);
            this.sprMultiTextBox1.TabIndex = 3;
            this.sprMultiTextBox1.TableColumn = "CUSMA03003";
            this.sprMultiTextBox1.TextBackColor = System.Drawing.SystemColors.Window;
            this.sprMultiTextBox1.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.sprMultiTextBox1.TextImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sprMultiTextBox1.TitleBackColor = System.Drawing.Color.Navy;
            this.sprMultiTextBox1.TitleForeColor = System.Drawing.Color.White;
            this.sprMultiTextBox1.TitleText = "ルート備考";
            this.sprMultiTextBox1.TitleWidth = 238;
            this.sprMultiTextBox1.Value = "";
            // 
            // Edit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sprTextBox1);
            this.Controls.Add(this.sprTreeItemsRadioButton1);
            this.Controls.Add(this.sprMultiTextBox1);
            this.Controls.Add(this.sprTextBox2);
            this.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Edit";
            this.Text = "ルートマスター保守";
            this.ResumeLayout(false);

        }

        #endregion

        private SprCommon.Controls.SprTreeItemsRadioButton sprTreeItemsRadioButton1;
        private SprCommon.Controls.SprTextBox sprTextBox1;
        private SprCommon.Controls.SprTextBox sprTextBox2;
        private SprCommon.Controls.SprMultiTextBox sprMultiTextBox1;
    }
}