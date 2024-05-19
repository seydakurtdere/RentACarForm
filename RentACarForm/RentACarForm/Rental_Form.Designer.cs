namespace RentACarForm
{
    partial class Rental_Form
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
            this.cmb_Customer = new System.Windows.Forms.ComboBox();
            this.cmb_Car = new System.Windows.Forms.ComboBox();
            this.cmb_Ins = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbx_DailyWage = new System.Windows.Forms.TextBox();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Fee = new System.Windows.Forms.Label();
            this.lbl_SelectedDay = new System.Windows.Forms.Label();
            this.lbl_TotalFee = new System.Windows.Forms.Label();
            this.lbl_VAT = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Customer
            // 
            this.cmb_Customer.FormattingEnabled = true;
            this.cmb_Customer.Location = new System.Drawing.Point(65, 62);
            this.cmb_Customer.Name = "cmb_Customer";
            this.cmb_Customer.Size = new System.Drawing.Size(270, 21);
            this.cmb_Customer.TabIndex = 0;
            // 
            // cmb_Car
            // 
            this.cmb_Car.FormattingEnabled = true;
            this.cmb_Car.Location = new System.Drawing.Point(65, 135);
            this.cmb_Car.Name = "cmb_Car";
            this.cmb_Car.Size = new System.Drawing.Size(270, 21);
            this.cmb_Car.TabIndex = 1;
            // 
            // cmb_Ins
            // 
            this.cmb_Ins.FormattingEnabled = true;
            this.cmb_Ins.Location = new System.Drawing.Point(65, 210);
            this.cmb_Ins.Name = "cmb_Ins";
            this.cmb_Ins.Size = new System.Drawing.Size(270, 21);
            this.cmb_Ins.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(646, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 457);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbx_DailyWage
            // 
            this.tbx_DailyWage.Location = new System.Drawing.Point(65, 291);
            this.tbx_DailyWage.Name = "tbx_DailyWage";
            this.tbx_DailyWage.Size = new System.Drawing.Size(270, 20);
            this.tbx_DailyWage.TabIndex = 6;
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Location = new System.Drawing.Point(411, 62);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_StartDate.TabIndex = 7;
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(411, 117);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_EndDate.TabIndex = 8;
            // 
            // lbl_Fee
            // 
            this.lbl_Fee.AutoSize = true;
            this.lbl_Fee.Location = new System.Drawing.Point(411, 210);
            this.lbl_Fee.Name = "lbl_Fee";
            this.lbl_Fee.Size = new System.Drawing.Size(0, 13);
            this.lbl_Fee.TabIndex = 9;
            // 
            // lbl_SelectedDay
            // 
            this.lbl_SelectedDay.AutoSize = true;
            this.lbl_SelectedDay.Location = new System.Drawing.Point(411, 241);
            this.lbl_SelectedDay.Name = "lbl_SelectedDay";
            this.lbl_SelectedDay.Size = new System.Drawing.Size(0, 13);
            this.lbl_SelectedDay.TabIndex = 10;
            this.lbl_SelectedDay.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_TotalFee
            // 
            this.lbl_TotalFee.AutoSize = true;
            this.lbl_TotalFee.Location = new System.Drawing.Point(411, 278);
            this.lbl_TotalFee.Name = "lbl_TotalFee";
            this.lbl_TotalFee.Size = new System.Drawing.Size(0, 13);
            this.lbl_TotalFee.TabIndex = 11;
            this.lbl_TotalFee.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.AutoSize = true;
            this.lbl_VAT.Location = new System.Drawing.Point(411, 315);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(0, 13);
            this.lbl_VAT.TabIndex = 12;
            // 
            // Rental_Form
            // 
            this.ClientSize = new System.Drawing.Size(1186, 568);
            this.Controls.Add(this.lbl_VAT);
            this.Controls.Add(this.lbl_TotalFee);
            this.Controls.Add(this.lbl_SelectedDay);
            this.Controls.Add(this.lbl_Fee);
            this.Controls.Add(this.dtp_EndDate);
            this.Controls.Add(this.dtp_StartDate);
            this.Controls.Add(this.tbx_DailyWage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_Ins);
            this.Controls.Add(this.cmb_Car);
            this.Controls.Add(this.cmb_Customer);
            this.Name = "Rental_Form";
            this.Load += new System.EventHandler(this.Rental_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Customer;
        private System.Windows.Forms.ComboBox cmb_Car;
        private System.Windows.Forms.ComboBox cmb_Ins;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbx_DailyWage;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label lbl_Fee;
        private System.Windows.Forms.Label lbl_SelectedDay;
        private System.Windows.Forms.Label lbl_TotalFee;
        private System.Windows.Forms.Label lbl_VAT;
    }
}