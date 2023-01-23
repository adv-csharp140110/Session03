namespace App.UI
{
    partial class FormCustomerList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.LastName,
            this.Email,
            this.Address,
            this.NationalCode,
            this.DOB,
            this.IsActive,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "FirstName";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // NationalCode
            // 
            this.NationalCode.DataPropertyName = "NationalCode";
            this.NationalCode.HeaderText = "کد ملی";
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "تارخ تولد";
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "فعال";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "حذف";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "حذف 🗑️";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCustomerList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FormCustomerList";
            this.Load += new System.EventHandler(this.FormCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn NationalCode;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewCheckBoxColumn IsActive;
        private DataGridViewButtonColumn Delete;
    }
}