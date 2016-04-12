namespace M.U.N_System_BackEnd
{
    partial class frmUpdateAppointment
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
            this.btncClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateAppointment = new System.Windows.Forms.Label();
            this.txtAppointmentTime = new System.Windows.Forms.TextBox();
            this.txtAppointmentDate = new System.Windows.Forms.TextBox();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncClose
            // 
            this.btncClose.Location = new System.Drawing.Point(200, 203);
            this.btncClose.Name = "btncClose";
            this.btncClose.Size = new System.Drawing.Size(114, 29);
            this.btncClose.TabIndex = 1;
            this.btncClose.Text = "Close";
            this.btncClose.UseVisualStyleBackColor = true;
            this.btncClose.Click += new System.EventHandler(this.btncClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(42, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 29);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Appointment";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateAppointment
            // 
            this.lblUpdateAppointment.AutoSize = true;
            this.lblUpdateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAppointment.Location = new System.Drawing.Point(77, 51);
            this.lblUpdateAppointment.Name = "lblUpdateAppointment";
            this.lblUpdateAppointment.Size = new System.Drawing.Size(210, 24);
            this.lblUpdateAppointment.TabIndex = 7;
            this.lblUpdateAppointment.Text = "Update Appointments";
            // 
            // txtAppointmentTime
            // 
            this.txtAppointmentTime.Location = new System.Drawing.Point(200, 155);
            this.txtAppointmentTime.Name = "txtAppointmentTime";
            this.txtAppointmentTime.Size = new System.Drawing.Size(100, 20);
            this.txtAppointmentTime.TabIndex = 11;
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.Location = new System.Drawing.Point(200, 100);
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.Size = new System.Drawing.Size(100, 20);
            this.txtAppointmentDate.TabIndex = 10;
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.Location = new System.Drawing.Point(51, 156);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(117, 16);
            this.lblAppointmentTime.TabIndex = 9;
            this.lblAppointmentTime.Text = "Appointment Time";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(51, 101);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(115, 16);
            this.lblAppointmentDate.TabIndex = 8;
            this.lblAppointmentDate.Text = "Appointment Date";
            // 
            // frmUpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.txtAppointmentTime);
            this.Controls.Add(this.txtAppointmentDate);
            this.Controls.Add(this.lblAppointmentTime);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblUpdateAppointment);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btncClose);
            this.Name = "frmUpdateAppointment";
            this.Text = "frmUpdateAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateAppointment;
        private System.Windows.Forms.TextBox txtAppointmentTime;
        private System.Windows.Forms.TextBox txtAppointmentDate;
        private System.Windows.Forms.Label lblAppointmentTime;
        private System.Windows.Forms.Label lblAppointmentDate;
    }
}