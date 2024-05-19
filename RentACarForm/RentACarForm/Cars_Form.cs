using System;
using RentACarForm.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using RentACarForm.Model;

namespace RentACarForm
{
    public partial class Cars_Form : Form
    {
        int carsformID = 0;
        public Cars_Form()
        {
            InitializeComponent();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            RentACarEntities db = new RentACarEntities();

            CarsForm carsForm = new CarsForm
            {
                CarBrand = tbx_carBrand.Text,
                CarModel = tbx_carModel.Text,
                CarYear = int.Parse(tbx_carYear.Text),
                CarKm = int.Parse(tbx_carKm.Text),
                CarDamagedParts = tbx_carDamage.Text,
                IsActive = true,
                AppUserFormId = LoginUser.AppUser.AppUserFormId
            };

            db.CarsForm.Add(carsForm);
            db.SaveChanges();
            MessageBox.Show("New car is added.");
            UpdateGrid();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RentACarEntities db = new RentACarEntities();
            
                var carToDelete = db.CarsForm.FirstOrDefault(s => s.CarsFormId==carsformID && s.IsActive==true);

                if (carToDelete != null)
                {
                    carToDelete.IsActive = false;
                    db.SaveChanges();
                    UpdateGrid();

                    MessageBox.Show("The car is deleted.");
                }
                else
                {
                    MessageBox.Show("The car is NOT found!");
                }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cars_Form_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            dataGridView1.Columns["CarsFormId"].Visible = false;


        }

        public void UpdateGrid()
        {

            RentACarEntities db = new RentACarEntities();
            List<CarsForm> carsformlist = db.CarsForm.Where(s => s.IsActive == true).ToList();
            List<CarsFormListModel> carsFormListModels = new List<CarsFormListModel>();
            foreach (var cars in carsformlist)
            {
                CarsFormListModel carsFormListModel = new CarsFormListModel()
                {
                    CarsFormId = cars.CarsFormId,
                    CarBrand = cars.CarBrand,
                    CarModel = cars.CarModel,
                    CarYear = cars.CarYear,
                    CarKm = cars.CarKm,
                    CarDamagedParts = cars.CarDamagedParts,
                    CreateByUser = cars.AppUserForm.UserName
                };
                carsFormListModels.Add(carsFormListModel);
            }
            dataGridView1.DataSource = carsFormListModels;
        }

        public void ClearTextBox()
        {
            tbx_carBrand.Text = "";
            tbx_carDamage.Text = "";
            tbx_carKm.Text = "";
            tbx_carModel.Text = "";
            tbx_carYear.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            carsformID = (int)dataGridView1.Rows[e.RowIndex].Cells["CarsFormId"].Value;
            RentACarEntities db = new RentACarEntities();
            CarsForm carsform = db.CarsForm.Where(s=>s.IsActive == true&&s.CarsFormId==carsformID).FirstOrDefault();
            tbx_carBrand.Text = carsform.CarBrand;
            tbx_carDamage.Text = carsform.CarDamagedParts;
            tbx_carKm.Text = carsform.CarKm.ToString();
            tbx_carModel.Text = carsform.CarModel;
            tbx_carYear.Text = carsform.CarYear.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {      
            RentACarEntities db = new RentACarEntities();
            CarsForm carsform = db.CarsForm.Where(s => s.IsActive == true && s.CarsFormId == carsformID).FirstOrDefault();
            if (carsform != null)
            {
                carsform.CarBrand= tbx_carBrand.Text;
                carsform.CarDamagedParts=tbx_carDamage.Text;
                carsform.CarKm= int.Parse(tbx_carKm.Text);
                carsform.CarModel = tbx_carModel.Text;
                carsform.CarYear= int.Parse(tbx_carYear.Text); ;
                db.SaveChanges();
                ClearTextBox();
                MessageBox.Show("Car informations are updated.");
                UpdateGrid();
            }
            else
            {
                MessageBox.Show("Car is NOT found!");
            }
        }
    }
}
