namespace CloverusSys.MasterMaintenance.SubRoute
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
            this.SuspendLayout();
            // 
            // sprTreeItemsRadioButton1
            // 
            this.sprTreeItemsRadioButton1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sprTreeItemsRadioButton1.ItemsCount = 2;
            this.sprTreeItemsRadioButton1.Location = new System.Drawing.Point(12, 41);
            this.sprTreeItemsRadioButton1.Name = "sprTreeItemsRadioButton1";
            this.sprTreeItemsRadioButton1.RadioCenterText = "夜";
            this.sprTreeItemsRadioButton1.RadioCenterValue = 2;
            this.sprTreeItemsRadioButton1.RadioLeftText = "昼";
            this.sprTreeItemsRadioButton1.RadioLeftValue = 1;
            this.sprTreeItemsRadioButton1.RadioRightText = "radioButton3";
            this.sprTreeItemsRadioButton1.RadioRightValue = 0;
            this.sprTreeItemsRadioButton1.Size = new System.Drawing.Size(442, 44);
            this.sprTreeItemsRadioButton1.TabIndex = 0;
            this.sprTreeItemsRadioButton1.TableColumn = null;
            this.sprTreeItemsRadioButton1.TitleBackColor = System.Drawing.Color.Navy;
            this.sprTreeItemsRadioButton1.TitleForeColor = System.Drawing.Color.White;
            this.sprTreeItemsRadioButton1.TitleText = "昼／夜区分";
            this.sprTreeItemsRadioButton1.TitleWidth = 238;
            this.sprTreeItemsRadioButton1.Value = 1;
            // 
            // sprTextBox1
            // 
            this.sprTextBox1.Enabled = false;
            this.sprTextBox1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sprTextBox1.Location = new System.Drawing.Point(13, 117);
            this.sprTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sprTextBox1.Name = "sprTextBox1";
            this.sprTextBox1.Size = new System.Drawing.Size(410, 43);
            this.sprTextBox1.TabIndex = 1;
            this.sprTextBox1.TableColumn = null;
            this.sprTextBox1.TextBackColor = System.Drawing.SystemColors.Window;
            this.sprTextBox1.TextEnabled = false;
            this.sprTextBox1.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.sprTextBox1.TextImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sprTextBox1.TitleBackColor = System.Drawing.Color.Navy;
            this.sprTextBox1.TitleForeColor = System.Drawing.Color.White;
            this.sprTextBox1.TitleText = "サブ番号";
            this.sprTextBox1.TitleWidth = 238;
            this.sprTextBox1.Value = "";
            // 
            // Edit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sprTextBox1);
            this.Controls.Add(this.sprTreeItemsRadioButton1);
            this.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);

        }

        #endregion

        private SprCommon.Controls.SprTreeItemsRadioButton sprTreeItemsRadioButton1;
        private SprCommon.Controls.SprTextBox sprTextBox1;
    }
}