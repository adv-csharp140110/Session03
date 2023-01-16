using App.Model;
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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var model = new Customer
            {
                FirstName = textBoxFirtsName.Text,
                LastName = textBoxLastName.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                IsActive = checkBoxIsactive.Checked,
                DOB = dateTimePickerDOB.Value,
                NationalCode= textBoxNationalCode.Text,
            };

            var service = new CustomerService();
            service.Create(model);
            MessageBox.Show("🎉🎉");

        }

        private void buttonSaveSP_Click(object sender, EventArgs e)
        {
            var model = new Customer
            {
                FirstName = textBoxFirtsName.Text,
                LastName = textBoxLastName.Text,
                Email = textBoxEmail.Text,
                Address = textBoxAddress.Text,
                IsActive = checkBoxIsactive.Checked,
                DOB = dateTimePickerDOB.Value,
                NationalCode = textBoxNationalCode.Text,
            };

            var service = new CustomerService();
            service.CreateSP(model);
            MessageBox.Show("🎉🎉");
        }
    }
}
