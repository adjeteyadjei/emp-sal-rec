namespace EmployeeManager
{
    partial class SalariesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalariesView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.searchEmployee = new System.Windows.Forms.Button();
            this.employeeGridList = new System.Windows.Forms.DataGridView();
            this.addNewEmployee = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 1);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "....list of employee salary schemes.";
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppTitle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAppTitle.Location = new System.Drawing.Point(3, 4);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(71, 23);
            this.lblAppTitle.TabIndex = 13;
            this.lblAppTitle.Text = "Salaries";
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchText.Location = new System.Drawing.Point(380, 55);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(282, 22);
            this.searchText.TabIndex = 65;
            // 
            // searchEmployee
            // 
            this.searchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchEmployee.BackColor = System.Drawing.SystemColors.Window;
            this.searchEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchEmployee.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchEmployee.Image = ((System.Drawing.Image)(resources.GetObject("searchEmployee.Image")));
            this.searchEmployee.Location = new System.Drawing.Point(662, 55);
            this.searchEmployee.Name = "searchEmployee";
            this.searchEmployee.Size = new System.Drawing.Size(26, 22);
            this.searchEmployee.TabIndex = 66;
            this.searchEmployee.UseVisualStyleBackColor = false;
            // 
            // employeeGridList
            // 
            this.employeeGridList.AllowUserToAddRows = false;
            this.employeeGridList.AllowUserToDeleteRows = false;
            this.employeeGridList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeeGridList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.employeeGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PaymentDate,
            this.EmployeeName,
            this.Amount,
            this.Description});
            this.employeeGridList.Location = new System.Drawing.Point(5, 83);
            this.employeeGridList.Name = "employeeGridList";
            this.employeeGridList.ReadOnly = true;
            this.employeeGridList.Size = new System.Drawing.Size(685, 337);
            this.employeeGridList.TabIndex = 64;
            // 
            // addNewEmployee
            // 
            this.addNewEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewEmployee.Image = ((System.Drawing.Image)(resources.GetObject("addNewEmployee.Image")));
            this.addNewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewEmployee.Location = new System.Drawing.Point(5, 47);
            this.addNewEmployee.Name = "addNewEmployee";
            this.addNewEmployee.Size = new System.Drawing.Size(140, 30);
            this.addNewEmployee.TabIndex = 63;
            this.addNewEmployee.Text = "Add New Salary";
            this.addNewEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addNewEmployee.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "Date";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Employee";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // SalariesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchEmployee);
            this.Controls.Add(this.employeeGridList);
            this.Controls.Add(this.addNewEmployee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAppTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalariesView";
            this.Size = new System.Drawing.Size(694, 426);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchEmployee;
        private System.Windows.Forms.DataGridView employeeGridList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button addNewEmployee;
    }
}
