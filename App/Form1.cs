using App.UI;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            var form = new FormCustomer();
            form.ShowDialog();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            var form = new FormCustomerList();
            form.Show();
        }

        private void buttonLinq_Click(object sender, EventArgs e)
        {
            var form = new FormLINQ();
            form.ShowDialog();
        }
    }
}