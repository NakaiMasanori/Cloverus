
namespace CloverusSys.MasterMaintenance.Customers
{
    partial class Preview
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
            this.GvPreview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GvPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // GvPreview
            // 
            this.GvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GvPreview.Location = new System.Drawing.Point(0, 0);
            this.GvPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GvPreview.Name = "GvPreview";
            this.GvPreview.RowTemplate.Height = 21;
            this.GvPreview.Size = new System.Drawing.Size(933, 675);
            this.GvPreview.TabIndex = 0;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 675);
            this.Controls.Add(this.GvPreview);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Preview";
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.GvPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GvPreview;
    }
}