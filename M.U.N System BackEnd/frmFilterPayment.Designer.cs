namespace M.U.N_System_BackEnd
{
    partial class frmFilterPayment
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
            this.lblFilterPayment = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lstFilterPayment = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFilterPayment
            // 
            this.lblFilterPayment.AutoSize = true;
            this.lblFilterPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblFilterPayment.Location = new System.Drawing.Point(35, 26);
            this.lblFilterPayment.Name = "lblFilterPayment";
            this.lblFilterPayment.Size = new System.Drawing.Size(203, 31);
            this.lblFilterPayment.TabIndex = 34;
            this.lblFilterPayment.Text = "Filter Payments";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(41, 436);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(41, 407);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 32;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lstFilterPayment
            // 
            this.lstFilterPayment.FormattingEnabled = true;
            this.lstFilterPayment.Location = new System.Drawing.Point(41, 109);
            this.lstFilterPayment.Name = "lstFilterPayment";
            this.lstFilterPayment.Size = new System.Drawing.Size(420, 277);
            this.lstFilterPayment.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // frmFilterPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(514, 486);
            this.Controls.Add(this.lblFilterPayment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lstFilterPayment);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFilterPayment";
            this.Text = "FilterPayment";
            this.Load += new System.EventHandler(this.FilterPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilterPayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListBox lstFilterPayment;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}