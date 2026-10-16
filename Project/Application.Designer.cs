namespace Project
{
    partial class Application
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.statRequests = new Project.StatCard();
            this.statPending = new Project.StatCard();
            this.statPeople = new Project.StatCard();
            this.cardForm = new Project.CardPanel();
            this.cardFormTitle = new System.Windows.Forms.Label();
            this.cardFormSub = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new Project.HintBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new Project.HintBox();
            this.lblPeople = new System.Windows.Forms.Label();
            this.txtPeople = new Project.HintBox();
            this.lblUrgency = new System.Windows.Forms.Label();
            this.cmbUrgency = new System.Windows.Forms.ComboBox();
            this.lblReceive = new System.Windows.Forms.Label();
            this.cmbReceive = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFormNote = new System.Windows.Forms.Label();
            this.cardRecent = new Project.CardPanel();
            this.cardRecentTitle = new System.Windows.Forms.Label();
            this.cardRecentSub = new System.Windows.Forms.Label();
            this.lvRequests = new System.Windows.Forms.ListView();
            this.lvRequests_date = new System.Windows.Forms.ColumnHeader();
            this.lvRequests_item = new System.Windows.Forms.ColumnHeader();
            this.lvRequests_people = new System.Windows.Forms.ColumnHeader();
            this.lvRequests_status = new System.Windows.Forms.ColumnHeader();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblBeforeHead = new System.Windows.Forms.Label();
            this.lblBeforeText = new System.Windows.Forms.Label();
            this.topBar = new Project.TopBar();
            this.pnlContent.SuspendLayout();
            this.cardForm.SuspendLayout();
            this.cardRecent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblWelcome);
            this.pnlContent.Controls.Add(this.lblIntro);
            this.pnlContent.Controls.Add(this.statRequests);
            this.pnlContent.Controls.Add(this.statPending);
            this.pnlContent.Controls.Add(this.statPeople);
            this.pnlContent.Controls.Add(this.cardForm);
            this.pnlContent.Controls.Add(this.cardRecent);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(250, 246, 240);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Size = new System.Drawing.Size(1200, 700);
            this.pnlContent.Name = "pnlContent";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 22F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.lblWelcome.Location = new System.Drawing.Point(60, 22);
            this.lblWelcome.Size = new System.Drawing.Size(1080, 38);
            this.lblWelcome.Text = "Welcome, Name";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWelcome.Name = "lblWelcome";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = false;
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblIntro.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblIntro.Location = new System.Drawing.Point(60, 62);
            this.lblIntro.Size = new System.Drawing.Size(1080, 24);
            this.lblIntro.Text = "Request food support for the people your organization looks after.";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIntro.Name = "lblIntro";
            // 
            // statRequests
            // 
            this.statRequests.Accent = System.Drawing.Color.FromArgb(46, 139, 115);
            this.statRequests.Caption = "Requests submitted";
            this.statRequests.Location = new System.Drawing.Point(60, 100);
            this.statRequests.Size = new System.Drawing.Size(344, 88);
            this.statRequests.Value = "0";
            this.statRequests.Name = "statRequests";
            // 
            // statPending
            // 
            this.statPending.Accent = System.Drawing.Color.FromArgb(230, 126, 34);
            this.statPending.Caption = "Waiting for review";
            this.statPending.Location = new System.Drawing.Point(428, 100);
            this.statPending.Size = new System.Drawing.Size(344, 88);
            this.statPending.Value = "0";
            this.statPending.Name = "statPending";
            // 
            // statPeople
            // 
            this.statPeople.Accent = System.Drawing.Color.FromArgb(31, 58, 86);
            this.statPeople.Caption = "People requested for";
            this.statPeople.Location = new System.Drawing.Point(796, 100);
            this.statPeople.Size = new System.Drawing.Size(344, 88);
            this.statPeople.Value = "0";
            this.statPeople.Name = "statPeople";
            // 
            // cardForm
            // 
            this.cardForm.Controls.Add(this.cardFormTitle);
            this.cardForm.Controls.Add(this.cardFormSub);
            this.cardForm.Controls.Add(this.lblCategory);
            this.cardForm.Controls.Add(this.cmbCategory);
            this.cardForm.Controls.Add(this.lblQty);
            this.cardForm.Controls.Add(this.txtQty);
            this.cardForm.Controls.Add(this.lblItem);
            this.cardForm.Controls.Add(this.txtItem);
            this.cardForm.Controls.Add(this.lblPeople);
            this.cardForm.Controls.Add(this.txtPeople);
            this.cardForm.Controls.Add(this.lblUrgency);
            this.cardForm.Controls.Add(this.cmbUrgency);
            this.cardForm.Controls.Add(this.lblReceive);
            this.cardForm.Controls.Add(this.cmbReceive);
            this.cardForm.Controls.Add(this.btnSubmit);
            this.cardForm.Controls.Add(this.btnClear);
            this.cardForm.Controls.Add(this.lblFormNote);
            this.cardForm.Accent = System.Drawing.Color.FromArgb(46, 139, 115);
            this.cardForm.BackColor = System.Drawing.Color.White;
            this.cardForm.Location = new System.Drawing.Point(60, 204);
            this.cardForm.Size = new System.Drawing.Size(600, 450);
            this.cardForm.Name = "cardForm";
            // 
            // cardFormTitle
            // 
            this.cardFormTitle.AutoSize = false;
            this.cardFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.cardFormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.cardFormTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.cardFormTitle.Location = new System.Drawing.Point(24, 18);
            this.cardFormTitle.Size = new System.Drawing.Size(552, 30);
            this.cardFormTitle.Text = "Request food support";
            this.cardFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardFormTitle.Name = "cardFormTitle";
            // 
            // cardFormSub
            // 
            this.cardFormSub.AutoSize = false;
            this.cardFormSub.BackColor = System.Drawing.Color.Transparent;
            this.cardFormSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cardFormSub.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.cardFormSub.Location = new System.Drawing.Point(24, 48);
            this.cardFormSub.Size = new System.Drawing.Size(552, 22);
            this.cardFormSub.Text = "Tell us what your community needs.";
            this.cardFormSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardFormSub.Name = "cardFormSub";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = false;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblCategory.Location = new System.Drawing.Point(24, 80);
            this.lblCategory.Size = new System.Drawing.Size(266, 22);
            this.lblCategory.Text = "Food category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblCategory.Name = "lblCategory";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(24, 102);
            this.cmbCategory.Size = new System.Drawing.Size(266, 27);
            this.cmbCategory.Items.AddRange(new object[] {
            "Grains and cereals",
            "Tinned food",
            "Fresh produce",
            "Dairy and eggs",
            "Bakery",
            "Cooked meals",
            "Drinks",
            "Other"});
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.Name = "cmbCategory";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = false;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblQty.Location = new System.Drawing.Point(310, 80);
            this.lblQty.Size = new System.Drawing.Size(266, 22);
            this.lblQty.Text = "Quantity needed";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblQty.Name = "lblQty";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtQty.Location = new System.Drawing.Point(310, 102);
            this.txtQty.Size = new System.Drawing.Size(266, 27);
            this.txtQty.Hint = "e.g. 50";
            this.txtQty.TabIndex = 1;
            this.txtQty.Name = "txtQty";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = false;
            this.lblItem.BackColor = System.Drawing.Color.Transparent;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblItem.Location = new System.Drawing.Point(24, 144);
            this.lblItem.Size = new System.Drawing.Size(552, 22);
            this.lblItem.Text = "Items needed";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblItem.Name = "lblItem";
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtItem.Location = new System.Drawing.Point(24, 166);
            this.txtItem.Size = new System.Drawing.Size(552, 27);
            this.txtItem.Hint = "e.g. Maize meal, 10 kg bags";
            this.txtItem.TabIndex = 2;
            this.txtItem.Name = "txtItem";
            // 
            // lblPeople
            // 
            this.lblPeople.AutoSize = false;
            this.lblPeople.BackColor = System.Drawing.Color.Transparent;
            this.lblPeople.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPeople.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblPeople.Location = new System.Drawing.Point(24, 208);
            this.lblPeople.Size = new System.Drawing.Size(266, 22);
            this.lblPeople.Text = "People to be fed";
            this.lblPeople.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblPeople.Name = "lblPeople";
            // 
            // txtPeople
            // 
            this.txtPeople.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPeople.Location = new System.Drawing.Point(24, 230);
            this.txtPeople.Size = new System.Drawing.Size(266, 27);
            this.txtPeople.Hint = "e.g. 120";
            this.txtPeople.TabIndex = 3;
            this.txtPeople.Name = "txtPeople";
            // 
            // lblUrgency
            // 
            this.lblUrgency.AutoSize = false;
            this.lblUrgency.BackColor = System.Drawing.Color.Transparent;
            this.lblUrgency.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUrgency.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblUrgency.Location = new System.Drawing.Point(310, 208);
            this.lblUrgency.Size = new System.Drawing.Size(266, 22);
            this.lblUrgency.Text = "How soon?";
            this.lblUrgency.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblUrgency.Name = "lblUrgency";
            // 
            // cmbUrgency
            // 
            this.cmbUrgency.BackColor = System.Drawing.Color.White;
            this.cmbUrgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrgency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUrgency.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbUrgency.FormattingEnabled = true;
            this.cmbUrgency.Location = new System.Drawing.Point(310, 230);
            this.cmbUrgency.Size = new System.Drawing.Size(266, 27);
            this.cmbUrgency.Items.AddRange(new object[] {
            "This week",
            "Within two weeks",
            "Within a month"});
            this.cmbUrgency.TabIndex = 4;
            this.cmbUrgency.Name = "cmbUrgency";
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = false;
            this.lblReceive.BackColor = System.Drawing.Color.Transparent;
            this.lblReceive.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReceive.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblReceive.Location = new System.Drawing.Point(24, 272);
            this.lblReceive.Size = new System.Drawing.Size(552, 22);
            this.lblReceive.Text = "How would you like to receive it?";
            this.lblReceive.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblReceive.Name = "lblReceive";
            // 
            // cmbReceive
            // 
            this.cmbReceive.BackColor = System.Drawing.Color.White;
            this.cmbReceive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReceive.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbReceive.FormattingEnabled = true;
            this.cmbReceive.Location = new System.Drawing.Point(24, 294);
            this.cmbReceive.Size = new System.Drawing.Size(552, 27);
            this.cmbReceive.Items.AddRange(new object[] {
            "We will collect",
            "Please deliver to us"});
            this.cmbReceive.TabIndex = 5;
            this.cmbReceive.Name = "cmbReceive";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(406, 348);
            this.btnSubmit.Size = new System.Drawing.Size(170, 38);
            this.btnSubmit.Text = "Submit request";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 95, 15);
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(214, 110, 20);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Location = new System.Drawing.Point(296, 348);
            this.btnClear.Size = new System.Drawing.Size(100, 38);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnClear.TabIndex = 7;
            this.btnClear.Name = "btnClear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFormNote
            // 
            this.lblFormNote.AutoSize = false;
            this.lblFormNote.BackColor = System.Drawing.Color.Transparent;
            this.lblFormNote.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFormNote.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblFormNote.Location = new System.Drawing.Point(24, 404);
            this.lblFormNote.Size = new System.Drawing.Size(552, 24);
            this.lblFormNote.Text = "Requests are reviewed by our team. We will reply by email.";
            this.lblFormNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFormNote.Name = "lblFormNote";
            // 
            // cardRecent
            // 
            this.cardRecent.Controls.Add(this.cardRecentTitle);
            this.cardRecent.Controls.Add(this.cardRecentSub);
            this.cardRecent.Controls.Add(this.lvRequests);
            this.cardRecent.Controls.Add(this.lblEmpty);
            this.cardRecent.Controls.Add(this.lblBeforeHead);
            this.cardRecent.Controls.Add(this.lblBeforeText);
            this.cardRecent.Accent = System.Drawing.Color.FromArgb(31, 58, 86);
            this.cardRecent.BackColor = System.Drawing.Color.White;
            this.cardRecent.Location = new System.Drawing.Point(684, 204);
            this.cardRecent.Size = new System.Drawing.Size(456, 450);
            this.cardRecent.Name = "cardRecent";
            // 
            // cardRecentTitle
            // 
            this.cardRecentTitle.AutoSize = false;
            this.cardRecentTitle.BackColor = System.Drawing.Color.Transparent;
            this.cardRecentTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.cardRecentTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.cardRecentTitle.Location = new System.Drawing.Point(24, 18);
            this.cardRecentTitle.Size = new System.Drawing.Size(408, 30);
            this.cardRecentTitle.Text = "Your recent requests";
            this.cardRecentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardRecentTitle.Name = "cardRecentTitle";
            // 
            // cardRecentSub
            // 
            this.cardRecentSub.AutoSize = false;
            this.cardRecentSub.BackColor = System.Drawing.Color.Transparent;
            this.cardRecentSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cardRecentSub.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.cardRecentSub.Location = new System.Drawing.Point(24, 48);
            this.cardRecentSub.Size = new System.Drawing.Size(408, 22);
            this.cardRecentSub.Text = "Your latest requests and their status.";
            this.cardRecentSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardRecentSub.Name = "cardRecentSub";
            // 
            // lvRequests
            // 
            this.lvRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvRequests_date,
            this.lvRequests_item,
            this.lvRequests_people,
            this.lvRequests_status});
            this.lvRequests.BackColor = System.Drawing.Color.White;
            this.lvRequests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRequests.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lvRequests.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lvRequests.FullRowSelect = true;
            this.lvRequests.GridLines = false;
            this.lvRequests.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRequests.HideSelection = false;
            this.lvRequests.Location = new System.Drawing.Point(24, 80);
            this.lvRequests.Size = new System.Drawing.Size(408, 270);
            this.lvRequests.UseCompatibleStateImageBehavior = false;
            this.lvRequests.View = System.Windows.Forms.View.Details;
            this.lvRequests.Name = "lvRequests";
            // 
            // lvRequests_date
            // 
            this.lvRequests_date.Text = "Date";
            this.lvRequests_date.Width = 96;
            // 
            // lvRequests_item
            // 
            this.lvRequests_item.Text = "Item";
            this.lvRequests_item.Width = 150;
            // 
            // lvRequests_people
            // 
            this.lvRequests_people.Text = "People";
            this.lvRequests_people.Width = 66;
            // 
            // lvRequests_status
            // 
            this.lvRequests_status.Text = "Status";
            this.lvRequests_status.Width = 80;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = false;
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmpty.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblEmpty.Location = new System.Drawing.Point(24, 80);
            this.lblEmpty.Size = new System.Drawing.Size(408, 270);
            this.lblEmpty.Text = "You have not made a request yet.\r\nUse the form on the left to get started.";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpty.Name = "lblEmpty";
            // 
            // lblBeforeHead
            // 
            this.lblBeforeHead.AutoSize = false;
            this.lblBeforeHead.BackColor = System.Drawing.Color.Transparent;
            this.lblBeforeHead.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblBeforeHead.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.lblBeforeHead.Location = new System.Drawing.Point(24, 366);
            this.lblBeforeHead.Size = new System.Drawing.Size(408, 24);
            this.lblBeforeHead.Text = "Before you apply";
            this.lblBeforeHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBeforeHead.Name = "lblBeforeHead";
            // 
            // lblBeforeText
            // 
            this.lblBeforeText.AutoSize = false;
            this.lblBeforeText.BackColor = System.Drawing.Color.Transparent;
            this.lblBeforeText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBeforeText.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblBeforeText.Location = new System.Drawing.Point(24, 392);
            this.lblBeforeText.Size = new System.Drawing.Size(408, 44);
            this.lblBeforeText.Text = "Keep your proof of registration up to date. We will contact you once a request is reviewed.";
            this.lblBeforeText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBeforeText.Name = "lblBeforeText";
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Size = new System.Drawing.Size(1200, 60);
            this.topBar.Name = "topBar";
            // 
            // Application
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.topBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Donation System - Applicant dashboard";
            this.AcceptButton = this.btnSubmit;
            this.Name = "Application";
            this.cardRecent.ResumeLayout(false);
            this.cardRecent.PerformLayout();
            this.cardForm.ResumeLayout(false);
            this.cardForm.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblIntro;
        private Project.StatCard statRequests;
        private Project.StatCard statPending;
        private Project.StatCard statPeople;
        private Project.CardPanel cardForm;
        private System.Windows.Forms.Label cardFormTitle;
        private System.Windows.Forms.Label cardFormSub;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblQty;
        private Project.HintBox txtQty;
        private System.Windows.Forms.Label lblItem;
        private Project.HintBox txtItem;
        private System.Windows.Forms.Label lblPeople;
        private Project.HintBox txtPeople;
        private System.Windows.Forms.Label lblUrgency;
        private System.Windows.Forms.ComboBox cmbUrgency;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.ComboBox cmbReceive;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFormNote;
        private Project.CardPanel cardRecent;
        private System.Windows.Forms.Label cardRecentTitle;
        private System.Windows.Forms.Label cardRecentSub;
        private System.Windows.Forms.ListView lvRequests;
        private System.Windows.Forms.ColumnHeader lvRequests_date;
        private System.Windows.Forms.ColumnHeader lvRequests_item;
        private System.Windows.Forms.ColumnHeader lvRequests_people;
        private System.Windows.Forms.ColumnHeader lvRequests_status;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblBeforeHead;
        private System.Windows.Forms.Label lblBeforeText;
        private Project.TopBar topBar;
    }
}
