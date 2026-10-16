namespace Project
{
    partial class StatCard
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
            this.lblValue = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = false;
            this.lblValue.BackColor = System.Drawing.Color.White;
            this.lblValue.Font = new System.Drawing.Font("Segoe UI Semibold", 22F);
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(31, 58, 86);
            this.lblValue.Location = new System.Drawing.Point(20, 14);
            this.lblValue.Size = new System.Drawing.Size(212, 36);
            this.lblValue.Text = "0";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblValue.Name = "lblValue";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = false;
            this.lblCaption.BackColor = System.Drawing.Color.White;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(100, 108, 116);
            this.lblCaption.Location = new System.Drawing.Point(20, 52);
            this.lblCaption.Size = new System.Drawing.Size(212, 24);
            this.lblCaption.Text = "Caption";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCaption.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblCaption.Name = "lblCaption";
            // 
            // StatCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblCaption);
            this.Size = new System.Drawing.Size(252, 88);
            this.Name = "StatCard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblCaption;
    }
}
