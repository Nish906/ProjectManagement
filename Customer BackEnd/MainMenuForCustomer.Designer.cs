namespace ScreenDesignsWindowsForm
{
    partial class MainMenuForCustomer
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnFilterPayments = new System.Windows.Forms.Button();
            this.btnFilterCustomer = new System.Windows.Forms.Button();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(73, 12);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(128, 34);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(73, 92);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(128, 35);
            this.btnUpdateCustomer.TabIndex = 1;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFilterPayments
            // 
            this.btnFilterPayments.Location = new System.Drawing.Point(73, 52);
            this.btnFilterPayments.Name = "btnFilterPayments";
            this.btnFilterPayments.Size = new System.Drawing.Size(128, 34);
            this.btnFilterPayments.TabIndex = 2;
            this.btnFilterPayments.Text = "Filter Payments";
            this.btnFilterPayments.UseVisualStyleBackColor = true;
            this.btnFilterPayments.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFilterCustomer
            // 
            this.btnFilterCustomer.Location = new System.Drawing.Point(73, 133);
            this.btnFilterCustomer.Name = "btnFilterCustomer";
            this.btnFilterCustomer.Size = new System.Drawing.Size(128, 33);
            this.btnFilterCustomer.TabIndex = 3;
            this.btnFilterCustomer.Text = "Filter Customer";
            this.btnFilterCustomer.UseVisualStyleBackColor = true;
            this.btnFilterCustomer.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(73, 172);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(128, 34);
            this.btnFindCustomer.TabIndex = 4;
            this.btnFindCustomer.Text = "Find Customer";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 234);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // MainMenuForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.btnFilterCustomer);
            this.Controls.Add(this.btnFilterPayments);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "MainMenuForCustomer";
            this.Text = "MainMenuForCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnFilterPayments;
        private System.Windows.Forms.Button btnFilterCustomer;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Button btnReturn;
    }
}