namespace M.U.N_System_BackEnd
{
    partial class frmFindCustomer
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
            this.lblFindCustomer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnCustomerData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFindCustomer
            // 
            this.lblFindCustomer.AutoSize = true;
            this.lblFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblFindCustomer.Location = new System.Drawing.Point(36, 31);
            this.lblFindCustomer.Name = "lblFindCustomer";
            this.lblFindCustomer.Size = new System.Drawing.Size(192, 31);
            this.lblFindCustomer.TabIndex = 34;
            this.lblFindCustomer.Text = "Find Customer";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(42, 248);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(39, 86);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(117, 13);
            this.lblKey.TabIndex = 32;
            this.lblKey.Text = "Search using keywords";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(42, 103);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 20);
            this.txtKey.TabIndex = 31;
            // 
            // btnCustomerData
            // 
            this.btnCustomerData.Location = new System.Drawing.Point(42, 129);
            this.btnCustomerData.Name = "btnCustomerData";
            this.btnCustomerData.Size = new System.Drawing.Size(148, 23);
            this.btnCustomerData.TabIndex = 30;
            this.btnCustomerData.Text = "Search Customer Database";
            this.btnCustomerData.UseVisualStyleBackColor = true;
            // 
            // frmFindCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(374, 320);
            this.Controls.Add(this.lblFindCustomer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnCustomerData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmFindCustomer";
            this.Text = "FindCustomer";
            this.Load += new System.EventHandler(this.FindCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFindCustomer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnCustomerData;
    }
}