namespace Project
{
    partial class Individual
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtName = new Project.HintBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtSurname = new Project.HintBox();
            this.lblCell = new System.Windows.Forms.Label();
            this.txtNum = new Project.HintBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Project.HintBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.flowGender = new System.Windows.Forms.FlowLayoutPanel();
            this.rdnMale = new System.Windows.Forms.RadioButton();
            this.rdnFemale = new System.Windows.Forms.RadioButton();
            this.lblDob = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
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
            this.btnAccount = new System.Windows.Forms.Button();
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
            this.flowGender.SuspendLayout();
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
            this.pnlBody.Controls.Add(this.lblFirst);
            this.pnlBody.Controls.Add(this.txtName);
            this.pnlBody.Controls.Add(this.lblLast);
            this.pnlBody.Controls.Add(this.txtSurname);
            this.pnlBody.Controls.Add(this.lblCell);
            this.pnlBody.Controls.Add(this.txtNum);
            this.pnlBody.Controls.Add(this.lblEmail);
            this.pnlBody.Controls.Add(this.txtEmail);
            this.pnlBody.Controls.Add(this.lblGender);
            this.pnlBody.Controls.Add(this.flowGender);
            this.pnlBody.Controls.Add(this.lblDob);
            this.pnlBody.Controls.Add(this.dtpDOB);
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
            this.pnlBody.Controls.Add(this.btnAccount);
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
            this.lblSubtitle.Text = "Register as an individual donor.";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSubtitle.Name = "lblSubtitle";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = false;
            this.lblFirst.BackColor = System.Drawing.Color.Transparent;
            this.lblFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFirst.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblFirst.Location = new System.Drawing.Point(32, 88);
            this.lblFirst.Size = new System.Drawing.Size(298, 22);
            this.lblFirst.Text = "First name";
            this.lblFirst.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblFirst.Name = "lblFirst";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtName.Location = new System.Drawing.Point(32, 110);
            this.txtName.Size = new System.Drawing.Size(298, 27);
            this.txtName.Hint = "e.g. Thandi";
            this.txtName.TabIndex = 0;
            this.txtName.Name = "txtName";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = false;
            this.lblLast.BackColor = System.Drawing.Color.Transparent;
            this.lblLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLast.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblLast.Location = new System.Drawing.Point(350, 88);
            this.lblLast.Size = new System.Drawing.Size(298, 22);
            this.lblLast.Text = "Last name";
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblLast.Name = "lblLast";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSurname.Location = new System.Drawing.Point(350, 110);
            this.txtSurname.Size = new System.Drawing.Size(298, 27);
            this.txtSurname.Hint = "e.g. Mokoena";
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Name = "txtSurname";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = false;
            this.lblCell.BackColor = System.Drawing.Color.Transparent;
            this.lblCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCell.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblCell.Location = new System.Drawing.Point(32, 152);
            this.lblCell.Size = new System.Drawing.Size(298, 22);
            this.lblCell.Text = "Cellphone number";
            this.lblCell.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblCell.Name = "lblCell";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNum.Location = new System.Drawing.Point(32, 174);
            this.txtNum.Size = new System.Drawing.Size(298, 27);
            this.txtNum.Hint = "e.g. 0821234567";
            this.txtNum.MaxLength = 10;
            this.txtNum.TabIndex = 2;
            this.txtNum.Name = "txtNum";
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblEmail.Location = new System.Drawing.Point(350, 152);
            this.lblEmail.Size = new System.Drawing.Size(298, 22);
            this.lblEmail.Text = "Email address";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblEmail.Name = "lblEmail";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtEmail.Location = new System.Drawing.Point(350, 174);
            this.txtEmail.Size = new System.Drawing.Size(298, 27);
            this.txtEmail.Hint = "name@email.com";
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Name = "txtEmail";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = false;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblGender.Location = new System.Drawing.Point(32, 216);
            this.lblGender.Size = new System.Drawing.Size(298, 22);
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblGender.Name = "lblGender";
            // 
            // flowGender
            // 
            this.flowGender.Controls.Add(this.rdnMale);
            this.flowGender.Controls.Add(this.rdnFemale);
            this.flowGender.BackColor = System.Drawing.Color.White;
            this.flowGender.Location = new System.Drawing.Point(32, 238);
            this.flowGender.Size = new System.Drawing.Size(298, 28);
            this.flowGender.WrapContents = false;
            this.flowGender.Name = "flowGender";
            // 
            // rdnMale
            // 
            this.rdnMale.AutoSize = true;
            this.rdnMale.BackColor = System.Drawing.Color.White;
            this.rdnMale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdnMale.Margin = new System.Windows.Forms.Padding(0, 4, 20, 0);
            this.rdnMale.TabIndex = 4;
            this.rdnMale.Text = "Male";
            this.rdnMale.UseVisualStyleBackColor = false;
            this.rdnMale.Name = "rdnMale";
            // 
            // rdnFemale
            // 
            this.rdnFemale.AutoSize = true;
            this.rdnFemale.BackColor = System.Drawing.Color.White;
            this.rdnFemale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdnFemale.Margin = new System.Windows.Forms.Padding(0, 4, 20, 0);
            this.rdnFemale.TabIndex = 5;
            this.rdnFemale.Text = "Female";
            this.rdnFemale.UseVisualStyleBackColor = false;
            this.rdnFemale.Name = "rdnFemale";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = false;
            this.lblDob.BackColor = System.Drawing.Color.Transparent;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDob.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblDob.Location = new System.Drawing.Point(350, 216);
            this.lblDob.Size = new System.Drawing.Size(298, 22);
            this.lblDob.Text = "Date of birth";
            this.lblDob.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblDob.Name = "lblDob";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd MMM yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(350, 238);
            this.dtpDOB.Size = new System.Drawing.Size(298, 27);
            this.dtpDOB.TabIndex = 6;
            this.dtpDOB.Name = "dtpDOB";
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
            this.cmbProvince.TabIndex = 7;
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
            this.txtCode.TabIndex = 8;
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
            this.txtAdress.TabIndex = 9;
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
            this.txtCreate.TabIndex = 10;
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
            this.txtConfirm.TabIndex = 11;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAccount.Location = new System.Drawing.Point(498, 480);
            this.btnAccount.Size = new System.Drawing.Size(150, 38);
            this.btnAccount.Text = "Create account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 95, 15);
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(214, 110, 20);
            this.btnAccount.TabIndex = 12;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
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
            this.btnBack.TabIndex = 13;
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
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // brandPanel
            // 
            this.brandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.brandPanel.Location = new System.Drawing.Point(0, 0);
            this.brandPanel.Size = new System.Drawing.Size(300, 590);
            this.brandPanel.Headline = "Every meal starts with someone like you.";
            this.brandPanel.Bullet1 = "Free to register";
            this.brandPanel.Bullet2 = "Takes about two minutes";
            this.brandPanel.Bullet3 = "Help families in your community";
            this.brandPanel.Name = "brandPanel";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Individual
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlCover);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create an individual donor account";
            this.AcceptButton = this.btnAccount;
            this.Name = "Individual";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.flowFooter.ResumeLayout(false);
            this.flowFooter.PerformLayout();
            this.flowGender.ResumeLayout(false);
            this.flowGender.PerformLayout();
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
        private System.Windows.Forms.Label lblFirst;
        private Project.HintBox txtName;
        private System.Windows.Forms.Label lblLast;
        private Project.HintBox txtSurname;
        private System.Windows.Forms.Label lblCell;
        private Project.HintBox txtNum;
        private System.Windows.Forms.Label lblEmail;
        private Project.HintBox txtEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.FlowLayoutPanel flowGender;
        private System.Windows.Forms.RadioButton rdnMale;
        private System.Windows.Forms.RadioButton rdnFemale;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dtpDOB;
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
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel flowFooter;
        private System.Windows.Forms.Label lblHaveAccount;
        private System.Windows.Forms.Button btnLogin;
        private Project.BrandPanel brandPanel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
