using App.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI
{
    public partial class FormCustomerList : Form
    {
        public FormCustomerList()
        {
            InitializeComponent();
        }

        private void FormCustomerList_Load(object sender, EventArgs e)
        {
            var service = new CustomerService();
            dataGridView1.DataSource= service.Read();
        }
    }
}
