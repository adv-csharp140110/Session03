namespace App.UI
{
    partial class FormCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirtsName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNationalCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxIsactive = new System.Windows.Forms.CheckBox();
            this.buttonSaveSP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // textBoxFirtsName
            // 
            this.textBoxFirtsName.Location = new System.Drawing.Point(142, 42);
            this.textBoxFirtsName.Name = "textBoxFirtsName";
            this.textBoxFirtsName.Size = new System.Drawing.Size(252, 23);
            this.textBoxFirtsName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(142, 71);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(252, 23);
            this.textBoxLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(142, 100);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(252, 23);
            this.textBoxEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // textBoxNationalCode
            // 
            this.textBoxNationalCode.Location = new System.Drawing.Point(142, 129);
            this.textBoxNationalCode.Name = "textBoxNationalCode";
            this.textBoxNationalCode.Size = new System.Drawing.Size(252, 23);
            this.textBoxNationalCode.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "National Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "DOB";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(142, 187);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(252, 98);
            this.textBoxAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(142, 158);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(252, 23);
            this.dateTimePickerDOB.TabIndex = 12;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(319, 333);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxIsactive
            // 
            this.checkBoxIsactive.AutoSize = true;
            this.checkBoxIsactive.Location = new System.Drawing.Point(142, 291);
            this.checkBoxIsactive.Name = "checkBoxIsactive";
            this.checkBoxIsactive.Size = new System.Drawing.Size(70, 19);
            this.checkBoxIsactive.TabIndex = 14;
            this.checkBoxIsactive.Text = "Is Active";
            this.checkBoxIsactive.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSP
            // 
            this.buttonSaveSP.Location = new System.Drawing.Point(319, 362);
            this.buttonSaveSP.Name = "buttonSaveSP";
            this.buttonSaveSP.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSP.TabIndex = 15;
            this.buttonSaveSP.Text = "Save SP";
            this.buttonSaveSP.UseVisualStyleBackColor = true;
            this.buttonSaveSP.Click += new System.EventHandler(this.buttonSaveSP_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 393);
            this.Controls.Add(this.buttonSaveSP);
            this.Controls.Add(this.checkBoxIsactive);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNationalCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirtsName);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxFirtsName;
        private TextBox textBoxLastName;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxNationalCode;
        private Label label4;
        private Label label5;
        private TextBox textBoxAddress;
        private Label label6;
        private DateTimePicker dateTimePickerDOB;
        private Button buttonSave;
        private CheckBox checkBoxIsactive;
        private Button buttonSaveSP;
    }
}