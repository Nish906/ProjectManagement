namespace ScreenDesignsWindowsForm
{
    partial class FilterPayment
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
            this.lblFilterPayment.Location = new System.Drawing.Point(52, 40);
            this.lblFilterPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterPayment.Name = "lblFilterPayment";
            this.lblFilterPayment.Size = new System.Drawing.Size(307, 47);
            this.lblFilterPayment.TabIndex = 34;
            this.lblFilterPayment.Text = "Filter Payments";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(61, 671);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 35);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(61, 626);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 35);
            this.btnHome.TabIndex = 32;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // lstFilterPayment
            // 
            this.lstFilterPayment.FormattingEnabled = true;
            this.lstFilterPayment.ItemHeight = 20;
            this.lstFilterPayment.Location = new System.Drawing.Point(61, 168);
            this.lstFilterPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstFilterPayment.Name = "lstFilterPayment";
            this.lstFilterPayment.Size = new System.Drawing.Size(628, 424);
            this.lstFilterPayment.TabIndex = 31;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 97);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 30;
            // 
            // FilterPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 747);
            this.Controls.Add(this.lblFilterPayment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lstFilterPayment);
            this.Controls.Add(this.comboBox1);
            this.Name = "FilterPayment";
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