using RentACarForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarForm
{    
    public partial class InsuranceCompany_Form : Form
    {
        int insurancecompanyformId = 0;
        public InsuranceCompany_Form()
        {
            InitializeComponent();
        }

        public void UpdateGrid()
        {
            RentACarEntities db =new RentACarEntities();
            List<InsuranceCompanyForm> insuranceCompanyForms = db.InsuranceCompanyForm.Where(s => s.IsActive == true).ToList();
            List<InsuranceCompanyFormListModel> insuranceCompanyFormListModels = new List<InsuranceCompanyFormListModel>();
            foreach(var  ins in insuranceCompanyForms)
            {
                InsuranceCompanyFormListModel insuranceCompanyFormListModel = new InsuranceCompanyFormListModel()
                {
                    InsuranceCompanyFormId = ins.InsuranceCompanyFormId,
                    CompanyName = ins.CompanyName,
                    OverDayWage = ins.OverDayWage,
                    
                };
                insuranceCompanyFormListModels.Add(insuranceCompanyFormListModel);
            };
            dataGridView1.DataSource = insuranceCompanyFormListModels;
        }

        public void ClearTextBox()
        {
            tbx_CompanyName.Text = "";
            tbx_OverdayWage.Text = "";
        }
        private void InsuranceCompany_Form_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            dataGridView1.Columns["InsuranceCompanyFormId"].Visible = false;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            RentACarEntities db= new RentACarEntities();
            InsuranceCompanyForm insuranceCompanyForm = new InsuranceCompanyForm
            {
                CompanyName= tbx_CompanyName.Text,
                OverDayWage = decimal.Parse(tbx_OverdayWage.Text),
                IsActive = true,

             };
            db.InsuranceCompanyForm.Add(insuranceCompanyForm);
            db.SaveChanges();
            MessageBox.Show("New insurance company is added.");
            UpdateGrid();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            insurancecompanyformId = (int)dataGridView1.Rows[e.RowIndex].Cells["InsuranceCompanyFormId"].Value;
            RentACarEntities db = new RentACarEntities();
            InsuranceCompanyForm insuranceCompanyForm=db.InsuranceCompanyForm.Where(s => s.IsActive == true && s.InsuranceCompanyFormId == insurancecompanyformId).FirstOrDefault();
            tbx_CompanyName.Text = insuranceCompanyForm.CompanyName;
            tbx_OverdayWage.Text = insuranceCompanyForm.OverDayWage.ToString();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            RentACarEntities db= new RentACarEntities();
            InsuranceCompanyForm insuranceCompanyForm=db.InsuranceCompanyForm.Where(s=>s.IsActive==true&& s.InsuranceCompanyFormId==insurancecompanyformId).FirstOrDefault();
            if(insuranceCompanyForm != null)
            {
                insuranceCompanyForm.CompanyName=tbx_CompanyName.Text;
                insuranceCompanyForm.OverDayWage = decimal.Parse(tbx_OverdayWage.Text);
                db.SaveChanges();
                UpdateGrid();
                ClearTextBox();
                MessageBox.Show("Insurance Company informations are updated.");
                
            }
            else
            {
                MessageBox.Show("Insurance Company is NOT found!");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            RentACarEntities db=new RentACarEntities();
            var InsToDelete= db.InsuranceCompanyForm.FirstOrDefault(s=>s.IsActive==true && s.InsuranceCompanyFormId==insurancecompanyformId);
            {
                if(InsToDelete!= null)
                {
                    InsToDelete.IsActive=false;
                    db.SaveChanges();
                    UpdateGrid();
                    MessageBox.Show("Insurance company is deleted.");

                }
                else
                {
                    MessageBox.Show("Insurance company is NOT found!");
                }
            }
        }
    }
}
