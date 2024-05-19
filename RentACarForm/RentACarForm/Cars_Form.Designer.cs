namespace RentACarForm
{
    partial class Cars_Form
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
            this.tbx_carBrand = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_carParts = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tbx_carYear = new System.Windows.Forms.TextBox();
            this.tbx_carDamage = new System.Windows.Forms.TextBox();
            this.tbx_carModel = new System.Windows.Forms.TextBox();
            this.tbx_carKm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_carBrand
            // 
            this.tbx_carBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_carBrand.Location = new System.Drawing.Point(189, 55);
            this.tbx_carBrand.Name = "tbx_carBrand";
            this.tbx_carBrand.Size = new System.Drawing.Size(188, 22);
            this.tbx_carBrand.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Brand";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Car Model";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Car Km";
            // 
            // tbx_carParts
            // 
            this.tbx_carParts.AutoSize = true;
            this.tbx_carParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_carParts.Location = new System.Drawing.Point(221, 331);
            this.tbx_carParts.Name = "tbx_carParts";
            this.tbx_carParts.Size = new System.Drawing.Size(126, 16);
            this.tbx_carParts.TabIndex = 8;
            this.tbx_carParts.Text = "Car Damaged Parts";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(69, 418);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(132, 44);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbx_carYear
            // 
            this.tbx_carYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_carYear.Location = new System.Drawing.Point(189, 198);
            this.tbx_carYear.Name = "tbx_carYear";
            this.tbx_carYear.Size = new System.Drawing.Size(188, 22);
            this.tbx_carYear.TabIndex = 12;
            // 
            // tbx_carDamage
            // 
            this.tbx_carDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_carDamage.Location = new System.Drawing.Point(189, 350);
            this.tbx_carDamage.Name = "tbx_carDamage";
            this.tbx_carDamage.Size = new System.Drawing.Size(188, 22);
            this.tbx_carDamage.TabIndex = 13;
            // 
            // tbx_carModel
            // 
            this.tbx_carModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_carModel.Location = new System.Drawing.Point(189, 128);
            this.tbx_carModel.Name = "tbx_carModel";
            this.tbx_carModel.Size = new System.Drawing.Size(188, 22);
            this.tbx_carModel.TabIndex = 14;
            // 
            // tbx_carKm
            // 
            this.tbx_carKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_carKm.Location = new System.Drawing.Point(189, 274);
            this.tbx_carKm.Name = "tbx_carKm";
            this.tbx_carKm.Size = new System.Drawing.Size(188, 22);
            this.tbx_carKm.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(652, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 407);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(402, 418);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(132, 44);
            this.btn_Update.TabIndex = 18;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Cars_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 522);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_carKm);
            this.Controls.Add(this.tbx_carModel);
            this.Controls.Add(this.tbx_carDamage);
            this.Controls.Add(this.tbx_carYear);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tbx_carParts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_carBrand);
            this.Name = "Cars_Form";
            this.Text = "Cars Form";
            this.Load += new System.EventHandler(this.Cars_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_carBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tbx_carParts;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tbx_carYear;
        private System.Windows.Forms.TextBox tbx_carDamage;
        private System.Windows.Forms.TextBox tbx_carModel;
        private System.Windows.Forms.TextBox tbx_carKm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Update;
    }
}

