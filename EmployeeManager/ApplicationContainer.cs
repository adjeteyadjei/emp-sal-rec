using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManager
{
    public partial class ApplicationContainer : Form
    {
        public ApplicationContainer()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            ShowControlForm(new EmployeeListView());
        }

        public void ShowControlForm(Control view)
        {
            view.Top = 10;
            view.Left = 5;
            view.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom)| AnchorStyles.Left)| AnchorStyles.Right;

            view.Width = viewContainer.Size.Width - 10;
            view.Height = viewContainer.Size.Height - 15;
            viewContainer.Controls.Clear();
            viewContainer.Controls.Add(view);
        }

        private void btnSalaries_Click(object sender, EventArgs e)
        {
            ShowControlForm(new SalariesView());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowControlForm(new SettingsView());
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            ShowControlForm(new AdministrationView());
        }
    }
}
