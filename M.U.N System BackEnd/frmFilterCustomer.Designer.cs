namespace M.U.N_System_BackEnd
{
    partial class frmFilterCustomer
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
            this.lblFilterCustomer = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lstFilter = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ourDatabaseDataSet = new M.U.N_System_BackEnd.OurDatabaseDataSet();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter = new M.U.N_System_BackEnd.OurDatabaseDataSetTableAdapters.tblCustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilterCustomer
            // 
            this.lblFilterCustomer.AutoSize = true;
            this.lblFilterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblFilterCustomer.Location = new System.Drawing.Point(43, 19);
            this.lblFilterCustomer.Name = "lblFilterCustomer";
            this.lblFilterCustomer.Size = new System.Drawing.Size(200, 31);
            this.lblFilterCustomer.TabIndex = 37;
            this.lblFilterCustomer.Text = "Filter Customer";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(46, 469);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(46, 55);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 35;
            this.lblFilter.Text = "Filter";
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(231, 418);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(75, 23);
            this.btnArchive.TabIndex = 34;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(138, 418);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(46, 418);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 32;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lstFilter
            // 
            this.lstFilter.DataSource = this.tblCustomerBindingSource;
            this.lstFilter.DisplayMember = "FirstName";
            this.lstFilter.FormattingEnabled = true;
            this.lstFilter.Location = new System.Drawing.Point(46, 120);
            this.lstFilter.Name = "lstFilter";
            this.lstFilter.Size = new System.Drawing.Size(420, 277);
            this.lstFilter.TabIndex = 31;
            this.lstFilter.ValueMember = "FirstName";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // ourDatabaseDataSet
            // 
            this.ourDatabaseDataSet.DataSetName = "OurDatabaseDataSet";
            this.ourDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.ourDatabaseDataSet;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // frmFilterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(509, 510);
            this.Controls.Add(this.lblFilterCustomer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lstFilter);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmFilterCustomer";
            this.Text = "FilterCustomer";
            this.Load += new System.EventHandler(this.FilterCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ourDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilterCustomer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListBox lstFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private OurDatabaseDataSet ourDatabaseDataSet;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private OurDatabaseDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
    }
}