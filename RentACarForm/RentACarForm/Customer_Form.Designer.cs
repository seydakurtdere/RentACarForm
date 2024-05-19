namespace RentACarForm
{
    partial class Customer_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_CustomerName = new System.Windows.Forms.TextBox();
            this.tbx_CustomerIdentity = new System.Windows.Forms.TextBox();
            this.tbx_CustomerMotherName = new System.Windows.Forms.TextBox();
            this.tbx_CustomerFatherName = new System.Windows.Forms.TextBox();
            this.tbx_CustomerJob = new System.Windows.Forms.TextBox();
            this.tbx_CustomerDrivingLicence = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name-Surname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Father Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer Mother Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Customer Identity Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(560, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Customer Job";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "CustomerDrivingLicenceType";
            // 
            // tbx_CustomerName
            // 
            this.tbx_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CustomerName.Location = new System.Drawing.Point(75, 59);
            this.tbx_CustomerName.Name = "tbx_CustomerName";
            this.tbx_CustomerName.Size = new System.Drawing.Size(236, 22);
            this.tbx_CustomerName.TabIndex = 8;
            // 
            // tbx_CustomerIdentity
            // 
            this.tbx_CustomerIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CustomerIdentity.Location = new System.Drawing.Point(75, 183);
            this.tbx_CustomerIdentity.Name = "tbx_CustomerIdentity";
            this.tbx_CustomerIdentity.Size = new System.Drawing.Size(236, 22);
            this.tbx_CustomerIdentity.TabIndex = 9;
            // 
            // tbx_CustomerMotherName
            // 
            this.tbx_CustomerMotherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CustomerMotherName.Location = new System.Drawing.Point(552, 59);
            this.tbx_CustomerMotherName.Name = "tbx_CustomerMotherName";
            this.tbx_CustomerMotherName.Size = new System.Drawing.Size(236, 22);
            this.tbx_CustomerMotherName.TabIndex = 10;
            // 
            // tbx_CustomerFatherName
            // 
            this.tbx_CustomerFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CustomerFatherName.Location = new System.Drawing.Point(552, 121);
            this.tbx_CustomerFatherName.Name = "tbx_CustomerFatherName";
            this.tbx_CustomerFatherName.Size = new System.Drawing.Size(236, 22);
            this.tbx_CustomerFatherName.TabIndex = 11;
            // 
            // tbx_CustomerJob
            // 
            this.tbx_CustomerJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CustomerJob.Location = new System.Drawing.Point(552, 183);
            this.tbx_CustomerJob.Name = "tbx_CustomerJob";
            this.tbx_CustomerJob.Size = new System.Drawing.Size(236, 22);
            this.tbx_CustomerJob.TabIndex = 12;
            // 
            // tbx_CustomerDrivingLicence
            // 
            this.tbx_CustomerDrivingLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CustomerDrivingLicence.Location = new System.Drawing.Point(75, 248);
            this.tbx_CustomerDrivingLicence.Name = "tbx_CustomerDrivingLicence";
            this.tbx_CustomerDrivingLicence.Size = new System.Drawing.Size(236, 22);
            this.tbx_CustomerDrivingLicence.TabIndex = 13;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(426, 236);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(116, 46);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Add ";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(569, 236);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(116, 46);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(712, 236);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(116, 46);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 281);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tbx_CustomerDrivingLicence);
            this.Controls.Add(this.tbx_CustomerJob);
            this.Controls.Add(this.tbx_CustomerFatherName);
            this.Controls.Add(this.tbx_CustomerMotherName);
            this.Controls.Add(this.tbx_CustomerIdentity);
            this.Controls.Add(this.tbx_CustomerName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Form";
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.Customer_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_CustomerName;
        private System.Windows.Forms.TextBox tbx_CustomerIdentity;
        private System.Windows.Forms.TextBox tbx_CustomerMotherName;
        private System.Windows.Forms.TextBox tbx_CustomerFatherName;
        private System.Windows.Forms.TextBox tbx_CustomerJob;
        private System.Windows.Forms.TextBox tbx_CustomerDrivingLicence;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}