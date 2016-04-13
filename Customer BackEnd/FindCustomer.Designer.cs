namespace ScreenDesignsWindowsForm
{
    partial class FindCustomer
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
            this.btnCustomerData = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFindCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomerData
            // 
            this.btnCustomerData.Location = new System.Drawing.Point(44, 107);
            this.btnCustomerData.Name = "btnCustomerData";
            this.btnCustomerData.Size = new System.Drawing.Size(148, 23);
            this.btnCustomerData.TabIndex = 0;
            this.btnCustomerData.Text = "Search Customer Database";
            this.btnCustomerData.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(44, 81);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 1;
            this.txtKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(41, 65);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(117, 13);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Search using keywords";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(44, 227);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblFindCustomer
            // 
            this.lblFindCustomer.AutoSize = true;
            this.lblFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblFindCustomer.Location = new System.Drawing.Point(38, 9);
            this.lblFindCustomer.Name = "lblFindCustomer";
            this.lblFindCustomer.Size = new System.Drawing.Size(192, 31);
            this.lblFindCustomer.TabIndex = 29;
            this.lblFindCustomer.Text = "Find Customer";
            // 
            // FindCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblFindCustomer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnCustomerData);
            this.Name = "FindCustomer";
            this.Text = "FindCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerData;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFindCustomer;
    }
}