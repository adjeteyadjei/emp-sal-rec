namespace EmployeeManager
{
    partial class ApplicationContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationContainer));
            this.pHeader = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSalaries = new System.Windows.Forms.Button();
            this.btnAdministration = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.viewContainer = new System.Windows.Forms.GroupBox();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pHeader.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHeader.BackColor = System.Drawing.Color.DarkBlue;
            this.pHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pHeader.Controls.Add(this.lblAppTitle);
            this.pHeader.Location = new System.Drawing.Point(-3, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(890, 38);
            this.pHeader.TabIndex = 9;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppTitle.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAppTitle.Location = new System.Drawing.Point(9, 7);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(143, 24);
            this.lblAppTitle.TabIndex = 2;
            this.lblAppTitle.Text = "Employee Manager";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-3, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 3);
            this.panel1.TabIndex = 10;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.Transparent;
            this.pMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMenu.Controls.Add(this.btnSettings);
            this.pMenu.Controls.Add(this.btnSalaries);
            this.pMenu.Controls.Add(this.btnAdministration);
            this.pMenu.Controls.Add(this.btnEmployee);
            this.pMenu.Location = new System.Drawing.Point(10, 51);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(145, 166);
            this.pMenu.TabIndex = 11;
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(10, 84);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(123, 33);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "     Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSalaries
            // 
            this.btnSalaries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalaries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaries.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalaries.ForeColor = System.Drawing.Color.Black;
            this.btnSalaries.Image = ((System.Drawing.Image)(resources.GetObject("btnSalaries.Image")));
            this.btnSalaries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaries.Location = new System.Drawing.Point(10, 45);
            this.btnSalaries.Name = "btnSalaries";
            this.btnSalaries.Size = new System.Drawing.Size(123, 33);
            this.btnSalaries.TabIndex = 0;
            this.btnSalaries.Text = "    Salaries";
            this.btnSalaries.UseVisualStyleBackColor = true;
            this.btnSalaries.Click += new System.EventHandler(this.btnSalaries_Click);
            // 
            // btnAdministration
            // 
            this.btnAdministration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdministration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministration.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministration.ForeColor = System.Drawing.Color.Black;
            this.btnAdministration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministration.Location = new System.Drawing.Point(10, 123);
            this.btnAdministration.Name = "btnAdministration";
            this.btnAdministration.Size = new System.Drawing.Size(123, 33);
            this.btnAdministration.TabIndex = 0;
            this.btnAdministration.Text = "Administration";
            this.btnAdministration.UseVisualStyleBackColor = true;
            this.btnAdministration.Click += new System.EventHandler(this.btnAdministration_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(10, 6);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(123, 33);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "     Employees";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // viewContainer
            // 
            this.viewContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewContainer.BackColor = System.Drawing.Color.Transparent;
            this.viewContainer.Location = new System.Drawing.Point(161, 45);
            this.viewContainer.Name = "viewContainer";
            this.viewContainer.Size = new System.Drawing.Size(717, 460);
            this.viewContainer.TabIndex = 12;
            this.viewContainer.TabStop = false;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel8,
            this.tssConnectionStatus});
            this.statusStrip2.Location = new System.Drawing.Point(0, 521);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(885, 22);
            this.statusStrip2.TabIndex = 13;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel8.Margin = new System.Windows.Forms.Padding(4, 3, 0, 2);
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel8.Text = "Version";
            // 
            // tssConnectionStatus
            // 
            this.tssConnectionStatus.ActiveLinkColor = System.Drawing.Color.Black;
            this.tssConnectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.tssConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssConnectionStatus.ForeColor = System.Drawing.Color.Black;
            this.tssConnectionStatus.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.tssConnectionStatus.Name = "tssConnectionStatus";
            this.tssConnectionStatus.Size = new System.Drawing.Size(35, 17);
            this.tssConnectionStatus.Text = "0.0.1";
            // 
            // ApplicationContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(885, 543);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.viewContainer);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(901, 582);
            this.Name = "ApplicationContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLOYEE MANAGER";
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pMenu.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSalaries;
        private System.Windows.Forms.Button btnAdministration;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.GroupBox viewContainer;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel tssConnectionStatus;

    }
}

