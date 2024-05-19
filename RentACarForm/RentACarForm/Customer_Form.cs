using RentACarForm.Infrastructure;
using RentACarForm.Model;
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
    public partial class Customer_Form : Form
    {
        int customerformID = 0;
        public Customer_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void UpdateGrid()
        {

            RentACarEntities db = new RentACarEntities();
            List<CustomerForm> customerformlist = db.CustomerForm.Where(s => s.IsActive == true).ToList();
            List<CustomerFormListModel> customerFormListModels = new List<CustomerFormListModel>();
            foreach (var customer in customerformlist)
            {
                CustomerFormListModel customerFormListModel = new CustomerFormListModel()
                {
                    CustomerFormId = customer.CustomerFormId,
                    CustomerName = customer.CustomerName,
                    CustomerBirthday = customer.CustomerBirthday,
                    CustomerFatherName = customer.CustomerFatherName,
                    CustomerMotherName = customer.CustomerMotherName,
                    CustomerDrivingLicenceType = customer.CustomerDrivingLicenceType,
                    CustomerJob = customer.CustomerJob,
                    CustomerIdentityNumber = customer.CustomerIdentityNumber,
                    CreateByUser = customer.AppUserForm.UserName,
                };
                customerFormListModels.Add(customerFormListModel);
             }

            dataGridView1.DataSource = customerFormListModels;
        }


        public void ClearTextBox()
        {
            tbx_CustomerName.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            tbx_CustomerIdentity.Text = "";
            tbx_CustomerFatherName.Text = "";
            tbx_CustomerMotherName.Text = "";
            tbx_CustomerJob.Text = "";
            tbx_CustomerDrivingLicence.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            RentACarEntities db = new RentACarEntities();

            CustomerForm customerForm = new CustomerForm
            {
                CustomerName = tbx_CustomerName.Text,
                CustomerBirthday = dateTimePicker1.Value,
                CustomerIdentityNumber = tbx_CustomerIdentity.Text,
                CustomerFatherName = tbx_CustomerFatherName.Text,
                CustomerMotherName = tbx_CustomerMotherName.Text,
                CustomerJob = tbx_CustomerJob.Text,
                CustomerDrivingLicenceType= tbx_CustomerDrivingLicence.Text,
                IsActive = true,
                AppUserFormId = LoginUser.AppUser.AppUserFormId
            };

            db.CustomerForm.Add(customerForm);
            db.SaveChanges();
            UpdateGrid();
            MessageBox.Show("New Customer is added.");

        }


        private void btn_Update_Click(object sender, EventArgs e)
        {         
            RentACarEntities db = new RentACarEntities();
            CustomerForm customerform = db.CustomerForm.Where(s => s.IsActive == true && s.CustomerFormId == customerformID).FirstOrDefault();
            if (customerform != null)
            {
                customerform.CustomerName = tbx_CustomerName.Text;
                customerform.CustomerBirthday = dateTimePicker1.Value;
                customerform.CustomerIdentityNumber = tbx_CustomerIdentity.Text;
                customerform.CustomerFatherName = tbx_CustomerFatherName.Text;
                customerform.CustomerMotherName=tbx_CustomerMotherName.Text;
                customerform.CustomerJob= tbx_CustomerJob.Text;
                customerform.CustomerDrivingLicenceType= tbx_CustomerDrivingLicence.Text;
                db.SaveChanges();
                ClearTextBox();
                MessageBox.Show("Customer informations are updated.");
                UpdateGrid();
            }
            else
            {
                MessageBox.Show("Customer is NOT found!");
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            customerformID = (int)dataGridView1.Rows[e.RowIndex].Cells["CustomerFormId"].Value;
            RentACarEntities db = new RentACarEntities();
            CustomerForm customerform = db.CustomerForm.Where(s => s.IsActive == true && s.CustomerFormId == customerformID).FirstOrDefault();
            tbx_CustomerName.Text = customerform.CustomerName;
            dateTimePicker1.Value = (DateTime)customerform.CustomerBirthday;
            tbx_CustomerIdentity.Text = customerform.CustomerIdentityNumber;
            tbx_CustomerFatherName.Text = customerform.CustomerFatherName;
            tbx_CustomerMotherName.Text = customerform.CustomerMotherName;
            tbx_CustomerJob.Text = customerform.CustomerJob;
            tbx_CustomerDrivingLicence.Text = customerform.CustomerDrivingLicenceType;
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            dataGridView1.Columns["CustomerFormId"].Visible = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            RentACarEntities db = new RentACarEntities();
            var customerToDelete = db.CustomerForm.FirstOrDefault(s=>s.CustomerFormId== customerformID&& s.IsActive == true);
            {
                if (customerToDelete != null)
                {
                    customerToDelete.IsActive = false;
                    db.SaveChanges();
                    UpdateGrid();
                    MessageBox.Show("The customer is deleted.");
                }

                else
                {
                    MessageBox.Show("The customer is NOT found!");
                }
            }
        }
    }
    
}
