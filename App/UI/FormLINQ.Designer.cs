namespace App.UI
{
    partial class FormLINQ
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
            this.buttonLinq1 = new System.Windows.Forms.Button();
            this.buttonLinq2 = new System.Windows.Forms.Button();
            this.buttonLinq3 = new System.Windows.Forms.Button();
            this.buttonLinq4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(774, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonLinq1
            // 
            this.buttonLinq1.Location = new System.Drawing.Point(12, 12);
            this.buttonLinq1.Name = "buttonLinq1";
            this.buttonLinq1.Size = new System.Drawing.Size(136, 23);
            this.buttonLinq1.TabIndex = 1;
            this.buttonLinq1.Text = "Linq 1";
            this.buttonLinq1.UseVisualStyleBackColor = true;
            this.buttonLinq1.Click += new System.EventHandler(this.buttonLinq1_Click);
            // 
            // buttonLinq2
            // 
            this.buttonLinq2.Location = new System.Drawing.Point(12, 41);
            this.buttonLinq2.Name = "buttonLinq2";
            this.buttonLinq2.Size = new System.Drawing.Size(136, 23);
            this.buttonLinq2.TabIndex = 2;
            this.buttonLinq2.Text = "Linq 2";
            this.buttonLinq2.UseVisualStyleBackColor = true;
            this.buttonLinq2.Click += new System.EventHandler(this.buttonLinq2_Click);
            // 
            // buttonLinq3
            // 
            this.buttonLinq3.Location = new System.Drawing.Point(12, 70);
            this.buttonLinq3.Name = "buttonLinq3";
            this.buttonLinq3.Size = new System.Drawing.Size(136, 23);
            this.buttonLinq3.TabIndex = 3;
            this.buttonLinq3.Text = "Linq 3";
            this.buttonLinq3.UseVisualStyleBackColor = true;
            this.buttonLinq3.Click += new System.EventHandler(this.buttonLinq3_Click);
            // 
            // buttonLinq4
            // 
            this.buttonLinq4.Location = new System.Drawing.Point(12, 99);
            this.buttonLinq4.Name = "buttonLinq4";
            this.buttonLinq4.Size = new System.Drawing.Size(136, 23);
            this.buttonLinq4.TabIndex = 4;
            this.buttonLinq4.Text = "Linq 4";
            this.buttonLinq4.UseVisualStyleBackColor = true;
            this.buttonLinq4.Click += new System.EventHandler(this.buttonLinq4_Click);
            // 
            // FormLINQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 521);
            this.Controls.Add(this.buttonLinq4);
            this.Controls.Add(this.buttonLinq3);
            this.Controls.Add(this.buttonLinq2);
            this.Controls.Add(this.buttonLinq1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormLINQ";
            this.Text = "FormLINQ";
            this.Load += new System.EventHandler(this.FormLINQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonLinq1;
        private Button buttonLinq2;
        private Button buttonLinq3;
        private Button buttonLinq4;
    }
}