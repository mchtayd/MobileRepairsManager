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

        }
        private void PictureEx_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        private void PictureHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void OpenTabPage(string pageName, string pageText, Control winForm)
        {
            tabPanel.Controls.Clear();
            Panel panel = new Panel();
            //tabPage.SetBounds(tabPage.Bounds.X, tabPage.Bounds.Y, 500, tabPage.Bounds.Height);
            panel. = false;
            panel.
            tabPage.Name = pageName;
            //tabPage.Width = 500;
            tabPage.Controls.Add(winForm);
            tabAnasayfa.SelectedTab = tabAnasayfa.TabPages[pageName];
        }
    }
}
