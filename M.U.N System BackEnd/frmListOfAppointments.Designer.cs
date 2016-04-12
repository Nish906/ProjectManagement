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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAppointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointment_ListOfAppointments = new M.U.N_System_BackEnd.Appointment_ListOfAppointments();
            this.tblAppointmentsTableAdapter = new M.U.N_System_BackEnd.Appointment_ListOfAppointmentsTableAdapters.tblAppointmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_ListOfAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(105, 409);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(105, 44);
            this.btnBook.TabIndex = 21;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(34, 56);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(70, 13);
            this.lblFilter.TabIndex = 20;
            this.lblFilter.Text = "Filter By Date";
            // 
            // lblListOfAppointments
            // 
            this.lblListOfAppointments.AutoSize = true;
            this.lblListOfAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfAppointments.Location = new System.Drawing.Point(150, 10);
            this.lblListOfAppointments.Name = "lblListOfAppointments";
            this.lblListOfAppointments.Size = new System.Drawing.Size(178, 20);
            this.lblListOfAppointments.TabIndex = 19;
            this.lblListOfAppointments.Text = "List Of Appointments";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(246, 409);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 44);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(315, 359);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 44);
            this.btndelete.TabIndex = 17;
            this.btndelete.Text = "Delete Appointments";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(179, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 43);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update Appointments";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 359);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 44);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Appointments";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentDateDataGridViewTextBoxColumn,
            this.appointmentTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAppointmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // appointmentDateDataGridViewTextBoxColumn
            // 
            this.appointmentDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appointmentDateDataGridViewTextBoxColumn.DataPropertyName = "Appointment Date";
            this.appointmentDateDataGridViewTextBoxColumn.HeaderText = "Appointment Date";
            this.appointmentDateDataGridViewTextBoxColumn.Name = "appointmentDateDataGridViewTextBoxColumn";
            // 
            // appointmentTimeDataGridViewTextBoxColumn
            // 
            this.appointmentTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appointmentTimeDataGridViewTextBoxColumn.DataPropertyName = "Appointment Time";
            this.appointmentTimeDataGridViewTextBoxColumn.HeaderText = "Appointment Time";
            this.appointmentTimeDataGridViewTextBoxColumn.Name = "appointmentTimeDataGridViewTextBoxColumn";
            // 
            // tblAppointmentsBindingSource
            // 
            this.tblAppointmentsBindingSource.DataMember = "tblAppointments";
            this.tblAppointmentsBindingSource.DataSource = this.appointment_ListOfAppointments;
            // 
            // appointment_ListOfAppointments
            // 
            this.appointment_ListOfAppointments.DataSetName = "Appointment_ListOfAppointments";
            this.appointment_ListOfAppointments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAppointmentsTableAdapter
            // 
            this.tblAppointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmListOfAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(477, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblListOfAppointments);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmListOfAppointments";
            this.Text = "frmListOfAppointments";
            this.Load += new System.EventHandler(this.frmListOfAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAppointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointment_ListOfAppointments)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private Appointment_ListOfAppointments appointment_ListOfAppointments;
        private System.Windows.Forms.BindingSource tblAppointmentsBindingSource;
        private Appointment_ListOfAppointmentsTableAdapters.tblAppointmentsTableAdapter tblAppointmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentTimeDataGridViewTextBoxColumn;
    }
}