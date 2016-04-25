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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 237);
            this.dataGridView1.TabIndex = 15;
            // 
            // frmEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}