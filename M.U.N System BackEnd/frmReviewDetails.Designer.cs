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
            this.ClientSize = new System.Drawing.Size(378, 295);
            this.Controls.Add(this.lblReviewAppointments);
            this.Controls.Add(this.listBox1);
            this.Name = "frmReviewDetails";
            this.Text = "frmReviewDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblReviewAppointments;
    }
}