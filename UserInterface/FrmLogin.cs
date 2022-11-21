using Business.Concreate;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmLogin : Form
    {
        LoginManager loginManager;
        public FrmLogin()
        {
            InitializeComponent();
            loginManager = LoginManager.GetInstance();               
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text.Trim() == "" || TxtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adınızı ve Şifreyi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Login login = loginManager.Get(TxtUserName.Text.Trim(), TxtPassword.Text.Trim());
            if (login==null)
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre girdiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FrmHomePage frmHomePage = new FrmHomePage();
            frmHomePage.Show();
            this.Hide();
        }

        private void LinkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCreateAccount frmCreateAccount = new FrmCreateAccount();
            frmCreateAccount.Show();
            this.Hide();
        }

        private void BtnSee_Click(object sender, EventArgs e)
        {
            if (TxtPassword.UseSystemPasswordChar == true)
            {
                TxtPassword.UseSystemPasswordChar = false;
                return;
            }
            if (TxtPassword.UseSystemPasswordChar == false)
            {
                TxtPassword.UseSystemPasswordChar = true;
                return;
            }
        }
    }
}
