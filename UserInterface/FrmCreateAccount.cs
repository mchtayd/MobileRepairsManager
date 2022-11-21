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
    public partial class FrmCreateAccount : Form
    {
        LoginManager loginManager;

        List<Login> logins;
        public FrmCreateAccount()
        {
            InitializeComponent();
            loginManager = LoginManager.GetInstance();
        }

        private void FrmCreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void BtnSee1_Click(object sender, EventArgs e)
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

        private void BtnSee2_Click(object sender, EventArgs e)
        {
            if (TxtPasswordRep.UseSystemPasswordChar == true)
            {
                TxtPasswordRep.UseSystemPasswordChar = false;
                return;
            }
            if (TxtPasswordRep.UseSystemPasswordChar == false)
            {
                TxtPasswordRep.UseSystemPasswordChar = true;
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string Control()
        {
            if (TxtUserName.Text=="")
            {
                return "Lütfen öncelikle USER NAME kısmını doldurunuz!";
            }
            if (TxtPassword.Text == "")
            {
                return "Lütfen öncelikle PASSWORD kısmını doldurunuz!";
            }
            if (TxtPasswordRep.Text == "")
            {
                return "Lütfen öncelikle PASSWORD REPETİTİON kısmını doldurunuz!";
            }
            if (TxtPassword.Text != TxtPasswordRep.Text)
            {
                return "Girilen şifre ve şifre tekrarı uyuşmamaktadır!";
            }
            return "OK";
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string mesaj = Control();
            if (mesaj != "OK")
            {
                MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Bilgileri kaydetmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                List<Login> logins = new List<Login>();
                logins = loginManager.GetList(TxtPassword.Text);
                if (logins.Count() != 0)
                {
                    MessageBox.Show("Bu kullanıcı adı ile daha önce hesap oluşturulmuş!\nLütfen yeni bir kullanıcı adı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUserName.Clear(); TxtPassword.Clear(); TxtPasswordRep.Clear();
                    return;
                }
                Login login = new Login(TxtUserName.Text, TxtPassword.Text);
                mesaj = loginManager.Add(login);
                if (mesaj!="OK")
                {
                    MessageBox.Show(mesaj, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Bilgiler başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Close();
            }
        }
    }
}
