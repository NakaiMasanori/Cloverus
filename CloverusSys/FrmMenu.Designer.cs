namespace CloverusSys
{
    partial class FrmMenu
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
            this.PnlMainMenu = new System.Windows.Forms.Panel();
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnAdministrativeTask = new System.Windows.Forms.Button();
            this.BtnBillingBusiness = new System.Windows.Forms.Button();
            this.BtnBasicBusiness = new System.Windows.Forms.Button();
            this.PnlSubMenu = new System.Windows.Forms.Panel();
            this.PnlReport = new CloverusSys.Controls.MenuPanel.MnuReport();
            this.PnlAdministrativeTask = new CloverusSys.Controls.MenuPanel.MenuAdministrativeTask();
            this.PnlBillingBusiness = new CloverusSys.Controls.MenuPanel.MenuBillingBusiness();
            this.PnlBasicBusiness = new CloverusSys.Controls.MenuPanel.MenuBasicBusiness();
            this.PnlMainMenu.SuspendLayout();
            this.PnlSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMainMenu
            // 
            this.PnlMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMainMenu.Controls.Add(this.BtnReport);
            this.PnlMainMenu.Controls.Add(this.BtnAdministrativeTask);
            this.PnlMainMenu.Controls.Add(this.BtnBillingBusiness);
            this.PnlMainMenu.Controls.Add(this.BtnBasicBusiness);
            this.PnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMainMenu.Name = "PnlMainMenu";
            this.PnlMainMenu.Size = new System.Drawing.Size(260, 991);
            this.PnlMainMenu.TabIndex = 0;
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReport.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnReport.Location = new System.Drawing.Point(10, 255);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(238, 50);
            this.BtnReport.TabIndex = 3;
            this.BtnReport.Text = "閉店業務";
            this.BtnReport.UseVisualStyleBackColor = true;
            // 
            // BtnAdministrativeTask
            // 
            this.BtnAdministrativeTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdministrativeTask.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnAdministrativeTask.Location = new System.Drawing.Point(10, 185);
            this.BtnAdministrativeTask.Name = "BtnAdministrativeTask";
            this.BtnAdministrativeTask.Size = new System.Drawing.Size(238, 50);
            this.BtnAdministrativeTask.TabIndex = 2;
            this.BtnAdministrativeTask.Text = "管理業務";
            this.BtnAdministrativeTask.UseVisualStyleBackColor = true;
            // 
            // BtnBillingBusiness
            // 
            this.BtnBillingBusiness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBillingBusiness.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnBillingBusiness.Location = new System.Drawing.Point(10, 114);
            this.BtnBillingBusiness.Name = "BtnBillingBusiness";
            this.BtnBillingBusiness.Size = new System.Drawing.Size(238, 50);
            this.BtnBillingBusiness.TabIndex = 1;
            this.BtnBillingBusiness.Text = "請求業務";
            this.BtnBillingBusiness.UseVisualStyleBackColor = true;
            // 
            // BtnBasicBusiness
            // 
            this.BtnBasicBusiness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBasicBusiness.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnBasicBusiness.Location = new System.Drawing.Point(10, 42);
            this.BtnBasicBusiness.Name = "BtnBasicBusiness";
            this.BtnBasicBusiness.Size = new System.Drawing.Size(238, 50);
            this.BtnBasicBusiness.TabIndex = 0;
            this.BtnBasicBusiness.Text = "基本業務";
            this.BtnBasicBusiness.UseVisualStyleBackColor = true;
            // 
            // PnlSubMenu
            // 
            this.PnlSubMenu.Controls.Add(this.PnlReport);
            this.PnlSubMenu.Controls.Add(this.PnlAdministrativeTask);
            this.PnlSubMenu.Controls.Add(this.PnlBillingBusiness);
            this.PnlSubMenu.Controls.Add(this.PnlBasicBusiness);
            this.PnlSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSubMenu.Location = new System.Drawing.Point(260, 0);
            this.PnlSubMenu.Name = "PnlSubMenu";
            this.PnlSubMenu.Size = new System.Drawing.Size(1644, 991);
            this.PnlSubMenu.TabIndex = 1;
            // 
            // PnlReport
            // 
            this.PnlReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PnlReport.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PnlReport.Location = new System.Drawing.Point(1109, 15);
            this.PnlReport.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PnlReport.Name = "PnlReport";
            this.PnlReport.Size = new System.Drawing.Size(510, 380);
            this.PnlReport.TabIndex = 3;
            // 
            // PnlAdministrativeTask
            // 
            this.PnlAdministrativeTask.BackColor = System.Drawing.SystemColors.Control;
            this.PnlAdministrativeTask.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PnlAdministrativeTask.Location = new System.Drawing.Point(718, 432);
            this.PnlAdministrativeTask.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PnlAdministrativeTask.Name = "PnlAdministrativeTask";
            this.PnlAdministrativeTask.Size = new System.Drawing.Size(912, 263);
            this.PnlAdministrativeTask.TabIndex = 2;
            // 
            // PnlBillingBusiness
            // 
            this.PnlBillingBusiness.BackColor = System.Drawing.SystemColors.Control;
            this.PnlBillingBusiness.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PnlBillingBusiness.Location = new System.Drawing.Point(390, 318);
            this.PnlBillingBusiness.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PnlBillingBusiness.Name = "PnlBillingBusiness";
            this.PnlBillingBusiness.Size = new System.Drawing.Size(1449, 700);
            this.PnlBillingBusiness.TabIndex = 1;
            // 
            // PnlBasicBusiness
            // 
            this.PnlBasicBusiness.BackColor = System.Drawing.SystemColors.Control;
            this.PnlBasicBusiness.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PnlBasicBusiness.Location = new System.Drawing.Point(61, 84);
            this.PnlBasicBusiness.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PnlBasicBusiness.Name = "PnlBasicBusiness";
            this.PnlBasicBusiness.Size = new System.Drawing.Size(1644, 991);
            this.PnlBasicBusiness.TabIndex = 0;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 991);
            this.Controls.Add(this.PnlSubMenu);
            this.Controls.Add(this.PnlMainMenu);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.PnlMainMenu.ResumeLayout(false);
            this.PnlSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainMenu;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Button BtnAdministrativeTask;
        private System.Windows.Forms.Button BtnBillingBusiness;
        private System.Windows.Forms.Button BtnBasicBusiness;
        private System.Windows.Forms.Panel PnlSubMenu;
        private Controls.MenuPanel.MenuBasicBusiness PnlBasicBusiness;
        private Controls.MenuPanel.MenuBillingBusiness PnlBillingBusiness;
        private Controls.MenuPanel.MnuReport PnlReport;
        private Controls.MenuPanel.MenuAdministrativeTask PnlAdministrativeTask;
    }
}