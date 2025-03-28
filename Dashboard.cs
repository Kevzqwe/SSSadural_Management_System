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
    public partial class Dashboard : Form
    {   
        public Dashboard()
        {
            InitializeComponent();
          
        }

        private void LoadForm(object Form)
        {
            if (this.AdminMainPanel.Controls.Count > 0)
                this.AdminMainPanel.Controls.RemoveAt(0);

            Form F = Form as Form;
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            this.AdminMainPanel.Controls.Add(F);
            this.AdminMainPanel.Tag = F;
            F.Show();
        }

        private void Employees_button_Click(object sender, EventArgs e)
        {
            LoadForm(new EmployeeFRM());
        }

        private void Home_button_Click(object sender, EventArgs e)
        {
            LoadForm(new homeFRM());
        }
    }

    }
