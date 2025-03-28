using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSSadural_Management_System
{
    public partial class EmployeeFRM : Form
    {
        public EmployeeFRM()
        {
            InitializeComponent();
        }
       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Clear previous controls inside the panel
            panel.Controls.Clear();

            // Create an instance of the AddEmployeeForm
            AddEmployeeFRM addEmployeeForm = new AddEmployeeFRM();

            // Remove form borders
            addEmployeeForm.TopLevel = false;
            addEmployeeForm.FormBorderStyle = FormBorderStyle.None;

            // Dock the form to fill the panel
            addEmployeeForm.Dock = DockStyle.Fill;

            // Add form to the panel and show it
            panel.Controls.Add(addEmployeeForm);
            addEmployeeForm.Show();
        }
    }
    
}
