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
        public int? Id { get; }
        CustomerService service = new CustomerService();

        public FormCustomer()
        {
            InitializeComponent();
        }

        public FormCustomer(int Id) : this()
        {
            this.Id = Id;
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
            if (!Id.HasValue)
            {
                service.CreateSP(model);
            }
            else
            {
                model.Id = Id.Value;
                service.Update(model);
                DialogResult= DialogResult.OK;
                Close();
            }
            
            MessageBox.Show("🎉🎉");
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                //EDIT
                var customer = service.GetById(Id.Value);
                textBoxFirtsName.Text = customer.FirstName;
                textBoxLastName.Text = customer.LastName;
                textBoxEmail.Text = customer.Email;
                textBoxAddress.Text = customer.Address;
                textBoxNationalCode.Text = customer.NationalCode;
                checkBoxIsactive.Checked = customer.IsActive;
                dateTimePickerDOB.Value = customer.DOB;
            }
        }
    }
}
