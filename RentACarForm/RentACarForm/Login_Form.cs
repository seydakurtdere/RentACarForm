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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(tbx_userName.Text);//ekranda tamam çıkartır
 

            RentACarEntities db = new RentACarEntities();

            AppUserForm appUserForm =db.AppUserForm.Where(s=>s.UserName== tbx_userName.Text&&s.UserPassword==tbx_password.Text&&s.IsActive==true).FirstOrDefault();

            if (appUserForm != null)
            {
                LoginUser.SetAppUser(appUserForm);
                MessageBox.Show("Success!");
                Main_Form mainForm = new Main_Form(); ///instance
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password is wrong!");
            }

        }

        private void tbx_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
