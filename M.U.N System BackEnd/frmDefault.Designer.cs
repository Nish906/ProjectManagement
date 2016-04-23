namespace M.U.N_System_BackEnd
{
    partial class frmDefault
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
            this.btnEmails = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmails
            // 
            this.btnEmails.Location = new System.Drawing.Point(124, 235);
            this.btnEmails.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmails.Name = "btnEmails";
            this.btnEmails.Size = new System.Drawing.Size(186, 66);
            this.btnEmails.TabIndex = 7;
            this.btnEmails.Text = "Emails";
            this.btnEmails.UseVisualStyleBackColor = true;
            this.btnEmails.Click += new System.EventHandler(this.btnEmails_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(124, 152);
            this.btnAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(186, 66);
            this.btnAppointment.TabIndex = 6;
            this.btnAppointment.Text = "Appointments";
            this.btnAppointment.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(124, 71);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(186, 66);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // frmDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 370);
            this.Controls.Add(this.btnEmails);
            this.Controls.Add(this.btnAppointment);
            this.Controls.Add(this.btnCustomers);
            this.Name = "frmDefault";
            this.Text = "frmDefault";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmails;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnCustomers;
    }
}