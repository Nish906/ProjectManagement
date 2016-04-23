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
            this.btncClose.Location = new System.Drawing.Point(300, 312);
            this.btncClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncClose.Name = "btncClose";
            this.btncClose.Size = new System.Drawing.Size(171, 45);
            this.btncClose.TabIndex = 1;
            this.btncClose.Text = "Close";
            this.btncClose.UseVisualStyleBackColor = true;
            this.btncClose.Click += new System.EventHandler(this.btncClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(63, 312);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Appointment";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateAppointment
            // 
            this.lblUpdateAppointment.AutoSize = true;
            this.lblUpdateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAppointment.Location = new System.Drawing.Point(116, 78);
            this.lblUpdateAppointment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateAppointment.Name = "lblUpdateAppointment";
            this.lblUpdateAppointment.Size = new System.Drawing.Size(313, 33);
            this.lblUpdateAppointment.TabIndex = 7;
            this.lblUpdateAppointment.Text = "Update Appointments";
            // 
            // txtAppointmentTime
            // 
            this.txtAppointmentTime.Location = new System.Drawing.Point(300, 238);
            this.txtAppointmentTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAppointmentTime.Name = "txtAppointmentTime";
            this.txtAppointmentTime.Size = new System.Drawing.Size(148, 26);
            this.txtAppointmentTime.TabIndex = 11;
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.Location = new System.Drawing.Point(300, 154);
            this.txtAppointmentDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.Size = new System.Drawing.Size(148, 26);
            this.txtAppointmentDate.TabIndex = 10;
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.Location = new System.Drawing.Point(76, 240);
            this.lblAppointmentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(171, 25);
            this.lblAppointmentTime.TabIndex = 9;
            this.lblAppointmentTime.Text = "Appointment Time";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(76, 155);
            this.lblAppointmentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(168, 25);
            this.lblAppointmentDate.TabIndex = 8;
            this.lblAppointmentDate.Text = "Appointment Date";
            // 
            // frmUpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(534, 403);
            this.Controls.Add(this.txtAppointmentTime);
            this.Controls.Add(this.txtAppointmentDate);
            this.Controls.Add(this.lblAppointmentTime);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblUpdateAppointment);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btncClose);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpdateAppointment";
            this.Text = "frmUpdateAppointment";
            this.Load += new System.EventHandler(this.frmUpdateAppointment_Load);
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