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
    public partial class FrmHomePage : Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }
        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            Frm1 frm1 = new Frm1();
            OpenPage(frm1);
        }
        private void PictureEx_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void PictureHome_Click(object sender, EventArgs e)
        {
            Frm1 frm1 = new Frm1();
            OpenPage(frm1);
        }

        private void Frm2Page_Click(object sender, EventArgs e)
        {
            Frm2 frm2 = new Frm2();
            OpenPage(frm2);
        }
        private void Frm3Page_Click(object sender, EventArgs e)
        {
            Frm3 frm3 = new Frm3();
            OpenPage(frm3);
        }

        void OpenPage(Form form)
        {
            tabPanel.Controls.Clear();
            form.TopLevel = false;
            tabPanel.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
            form.BringToFront();
        }

        
    }
}
