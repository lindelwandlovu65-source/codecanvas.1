namespace Project
{
    partial class LoginPage
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
            this.pnlCover = new Project.CoverPanel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new Project.HintBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new Project.HintBox();
            this.chkMask = new System.Windows.Forms.CheckBox();
            this.btbCancell = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.brandPanel = new Project.BrandPanel();
            this.pnlCover.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCover
            // 
            this.pnlCover.Controls.Add(this.pnlCard);
            this.pnlCover.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.pnlCover.Cover = global::Project.Properties.Resources.Blank_background;
            this.pnlCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCover.Location = new System.Drawing.Point(0, 0);
            this.pnlCover.Size = new System.Drawing.Size(1100, 620);
            this.pnlCover.Name = "pnlCover";
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.pnlBody);
            this.pnlCard.Controls.Add(this.brandPanel);
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(140, 130);
            this.pnlCard.Size = new System.Drawing.Size(820, 360);
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.Name = "pnlCard";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblTitle);
            this.pnlBody.Controls.Add(this.lblSubtitle);
            this.pnlBody.Controls.Add(this.lblUser);
            this.pnlBody.Controls.Add(this.txtUser);
            this.pnlBody.Controls.Add(this.lblPass);
            this.pnlBody.Controls.Add(this.txtPass);
            this.pnlBody.Controls.Add(this.chkMask);
            this.pnlBody.Controls.Add(this.btbCancell);
            this.pnlBody.Controls.Add(this.btnLogin);
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Location = new System.Drawing.Point(300, 0);
            this.pnlBody.Size = new System.Drawing.Size(520, 360);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.lblTitle.Location = new System.Drawing.Point(32, 24);
            this.lblTitle.Size = new System.Drawing.Size(456, 34);
            this.lblTitle.Text = "Log in";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Name = "lblTitle";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblSubtitle.Location = new System.Drawing.Point(32, 58);
            this.lblSubtitle.Size = new System.Drawing.Size(456, 30);
            this.lblSubtitle.Text = "Enter your details to continue.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSubtitle.Name = "lblSubtitle";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = false;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblUser.Location = new System.Drawing.Point(32, 88);
            this.lblUser.Size = new System.Drawing.Size(456, 22);
            this.lblUser.Text = "Username";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblUser.Name = "lblUser";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtUser.Location = new System.Drawing.Point(32, 110);
            this.txtUser.Size = new System.Drawing.Size(456, 27);
            this.txtUser.Hint = "Your username";
            this.txtUser.TabIndex = 0;
            this.txtUser.Name = "txtUser";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = false;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblPass.Location = new System.Drawing.Point(32, 152);
            this.lblPass.Size = new System.Drawing.Size(456, 22);
            this.lblPass.Text = "Password";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblPass.Name = "lblPass";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPass.Location = new System.Drawing.Point(32, 174);
            this.txtPass.Size = new System.Drawing.Size(456, 27);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Name = "txtPass";
            // 
            // chkMask
            // 
            this.chkMask.AutoSize = false;
            this.chkMask.BackColor = System.Drawing.Color.White;
            this.chkMask.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkMask.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.chkMask.Location = new System.Drawing.Point(32, 216);
            this.chkMask.Size = new System.Drawing.Size(456, 32);
            this.chkMask.TabIndex = 2;
            this.chkMask.Text = "Show password";
            this.chkMask.UseVisualStyleBackColor = false;
            this.chkMask.Name = "chkMask";
            this.chkMask.CheckedChanged += new System.EventHandler(this.chkMask_CheckedChanged);
            // 
            // btbCancell
            // 
            this.btbCancell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbCancell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbCancell.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btbCancell.Location = new System.Drawing.Point(258, 256);
            this.btbCancell.Size = new System.Drawing.Size(110, 38);
            this.btbCancell.Text = "Back";
            this.btbCancell.UseVisualStyleBackColor = false;
            this.btbCancell.BackColor = System.Drawing.Color.White;
            this.btbCancell.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btbCancell.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btbCancell.FlatAppearance.BorderSize = 1;
            this.btbCancell.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btbCancell.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btbCancell.TabIndex = 4;
            this.btbCancell.Name = "btbCancell";
            this.btbCancell.Click += new System.EventHandler(this.btbCancell_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogin.Location = new System.Drawing.Point(378, 256);
            this.btnLogin.Size = new System.Drawing.Size(110, 38);
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 95, 15);
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(214, 110, 20);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // brandPanel
            // 
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.brandPanel.Location = new System.Drawing.Point(0, 0);
            this.brandPanel.Size = new System.Drawing.Size(300, 360);
            this.brandPanel.Headline = "Welcome back.";
            this.brandPanel.Bullet1 = "Donate surplus food";
            this.brandPanel.Bullet2 = "Apply for support";
            this.brandPanel.Bullet3 = "Make a difference today";
            this.brandPanel.Name = "brandPanel";
            // 
            // LoginPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.ClientSize = new System.Drawing.Size(1100, 620);
            this.Controls.Add(this.pnlCover);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Donation System - Login";
            this.AcceptButton = this.btnLogin;
            this.CancelButton = this.btbCancell;
            this.Name = "LoginPage";
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlCover.ResumeLayout(false);
            this.pnlCover.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Project.CoverPanel pnlCover;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUser;
        private Project.HintBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private Project.HintBox txtPass;
        private System.Windows.Forms.CheckBox chkMask;
        private System.Windows.Forms.Button btbCancell;
        private System.Windows.Forms.Button btnLogin;
        private Project.BrandPanel brandPanel;
    }
}
