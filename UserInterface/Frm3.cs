using Business.Concreate;
using DataAccess;
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
    public partial class Frm3 : Form
    {
        CostomerManager costomerManager;
        List<Costomer> costomers;
        int id;
        public Frm3()
        {
            InitializeComponent();
            costomerManager = CostomerManager.GetInstance();
        }

        private void Frm3_Load(object sender, EventArgs e)
        {
            DataDisplay();
        }
        void DataDisplay()
        {
            costomers = costomerManager.GetList();
            dataBinder.DataSource = costomers.ToDataTable();
            DtgList.DataSource = dataBinder;

            DtgList.Columns["Id"].HeaderText = "CustCode";
            DtgList.Columns["Name"].HeaderText = "CustName";
            DtgList.Columns["Phone"].HeaderText = "CustPhone";
            DtgList.Columns["Adress"].HeaderText = "CustAdd";
        }

        void Temizle()
        {
            id = 0;
            TxtName.Clear();
            TxtPhone.Clear();
            TxtAdress.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bilgileri kaydetmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Costomer costomer = new Costomer(TxtName.Text, TxtPhone.Text, TxtAdress.Text);
                string control = costomerManager.Add(costomer);
                if (control != "OK")
                {
                    MessageBox.Show(control, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Bilgiler başarıyla kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataDisplay();
                Temizle();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Lütfen öncelikle tablodan bir kayıt seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Bilgileri güncellemek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Costomer costomer = new Costomer(id, TxtName.Text, TxtPhone.Text, TxtAdress.Text);
                string control = costomerManager.Update(costomer);
                if (control != "OK")
                {
                    MessageBox.Show(control, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Bilgiler başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataDisplay();
                Temizle();
            }

        }

        private void DtgList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DtgList.CurrentRow == null)
            {
                MessageBox.Show("Öncelikle bir kayıt seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = DtgList.CurrentRow.Cells["Id"].Value.ConInt();
            TxtName.Text= DtgList.CurrentRow.Cells["Name"].Value.ToString();
            TxtPhone.Text = DtgList.CurrentRow.Cells["Phone"].Value.ToString();
            TxtAdress.Text = DtgList.CurrentRow.Cells["Adress"].Value.ToString();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Lütfen öncelikle tablodan bir kayıt seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Bilgileri silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string control = costomerManager.Delete(id);
                if (control != "OK")
                {
                    MessageBox.Show(control, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Bilgiler başarıyla silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataDisplay();
                Temizle();
            }
        }
    }
}
