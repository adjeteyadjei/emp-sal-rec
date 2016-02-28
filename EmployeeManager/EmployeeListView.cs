using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManager.DataAccess;

namespace EmployeeManager
{
    public partial class EmployeeListView : UserControl
    {
        public EmployeeListView()
        {
            InitializeComponent();
        }

        private void addNewEmployee_Click(object sender, EventArgs e)
        {
            OpenEmployeeForm(null);
        }

        private void OpenEmployeeForm(string id)
        {
            var main = (ParentForm as ApplicationContainer);
            if (main == null) return;
            main.ShowControlForm(new EmployeeFormView(id));
        }

        private void EmployeeListView_Load(object sender, EventArgs e)
        {
            SetEmployeeList(DbContext.Employees.Get());
        }

        private void SetEmployeeList(List<Employee> employees)
        {
            employees.ForEach(emp =>
                employeeGridList.Rows.Add(emp.Id, emp.Name,
                emp.PhoneNumber, emp.Email, emp.JobTitle,
                emp.Address, emp.Gender));
        }

        private void searchEmployee_Click(object sender, EventArgs e)
        {
            var employeeList = DbContext.Employees.Get()
                .Where(q => q.Name.ToLower().Contains(searchText.Text.ToLower()))
                .ToList();
            SetEmployeeList(employeeList);

        }

        private void employeeGridList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (employeeGridList.SelectedRows.Count == 0) return;
            var id = employeeGridList.SelectedRows[0].Cells[0].Value.ToString();
            OpenEmployeeForm(id);

        }
        
   
    }
}
