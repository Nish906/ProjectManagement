namespace M.U.N_System_BackEnd
{
    partial class frmReviewDetails
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblReviewAppointments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 186);
            this.listBox1.TabIndex = 0;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(45, 250);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(81, 41);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept Appointment";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(145, 250);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(81, 42);
            this.btnDecline.TabIndex = 2;
            this.btnDecline.Text = "Decline Appointment";
            this.btnDecline.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(244, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblReviewAppointments
            // 
            this.lblReviewAppointments.AutoSize = true;
            this.lblReviewAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewAppointments.Location = new System.Drawing.Point(91, 19);
            this.lblReviewAppointments.Name = "lblReviewAppointments";
            this.lblReviewAppointments.Size = new System.Drawing.Size(182, 20);
            this.lblReviewAppointments.TabIndex = 12;
            this.lblReviewAppointments.Text = "Review Appointments";
            // 
            // frmReviewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(346, 322);
            this.Controls.Add(this.lblReviewAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.listBox1);
            this.Name = "frmReviewDetails";
            this.Text = "frmReviewDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblReviewAppointments;
    }
}