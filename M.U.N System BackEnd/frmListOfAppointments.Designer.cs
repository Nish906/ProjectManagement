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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAppointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ourDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAppointmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ourDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAppointmentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lstAppointments = new System.Windows.Forms.ListBox();
            this.tblAppointmentBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.ourDatabaseDataSetAppointment = new M.U.N_System_BackEnd.OurDatabaseDataSetAppointment();
            this.tblAppointmentBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ourDatabaseDataSet = new M.U.N_System_BackEnd.OurDatabaseDataSet();
            this.tblAppointmentTableAdapter = new M.U.N_System_BackEnd.OurDatabaseDataSetTableAdapters.tblAppointmentTableAdapter();
            this.tblAppointmentTableAdapter1 = new M.U.N_System_BackEnd.OurDatabaseDataSetAppointmentTableAdapters.tblAppointmentTableAdapter();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(139, 362);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(105, 44);
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
            this.lblListOfAppointments.Location = new System.Drawing.Point(159, 24);
            this.lblListOfAppointments.Name = "lblListOfAppointments";
            this.lblListOfAppointments.Size = new System.Drawing.Size(178, 20);
            this.lblListOfAppointments.TabIndex = 33;
            this.lblListOfAppointments.Text = "List Of Appointments";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(280, 362);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 44);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(349, 312);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 44);
            this.btndelete.TabIndex = 31;
            this.btndelete.Text = "Delete Appointments";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(213, 313);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 43);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Update Appointments";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(71, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 44);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add Appointments";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tblAppointmentBindingSource
            // 
            this.tblAppointmentBindingSource.DataMember = "tblAppointment";
            // 
            // tblAppointmentBindingSource1
            // 
            this.tblAppointmentBindingSource1.DataMember = "tblAppointment";
            this.tblAppointmentBindingSource1.DataSource = this.ourDatabaseDataSetBindingSource;
            // 
            // tblAppointmentBindingSource2
            // 
            this.tblAppointmentBindingSource2.DataMember = "tblAppointment";
            this.tblAppointmentBindingSource2.DataSource = this.ourDatabaseDataSetBindingSource;
            // 
            // tblAppointmentBindingSource3
            // 
            this.tblAppointmentBindingSource3.DataMember = "tblAppointment";
            // 
            // lstAppointments
            // 
            this.lstAppointments.DataSource = this.tblAppointmentBindingSource5;
            this.lstAppointments.DisplayMember = "AppointmentDate";
            this.lstAppointments.FormattingEnabled = true;
            this.lstAppointments.Location = new System.Drawing.Point(45, 95);
            this.lstAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.lstAppointments.Name = "lstAppointments";
            this.lstAppointments.Size = new System.Drawing.Size(490, 199);
            this.lstAppointments.TabIndex = 36;
            this.lstAppointments.ValueMember = "AppointmentDate";
            // 
            // tblAppointmentBindingSource5
            // 
            this.tblAppointmentBindingSource5.DataMember = "tblAppointment";
            this.tblAppointmentBindingSource5.DataSource = this.ourDatabaseDataSetAppointment;
            // 
            // ourDatabaseDataSetAppointment
            // 
            this.ourDatabaseDataSetAppointment.DataSetName = "OurDatabaseDataSetAppointment";
            this.ourDatabaseDataSetAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAppointmentBindingSource4
            // 
            this.tblAppointmentBindingSource4.DataMember = "tblAppointment";
            this.tblAppointmentBindingSource4.DataSource = this.ourDatabaseDataSet;
            // 
            // ourDatabaseDataSet
            // 
            this.ourDatabaseDataSet.DataSetName = "OurDatabaseDataSet";
            this.ourDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAppointmentTableAdapter
            // 
            this.tblAppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tblAppointmentTableAdapter1
            // 
            this.tblAppointmentTableAdapter1.ClearBeforeFill = true;
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
            // frmListOfAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(574, 436);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lstAppointments);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblListOfAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmListOfAppointments";
            this.Text = "zzzzzz";
            this.Load += new System.EventHandler(this.frmListOfAppointments_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblListOfAppointments;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource1;
        private System.Windows.Forms.BindingSource ourDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource2;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource3;
        private System.Windows.Forms.BindingSource ourDatabaseDataSetBindingSource1;
        private System.Windows.Forms.ListBox lstAppointments;
        private OurDatabaseDataSet ourDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource4;
        private OurDatabaseDataSetTableAdapters.tblAppointmentTableAdapter tblAppointmentTableAdapter;
        private OurDatabaseDataSetAppointment ourDatabaseDataSetAppointment;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource5;
        private OurDatabaseDataSetAppointmentTableAdapters.tblAppointmentTableAdapter tblAppointmentTableAdapter1;
        private System.Windows.Forms.Label lblError;
        
    }
}