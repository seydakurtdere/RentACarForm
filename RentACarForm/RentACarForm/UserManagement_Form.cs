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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RentACarForm
{
    public partial class UserManagement_Form : Form
    {
        int appuserformId = 0;
        public UserManagement_Form()
        {
            InitializeComponent();
        }

        public void UpdateGrid()
        {
            RentACarEntities db= new RentACarEntities();
            List<AppUserForm> appuserform= db.AppUserForm.Where(s => s.IsActive == true).ToList();
            List<AppUserFormListModel> appuserformmodel = new List<AppUserFormListModel>();
            foreach(var user in appuserform)
            {
                AppUserFormListModel appUserFormListModel = new AppUserFormListModel()
                {  
                    AppUserFormId=user.AppUserFormId,
                    UserName = user.UserName,
                    UserPassword = user.UserPassword,
                    CreateDate= user.CreateDate,
                };
                appuserformmodel.Add(appUserFormListModel);
            }

           dataGridView1.DataSource = appuserformmodel;
        }

        private void ClearTextbox()
        {
            tbx_UserName.Text = "";
            tbx_UserPassword.Text = "";
            dateTimePicker1.Value= DateTime.Now;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            RentACarEntities db = new RentACarEntities();
            AppUserForm appUserForm = new AppUserForm
            {
                UserName= tbx_UserName.Text,
                UserPassword= tbx_UserPassword.Text,
                CreateDate= dateTimePicker1.Value, 
                IsActive= true,
            };
            db.AppUserForm.Add(appUserForm);
            db.SaveChanges();           
            MessageBox.Show("New user is added.");
            UpdateGrid();
        }

        private void UserManagement_Form_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            dataGridView1.Columns["AppUserFormId"].Visible = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            RentACarEntities db = new RentACarEntities();
            AppUserForm appuserform = db.AppUserForm.Where(s => s.IsActive == true && s.AppUserFormId == appuserformId).FirstOrDefault();
            if (appuserform != null)
            {
                 tbx_UserName.Text= appuserform.UserName;
                appuserform.UserPassword= tbx_UserPassword.Text;
                appuserform.CreateDate= dateTimePicker1.Value;
                db.SaveChanges();
                ClearTextbox();
                UpdateGrid();
                MessageBox.Show("User informations are updated.");

            }
            else
            {
                MessageBox.Show("The user is NOT found!");
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            appuserformId = (int)dataGridView1.Rows[e.RowIndex].Cells["AppUserFormId"].Value;
            RentACarEntities db = new RentACarEntities();
            AppUserForm appuserform= db.AppUserForm.Where(s => s.IsActive == true && s.AppUserFormId == appuserformId).FirstOrDefault();
            tbx_UserName.Text = appuserform.UserName;
            tbx_UserPassword.Text= appuserform.UserPassword;
            dateTimePicker1.Value = appuserform.CreateDate.Value;


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            RentACarEntities db= new RentACarEntities();
            var userToDelete = db.AppUserForm.FirstOrDefault(s => s.AppUserFormId == appuserformId && s.IsActive == true);

            if (userToDelete != null)
            {
                userToDelete.IsActive = false;
                db.SaveChanges();
                UpdateGrid();

                MessageBox.Show("The user is deleted.");
            }
            else
            {
                MessageBox.Show("The user is NOT found!");
            }
        }
    }
}
