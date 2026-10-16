namespace Project
{
    partial class TopBar
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
            this.tblBar = new System.Windows.Forms.TableLayoutPanel();
            this.flowBrand = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHeart = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblWho = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tblBar.SuspendLayout();
            this.flowBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblBar
            // 
            this.tblBar.ColumnCount = 3;
            this.tblBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tblBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tblBar.Controls.Add(this.flowBrand, 0, 0);
            this.tblBar.Controls.Add(this.lblWho, 1, 0);
            this.tblBar.Controls.Add(this.btnLogout, 2, 0);
            this.tblBar.RowCount = 1;
            this.tblBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBar.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.tblBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBar.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.tblBar.Name = "tblBar";
            // 
            // flowBrand
            // 
            this.flowBrand.Controls.Add(this.lblHeart);
            this.flowBrand.Controls.Add(this.lblBrand);
            this.flowBrand.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.flowBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowBrand.WrapContents = false;
            this.flowBrand.Name = "flowBrand";
            // 
            // lblHeart
            // 
            this.lblHeart.AutoSize = true;
            this.lblHeart.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.lblHeart.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.lblHeart.ForeColor = System.Drawing.Color.FromArgb(230, 126, 34);
            this.lblHeart.Margin = new System.Windows.Forms.Padding(0, 14, 8, 0);
            this.lblHeart.Text = "\u2665";
            this.lblHeart.Name = "lblHeart";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 14F);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.lblBrand.Text = "Food Donation System";
            this.lblBrand.Name = "lblBrand";
            // 
            // lblWho
            // 
            this.lblWho.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblWho.AutoSize = true;
            this.lblWho.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.lblWho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWho.ForeColor = System.Drawing.Color.FromArgb(220, 230, 240);
            this.lblWho.Margin = new System.Windows.Forms.Padding(0);
            this.lblWho.Text = "Name   \u00b7   Role";
            this.lblWho.Name = "lblWho";
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.Size = new System.Drawing.Size(100, 34);
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 1;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(48, 80, 114);
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(48, 80, 114);
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // TopBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.Controls.Add(this.tblBar);
            this.Size = new System.Drawing.Size(1200, 60);
            this.Name = "TopBar";
            this.flowBrand.ResumeLayout(false);
            this.flowBrand.PerformLayout();
            this.tblBar.ResumeLayout(false);
            this.tblBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBar;
        private System.Windows.Forms.FlowLayoutPanel flowBrand;
        private System.Windows.Forms.Label lblHeart;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.Button btnLogout;
    }
}
