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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FrmHomePage frmHomePage = new FrmHomePage();
            frmHomePage.Show();
            this.Hide();

            /*if (TxtUserName.Text.Trim() == "" || TxtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adınızı ve Şifreyi giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

        }
    }
}
