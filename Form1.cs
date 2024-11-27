using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text;
            string firstName = txtFirstName.Text;
            string phone = txtPhone.Text;

            if (!string.IsNullOrWhiteSpace(lastName) &&
                !string.IsNullOrWhiteSpace(firstName) &&
                !string.IsNullOrWhiteSpace(phone))
            {
                dgvNames.Rows.Add(lastName, firstName, phone);
                txtLastName.Clear();
                txtFirstName.Clear();
                txtPhone.Clear();
            }
            else
            {
                MessageBox.Show("Vui long điền vào.");
            }
        }
    }
}
