
namespace CloverusSys.MasterMaintenance.Customers
{
    partial class FrmEdit
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
            this.sprTextBox1 = new SprCommon.Controls.SprTextBox();
            this.SuspendLayout();
            // 
            // sprTextBox1
            // 
            this.sprTextBox1.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sprTextBox1.Location = new System.Drawing.Point(22, 130);
            this.sprTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sprTextBox1.Name = "sprTextBox1";
            this.sprTextBox1.Size = new System.Drawing.Size(468, 30);
            this.sprTextBox1.TabIndex = 0;
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.sprTextBox1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "顧客マスター";
            this.ResumeLayout(false);

        }

        #endregion

        private SprCommon.Controls.SprTextBox sprTextBox1;
    }
}