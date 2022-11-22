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
    public partial class Frm2 : Form
    {
        PartManager partManager;
        List<Part> parts;

        int id;
        public Frm2()
        {
            InitializeComponent();
            partManager = PartManager.GetInstance();
        }

        private void Frm2_Load(object sender, EventArgs e)
        {
            DataDisplay();
        }
        void DataDisplay()
        {
            parts = partManager.GetList();
            dataBinder.DataSource = parts.ToDataTable();
            DtgList.DataSource = dataBinder;

            DtgList.Columns["Id"].HeaderText = "SpCode";
            DtgList.Columns["Name"].HeaderText = "SpName";
            DtgList.Columns["Cost"].HeaderText = "SpCost";
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bilgileri kaydetmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Part part = new Part(TxtName.Text, TxtCost.Text.ConInt());
                string control = partManager.Add(part);
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
                Part part = new Part(id, TxtName.Text, TxtCost.Text.ConInt());
                string control = partManager.Update(part);
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
                string control = partManager.Delete(id);
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

        void Temizle()
        {
            TxtName.Clear(); TxtCost.Clear();
        }

        private void TxtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DtgList_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DtgList.CurrentRow == null)
            {
                MessageBox.Show("Öncelikle bir kayıt seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id = DtgList.CurrentRow.Cells["Id"].Value.ConInt();
            TxtName.Text = DtgList.CurrentRow.Cells["Name"].Value.ToString();
            TxtCost.Text = DtgList.CurrentRow.Cells["Cost"].Value.ToString();
        }

        private void DtgList_FilterStringChanged(object sender, EventArgs e)
        {
            dataBinder.Filter = DtgList.FilterString;
        }

        private void DtgList_SortStringChanged(object sender, EventArgs e)
        {
            dataBinder.Sort = DtgList.SortString;
        }
    }
}
