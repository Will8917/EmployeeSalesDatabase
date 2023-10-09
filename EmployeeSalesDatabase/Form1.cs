using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalesDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowXML_Click(object sender, EventArgs e)
        {
            txtXMLData.Text = DataLayer.GetXML();
        }

        private void btnShowEmployees_Click(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = DataLayer.GetEmployees();
        }

        private void btnCountEmployees_Click(object sender, EventArgs e)
        {
            labelCount.Text = DataLayer.GetNumEmployees().ToString();
        }
    }
}
