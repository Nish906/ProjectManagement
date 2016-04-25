namespace M.U.N_System_BackEnd
{
    partial class frmListOfAppointments
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
            this.components = new System.ComponentModel.Container();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblListOfAppointments = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtAppointmentDate = new System.Windows.Forms.TextBox();
            this.lstAppointments = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ourDatabaseDataSetAppointment = new M.U.N_System_BackEnd.OurDatabaseDataSetAppointment();
            this.tblAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAppointmentTableAdapter = new M.U.N_System_BackEnd.OurDatabaseDataSetAppointmentTableAdapters.tblAppointmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(71, 380);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(173, 44);
            this.btnBook.TabIndex = 35;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click_1);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(43, 70);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(70, 13);
            this.lblFilter.TabIndex = 34;
            this.lblFilter.Text = "Filter By Date";
            // 
            // lblListOfAppointments
            // 
            this.lblListOfAppointments.AutoSize = true;
            this.lblListOfAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfAppointments.Location = new System.Drawing.Point(159, 32);
            this.lblListOfAppointments.Name = "lblListOfAppointments";
            this.lblListOfAppointments.Size = new System.Drawing.Size(178, 20);
            this.lblListOfAppointments.TabIndex = 33;
            this.lblListOfAppointments.Text = "List Of Appointments";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(280, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 44);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(280, 299);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(174, 44);
            this.btndelete.TabIndex = 31;
            this.btndelete.Text = "Delete Appointments";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(71, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 44);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add Appointments";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(85, 294);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 37;
            // 
            // txtAppointmentDate
            // 
            this.txtAppointmentDate.Location = new System.Drawing.Point(280, 354);
            this.txtAppointmentDate.Name = "txtAppointmentDate";
            this.txtAppointmentDate.Size = new System.Drawing.Size(174, 20);
            this.txtAppointmentDate.TabIndex = 38;
            // 
            // lstAppointments
            // 
            this.lstAppointments.DataSource = this.tblAppointmentBindingSource;
            this.lstAppointments.DisplayMember = "AppointmentDate";
            this.lstAppointments.FormattingEnabled = true;
            this.lstAppointments.Location = new System.Drawing.Point(71, 95);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(479, 199);
            this.lstAppointments.TabIndex = 40;
            this.lstAppointments.ValueMember = "AppointmentDate";
            this.lstAppointments.SelectedIndexChanged += new System.EventHandler(this.lstAppointment_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.tblAppointmentBindingSource;
            this.listBox2.DisplayMember = "AppointmentID";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(13, 95);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(53, 199);
            this.listBox2.TabIndex = 41;
            this.listBox2.ValueMember = "AppointmentID";
            // 
            // ourDatabaseDataSetAppointment
            // 
            this.ourDatabaseDataSetAppointment.DataSetName = "OurDatabaseDataSetAppointment";
            this.ourDatabaseDataSetAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAppointmentBindingSource
            // 
            this.tblAppointmentBindingSource.DataMember = "tblAppointment";
            this.tblAppointmentBindingSource.DataSource = this.ourDatabaseDataSetAppointment;
            // 
            // tblAppointmentTableAdapter
            // 
            this.tblAppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // frmListOfAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(574, 436);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lstAppointments);
            this.Controls.Add(this.txtAppointmentDate);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblListOfAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmListOfAppointments";
            this.Text = "zzzzzz";
            this.Load += new System.EventHandler(this.frmListOfAppointments_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblListOfAppointments;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtAppointmentDate;
        private System.Windows.Forms.ListBox lstAppointments;
        private System.Windows.Forms.ListBox listBox2;
        private OurDatabaseDataSetAppointment ourDatabaseDataSetAppointment;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource;
        private OurDatabaseDataSetAppointmentTableAdapters.tblAppointmentTableAdapter tblAppointmentTableAdapter;
        
    }
}