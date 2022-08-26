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
            this.BtnClosing = new System.Windows.Forms.Button();
            this.BtnAdministrativeTask = new System.Windows.Forms.Button();
            this.BtnBillingBusiness = new System.Windows.Forms.Button();
            this.BtnBasicBusiness = new System.Windows.Forms.Button();
            this.pnlSplit = new System.Windows.Forms.Panel();
            this.PnlSubMenu = new System.Windows.Forms.Panel();
            this.PnlCloseBusiness = new CloverusSys.Controls.MenuPanel.MenuClosingBusiness();
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
            this.PnlMainMenu.Controls.Add(this.BtnClosing);
            this.PnlMainMenu.Controls.Add(this.BtnAdministrativeTask);
            this.PnlMainMenu.Controls.Add(this.BtnBillingBusiness);
            this.PnlMainMenu.Controls.Add(this.BtnBasicBusiness);
            this.PnlMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMainMenu.Name = "PnlMainMenu";
            this.PnlMainMenu.Size = new System.Drawing.Size(260, 991);
            this.PnlMainMenu.TabIndex = 0;
            // 
            // BtnClosing
            // 
            this.BtnClosing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClosing.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClosing.Location = new System.Drawing.Point(10, 255);
            this.BtnClosing.Name = "BtnClosing";
            this.BtnClosing.Size = new System.Drawing.Size(238, 50);
            this.BtnClosing.TabIndex = 3;
            this.BtnClosing.Text = "閉店業務(F4)";
            this.BtnClosing.UseVisualStyleBackColor = true;
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
            this.BtnAdministrativeTask.Text = "管理業務(F3)";
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
            this.BtnBillingBusiness.Text = "請求業務(F2)";
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
            this.BtnBasicBusiness.Text = "基本業務(F1)";
            this.BtnBasicBusiness.UseVisualStyleBackColor = true;
            // 
            // pnlSplit
            // 
            this.pnlSplit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSplit.Location = new System.Drawing.Point(260, 0);
            this.pnlSplit.Name = "pnlSplit";
            this.pnlSplit.Size = new System.Drawing.Size(2, 991);
            this.pnlSplit.TabIndex = 1;
            // 
            // PnlSubMenu
            // 
            this.PnlSubMenu.Controls.Add(this.PnlCloseBusiness);
            this.PnlSubMenu.Controls.Add(this.PnlAdministrativeTask);
            this.PnlSubMenu.Controls.Add(this.PnlBillingBusiness);
            this.PnlSubMenu.Controls.Add(this.PnlBasicBusiness);
            this.PnlSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSubMenu.Location = new System.Drawing.Point(262, 0);
            this.PnlSubMenu.Name = "PnlSubMenu";
            this.PnlSubMenu.Size = new System.Drawing.Size(1642, 991);
            this.PnlSubMenu.TabIndex = 2;
            // 
            // PnlCloseBusiness
            // 
            this.PnlCloseBusiness.BackColor = System.Drawing.SystemColors.Control;
            this.PnlCloseBusiness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCloseBusiness.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PnlCloseBusiness.Location = new System.Drawing.Point(1109, 15);
            this.PnlCloseBusiness.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PnlCloseBusiness.Name = "PnlCloseBusiness";
            this.PnlCloseBusiness.Size = new System.Drawing.Size(510, 380);
            this.PnlCloseBusiness.TabIndex = 3;
            // 
            // PnlAdministrativeTask
            // 
            this.PnlAdministrativeTask.BackColor = System.Drawing.SystemColors.Control;
            this.PnlAdministrativeTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.PnlBasicBusiness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.Controls.Add(this.pnlSplit);
            this.Controls.Add(this.PnlMainMenu);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMenu_KeyDown);
            this.PnlMainMenu.ResumeLayout(false);
            this.PnlSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMainMenu;
        private System.Windows.Forms.Button BtnClosing;
        private System.Windows.Forms.Button BtnAdministrativeTask;
        private System.Windows.Forms.Button BtnBillingBusiness;
        private System.Windows.Forms.Button BtnBasicBusiness;
        private System.Windows.Forms.Panel pnlSplit;
        private System.Windows.Forms.Panel PnlSubMenu;
        private Controls.MenuPanel.MenuClosingBusiness PnlCloseBusiness;
        private Controls.MenuPanel.MenuAdministrativeTask PnlAdministrativeTask;
        private Controls.MenuPanel.MenuBillingBusiness PnlBillingBusiness;
        private Controls.MenuPanel.MenuBasicBusiness PnlBasicBusiness;
    }
}