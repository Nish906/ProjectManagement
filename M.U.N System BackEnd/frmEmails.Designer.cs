namespace M.U.N_System_BackEnd
{
    partial class frmEmails
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tblEmailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ourDatabaseDataSetAppointment = new M.U.N_System_BackEnd.OurDatabaseDataSetAppointment();
            this.ourDatabaseDataSetAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ourDatabaseDataSet = new M.U.N_System_BackEnd.OurDatabaseDataSet();
            this.tblEmailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmailTableAdapter = new M.U.N_System_BackEnd.OurDatabaseDataSetTableAdapters.tblEmailTableAdapter();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmailBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 55);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Emails";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(497, 20);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(121, 53);
            this.btnSendEmail.TabIndex = 11;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Location = new System.Drawing.Point(363, 20);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(121, 53);
            this.btnContacts.TabIndex = 12;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(9, 351);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 53);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tblEmailBindingSource
            // 
            this.tblEmailBindingSource.DataMember = "tblEmail";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailAddressDataGridViewTextBoxColumn,
            this.emailSubjectDataGridViewTextBoxColumn,
            this.emailDateDataGridViewTextBoxColumn,
            this.emailFieldDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmailBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(40, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 237);
            this.dataGridView1.TabIndex = 15;
            // 
            // ourDatabaseDataSetAppointment
            // 
            this.ourDatabaseDataSetAppointment.DataSetName = "OurDatabaseDataSetAppointment";
            this.ourDatabaseDataSetAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ourDatabaseDataSetAppointmentBindingSource
            // 
            this.ourDatabaseDataSetAppointmentBindingSource.DataSource = this.ourDatabaseDataSetAppointment;
            this.ourDatabaseDataSetAppointmentBindingSource.Position = 0;
            // 
            // ourDatabaseDataSet
            // 
            this.ourDatabaseDataSet.DataSetName = "OurDatabaseDataSet";
            this.ourDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmailBindingSource1
            // 
            this.tblEmailBindingSource1.DataMember = "tblEmail";
            this.tblEmailBindingSource1.DataSource = this.ourDatabaseDataSet;
            // 
            // tblEmailTableAdapter
            // 
            this.tblEmailTableAdapter.ClearBeforeFill = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "Email Address";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // emailSubjectDataGridViewTextBoxColumn
            // 
            this.emailSubjectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailSubjectDataGridViewTextBoxColumn.DataPropertyName = "EmailSubject";
            this.emailSubjectDataGridViewTextBoxColumn.HeaderText = "Email Subject";
            this.emailSubjectDataGridViewTextBoxColumn.Name = "emailSubjectDataGridViewTextBoxColumn";
            // 
            // emailDateDataGridViewTextBoxColumn
            // 
            this.emailDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDateDataGridViewTextBoxColumn.DataPropertyName = "EmailDate";
            this.emailDateDataGridViewTextBoxColumn.HeaderText = "Email Date";
            this.emailDateDataGridViewTextBoxColumn.Name = "emailDateDataGridViewTextBoxColumn";
            // 
            // emailFieldDataGridViewTextBoxColumn
            // 
            this.emailFieldDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailFieldDataGridViewTextBoxColumn.DataPropertyName = "EmailField";
            this.emailFieldDataGridViewTextBoxColumn.HeaderText = "Email Field";
            this.emailFieldDataGridViewTextBoxColumn.Name = "emailFieldDataGridViewTextBoxColumn";
            // 
            // frmEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(627, 421);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmEmails";
            this.Text = "frmEmails";
            this.Load += new System.EventHandler(this.frmEmails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEmailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSetAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmailBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.BindingSource tblEmailBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ourDatabaseDataSetAppointmentBindingSource;
        private OurDatabaseDataSetAppointment ourDatabaseDataSetAppointment;
        private OurDatabaseDataSet ourDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblEmailBindingSource1;
        private OurDatabaseDataSetTableAdapters.tblEmailTableAdapter tblEmailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailFieldDataGridViewTextBoxColumn;
    }
}