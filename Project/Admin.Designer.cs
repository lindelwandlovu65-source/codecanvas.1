namespace Project
{
    partial class Admin
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
            this.statAccounts = new Project.StatCard();
            this.statOpenRequests = new Project.StatCard();
            this.statPendingDonations = new Project.StatCard();
            this.statMoney = new Project.StatCard();
            this.cardRecords = new Project.CardPanel();
            this.cardRecordsTitle = new System.Windows.Forms.Label();
            this.cardRecordsSub = new System.Windows.Forms.Label();
            this.rdoRequests = new System.Windows.Forms.RadioButton();
            this.rdoDonations = new System.Windows.Forms.RadioButton();
            this.rdoMoney = new System.Windows.Forms.RadioButton();
            this.rdoAccounts = new System.Windows.Forms.RadioButton();
            this.lvRecords = new System.Windows.Forms.ListView();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.btnAction1 = new System.Windows.Forms.Button();
            this.btnAction2 = new System.Windows.Forms.Button();
            this.btnAction3 = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.topBar = new Project.TopBar();
            this.pnlContent.SuspendLayout();
            this.cardRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.lblWelcome);
            this.pnlContent.Controls.Add(this.lblIntro);
            this.pnlContent.Controls.Add(this.statAccounts);
            this.pnlContent.Controls.Add(this.statOpenRequests);
            this.pnlContent.Controls.Add(this.statPendingDonations);
            this.pnlContent.Controls.Add(this.statMoney);
            this.pnlContent.Controls.Add(this.cardRecords);
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
            this.lblWelcome.Text = "Admin console";
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
            this.lblIntro.Text = "Review food requests, confirm donations and look after accounts.";
            this.lblIntro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIntro.Name = "lblIntro";
            // 
            // statAccounts
            // 
            this.statAccounts.Accent = System.Drawing.Color.FromArgb(46, 139, 115);
            this.statAccounts.Caption = "Registered accounts";
            this.statAccounts.Location = new System.Drawing.Point(60, 100);
            this.statAccounts.Size = new System.Drawing.Size(252, 88);
            this.statAccounts.Value = "0";
            this.statAccounts.Name = "statAccounts";
            // 
            // statOpenRequests
            // 
            this.statOpenRequests.Accent = System.Drawing.Color.FromArgb(230, 126, 34);
            this.statOpenRequests.Caption = "Food requests to review";
            this.statOpenRequests.Location = new System.Drawing.Point(336, 100);
            this.statOpenRequests.Size = new System.Drawing.Size(252, 88);
            this.statOpenRequests.Value = "0";
            this.statOpenRequests.Name = "statOpenRequests";
            // 
            // statPendingDonations
            // 
            this.statPendingDonations.Accent = System.Drawing.Color.FromArgb(31, 58, 86);
            this.statPendingDonations.Caption = "Food donations pending";
            this.statPendingDonations.Location = new System.Drawing.Point(612, 100);
            this.statPendingDonations.Size = new System.Drawing.Size(252, 88);
            this.statPendingDonations.Value = "0";
            this.statPendingDonations.Name = "statPendingDonations";
            // 
            // statMoney
            // 
            this.statMoney.Accent = System.Drawing.Color.FromArgb(46, 139, 115);
            this.statMoney.Caption = "Money received";
            this.statMoney.Location = new System.Drawing.Point(888, 100);
            this.statMoney.Size = new System.Drawing.Size(252, 88);
            this.statMoney.Value = "R0";
            this.statMoney.Name = "statMoney";
            // 
            // cardRecords
            // 
            this.cardRecords.Controls.Add(this.cardRecordsTitle);
            this.cardRecords.Controls.Add(this.cardRecordsSub);
            this.cardRecords.Controls.Add(this.rdoRequests);
            this.cardRecords.Controls.Add(this.rdoDonations);
            this.cardRecords.Controls.Add(this.rdoMoney);
            this.cardRecords.Controls.Add(this.rdoAccounts);
            this.cardRecords.Controls.Add(this.lvRecords);
            this.cardRecords.Controls.Add(this.lblEmpty);
            this.cardRecords.Controls.Add(this.btnAction1);
            this.cardRecords.Controls.Add(this.btnAction2);
            this.cardRecords.Controls.Add(this.btnAction3);
            this.cardRecords.Controls.Add(this.lblHint);
            this.cardRecords.Accent = System.Drawing.Color.FromArgb(31, 58, 86);
            this.cardRecords.BackColor = System.Drawing.Color.White;
            this.cardRecords.Location = new System.Drawing.Point(60, 204);
            this.cardRecords.Size = new System.Drawing.Size(1080, 450);
            this.cardRecords.Name = "cardRecords";
            // 
            // cardRecordsTitle
            // 
            this.cardRecordsTitle.AutoSize = false;
            this.cardRecordsTitle.BackColor = System.Drawing.Color.Transparent;
            this.cardRecordsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F);
            this.cardRecordsTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.cardRecordsTitle.Location = new System.Drawing.Point(24, 18);
            this.cardRecordsTitle.Size = new System.Drawing.Size(1032, 30);
            this.cardRecordsTitle.Text = "Records";
            this.cardRecordsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardRecordsTitle.Name = "cardRecordsTitle";
            // 
            // cardRecordsSub
            // 
            this.cardRecordsSub.AutoSize = false;
            this.cardRecordsSub.BackColor = System.Drawing.Color.Transparent;
            this.cardRecordsSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cardRecordsSub.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.cardRecordsSub.Location = new System.Drawing.Point(24, 48);
            this.cardRecordsSub.Size = new System.Drawing.Size(1032, 22);
            this.cardRecordsSub.Text = "Pick a section, select a row, then choose an action.";
            this.cardRecordsSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cardRecordsSub.Name = "cardRecordsSub";
            // 
            // rdoRequests
            // 
            this.rdoRequests.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoRequests.BackColor = System.Drawing.Color.White;
            this.rdoRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoRequests.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoRequests.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(253, 236, 217);
            this.rdoRequests.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.rdoRequests.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoRequests.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoRequests.Location = new System.Drawing.Point(24, 80);
            this.rdoRequests.Size = new System.Drawing.Size(180, 34);
            this.rdoRequests.Tag = "0";
            this.rdoRequests.TabIndex = 0;
            this.rdoRequests.Text = "Food requests";
            this.rdoRequests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoRequests.UseVisualStyleBackColor = false;
            this.rdoRequests.Checked = true;
            this.rdoRequests.TabStop = true;
            this.rdoRequests.Name = "rdoRequests";
            this.rdoRequests.CheckedChanged += new System.EventHandler(this.rdoTab_CheckedChanged);
            // 
            // rdoDonations
            // 
            this.rdoDonations.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoDonations.BackColor = System.Drawing.Color.White;
            this.rdoDonations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoDonations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoDonations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoDonations.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(253, 236, 217);
            this.rdoDonations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.rdoDonations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoDonations.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoDonations.Location = new System.Drawing.Point(212, 80);
            this.rdoDonations.Size = new System.Drawing.Size(180, 34);
            this.rdoDonations.Tag = "1";
            this.rdoDonations.TabIndex = 1;
            this.rdoDonations.Text = "Food donations";
            this.rdoDonations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoDonations.UseVisualStyleBackColor = false;
            this.rdoDonations.Name = "rdoDonations";
            this.rdoDonations.CheckedChanged += new System.EventHandler(this.rdoTab_CheckedChanged);
            // 
            // rdoMoney
            // 
            this.rdoMoney.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoMoney.BackColor = System.Drawing.Color.White;
            this.rdoMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoMoney.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(253, 236, 217);
            this.rdoMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.rdoMoney.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoMoney.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoMoney.Location = new System.Drawing.Point(400, 80);
            this.rdoMoney.Size = new System.Drawing.Size(180, 34);
            this.rdoMoney.Tag = "2";
            this.rdoMoney.TabIndex = 2;
            this.rdoMoney.Text = "Money donations";
            this.rdoMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoMoney.UseVisualStyleBackColor = false;
            this.rdoMoney.Name = "rdoMoney";
            this.rdoMoney.CheckedChanged += new System.EventHandler(this.rdoTab_CheckedChanged);
            // 
            // rdoAccounts
            // 
            this.rdoAccounts.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoAccounts.BackColor = System.Drawing.Color.White;
            this.rdoAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoAccounts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoAccounts.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(253, 236, 217);
            this.rdoAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.rdoAccounts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoAccounts.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.rdoAccounts.Location = new System.Drawing.Point(588, 80);
            this.rdoAccounts.Size = new System.Drawing.Size(180, 34);
            this.rdoAccounts.Tag = "3";
            this.rdoAccounts.TabIndex = 3;
            this.rdoAccounts.Text = "Accounts";
            this.rdoAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAccounts.UseVisualStyleBackColor = false;
            this.rdoAccounts.Name = "rdoAccounts";
            this.rdoAccounts.CheckedChanged += new System.EventHandler(this.rdoTab_CheckedChanged);
            // 
            // lvRecords
            // 
            this.lvRecords.BackColor = System.Drawing.Color.White;
            this.lvRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRecords.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lvRecords.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45);
            this.lvRecords.FullRowSelect = true;
            this.lvRecords.GridLines = false;
            this.lvRecords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvRecords.HideSelection = false;
            this.lvRecords.Location = new System.Drawing.Point(24, 128);
            this.lvRecords.Size = new System.Drawing.Size(1032, 246);
            this.lvRecords.UseCompatibleStateImageBehavior = false;
            this.lvRecords.View = System.Windows.Forms.View.Details;
            this.lvRecords.TabIndex = 4;
            this.lvRecords.Name = "lvRecords";
            this.lvRecords.SelectedIndexChanged += new System.EventHandler(this.lvRecords_SelectedIndexChanged);
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = false;
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmpty.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblEmpty.Location = new System.Drawing.Point(24, 128);
            this.lblEmpty.Size = new System.Drawing.Size(1032, 246);
            this.lblEmpty.Text = "Nothing here yet.";
            this.lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpty.Name = "lblEmpty";
            // 
            // btnAction1
            // 
            this.btnAction1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAction1.Location = new System.Drawing.Point(24, 392);
            this.btnAction1.Size = new System.Drawing.Size(150, 38);
            this.btnAction1.Text = "Approve";
            this.btnAction1.UseVisualStyleBackColor = false;
            this.btnAction1.BackColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.btnAction1.ForeColor = System.Drawing.Color.White;
            this.btnAction1.FlatAppearance.BorderSize = 0;
            this.btnAction1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(190, 95, 15);
            this.btnAction1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(214, 110, 20);
            this.btnAction1.TabIndex = 5;
            this.btnAction1.Name = "btnAction1";
            this.btnAction1.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnAction2
            // 
            this.btnAction2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAction2.Location = new System.Drawing.Point(184, 392);
            this.btnAction2.Size = new System.Drawing.Size(150, 38);
            this.btnAction2.Text = "Decline";
            this.btnAction2.UseVisualStyleBackColor = false;
            this.btnAction2.BackColor = System.Drawing.Color.White;
            this.btnAction2.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnAction2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnAction2.FlatAppearance.BorderSize = 1;
            this.btnAction2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnAction2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnAction2.TabIndex = 6;
            this.btnAction2.Name = "btnAction2";
            this.btnAction2.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnAction3
            // 
            this.btnAction3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAction3.Location = new System.Drawing.Point(344, 392);
            this.btnAction3.Size = new System.Drawing.Size(150, 38);
            this.btnAction3.Text = "Mark fulfilled";
            this.btnAction3.UseVisualStyleBackColor = false;
            this.btnAction3.BackColor = System.Drawing.Color.White;
            this.btnAction3.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnAction3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnAction3.FlatAppearance.BorderSize = 1;
            this.btnAction3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnAction3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(235, 240, 245);
            this.btnAction3.TabIndex = 7;
            this.btnAction3.Name = "btnAction3";
            this.btnAction3.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = false;
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblHint.Location = new System.Drawing.Point(520, 392);
            this.lblHint.Size = new System.Drawing.Size(536, 38);
            this.lblHint.Text = "Select a row to enable the actions.";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHint.Name = "lblHint";
            // 
            // topBar
            // 
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Size = new System.Drawing.Size(1200, 60);
            this.topBar.Name = "topBar";
            // 
            // Admin
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
            this.Text = "Food Donation System - Admin console";
            this.Name = "Admin";
            this.cardRecords.ResumeLayout(false);
            this.cardRecords.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblIntro;
        private Project.StatCard statAccounts;
        private Project.StatCard statOpenRequests;
        private Project.StatCard statPendingDonations;
        private Project.StatCard statMoney;
        private Project.CardPanel cardRecords;
        private System.Windows.Forms.Label cardRecordsTitle;
        private System.Windows.Forms.Label cardRecordsSub;
        private System.Windows.Forms.RadioButton rdoRequests;
        private System.Windows.Forms.RadioButton rdoDonations;
        private System.Windows.Forms.RadioButton rdoMoney;
        private System.Windows.Forms.RadioButton rdoAccounts;
        private System.Windows.Forms.ListView lvRecords;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Button btnAction1;
        private System.Windows.Forms.Button btnAction2;
        private System.Windows.Forms.Button btnAction3;
        private System.Windows.Forms.Label lblHint;
        private Project.TopBar topBar;
    }
}
