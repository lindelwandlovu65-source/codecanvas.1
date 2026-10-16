namespace Project
{
    partial class DonateMoney
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
            this.statPledged = new Project.StatCard();
            this.statReceived = new Project.StatCard();
            this.statCount = new Project.StatCard();
            this.cardPledge = new Project.CardPanel();
            this.cardPledgeTitle = new System.Windows.Forms.Label();
            this.cardPledgeSub = new System.Windows.Forms.Label();
            this.rdoPreset50 = new System.Windows.Forms.RadioButton();
            this.rdoPreset100 = new System.Windows.Forms.RadioButton();
            this.rdoPreset250 = new System.Windows.Forms.RadioButton();
            this.rdoPreset500 = new System.Windows.Forms.RadioButton();
            this.rdoPreset1000 = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new Project.HintBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.cmbFrequency = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new Project.HintBox();
            this.btnPledge = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPledgeNote = new System.Windows.Forms.Label();
            this.lblWhereHead = new System.Windows.Forms.Label();
            this.lblWhereText = new System.Windows.Forms.Label();
            this.cardPay = new Project.CardPanel();
            this.cardPayTitle = new System.Windows.Forms.Label();
            this.cardPaySub = new System.Windows.Forms.Label();
            this.lblKeyBank = new System.Windows.Forms.Label();
            this.lblValBank = new System.Windows.Forms.Label();
            this.lblKeyAccountName = new System.Windows.Forms.Label();
            this.lblValAccountName = new System.Windows.Forms.Label();
            this.lblKeyAccountNumber = new System.Windows.Forms.Label();
            this.lblValAccountNumber = new System.Windows.Forms.Label();
            this.lblKeyBranch = new System.Windows.Forms.Label();
            this.lblValBranch = new System.Windows.Forms.Label();
            this.lblKeyReference = new System.Windows.Forms.Label();
            this.lblValReference = new System.Windows.Forms.Label();
            this.lblContribHead = new System.Windows.Forms.Label();
            this.lvContributions = new System.Windows.Forms.ListView();
            this.lvContributions_date = new System.Windows.Forms.ColumnHeader();
            this.lvContributions_amount = new System.Windows.Forms.ColumnHeader();
            this.lvContributions_ref = new System.Windows.Forms.ColumnHeader();
            this.lvContributions_status = new System.Windows.Forms.ColumnHeader();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.topBar = new Project.TopBar();
            this.pnlContent.SuspendLayout();
            this.cardPledge.SuspendLayout();
            this.cardPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblWelcome);
            this.pnlContent.Controls.Add(this.lblIntro);
            this.pnlContent.Controls.Add(this.statPledged);
            this.pnlContent.Controls.Add(this.statReceived);
            this.pnlContent.Controls.Add(this.statCount);
            this.pnlContent.Controls.Add(this.cardPledge);
            this.pnlContent.Controls.Add(this.cardPay);
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
            this.lblWelcome.Text = "Donate money";
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
            this.lblIntro.Text = "Every rand helps us move surplus food to the families who need it.";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIntro.Name = "lblIntro";
            // 
            // statPledged
            // 
            this.statPledged.Accent = System.Drawing.Color.FromArgb(230, 126, 34);
            this.statPledged.Caption = "Total pledged";
            this.statPledged.Location = new System.Drawing.Point(60, 100);
            this.statPledged.Size = new System.Drawing.Size(344, 88);
            this.statPledged.Value = "R0";
            this.statPledged.Name = "statPledged";
            // 
            // statReceived
            // 
            this.statReceived.Accent = System.Drawing.Color.FromArgb(46, 139, 115);
            this.statReceived.Caption = "Confirmed as received";
            this.statReceived.Location = new System.Drawing.Point(428, 100);
            this.statReceived.Size = new System.Drawing.Size(344, 88);
            this.statReceived.Value = "R0";
            this.statReceived.Name = "statReceived";
            // 
            // statCount
            // 
            this.statCount.Accent = System.Drawing.Color.FromArgb(31, 58, 86);
            this.statCount.Caption = "Contributions";
            this.statCount.Location = new System.Drawing.Point(796, 100);
            this.statCount.Size = new System.Drawing.Size(344, 88);
            this.statCount.Value = "0";
            this.statCount.Name = "statCount";
            // 
            // cardPledge
            // 
            this.cardPledge.Controls.Add(this.cardPledgeTitle);
            this.cardPledge.Controls.Add(this.cardPledgeSub);
            this.cardPledge.Controls.Add(this.rdoPreset50);
            this.cardPledge.Controls.Add(this.rdoPreset100);
            this.cardPledge.Controls.Add(this.rdoPreset250);
            this.cardPledge.Controls.Add(this.rdoPreset500);
            this.cardPledge.Controls.Add(this.rdoPreset1000);
            this.cardPledge.Controls.Add(this.lblAmount);
            this.cardPledge.Controls.Add(this.txtAmount);
            this.cardPledge.Controls.Add(this.lblFrequency);
            this.cardPledge.Controls.Add(this.cmbFrequency);
            this.cardPledge.Controls.Add(this.lblNote);
            this.cardPledge.Controls.Add(this.txtNote);
            this.cardPledge.Controls.Add(this.btnPledge);
            this.cardPledge.Controls.Add(this.btnBack);
            this.cardPledge.Controls.Add(this.lblPledgeNote);
            this.cardPledge.Controls.Add(this.lblWhereHead);
            this.cardPledge.Controls.Add(this.lblWhereText);
            this.cardPledge.Accent = System.Drawing.Color.FromArgb(230, 126, 34);
            this.cardPledge.BackColor = System.Drawing.Color.White;
            this.cardPledge.Location = new System.Drawing.Point(60, 204);
            this.cardPledge.Size = new System.Drawing.Size(600, 450);
            this.cardPledge.Name = "cardPledge";
            // 
            // cardPledgeTitle
            // 
            this.cardPledgeTitle.AutoSize = false;
            this.cardPledgeTitle.BackColor = System.Drawing.Color.Transparent;
            this.cardPledgeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.cardPledgeTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.cardPledgeTitle.Location = new System.Drawing.Point(24, 18);
            this.cardPledgeTitle.Size = new System.Drawing.Size(552, 30);
            this.cardPledgeTitle.Text = "Choose an amount";
            this.cardPledgeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardPledgeTitle.Name = "cardPledgeTitle";
            // 
            // cardPledgeSub
            // 
            this.cardPledgeSub.AutoSize = false;
            this.cardPledgeSub.BackColor = System.Drawing.Color.Transparent;
            this.cardPledgeSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cardPledgeSub.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.cardPledgeSub.Location = new System.Drawing.Point(24, 48);
            this.cardPledgeSub.Size = new System.Drawing.Size(552, 22);
            this.cardPledgeSub.Text = "Pick a quick amount or type your own.";
            this.cardPledgeSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardPledgeSub.Name = "cardPledgeSub";
            // 
            // rdoPreset50
            // 
            this.rdoPreset50.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPreset50.BackColor = System.Drawing.Color.White;
            this.rdoPreset50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPreset50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPreset50.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoPreset50.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(253, 236, 217);
            this.rdoPreset50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.rdoPreset50.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoPreset50.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoPreset50.Location = new System.Drawing.Point(24, 84);
            this.rdoPreset50.Size = new System.Drawing.Size(100, 38);
            this.rdoPreset50.TabStop = false;
            this.rdoPreset50.Tag = "50";
            this.rdoPreset50.Text = "R50";
            this.rdoPreset50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoPreset50.UseVisualStyleBackColor = false;
            this.rdoPreset50.Name = "rdoPreset50";
            this.rdoPreset50.CheckedChanged += new System.EventHandler(this.rdoPreset_CheckedChanged);
            // 
            // rdoPreset100
            // 
            this.rdoPreset100.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPreset100.BackColor = System.Drawing.Color.White;
            this.rdoPreset100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPreset100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPreset100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoPreset100.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(253, 236, 217);
            this.rdoPreset100.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.rdoPreset100.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoPreset100.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoPreset100.Location = new System.Drawing.Point(137, 84);
            this.rdoPreset100.Size = new System.Drawing.Size(100, 38);
            this.rdoPreset100.TabStop = false;
            this.rdoPreset100.Tag = "100";
            this.rdoPreset100.Text = "R100";
            this.rdoPreset100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoPreset100.UseVisualStyleBackColor = false;
            this.rdoPreset100.Name = "rdoPreset100";
            this.rdoPreset100.CheckedChanged += new System.EventHandler(this.rdoPreset_CheckedChanged);
            // 
            // rdoPreset250
            // 
            this.rdoPreset250.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPreset250.BackColor = System.Drawing.Color.White;
            this.rdoPreset250.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPreset250.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPreset250.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoPreset250.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(253, 236, 217);
            this.rdoPreset250.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.rdoPreset250.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoPreset250.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoPreset250.Location = new System.Drawing.Point(250, 84);
            this.rdoPreset250.Size = new System.Drawing.Size(100, 38);
            this.rdoPreset250.TabStop = false;
            this.rdoPreset250.Tag = "250";
            this.rdoPreset250.Text = "R250";
            this.rdoPreset250.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoPreset250.UseVisualStyleBackColor = false;
            this.rdoPreset250.Name = "rdoPreset250";
            this.rdoPreset250.CheckedChanged += new System.EventHandler(this.rdoPreset_CheckedChanged);
            // 
            // rdoPreset500
            // 
            this.rdoPreset500.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPreset500.BackColor = System.Drawing.Color.White;
            this.rdoPreset500.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPreset500.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPreset500.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoPreset500.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(253, 236, 217);
            this.rdoPreset500.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.rdoPreset500.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoPreset500.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoPreset500.Location = new System.Drawing.Point(363, 84);
            this.rdoPreset500.Size = new System.Drawing.Size(100, 38);
            this.rdoPreset500.TabStop = false;
            this.rdoPreset500.Tag = "500";
            this.rdoPreset500.Text = "R500";
            this.rdoPreset500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoPreset500.UseVisualStyleBackColor = false;
            this.rdoPreset500.Name = "rdoPreset500";
            this.rdoPreset500.CheckedChanged += new System.EventHandler(this.rdoPreset_CheckedChanged);
            // 
            // rdoPreset1000
            // 
            this.rdoPreset1000.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoPreset1000.BackColor = System.Drawing.Color.White;
            this.rdoPreset1000.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoPreset1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoPreset1000.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoPreset1000.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(253, 236, 217);
            this.rdoPreset1000.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.rdoPreset1000.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoPreset1000.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoPreset1000.Location = new System.Drawing.Point(476, 84);
            this.rdoPreset1000.Size = new System.Drawing.Size(100, 38);
            this.rdoPreset1000.TabStop = false;
            this.rdoPreset1000.Tag = "1000";
            this.rdoPreset1000.Text = "R1,000";
            this.rdoPreset1000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoPreset1000.UseVisualStyleBackColor = false;
            this.rdoPreset1000.Name = "rdoPreset1000";
            this.rdoPreset1000.CheckedChanged += new System.EventHandler(this.rdoPreset_CheckedChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = false;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblAmount.Location = new System.Drawing.Point(24, 136);
            this.lblAmount.Size = new System.Drawing.Size(266, 22);
            this.lblAmount.Text = "Amount (rand)";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblAmount.Name = "lblAmount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAmount.Location = new System.Drawing.Point(24, 158);
            this.txtAmount.Size = new System.Drawing.Size(266, 27);
            this.txtAmount.Hint = "e.g. 250";
            this.txtAmount.TabIndex = 1;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = false;
            this.lblFrequency.BackColor = System.Drawing.Color.Transparent;
            this.lblFrequency.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFrequency.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblFrequency.Location = new System.Drawing.Point(310, 136);
            this.lblFrequency.Size = new System.Drawing.Size(266, 22);
            this.lblFrequency.Text = "How often?";
            this.lblFrequency.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblFrequency.Name = "lblFrequency";
            // 
            // cmbFrequency
            // 
            this.cmbFrequency.BackColor = System.Drawing.Color.White;
            this.cmbFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFrequency.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbFrequency.FormattingEnabled = true;
            this.cmbFrequency.Location = new System.Drawing.Point(310, 158);
            this.cmbFrequency.Size = new System.Drawing.Size(266, 27);
            this.cmbFrequency.Items.AddRange(new object[] {
            "One-time",
            "Monthly"});
            this.cmbFrequency.TabIndex = 0;
            this.cmbFrequency.SelectedIndex = 0;
            this.cmbFrequency.Name = "cmbFrequency";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = false;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(70, 78, 86);
            this.lblNote.Location = new System.Drawing.Point(24, 200);
            this.lblNote.Size = new System.Drawing.Size(552, 22);
            this.lblNote.Text = "Message (optional)";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblNote.Name = "lblNote";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNote.Location = new System.Drawing.Point(24, 222);
            this.txtNote.Size = new System.Drawing.Size(552, 27);
            this.txtNote.Hint = "e.g. In memory of my grandmother";
            this.txtNote.TabIndex = 2;
            this.txtNote.Name = "txtNote";
            // 
            // btnPledge
            // 
            this.btnPledge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPledge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPledge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPledge.Location = new System.Drawing.Point(406, 284);
            this.btnPledge.Size = new System.Drawing.Size(170, 38);
            this.btnPledge.Text = "Pledge donation";
            this.btnPledge.UseVisualStyleBackColor = false;
            this.btnPledge.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnPledge.ForeColor = System.Drawing.Color.White;
            this.btnPledge.FlatAppearance.BorderSize = 0;
            this.btnPledge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 95, 15);
            this.btnPledge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(214, 110, 20);
            this.btnPledge.TabIndex = 3;
            this.btnPledge.Name = "btnPledge";
            this.btnPledge.Click += new System.EventHandler(this.btnPledge_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.Location = new System.Drawing.Point(296, 284);
            this.btnBack.Size = new System.Drawing.Size(100, 38);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnBack.FlatAppearance.BorderSize = 1;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnBack.TabIndex = 4;
            this.btnBack.Name = "btnBack";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPledgeNote
            // 
            this.lblPledgeNote.AutoSize = false;
            this.lblPledgeNote.BackColor = System.Drawing.Color.Transparent;
            this.lblPledgeNote.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPledgeNote.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblPledgeNote.Location = new System.Drawing.Point(24, 340);
            this.lblPledgeNote.Size = new System.Drawing.Size(552, 46);
            this.lblPledgeNote.Text = "No card details are collected here. Pay by EFT using the reference you receive. Monthly pledges are a reminder to repeat the gift; nothing is debited automatically.";
            this.lblPledgeNote.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPledgeNote.Name = "lblPledgeNote";
            // 
            // lblWhereHead
            // 
            this.lblWhereHead.AutoSize = false;
            this.lblWhereHead.BackColor = System.Drawing.Color.Transparent;
            this.lblWhereHead.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblWhereHead.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.lblWhereHead.Location = new System.Drawing.Point(24, 392);
            this.lblWhereHead.Size = new System.Drawing.Size(552, 24);
            this.lblWhereHead.Text = "Where your money goes";
            this.lblWhereHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWhereHead.Name = "lblWhereHead";
            // 
            // lblWhereText
            // 
            this.lblWhereText.AutoSize = false;
            this.lblWhereText.BackColor = System.Drawing.Color.Transparent;
            this.lblWhereText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWhereText.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblWhereText.Location = new System.Drawing.Point(24, 416);
            this.lblWhereText.Size = new System.Drawing.Size(552, 22);
            this.lblWhereText.Text = "Funds help buy staples and cover transport so surplus food can reach families.";
            this.lblWhereText.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblWhereText.Name = "lblWhereText";
            // 
            // cardPay
            // 
            this.cardPay.Controls.Add(this.cardPayTitle);
            this.cardPay.Controls.Add(this.cardPaySub);
            this.cardPay.Controls.Add(this.lblKeyBank);
            this.cardPay.Controls.Add(this.lblValBank);
            this.cardPay.Controls.Add(this.lblKeyAccountName);
            this.cardPay.Controls.Add(this.lblValAccountName);
            this.cardPay.Controls.Add(this.lblKeyAccountNumber);
            this.cardPay.Controls.Add(this.lblValAccountNumber);
            this.cardPay.Controls.Add(this.lblKeyBranch);
            this.cardPay.Controls.Add(this.lblValBranch);
            this.cardPay.Controls.Add(this.lblKeyReference);
            this.cardPay.Controls.Add(this.lblValReference);
            this.cardPay.Controls.Add(this.lblContribHead);
            this.cardPay.Controls.Add(this.lvContributions);
            this.cardPay.Controls.Add(this.lblEmpty);
            this.cardPay.Accent = System.Drawing.Color.FromArgb(31, 58, 86);
            this.cardPay.BackColor = System.Drawing.Color.White;
            this.cardPay.Location = new System.Drawing.Point(684, 204);
            this.cardPay.Size = new System.Drawing.Size(456, 450);
            this.cardPay.Name = "cardPay";
            // 
            // cardPayTitle
            // 
            this.cardPayTitle.AutoSize = false;
            this.cardPayTitle.BackColor = System.Drawing.Color.Transparent;
            this.cardPayTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.cardPayTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.cardPayTitle.Location = new System.Drawing.Point(24, 18);
            this.cardPayTitle.Size = new System.Drawing.Size(408, 30);
            this.cardPayTitle.Text = "How to pay";
            this.cardPayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardPayTitle.Name = "cardPayTitle";
            // 
            // cardPaySub
            // 
            this.cardPaySub.AutoSize = false;
            this.cardPaySub.BackColor = System.Drawing.Color.Transparent;
            this.cardPaySub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cardPaySub.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.cardPaySub.Location = new System.Drawing.Point(24, 48);
            this.cardPaySub.Size = new System.Drawing.Size(408, 22);
            this.cardPaySub.Text = "Use your reference when you make the EFT payment.";
            this.cardPaySub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardPaySub.Name = "cardPaySub";
            // 
            // lblKeyBank
            // 
            this.lblKeyBank.AutoSize = false;
            this.lblKeyBank.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyBank.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKeyBank.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblKeyBank.Location = new System.Drawing.Point(24, 82);
            this.lblKeyBank.Size = new System.Drawing.Size(130, 24);
            this.lblKeyBank.Text = "Bank";
            this.lblKeyBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKeyBank.Name = "lblKeyBank";
            // 
            // lblValBank
            // 
            this.lblValBank.AutoSize = false;
            this.lblValBank.BackColor = System.Drawing.Color.Transparent;
            this.lblValBank.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblValBank.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblValBank.Location = new System.Drawing.Point(160, 82);
            this.lblValBank.Size = new System.Drawing.Size(272, 24);
            this.lblValBank.Text = "Sample Bank";
            this.lblValBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValBank.Name = "lblValBank";
            // 
            // lblKeyAccountName
            // 
            this.lblKeyAccountName.AutoSize = false;
            this.lblKeyAccountName.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyAccountName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKeyAccountName.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblKeyAccountName.Location = new System.Drawing.Point(24, 108);
            this.lblKeyAccountName.Size = new System.Drawing.Size(130, 24);
            this.lblKeyAccountName.Text = "Account name";
            this.lblKeyAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKeyAccountName.Name = "lblKeyAccountName";
            // 
            // lblValAccountName
            // 
            this.lblValAccountName.AutoSize = false;
            this.lblValAccountName.BackColor = System.Drawing.Color.Transparent;
            this.lblValAccountName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblValAccountName.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblValAccountName.Location = new System.Drawing.Point(160, 108);
            this.lblValAccountName.Size = new System.Drawing.Size(272, 24);
            this.lblValAccountName.Text = "Food Donation System";
            this.lblValAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValAccountName.Name = "lblValAccountName";
            // 
            // lblKeyAccountNumber
            // 
            this.lblKeyAccountNumber.AutoSize = false;
            this.lblKeyAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyAccountNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKeyAccountNumber.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblKeyAccountNumber.Location = new System.Drawing.Point(24, 134);
            this.lblKeyAccountNumber.Size = new System.Drawing.Size(130, 24);
            this.lblKeyAccountNumber.Text = "Account number";
            this.lblKeyAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKeyAccountNumber.Name = "lblKeyAccountNumber";
            // 
            // lblValAccountNumber
            // 
            this.lblValAccountNumber.AutoSize = false;
            this.lblValAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblValAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblValAccountNumber.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblValAccountNumber.Location = new System.Drawing.Point(160, 134);
            this.lblValAccountNumber.Size = new System.Drawing.Size(272, 24);
            this.lblValAccountNumber.Text = "000 000 0000";
            this.lblValAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValAccountNumber.Name = "lblValAccountNumber";
            // 
            // lblKeyBranch
            // 
            this.lblKeyBranch.AutoSize = false;
            this.lblKeyBranch.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyBranch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKeyBranch.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblKeyBranch.Location = new System.Drawing.Point(24, 160);
            this.lblKeyBranch.Size = new System.Drawing.Size(130, 24);
            this.lblKeyBranch.Text = "Branch code";
            this.lblKeyBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKeyBranch.Name = "lblKeyBranch";
            // 
            // lblValBranch
            // 
            this.lblValBranch.AutoSize = false;
            this.lblValBranch.BackColor = System.Drawing.Color.Transparent;
            this.lblValBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblValBranch.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lblValBranch.Location = new System.Drawing.Point(160, 160);
            this.lblValBranch.Size = new System.Drawing.Size(272, 24);
            this.lblValBranch.Text = "000 000";
            this.lblValBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValBranch.Name = "lblValBranch";
            // 
            // lblKeyReference
            // 
            this.lblKeyReference.AutoSize = false;
            this.lblKeyReference.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyReference.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKeyReference.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblKeyReference.Location = new System.Drawing.Point(24, 186);
            this.lblKeyReference.Size = new System.Drawing.Size(130, 24);
            this.lblKeyReference.Text = "Your reference";
            this.lblKeyReference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKeyReference.Name = "lblKeyReference";
            // 
            // lblValReference
            // 
            this.lblValReference.AutoSize = false;
            this.lblValReference.BackColor = System.Drawing.Color.Transparent;
            this.lblValReference.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.lblValReference.ForeColor = System.Drawing.Color.FromArgb(180, 90, 10);
            this.lblValReference.Location = new System.Drawing.Point(160, 186);
            this.lblValReference.Size = new System.Drawing.Size(272, 24);
            this.lblValReference.Text = "Pledge first to get one";
            this.lblValReference.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValReference.Name = "lblValReference";
            // 
            // lblContribHead
            // 
            this.lblContribHead.AutoSize = false;
            this.lblContribHead.BackColor = System.Drawing.Color.Transparent;
            this.lblContribHead.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblContribHead.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.lblContribHead.Location = new System.Drawing.Point(24, 224);
            this.lblContribHead.Size = new System.Drawing.Size(408, 24);
            this.lblContribHead.Text = "Your contributions";
            this.lblContribHead.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblContribHead.Name = "lblContribHead";
            // 
            // lvContributions
            // 
            this.lvContributions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvContributions_date,
            this.lvContributions_amount,
            this.lvContributions_ref,
            this.lvContributions_status});
            this.lvContributions.BackColor = System.Drawing.Color.White;
            this.lvContributions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvContributions.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lvContributions.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lvContributions.FullRowSelect = true;
            this.lvContributions.GridLines = false;
            this.lvContributions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvContributions.HideSelection = false;
            this.lvContributions.Location = new System.Drawing.Point(24, 252);
            this.lvContributions.Size = new System.Drawing.Size(408, 168);
            this.lvContributions.UseCompatibleStateImageBehavior = false;
            this.lvContributions.View = System.Windows.Forms.View.Details;
            this.lvContributions.Name = "lvContributions";
            // 
            // lvContributions_date
            // 
            this.lvContributions_date.Text = "Date";
            this.lvContributions_date.Width = 90;
            // 
            // lvContributions_amount
            // 
            this.lvContributions_amount.Text = "Amount";
            this.lvContributions_amount.Width = 78;
            // 
            // lvContributions_ref
            // 
            this.lvContributions_ref.Text = "Reference";
            this.lvContributions_ref.Width = 150;
            // 
            // lvContributions_status
            // 
            this.lvContributions_status.Text = "Status";
            this.lvContributions_status.Width = 86;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = false;
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmpty.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblEmpty.Location = new System.Drawing.Point(24, 252);
            this.lblEmpty.Size = new System.Drawing.Size(408, 168);
            this.lblEmpty.Text = "You have not made a contribution yet.\r\nUse the form on the left to pledge.";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpty.Name = "lblEmpty";
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Size = new System.Drawing.Size(1200, 60);
            this.topBar.Name = "topBar";
            // 
            // DonateMoney
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
            this.Text = "Food Donation System - Donate money";
            this.AcceptButton = this.btnPledge;
            this.Name = "DonateMoney";
            this.cardPay.ResumeLayout(false);
            this.cardPay.PerformLayout();
            this.cardPledge.ResumeLayout(false);
            this.cardPledge.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblIntro;
        private Project.StatCard statPledged;
        private Project.StatCard statReceived;
        private Project.StatCard statCount;
        private Project.CardPanel cardPledge;
        private System.Windows.Forms.Label cardPledgeTitle;
        private System.Windows.Forms.Label cardPledgeSub;
        private System.Windows.Forms.RadioButton rdoPreset50;
        private System.Windows.Forms.RadioButton rdoPreset100;
        private System.Windows.Forms.RadioButton rdoPreset250;
        private System.Windows.Forms.RadioButton rdoPreset500;
        private System.Windows.Forms.RadioButton rdoPreset1000;
        private System.Windows.Forms.Label lblAmount;
        private Project.HintBox txtAmount;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.ComboBox cmbFrequency;
        private System.Windows.Forms.Label lblNote;
        private Project.HintBox txtNote;
        private System.Windows.Forms.Button btnPledge;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPledgeNote;
        private System.Windows.Forms.Label lblWhereHead;
        private System.Windows.Forms.Label lblWhereText;
        private Project.CardPanel cardPay;
        private System.Windows.Forms.Label cardPayTitle;
        private System.Windows.Forms.Label cardPaySub;
        private System.Windows.Forms.Label lblKeyBank;
        private System.Windows.Forms.Label lblValBank;
        private System.Windows.Forms.Label lblKeyAccountName;
        private System.Windows.Forms.Label lblValAccountName;
        private System.Windows.Forms.Label lblKeyAccountNumber;
        private System.Windows.Forms.Label lblValAccountNumber;
        private System.Windows.Forms.Label lblKeyBranch;
        private System.Windows.Forms.Label lblValBranch;
        private System.Windows.Forms.Label lblKeyReference;
        private System.Windows.Forms.Label lblValReference;
        private System.Windows.Forms.Label lblContribHead;
        private System.Windows.Forms.ListView lvContributions;
        private System.Windows.Forms.ColumnHeader lvContributions_date;
        private System.Windows.Forms.ColumnHeader lvContributions_amount;
        private System.Windows.Forms.ColumnHeader lvContributions_ref;
        private System.Windows.Forms.ColumnHeader lvContributions_status;
        private System.Windows.Forms.Label lblEmpty;
        private Project.TopBar topBar;
    }
}
