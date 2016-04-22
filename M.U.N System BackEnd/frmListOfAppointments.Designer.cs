﻿namespace M.U.N_System_BackEnd
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tblAppointmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAppointmentTableAdapter = new M.U.N_System_BackEnd.OurDatabaseDataSetTableAdapters.tblAppointmentTableAdapter();
            this.tblAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAppointmentTableAdapter1 = new M.U.N_System_BackEnd.OurDatabaseDataSet2TableAdapters.tblAppointmentTableAdapter();
            this.ourDatabaseDataSet2 = new M.U.N_System_BackEnd.OurDatabaseDataSet2();
            this.ourDatabaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ourDatabaseDataSet = new M.U.N_System_BackEnd.OurDatabaseDataSet();
            this.ourDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ourDatabaseDataSet3 = new M.U.N_System_BackEnd.OurDatabaseDataSet3();
            this.tblAppointmentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAppointmentTableAdapter2 = new M.U.N_System_BackEnd.OurDatabaseDataSet3TableAdapters.tblAppointmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(130, 351);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(105, 44);
            this.btnBook.TabIndex = 28;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click_1);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(34, 59);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(70, 13);
            this.lblFilter.TabIndex = 27;
            this.lblFilter.Text = "Filter By Date";
            // 
            // lblListOfAppointments
            // 
            this.lblListOfAppointments.AutoSize = true;
            this.lblListOfAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfAppointments.Location = new System.Drawing.Point(150, 13);
            this.lblListOfAppointments.Name = "lblListOfAppointments";
            this.lblListOfAppointments.Size = new System.Drawing.Size(178, 20);
            this.lblListOfAppointments.TabIndex = 26;
            this.lblListOfAppointments.Text = "List Of Appointments";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(271, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 44);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(340, 301);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 44);
            this.btndelete.TabIndex = 24;
            this.btndelete.Text = "Delete Appointments";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(204, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 43);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update Appointments";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(62, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 44);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add Appointments";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tblAppointmentBindingSource2;
            this.listBox1.DisplayMember = "AppointmentDate";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(76, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(369, 199);
            this.listBox1.TabIndex = 29;
            this.listBox1.ValueMember = "AppointmentDate";
            // 
            // tblAppointmentTableAdapter
            // 
            this.tblAppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tblAppointmentBindingSource
            // 
            this.tblAppointmentBindingSource.DataMember = "tblAppointment";
            // 
            // tblAppointmentTableAdapter1
            // 
            this.tblAppointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // ourDatabaseDataSet2
            // 
            this.ourDatabaseDataSet2.DataSetName = "OurDatabaseDataSet2";
            this.ourDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ourDatabaseDataSet2BindingSource
            // 
            this.ourDatabaseDataSet2BindingSource.DataSource = this.ourDatabaseDataSet2;
            this.ourDatabaseDataSet2BindingSource.Position = 0;
            // 
            // ourDatabaseDataSet
            // 
            this.ourDatabaseDataSet.DataSetName = "OurDatabaseDataSet";
            this.ourDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ourDatabaseDataSetBindingSource
            // 
            this.ourDatabaseDataSetBindingSource.DataSource = this.ourDatabaseDataSet;
            this.ourDatabaseDataSetBindingSource.Position = 0;
            // 
            // ourDatabaseDataSet3
            // 
            this.ourDatabaseDataSet3.DataSetName = "OurDatabaseDataSet3";
            this.ourDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAppointmentBindingSource2
            // 
            this.tblAppointmentBindingSource2.DataMember = "tblAppointment";
            this.tblAppointmentBindingSource2.DataSource = this.ourDatabaseDataSet3;
            // 
            // tblAppointmentTableAdapter2
            // 
            this.tblAppointmentTableAdapter2.ClearBeforeFill = true;
            // 
            // frmListOfAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(515, 436);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblListOfAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmListOfAppointments";
            this.Text = "frmListOfAppointments";
            this.Load += new System.EventHandler(this.frmListOfAppointments_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentBindingSource2)).EndInit();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource;
        private OurDatabaseDataSetTableAdapters.tblAppointmentTableAdapter tblAppointmentTableAdapter;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource1;
        private OurDatabaseDataSet2TableAdapters.tblAppointmentTableAdapter tblAppointmentTableAdapter1;
        private System.Windows.Forms.BindingSource ourDatabaseDataSetBindingSource;
        private OurDatabaseDataSet ourDatabaseDataSet;
        private OurDatabaseDataSet2 ourDatabaseDataSet2;
        private System.Windows.Forms.BindingSource ourDatabaseDataSet2BindingSource;
        private OurDatabaseDataSet3 ourDatabaseDataSet3;
        private System.Windows.Forms.BindingSource tblAppointmentBindingSource2;
        private OurDatabaseDataSet3TableAdapters.tblAppointmentTableAdapter tblAppointmentTableAdapter2;
    }
}