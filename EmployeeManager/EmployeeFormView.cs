using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ALHelpers.WinForm;
using EmployeeManager.DataAccess;

namespace EmployeeManager
{
    public partial class EmployeeFormView : UserControl
    {
        private readonly bool _isNew;
        private readonly string _employeeId;
        private int? _index;
        public EmployeeFormView(string id)
        {
            InitializeComponent();
            _isNew = string.IsNullOrEmpty(id);
            _employeeId = id;
        }

        private void EmployeeFormView_Load(object sender, EventArgs e)
        {
            formTitle.Text = _isNew ? "New Employee" : "Edit Employee";
            deleteEmployee.Visible = !_isNew;
            if (!_isNew) SetEmployee();
        }

        private void SetEmployee()
        {
            var empList = DbContext.Employees.Get();
            var employee = empList.FirstOrDefault(q => q.Id == _employeeId);
            if (employee == null)
            {
                Error("Employee not found");
                backButton_Click(null, null);
                return;
            }
            
            _index = empList.IndexOf(employee);
            lastName.Text = employee.LastName;
            otherNames.Text = employee.OtherNames;
            jobTitle.Text = employee.JobTitle;
            phoneNumber.Text = employee.PhoneNumber;
            email.Text = employee.Email;
            employeeNumber.Text = employee.EmployeeNo;
            address.Text = employee.Address;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var main = (ParentForm as ApplicationContainer);
            if (main == null) return;
            main.ShowControlForm(new EmployeeListView());
        }

        private void cancelForm_Click(object sender, EventArgs e)
        {
            backButton_Click(sender, e);
        }

        private void saveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var valid = new FormValidate().IsValidControls(new List<ControlToValidate>
                {
                    new ControlToValidate {Control = lastName, ValidateType = ValidationType.Required},
                    new ControlToValidate {Control = otherNames, ValidateType = ValidationType.Required},
                    new ControlToValidate {Control = jobTitle, ValidateType = ValidationType.Required},
                    new ControlToValidate {Control = phoneNumber, ValidateType = ValidationType.Required}
                });

                if (!valid) return;
                var employee = new Employee
                {
                    LastName = lastName.Text,
                    OtherNames = otherNames.Text,
                    JobTitle = jobTitle.Text,
                    PhoneNumber = phoneNumber.Text,
                    Email = email.Text,
                    Address = address.Text,
                    EmployeeNo = employeeNumber.Text,
                    Name = lastName.Text + " " + otherNames.Text,
                    CreatedBy = "System",
                    ModifiedBy = "System"
                };
                DbContext.Employees.Save(employee, _index);
                Success("Employee Saved.");
                backButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }

        }

        private void deleteEmployee_Click(object sender, EventArgs e)
        {
            if (!_index.HasValue)
            {
                Error("No Employee Selected");
                return;
            }
            var answer = MessageBox.Show(@"Are you sure you want to delete this employee?", @"Delete Employee", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                DbContext.Employees.Delete(_index.Value);
                Success("Employee Deleted");
                backButton_Click(sender, e);
            }
        }

        private void Success(string message)
        {
            MessageBox.Show(message, formTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Error(string message)
        {
            MessageBox.Show(message, formTitle.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
