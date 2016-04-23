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
            this.btnSend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(411, 347);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(0, 0);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 577);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 69);
            this.button1.TabIndex = 16;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(49, 30);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(31, 20);
            this.lblTo.TabIndex = 18;
            this.lblTo.Text = "To:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(90, 24);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(871, 26);
            this.txtTo.TabIndex = 17;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(90, 60);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(871, 26);
            this.txtSubject.TabIndex = 22;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(13, 66);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(67, 20);
            this.lblSubject.TabIndex = 21;
            this.lblSubject.Text = "Subject:";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(20, 114);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(941, 436);
            this.txtContent.TabIndex = 23;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(20, 577);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(148, 69);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Retrun";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // frmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 664);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSend);
            this.Name = "frmSendEmail";
            this.Text = "frmSendEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnReturn;
    }
}