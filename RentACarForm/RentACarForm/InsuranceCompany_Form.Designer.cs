namespace RentACarForm
{
    partial class InsuranceCompany_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_CompanyName = new System.Windows.Forms.TextBox();
            this.tbx_OverdayWage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Overday Wage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insurance Company Name";
            // 
            // tbx_CompanyName
            // 
            this.tbx_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_CompanyName.Location = new System.Drawing.Point(88, 74);
            this.tbx_CompanyName.Name = "tbx_CompanyName";
            this.tbx_CompanyName.Size = new System.Drawing.Size(211, 22);
            this.tbx_CompanyName.TabIndex = 3;
            // 
            // tbx_OverdayWage
            // 
            this.tbx_OverdayWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_OverdayWage.Location = new System.Drawing.Point(88, 140);
            this.tbx_OverdayWage.Name = "tbx_OverdayWage";
            this.tbx_OverdayWage.Size = new System.Drawing.Size(211, 22);
            this.tbx_OverdayWage.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(416, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 186);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(156, 195);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 46);
            this.btn_Update.TabIndex = 7;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(274, 195);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 46);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(38, 195);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 46);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // InsuranceCompany_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 336);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbx_OverdayWage);
            this.Controls.Add(this.tbx_CompanyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "InsuranceCompany_Form";
            this.Text = "InsuranceCompany_Form";
            this.Load += new System.EventHandler(this.InsuranceCompany_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_CompanyName;
        private System.Windows.Forms.TextBox tbx_OverdayWage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
    }
}