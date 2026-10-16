namespace Project
{
    partial class Donor
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
            this.btnMoney = new System.Windows.Forms.Button();
            this.statDonations = new Project.StatCard();
            this.statItems = new Project.StatCard();
            this.statMoney = new Project.StatCard();
            this.statLast = new Project.StatCard();
            this.cardForm = new Project.CardPanel();
            this.cardFormTitle = new System.Windows.Forms.Label();
            this.cardFormSub = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new Project.HintBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new Project.HintBox();
            this.lblBest = new System.Windows.Forms.Label();
            this.dtpBest = new System.Windows.Forms.DateTimePicker();
            this.lblHandover = new System.Windows.Forms.Label();
            this.cmbHandover = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddr = new Project.HintBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFormNote = new System.Windows.Forms.Label();
            this.cardRecent = new Project.CardPanel();
            this.cardRecentTitle = new System.Windows.Forms.Label();
            this.cardRecentSub = new System.Windows.Forms.Label();
            this.lvDonations = new System.Windows.Forms.ListView();
            this.lvDonations_date = new System.Windows.Forms.ColumnHeader();
            this.lvDonations_item = new System.Windows.Forms.ColumnHeader();
            this.lvDonations_qty = new System.Windows.Forms.ColumnHeader();
            this.lvDonations_status = new System.Windows.Forms.ColumnHeader();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblNeededHead = new System.Windows.Forms.Label();
            this.lblNeededText = new System.Windows.Forms.Label();
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
            this.pnlContent.Controls.Add(this.btnMoney);
            this.pnlContent.Controls.Add(this.statDonations);
            this.pnlContent.Controls.Add(this.statItems);
            this.pnlContent.Controls.Add(this.statMoney);
            this.pnlContent.Controls.Add(this.statLast);
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
            this.lblWelcome.Size = new System.Drawing.Size(860, 38);
            this.lblWelcome.Text = "Welcome back, Name";
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
            this.lblIntro.Size = new System.Drawing.Size(860, 24);
            this.lblIntro.Text = "Share surplus food with the families and community groups who need it.";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIntro.Name = "lblIntro";
            // 
            // btnMoney
            // 
            this.btnMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoney.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMoney.Location = new System.Drawing.Point(950, 30);
            this.btnMoney.Size = new System.Drawing.Size(190, 42);
            this.btnMoney.Text = "Donate money";
            this.btnMoney.UseVisualStyleBackColor = false;
            this.btnMoney.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnMoney.ForeColor = System.Drawing.Color.White;
            this.btnMoney.FlatAppearance.BorderSize = 0;
            this.btnMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 95, 15);
            this.btnMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(214, 110, 20);
            this.btnMoney.TabIndex = 0;
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // statDonations
            // 
            this.statDonations.Accent = System.Drawing.Color.FromArgb(230, 126, 34);
            this.statDonations.Caption = "Donations made";
            this.statDonations.Location = new System.Drawing.Point(60, 100);
            this.statDonations.Size = new System.Drawing.Size(252, 88);
            this.statDonations.Value = "0";
            this.statDonations.Name = "statDonations";
            // 
            // statItems
            // 
            this.statItems.Accent = System.Drawing.Color.FromArgb(31, 58, 86);
            this.statItems.Caption = "Items donated";
            this.statItems.Location = new System.Drawing.Point(336, 100);
            this.statItems.Size = new System.Drawing.Size(252, 88);
            this.statItems.Value = "0";
            this.statItems.Name = "statItems";
            // 
            // statMoney
            // 
            this.statMoney.Accent = System.Drawing.Color.FromArgb(46, 139, 115);
            this.statMoney.Caption = "Money pledged";
            this.statMoney.Location = new System.Drawing.Point(612, 100);
            this.statMoney.Size = new System.Drawing.Size(252, 88);
            this.statMoney.Value = "R0";
            this.statMoney.Name = "statMoney";
            // 
            // statLast
            // 
            this.statLast.Accent = System.Drawing.Color.FromArgb(230, 126, 34);
            this.statLast.Caption = "Last donation";
            this.statLast.Location = new System.Drawing.Point(888, 100);
            this.statLast.Size = new System.Drawing.Size(252, 88);
            this.statLast.Value = "None yet";
            this.statLast.Name = "statLast";
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
            this.cardForm.Controls.Add(this.lblBest);
            this.cardForm.Controls.Add(this.dtpBest);
            this.cardForm.Controls.Add(this.lblHandover);
            this.cardForm.Controls.Add(this.cmbHandover);
            this.cardForm.Controls.Add(this.lblAddress);
            this.cardForm.Controls.Add(this.txtAddr);
            this.cardForm.Controls.Add(this.btnSubmit);
            this.cardForm.Controls.Add(this.btnClear);
            this.cardForm.Controls.Add(this.lblFormNote);
            this.cardForm.Accent = System.Drawing.Color.FromArgb(230, 126, 34);
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
            this.cardFormTitle.Text = "Make a donation";
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
            this.cardFormSub.Text = "Tell us what you can give and when.";
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
            this.cmbCategory.TabIndex = 1;
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
            this.lblQty.Text = "Quantity";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblQty.Name = "lblQty";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtQty.Location = new System.Drawing.Point(310, 102);
            this.txtQty.Size = new System.Drawing.Size(266, 27);
            this.txtQty.Hint = "e.g. 20";
            this.txtQty.TabIndex = 2;
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
            this.lblItem.Text = "Item description";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblItem.Name = "lblItem";
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtItem.Location = new System.Drawing.Point(24, 166);
            this.txtItem.Size = new System.Drawing.Size(552, 27);
            this.txtItem.Hint = "e.g. Long-life milk, 1 litre";
            this.txtItem.TabIndex = 3;
            this.txtItem.Name = "txtItem";
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = false;
            this.lblBest.BackColor = System.Drawing.Color.Transparent;
            this.lblBest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBest.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblBest.Location = new System.Drawing.Point(24, 208);
            this.lblBest.Size = new System.Drawing.Size(266, 22);
            this.lblBest.Text = "Best before";
            this.lblBest.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblBest.Name = "lblBest";
            // 
            // dtpBest
            // 
            this.dtpBest.CustomFormat = "dd MMM yyyy";
            this.dtpBest.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpBest.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBest.Location = new System.Drawing.Point(24, 230);
            this.dtpBest.Size = new System.Drawing.Size(266, 27);
            this.dtpBest.TabIndex = 4;
            this.dtpBest.Name = "dtpBest";
            // 
            // lblHandover
            // 
            this.lblHandover.AutoSize = false;
            this.lblHandover.BackColor = System.Drawing.Color.Transparent;
            this.lblHandover.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHandover.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblHandover.Location = new System.Drawing.Point(310, 208);
            this.lblHandover.Size = new System.Drawing.Size(266, 22);
            this.lblHandover.Text = "Handover";
            this.lblHandover.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblHandover.Name = "lblHandover";
            // 
            // cmbHandover
            // 
            this.cmbHandover.BackColor = System.Drawing.Color.White;
            this.cmbHandover.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHandover.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbHandover.FormattingEnabled = true;
            this.cmbHandover.Location = new System.Drawing.Point(310, 230);
            this.cmbHandover.Size = new System.Drawing.Size(266, 27);
            this.cmbHandover.Items.AddRange(new object[] {
            "I will drop it off",
            "Please collect from me"});
            this.cmbHandover.TabIndex = 5;
            this.cmbHandover.Name = "cmbHandover";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = false;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblAddress.Location = new System.Drawing.Point(24, 272);
            this.lblAddress.Size = new System.Drawing.Size(552, 22);
            this.lblAddress.Text = "Pickup address (only if we collect)";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblAddress.Name = "lblAddress";
            // 
            // txtAddr
            // 
            this.txtAddr.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAddr.Location = new System.Drawing.Point(24, 294);
            this.txtAddr.Size = new System.Drawing.Size(552, 27);
            this.txtAddr.Hint = "Street, suburb, city";
            this.txtAddr.TabIndex = 6;
            this.txtAddr.Name = "txtAddr";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubmit.Location = new System.Drawing.Point(406, 348);
            this.btnSubmit.Size = new System.Drawing.Size(170, 38);
            this.btnSubmit.Text = "Submit donation";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 95, 15);
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(214, 110, 20);
            this.btnSubmit.TabIndex = 7;
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
            this.btnClear.TabIndex = 8;
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
            this.lblFormNote.Text = "We will contact you by email to arrange the handover.";
            this.lblFormNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFormNote.Name = "lblFormNote";
            // 
            // cardRecent
            // 
            this.cardRecent.Controls.Add(this.cardRecentTitle);
            this.cardRecent.Controls.Add(this.cardRecentSub);
            this.cardRecent.Controls.Add(this.lvDonations);
            this.cardRecent.Controls.Add(this.lblEmpty);
            this.cardRecent.Controls.Add(this.lblNeededHead);
            this.cardRecent.Controls.Add(this.lblNeededText);
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
            this.cardRecentTitle.Text = "Your recent donations";
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
            this.cardRecentSub.Text = "Your latest submissions and their status.";
            this.cardRecentSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardRecentSub.Name = "cardRecentSub";
            // 
            // lvDonations
            // 
            this.lvDonations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvDonations_date,
            this.lvDonations_item,
            this.lvDonations_qty,
            this.lvDonations_status});
            this.lvDonations.BackColor = System.Drawing.Color.White;
            this.lvDonations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvDonations.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lvDonations.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lvDonations.FullRowSelect = true;
            this.lvDonations.GridLines = false;
            this.lvDonations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvDonations.HideSelection = false;
            this.lvDonations.Location = new System.Drawing.Point(24, 80);
            this.lvDonations.Size = new System.Drawing.Size(408, 270);
            this.lvDonations.UseCompatibleStateImageBehavior = false;
            this.lvDonations.View = System.Windows.Forms.View.Details;
            this.lvDonations.Name = "lvDonations";
            // 
            // lvDonations_date
            // 
            this.lvDonations_date.Text = "Date";
            this.lvDonations_date.Width = 96;
            // 
            // lvDonations_item
            // 
            this.lvDonations_item.Text = "Item";
            this.lvDonations_item.Width = 150;
            // 
            // lvDonations_qty
            // 
            this.lvDonations_qty.Text = "Qty";
            this.lvDonations_qty.Width = 56;
            // 
            // lvDonations_status
            // 
            this.lvDonations_status.Text = "Status";
            this.lvDonations_status.Width = 90;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = false;
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmpty.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblEmpty.Location = new System.Drawing.Point(24, 80);
            this.lblEmpty.Size = new System.Drawing.Size(408, 270);
            this.lblEmpty.Text = "You have not made a donation yet.\r\nUse the form on the left to get started.";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpty.Name = "lblEmpty";
            // 
            // lblNeededHead
            // 
            this.lblNeededHead.AutoSize = false;
            this.lblNeededHead.BackColor = System.Drawing.Color.Transparent;
            this.lblNeededHead.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblNeededHead.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.lblNeededHead.Location = new System.Drawing.Point(24, 366);
            this.lblNeededHead.Size = new System.Drawing.Size(408, 24);
            this.lblNeededHead.Text = "Most needed right now";
            this.lblNeededHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNeededHead.Name = "lblNeededHead";
            // 
            // lblNeededText
            // 
            this.lblNeededText.AutoSize = false;
            this.lblNeededText.BackColor = System.Drawing.Color.Transparent;
            this.lblNeededText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNeededText.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblNeededText.Location = new System.Drawing.Point(24, 392);
            this.lblNeededText.Size = new System.Drawing.Size(408, 40);
            this.lblNeededText.Text = "Rice, Maize meal, Pasta, Samp and beans, Lentils, Tinned fish and more.";
            this.lblNeededText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNeededText.Name = "lblNeededText";
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Size = new System.Drawing.Size(1200, 60);
            this.topBar.Name = "topBar";
            // 
            // Donor
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
            this.Text = "Food Donation System - Donor dashboard";
            this.AcceptButton = this.btnSubmit;
            this.Name = "Donor";
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
        private System.Windows.Forms.Button btnMoney;
        private Project.StatCard statDonations;
        private Project.StatCard statItems;
        private Project.StatCard statMoney;
        private Project.StatCard statLast;
        private Project.CardPanel cardForm;
        private System.Windows.Forms.Label cardFormTitle;
        private System.Windows.Forms.Label cardFormSub;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblQty;
        private Project.HintBox txtQty;
        private System.Windows.Forms.Label lblItem;
        private Project.HintBox txtItem;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.DateTimePicker dtpBest;
        private System.Windows.Forms.Label lblHandover;
        private System.Windows.Forms.ComboBox cmbHandover;
        private System.Windows.Forms.Label lblAddress;
        private Project.HintBox txtAddr;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFormNote;
        private Project.CardPanel cardRecent;
        private System.Windows.Forms.Label cardRecentTitle;
        private System.Windows.Forms.Label cardRecentSub;
        private System.Windows.Forms.ListView lvDonations;
        private System.Windows.Forms.ColumnHeader lvDonations_date;
        private System.Windows.Forms.ColumnHeader lvDonations_item;
        private System.Windows.Forms.ColumnHeader lvDonations_qty;
        private System.Windows.Forms.ColumnHeader lvDonations_status;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblNeededHead;
        private System.Windows.Forms.Label lblNeededText;
        private Project.TopBar topBar;
    }
}
