using RentACarForm.Infrastructure;
using RentACarForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarForm
{
    public partial class Rental_Form : Form
    {
        int rentalformID = 0;
        public Rental_Form()
        {
            InitializeComponent();
        }

        private void Rental_Form_Load(object sender, EventArgs e)
        {
            RentACarEntities db = new RentACarEntities();

            #region Cars Form Combobox
            List<CarsForm> carsFormList = db.CarsForm.Where(s => s.IsActive == true).ToList();
            List<GenericComboboxModel> carsFormcmbModelList = new List<GenericComboboxModel>();
            foreach (var car in carsFormList)
            {
                GenericComboboxModel genericComboboxModel = new GenericComboboxModel()
                {
                    Id = car.CarsFormId,
                    Name = car.CarBrand + "    -    " + car.CarModel + "    -    " + car.CarYear
                };
                carsFormcmbModelList.Add(genericComboboxModel);
            }

            cmb_Car.DataSource = carsFormcmbModelList;
            cmb_Car.ValueMember = "Id";
            cmb_Car.DisplayMember = "Name";
            #endregion

            List<CustomerForm> customerFormList = db.CustomerForm.Where(s => s.IsActive == true).ToList();
            List<GenericComboboxModel> customerFormcmbModelList = new List<GenericComboboxModel>();
            foreach (var customer in customerFormList)
            {
                GenericComboboxModel genericComboboxModel = new GenericComboboxModel()
                {
                    Id = customer.CustomerFormId,
                    Name = customer.CustomerName + "    -    " + customer.CustomerIdentityNumber + "    -    " + customer.CustomerDrivingLicenceType
                };
                customerFormcmbModelList.Add(genericComboboxModel);
            }

            cmb_Customer.DataSource = customerFormcmbModelList;
            cmb_Customer.ValueMember = "Id";
            cmb_Customer.DisplayMember = "Name";

            List<InsuranceCompanyForm> insurancecompanyFormList = db.InsuranceCompanyForm.Where(s => s.IsActive == true).ToList();
            List<GenericComboboxModel> insurancecompanyFormcmbModelList = new List<GenericComboboxModel>();
            foreach (var ins in insurancecompanyFormList)
            {
                GenericComboboxModel genericComboboxModel = new GenericComboboxModel()
                {
                    Id = ins.InsuranceCompanyFormId,
                    Name = ins.CompanyName + "    -    " + ins.OverDayWage
                };
                insurancecompanyFormcmbModelList.Add(genericComboboxModel);
            }

            cmb_Ins.DataSource = insurancecompanyFormcmbModelList;
            cmb_Ins.ValueMember = "Id";
            cmb_Ins.DisplayMember = "Name";

            UpdateGrid();
            dataGridView1.Columns["rentalformID"].Visible = false;
        }

        public void UpdateGrid()
        {

            RentACarEntities db = new RentACarEntities();
            List<RentalForm> rentalformlist = db.RentalForm.Where(s => s.IsActive == true).ToList();
            List<RentalFormListModel> rentalformlistModels = new List<RentalFormListModel>();
            foreach (var rent in rentalformlist)
            {
                RentalFormListModel rentalFormListModel = new RentalFormListModel()
                {
                    rentalformID = rent.RentalFormId,
                    CustomerName = rent.CustomerForm.CustomerName,
                    CarBrand = rent.CarsForm.CarBrand,
                    CarModel = rent.CarsForm.CarModel,
                    CarYear = rent.CarsForm.CarYear,
                    CompanyName = rent.InsuranceCompanyForm.CompanyName,
                    OverDayWage = rent.InsuranceWage,
                    DailyWage = rent.DailyWage,
                    StartDate = rent.StartDate,
                    EndDate = rent.EndDate,
                    Date = (int)(rent.EndDate - rent.StartDate)?.TotalDays,

                };
                rentalformlistModels.Add(rentalFormListModel);
            }

            dataGridView1.DataSource = rentalformlistModels;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal overDayWage = decimal.Parse(cmb_Ins.Text.Split(' ').Last());
            decimal DailyWage = decimal.Parse(tbx_DailyWage.Text);
            DateTime StartDate = dtp_StartDate.Value.Date;
            DateTime EndDate = dtp_EndDate.Value.Date;
            TimeSpan timeSpan = EndDate - StartDate;
            int Date = (int)timeSpan.TotalDays;
            decimal VAT = (overDayWage * 0.2m) * Date + (DailyWage * 0.2m) * Date;
            decimal TotalFee = ((overDayWage + DailyWage) * Date) + VAT;

            lbl_Fee.Text = $"Rental Fee for One day: {overDayWage:C}";
            lbl_SelectedDay.Text = $"Selected day for Rent Car: {Date} Day";
            lbl_TotalFee.Text = $"Total Rental Fee: {TotalFee:C}";
            lbl_VAT.Text = $"VAT: {VAT:C}";

            UpdateGrid();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rentalformID = (int)dataGridView1.Rows[e.RowIndex].Cells["RentalFormId"].Value;
            RentACarEntities db = new RentACarEntities();
            RentalForm rentalform = db.RentalForm.Where(s => s.IsActive == true && s.RentalFormId == rentalformID).FirstOrDefault();
            dtp_StartDate.Value = rentalform.StartDate.Value;
            dtp_EndDate.Value = rentalform.EndDate.Value;
            tbx_DailyWage.Text = rentalform.DailyWage.ToString();
            cmb_Car.SelectedValue = rentalform.CarsFormId;
            cmb_Customer.SelectedValue = rentalform.CustomerFormId;
            cmb_Ins.SelectedValue = rentalform.InsuranceCompanyFormId;

            UpdateGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RentACarEntities db = new RentACarEntities();


            RentalForm rentalForm = new RentalForm
            {
                StartDate = dtp_StartDate.Value,
                EndDate = dtp_EndDate.Value,
                DailyWage = decimal.Parse(tbx_DailyWage.Text),
                IsActive = true,
                InsuranceWage = decimal.Parse(cmb_Ins.Text.Split(' ').Last()),
                CarsFormId = (int)cmb_Car.SelectedValue,
                AppUserFormId = LoginUser.AppUser.AppUserFormId,
                CustomerFormId = (int)cmb_Customer.SelectedValue,
                InsuranceCompanyFormId = (int)cmb_Ins.SelectedValue,
                CreateDate = DateTime.Now,
            };

            db.RentalForm.Add(rentalForm);
            db.SaveChanges();
            UpdateGrid();
            MessageBox.Show("Rental informations are showed.");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}