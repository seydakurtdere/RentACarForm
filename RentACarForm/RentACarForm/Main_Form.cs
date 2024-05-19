using RentACarForm.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarForm
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void btn_LoginInto_Click(object sender, EventArgs e)
        {
            AppUserForm appUserForm = LoginUser.GetAppUserForm();
            MessageBox.Show(appUserForm.UserName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cars_Form carsForm = new Cars_Form();
            carsForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InsuranceCompany_Form insuranceCompanyForm = new InsuranceCompany_Form();
            insuranceCompanyForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer_Form customerForm = new Customer_Form();
            customerForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rental_Form rentalForm = new Rental_Form();
            rentalForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserManagement_Form userManagementForm = new UserManagement_Form();
            userManagementForm.Show();
        }
    }
}
