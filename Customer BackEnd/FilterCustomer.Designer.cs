namespace ScreenDesignsWindowsForm
{
    partial class FilterCustomer
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lstFilter = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFilterCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(59, 408);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstFilter
            // 
            this.lstFilter.FormattingEnabled = true;
            this.lstFilter.Location = new System.Drawing.Point(59, 110);
            this.lstFilter.Name = "lstFilter";
            this.lstFilter.Size = new System.Drawing.Size(420, 277);
            this.lstFilter.TabIndex = 4;
            this.lstFilter.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(151, 408);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(244, 408);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(75, 23);
            this.btnArchive.TabIndex = 7;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(59, 45);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(29, 13);
            this.lblFilter.TabIndex = 8;
            this.lblFilter.Text = "Filter";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(59, 459);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblFilterCustomer
            // 
            this.lblFilterCustomer.AutoSize = true;
            this.lblFilterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblFilterCustomer.Location = new System.Drawing.Point(56, 9);
            this.lblFilterCustomer.Name = "lblFilterCustomer";
            this.lblFilterCustomer.Size = new System.Drawing.Size(200, 31);
            this.lblFilterCustomer.TabIndex = 29;
            this.lblFilterCustomer.Text = "Filter Customer";
            // 
            // FilterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 494);
            this.Controls.Add(this.lblFilterCustomer);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lstFilter);
            this.Controls.Add(this.comboBox1);
            this.Name = "FilterCustomer";
            this.Text = "FilterCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListBox lstFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFilterCustomer;
    }
}