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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstFilterPayment = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFilterPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // lstFilterPayment
            // 
            this.lstFilterPayment.FormattingEnabled = true;
            this.lstFilterPayment.Location = new System.Drawing.Point(44, 92);
            this.lstFilterPayment.Name = "lstFilterPayment";
            this.lstFilterPayment.Size = new System.Drawing.Size(420, 277);
            this.lstFilterPayment.TabIndex = 1;
            this.lstFilterPayment.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(44, 390);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(44, 419);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblFilterPayment
            // 
            this.lblFilterPayment.AutoSize = true;
            this.lblFilterPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblFilterPayment.Location = new System.Drawing.Point(38, 9);
            this.lblFilterPayment.Name = "lblFilterPayment";
            this.lblFilterPayment.Size = new System.Drawing.Size(203, 31);
            this.lblFilterPayment.TabIndex = 29;
            this.lblFilterPayment.Text = "Filter Payments";
            this.lblFilterPayment.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // FilterPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 453);
            this.Controls.Add(this.lblFilterPayment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lstFilterPayment);
            this.Controls.Add(this.comboBox1);
            this.Name = "FilterPayment";
            this.Text = "FilterPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lstFilterPayment;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFilterPayment;
    }
}