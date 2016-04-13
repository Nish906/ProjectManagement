namespace EmailBackEnd
{
    partial class frmSendEmail
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
            this.btnAttach = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblSendingError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(8, 161);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(97, 24);
            this.btnAttach.TabIndex = 22;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(9, 191);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(624, 237);
            this.txtContent.TabIndex = 21;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(51, 130);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(582, 20);
            this.txtSubject.TabIndex = 20;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(51, 99);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(582, 20);
            this.txtCC.TabIndex = 19;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(6, 133);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 18;
            this.lblSubject.Text = "Subject:";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(27, 102);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(24, 13);
            this.lblCC.TabIndex = 17;
            this.lblCC.Text = "CC:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(28, 66);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 16;
            this.lblTo.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(51, 63);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(582, 20);
            this.txtTo.TabIndex = 15;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(21, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(101, 45);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(9, 446);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 37);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Retrun";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblSendingError
            // 
            this.lblSendingError.AutoSize = true;
            this.lblSendingError.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendingError.ForeColor = System.Drawing.Color.Red;
            this.lblSendingError.Location = new System.Drawing.Point(128, 24);
            this.lblSendingError.Name = "lblSendingError";
            this.lblSendingError.Size = new System.Drawing.Size(0, 19);
            this.lblSendingError.TabIndex = 23;
            // 
            // frmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 495);
            this.Controls.Add(this.lblSendingError);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmSendEmail";
            this.Text = "frmSendEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblSendingError;
    }
}