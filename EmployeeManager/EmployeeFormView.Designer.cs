namespace EmployeeManager
{
    partial class EmployeeFormView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeFormView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.formTitle = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.address = new System.Windows.Forms.TextBox();
            this.jobTitle = new System.Windows.Forms.TextBox();
            this.employeeNumber = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.otherNames = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.saveEmployee = new System.Windows.Forms.Button();
            this.cancelForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 1);
            this.panel1.TabIndex = 14;
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.BackColor = System.Drawing.Color.Transparent;
            this.formTitle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.formTitle.Location = new System.Drawing.Point(34, 5);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(0, 23);
            this.formTitle.TabIndex = 13;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(27, 29);
            this.backButton.TabIndex = 63;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.jobTitle);
            this.groupBox1.Controls.Add(this.employeeNumber);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.otherNames);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.female);
            this.panel2.Controls.Add(this.male);
            this.panel2.Location = new System.Drawing.Point(160, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 30);
            this.panel2.TabIndex = 8;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(65, 4);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(72, 20);
            this.female.TabIndex = 1;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Location = new System.Drawing.Point(3, 4);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(56, 20);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(160, 164);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(396, 74);
            this.address.TabIndex = 6;
            // 
            // jobTitle
            // 
            this.jobTitle.Location = new System.Drawing.Point(160, 241);
            this.jobTitle.Name = "jobTitle";
            this.jobTitle.Size = new System.Drawing.Size(396, 22);
            this.jobTitle.TabIndex = 7;
            // 
            // employeeNumber
            // 
            this.employeeNumber.Location = new System.Drawing.Point(160, 136);
            this.employeeNumber.Name = "employeeNumber";
            this.employeeNumber.Size = new System.Drawing.Size(396, 22);
            this.employeeNumber.TabIndex = 5;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(160, 108);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(396, 22);
            this.email.TabIndex = 4;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(160, 80);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(396, 22);
            this.phoneNumber.TabIndex = 3;
            // 
            // otherNames
            // 
            this.otherNames.Location = new System.Drawing.Point(160, 52);
            this.otherNames.Name = "otherNames";
            this.otherNames.Size = new System.Drawing.Size(396, 22);
            this.otherNames.TabIndex = 2;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(160, 24);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(396, 22);
            this.lastName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(98, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Job Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Employee No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Other Names:";
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteEmployee.Image = ((System.Drawing.Image)(resources.GetObject("deleteEmployee.Image")));
            this.deleteEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteEmployee.Location = new System.Drawing.Point(38, 380);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(113, 32);
            this.deleteEmployee.TabIndex = 3;
            this.deleteEmployee.Text = "    Delete";
            this.deleteEmployee.UseVisualStyleBackColor = true;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // saveEmployee
            // 
            this.saveEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveEmployee.Image = ((System.Drawing.Image)(resources.GetObject("saveEmployee.Image")));
            this.saveEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveEmployee.Location = new System.Drawing.Point(451, 380);
            this.saveEmployee.Name = "saveEmployee";
            this.saveEmployee.Size = new System.Drawing.Size(143, 32);
            this.saveEmployee.TabIndex = 1;
            this.saveEmployee.Text = "       Save";
            this.saveEmployee.UseVisualStyleBackColor = true;
            this.saveEmployee.Click += new System.EventHandler(this.saveEmployee_Click);
            // 
            // cancelForm
            // 
            this.cancelForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelForm.Image = ((System.Drawing.Image)(resources.GetObject("cancelForm.Image")));
            this.cancelForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelForm.Location = new System.Drawing.Point(362, 380);
            this.cancelForm.Name = "cancelForm";
            this.cancelForm.Size = new System.Drawing.Size(83, 32);
            this.cancelForm.TabIndex = 2;
            this.cancelForm.Text = "    Cancel";
            this.cancelForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelForm.UseVisualStyleBackColor = true;
            this.cancelForm.Click += new System.EventHandler(this.cancelForm_Click);
            // 
            // EmployeeFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.cancelForm);
            this.Controls.Add(this.saveEmployee);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeFormView";
            this.Size = new System.Drawing.Size(694, 426);
            this.Load += new System.EventHandler(this.EmployeeFormView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox employeeNumber;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox otherNames;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.Button saveEmployee;
        private System.Windows.Forms.Button cancelForm;
        private System.Windows.Forms.TextBox jobTitle;
    }
}
