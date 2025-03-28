using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SSSadural_Management_System
{
    public partial class AddEmployeeFRM : Form
    {
        public AddEmployeeFRM()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Clear previous controls inside the panel
            Panel.Controls.Clear();

            // Create an instance of the AddEmployeeForm
            EmployeeFRM employeeFRM= new EmployeeFRM();

            // Remove form borders
            employeeFRM.TopLevel = false;
            employeeFRM.FormBorderStyle = FormBorderStyle.None;

            // Dock the form to fill the panel
            employeeFRM.Dock = DockStyle.Fill;

            // Add form to the panel and show it
           Panel.Controls.Add(employeeFRM);
            employeeFRM.Show();
        }
    }
    
}
