namespace M.U.N_System_BackEnd
{
    partial class frmAddAppointments
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
            this.lblAddAppointment = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.txtAppointmentDate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtAppointmentTime = new System.Windows.Forms.TextBox();
            this.lblAppointmentTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddAppointment
            // 
            this.lblAddAppointment.AutoSize = true;
            this.lblAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAppointment.Location = new System.Drawing.Point(75, 36);
            this.lblAddAppointment.Name = "lblAddAppointment";
            this.lblAddAppointment.Size = new System.Drawing.Size(182, 24);
            this.lblAddAppointment.TabIndex = 0;
            this.lblAddAppointment.Text = "Add Appointments";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(43, 92);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(115, 16);
            this.lblAppointmentDate.TabIndex = 1;
            this.lblAppointmentDate.Text = "Appointment Date";
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.Location = new System.Drawing.Point(192, 91);
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.Size = new System.Drawing.Size(100, 20);
            this.txtAppointmentDate.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Appointment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(180, 165);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(54, 212);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 7;
            // 
            // txtAppointmentTime
            // 
            this.txtAppointmentTime.Location = new System.Drawing.Point(192, 127);
            this.txtAppointmentTime.Name = "txtAppointmentTime";
            this.txtAppointmentTime.Size = new System.Drawing.Size(100, 20);
            this.txtAppointmentTime.TabIndex = 9;
            // 
            // lblAppointmentTime
            // 
            this.lblAppointmentTime.AutoSize = true;
            this.lblAppointmentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentTime.Location = new System.Drawing.Point(43, 128);
            this.lblAppointmentTime.Name = "lblAppointmentTime";
            this.lblAppointmentTime.Size = new System.Drawing.Size(117, 16);
            this.lblAppointmentTime.TabIndex = 8;
            this.lblAppointmentTime.Text = "Appointment Time";
            // 
            // frmAddAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(350, 246);
            this.Controls.Add(this.txtAppointmentTime);
            this.Controls.Add(this.lblAppointmentTime);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAppointmentDate);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblAddAppointment);
            this.Name = "frmAddAppointments";
            this.Text = "frmAddAppointment";
            this.Load += new System.EventHandler(this.frmAddAppointments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddAppointment;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.TextBox txtAppointmentDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtAppointmentTime;
        private System.Windows.Forms.Label lblAppointmentTime;
    }
}