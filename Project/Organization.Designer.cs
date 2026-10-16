namespace Project
{
    partial class Organization
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
            this.components = new System.ComponentModel.Container();
            this.pnlCover = new Project.CoverPanel();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblOrgName = new System.Windows.Forms.Label();
            this.txtName = new Project.HintBox();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.txtRegnum = new Project.HintBox();
            this.lblOrgEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Project.HintBox();
            this.lblProof = new System.Windows.Forms.Label();
            this.txtBrowse = new Project.HintBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblProvince = new System.Windows.Forms.Label();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.lblPostal = new System.Windows.Forms.Label();
            this.txtCode = new Project.HintBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAdress = new Project.HintBox();
            this.lblCreate = new System.Windows.Forms.Label();
            this.txtCreate = new Project.HintBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new Project.HintBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.flowFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHaveAccount = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.brandPanel = new Project.BrandPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlCover.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.flowFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCover
            // 
            this.pnlCover.Controls.Add(this.pnlCard);
            this.pnlCover.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.pnlCover.Cover = global::Project.Properties.Resources.Blank_background;
            this.pnlCover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCover.Location = new System.Drawing.Point(0, 0);
            this.pnlCover.Size = new System.Drawing.Size(1100, 680);
            this.pnlCover.Name = "pnlCover";
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.pnlBody);
            this.pnlCard.Controls.Add(this.brandPanel);
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(60, 45);
            this.pnlCard.Size = new System.Drawing.Size(980, 590);
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.Name = "pnlCard";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblTitle);
            this.pnlBody.Controls.Add(this.lblSubtitle);
            this.pnlBody.Controls.Add(this.lblOrgName);
            this.pnlBody.Controls.Add(this.txtName);
            this.pnlBody.Controls.Add(this.lblRegNum);
            this.pnlBody.Controls.Add(this.txtRegnum);
            this.pnlBody.Controls.Add(this.lblOrgEmail);
            this.pnlBody.Controls.Add(this.txtEmail);
            this.pnlBody.Controls.Add(this.lblProof);
            this.pnlBody.Controls.Add(this.txtBrowse);
            this.pnlBody.Controls.Add(this.btnBrowse);
            this.pnlBody.Controls.Add(this.lblProvince);
            this.pnlBody.Controls.Add(this.cmbProvince);
            this.pnlBody.Controls.Add(this.lblPostal);
            this.pnlBody.Controls.Add(this.txtCode);
            this.pnlBody.Controls.Add(this.lblAddress);
            this.pnlBody.Controls.Add(this.txtAdress);
            this.pnlBody.Controls.Add(this.lblCreate);
            this.pnlBody.Controls.Add(this.txtCreate);
            this.pnlBody.Controls.Add(this.lblConfirm);
            this.pnlBody.Controls.Add(this.txtConfirm);
            this.pnlBody.Controls.Add(this.btnCreate);
            this.pnlBody.Controls.Add(this.btnBack);
            this.pnlBody.Controls.Add(this.flowFooter);
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Location = new System.Drawing.Point(300, 0);
            this.pnlBody.Size = new System.Drawing.Size(680, 590);
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
            this.lblTitle.Size = new System.Drawing.Size(616, 34);
            this.lblTitle.Text = "Create your account";
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
            this.lblSubtitle.Size = new System.Drawing.Size(616, 30);
            this.lblSubtitle.Text = "Register as an organization donor.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSubtitle.Name = "lblSubtitle";
            // 
            // lblOrgName
            // 
            this.lblOrgName.AutoSize = false;
            this.lblOrgName.BackColor = System.Drawing.Color.Transparent;
            this.lblOrgName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrgName.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblOrgName.Location = new System.Drawing.Point(32, 88);
            this.lblOrgName.Size = new System.Drawing.Size(616, 22);
            this.lblOrgName.Text = "Organization name";
            this.lblOrgName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblOrgName.Name = "lblOrgName";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtName.Location = new System.Drawing.Point(32, 110);
            this.txtName.Size = new System.Drawing.Size(616, 27);
            this.txtName.Hint = "e.g. Hope Community Kitchen";
            this.txtName.TabIndex = 0;
            this.txtName.Name = "txtName";
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = false;
            this.lblRegNum.BackColor = System.Drawing.Color.Transparent;
            this.lblRegNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRegNum.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblRegNum.Location = new System.Drawing.Point(32, 152);
            this.lblRegNum.Size = new System.Drawing.Size(298, 22);
            this.lblRegNum.Text = "NPO registration number";
            this.lblRegNum.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblRegNum.Name = "lblRegNum";
            // 
            // txtRegnum
            // 
            this.txtRegnum.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtRegnum.Location = new System.Drawing.Point(32, 174);
            this.txtRegnum.Size = new System.Drawing.Size(298, 27);
            this.txtRegnum.Hint = "000-000";
            this.txtRegnum.TabIndex = 1;
            this.txtRegnum.Name = "txtRegnum";
            // 
            // lblOrgEmail
            // 
            this.lblOrgEmail.AutoSize = false;
            this.lblOrgEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblOrgEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrgEmail.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblOrgEmail.Location = new System.Drawing.Point(350, 152);
            this.lblOrgEmail.Size = new System.Drawing.Size(298, 22);
            this.lblOrgEmail.Text = "Organization email";
            this.lblOrgEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblOrgEmail.Name = "lblOrgEmail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEmail.Location = new System.Drawing.Point(350, 174);
            this.txtEmail.Size = new System.Drawing.Size(298, 27);
            this.txtEmail.Hint = "info@yourorganization.org";
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Name = "txtEmail";
            // 
            // lblProof
            // 
            this.lblProof.AutoSize = false;
            this.lblProof.BackColor = System.Drawing.Color.Transparent;
            this.lblProof.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProof.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblProof.Location = new System.Drawing.Point(32, 216);
            this.lblProof.Size = new System.Drawing.Size(616, 22);
            this.lblProof.Text = "Proof of legal entity";
            this.lblProof.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblProof.Name = "lblProof";
            // 
            // txtBrowse
            // 
            this.txtBrowse.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtBrowse.Location = new System.Drawing.Point(32, 238);
            this.txtBrowse.Size = new System.Drawing.Size(512, 27);
            this.txtBrowse.ReadOnly = true;
            this.txtBrowse.BackColor = System.Drawing.Color.White;
            this.txtBrowse.TabIndex = 3;
            this.txtBrowse.TabStop = false;
            this.txtBrowse.Name = "txtBrowse";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBrowse.Location = new System.Drawing.Point(552, 238);
            this.btnBrowse.Size = new System.Drawing.Size(96, 28);
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnBrowse.FlatAppearance.BorderSize = 1;
            this.btnBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = false;
            this.lblProvince.BackColor = System.Drawing.Color.Transparent;
            this.lblProvince.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProvince.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblProvince.Location = new System.Drawing.Point(32, 280);
            this.lblProvince.Size = new System.Drawing.Size(298, 22);
            this.lblProvince.Text = "Province";
            this.lblProvince.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblProvince.Name = "lblProvince";
            // 
            // cmbProvince
            // 
            this.cmbProvince.BackColor = System.Drawing.Color.White;
            this.cmbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProvince.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(32, 302);
            this.cmbProvince.Size = new System.Drawing.Size(298, 27);
            this.cmbProvince.Items.AddRange(new object[] {
            "Eastern Cape",
            "Free State",
            "Gauteng",
            "KwaZulu-Natal",
            "Limpopo",
            "Mpumalanga",
            "Northern Cape",
            "North West",
            "Western Cape"});
            this.cmbProvince.TabIndex = 5;
            this.cmbProvince.Name = "cmbProvince";
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = false;
            this.lblPostal.BackColor = System.Drawing.Color.Transparent;
            this.lblPostal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPostal.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblPostal.Location = new System.Drawing.Point(350, 280);
            this.lblPostal.Size = new System.Drawing.Size(298, 22);
            this.lblPostal.Text = "Postal code";
            this.lblPostal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblPostal.Name = "lblPostal";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCode.Location = new System.Drawing.Point(350, 302);
            this.txtCode.Size = new System.Drawing.Size(298, 27);
            this.txtCode.Hint = "e.g. 2000";
            this.txtCode.MaxLength = 4;
            this.txtCode.TabIndex = 6;
            this.txtCode.Name = "txtCode";
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = false;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblAddress.Location = new System.Drawing.Point(32, 344);
            this.lblAddress.Size = new System.Drawing.Size(616, 22);
            this.lblAddress.Text = "Physical address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblAddress.Name = "lblAddress";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAdress.Location = new System.Drawing.Point(32, 366);
            this.txtAdress.Size = new System.Drawing.Size(616, 27);
            this.txtAdress.Hint = "Street, suburb, city";
            this.txtAdress.TabIndex = 7;
            this.txtAdress.Name = "txtAdress";
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = false;
            this.lblCreate.BackColor = System.Drawing.Color.Transparent;
            this.lblCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCreate.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblCreate.Location = new System.Drawing.Point(32, 408);
            this.lblCreate.Size = new System.Drawing.Size(298, 22);
            this.lblCreate.Text = "Create password";
            this.lblCreate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblCreate.Name = "lblCreate";
            // 
            // txtCreate
            // 
            this.txtCreate.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCreate.Location = new System.Drawing.Point(32, 430);
            this.txtCreate.Size = new System.Drawing.Size(298, 27);
            this.txtCreate.PasswordChar = '*';
            this.txtCreate.TabIndex = 8;
            this.txtCreate.Name = "txtCreate";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = false;
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblConfirm.Location = new System.Drawing.Point(350, 408);
            this.lblConfirm.Size = new System.Drawing.Size(298, 22);
            this.lblConfirm.Text = "Confirm password";
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblConfirm.Name = "lblConfirm";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtConfirm.Location = new System.Drawing.Point(350, 430);
            this.txtConfirm.Size = new System.Drawing.Size(298, 27);
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.TabIndex = 9;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCreate.Location = new System.Drawing.Point(498, 480);
            this.btnCreate.Size = new System.Drawing.Size(150, 38);
            this.btnCreate.Text = "Create account";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 95, 15);
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(214, 110, 20);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.Location = new System.Drawing.Point(388, 480);
            this.btnBack.Size = new System.Drawing.Size(100, 38);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnBack.FlatAppearance.BorderSize = 1;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnBack.TabIndex = 11;
            this.btnBack.Name = "btnBack";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flowFooter
            // 
            this.flowFooter.Controls.Add(this.lblHaveAccount);
            this.flowFooter.Controls.Add(this.btnLogin);
            this.flowFooter.BackColor = System.Drawing.Color.White;
            this.flowFooter.Location = new System.Drawing.Point(32, 526);
            this.flowFooter.Size = new System.Drawing.Size(616, 40);
            this.flowFooter.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowFooter.WrapContents = false;
            this.flowFooter.Name = "flowFooter";
            // 
            // lblHaveAccount
            // 
            this.lblHaveAccount.AutoSize = true;
            this.lblHaveAccount.BackColor = System.Drawing.Color.White;
            this.lblHaveAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHaveAccount.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblHaveAccount.Margin = new System.Windows.Forms.Padding(0, 7, 4, 0);
            this.lblHaveAccount.Text = "Already have an account?";
            this.lblHaveAccount.Name = "lblHaveAccount";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(180, 90, 10);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(253, 242, 230);
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(253, 242, 230);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // brandPanel
            // 
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.brandPanel.Location = new System.Drawing.Point(0, 0);
            this.brandPanel.Size = new System.Drawing.Size(300, 590);
            this.brandPanel.Headline = "Share your surplus with people who need it.";
            this.brandPanel.Bullet1 = "Free for organizations";
            this.brandPanel.Bullet2 = "Register in a few minutes";
            this.brandPanel.Bullet3 = "Reach families who need it most";
            this.brandPanel.Name = "brandPanel";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Organization
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlCover);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create an organization donor account";
            this.AcceptButton = this.btnCreate;
            this.Name = "Organization";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowFooter.ResumeLayout(false);
            this.flowFooter.PerformLayout();
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
        private System.Windows.Forms.Label lblOrgName;
        private Project.HintBox txtName;
        private System.Windows.Forms.Label lblRegNum;
        private Project.HintBox txtRegnum;
        private System.Windows.Forms.Label lblOrgEmail;
        private Project.HintBox txtEmail;
        private System.Windows.Forms.Label lblProof;
        private Project.HintBox txtBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.Label lblPostal;
        private Project.HintBox txtCode;
        private System.Windows.Forms.Label lblAddress;
        private Project.HintBox txtAdress;
        private System.Windows.Forms.Label lblCreate;
        private Project.HintBox txtCreate;
        private System.Windows.Forms.Label lblConfirm;
        private Project.HintBox txtConfirm;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel flowFooter;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.Button btnLogin;
        private Project.BrandPanel brandPanel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
