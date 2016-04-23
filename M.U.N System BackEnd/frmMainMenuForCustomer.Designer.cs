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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.btnFilterCustomer = new System.Windows.Forms.Button();
            this.btnFilterPayments = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(212, 455);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 35);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(304, 360);
            this.btnFindCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(192, 52);
            this.btnFindCustomer.TabIndex = 10;
            this.btnFindCustomer.Text = "Find Customer";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            // 
            // btnFilterCustomer
            // 
            this.btnFilterCustomer.Location = new System.Drawing.Point(304, 300);
            this.btnFilterCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilterCustomer.Name = "btnFilterCustomer";
            this.btnFilterCustomer.Size = new System.Drawing.Size(192, 51);
            this.btnFilterCustomer.TabIndex = 9;
            this.btnFilterCustomer.Text = "Filter Customer";
            this.btnFilterCustomer.UseVisualStyleBackColor = true;
            // 
            // btnFilterPayments
            // 
            this.btnFilterPayments.Location = new System.Drawing.Point(304, 175);
            this.btnFilterPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilterPayments.Name = "btnFilterPayments";
            this.btnFilterPayments.Size = new System.Drawing.Size(192, 52);
            this.btnFilterPayments.TabIndex = 8;
            this.btnFilterPayments.Text = "Filter Payments";
            this.btnFilterPayments.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(304, 237);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(192, 54);
            this.btnUpdateCustomer.TabIndex = 7;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(304, 113);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(192, 52);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // MainMenuForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 602);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.btnFilterCustomer);
            this.Controls.Add(this.btnFilterPayments);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "MainMenuForCustomer";
            this.Text = "MainMenuForCustomer";
            this.Load += new System.EventHandler(this.MainMenuForCustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Button btnFilterCustomer;
        private System.Windows.Forms.Button btnFilterPayments;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
    }
}