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
            RefreshData();
        }

        private void RefreshData()
        {
            var service = new CustomerService();
            dataGridView1.DataSource = service.Read();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentCell.OwningColumn.Name == "Delete")
            {
                if(MessageBox.Show("مطمنئ هستید؟", "حذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var service = new CustomerService();
                    var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    service.Delete(id);
                    //dataGridView1.DataSource = service.Read();
                    RefreshData();
                    MessageBox.Show("Success");
                }
            }
            
        }
    }
}
