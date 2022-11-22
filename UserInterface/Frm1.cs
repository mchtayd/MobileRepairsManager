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
    public partial class Frm1 : Form
    {
        RepairManager repairManager;
        CostomerManager costomerManager;
        PartManager partManager;

        List<Repair> repairs;

        bool start = false;
        int id, total;

        public Frm1()
        {
            InitializeComponent();
            repairManager = RepairManager.GetInstance();
            costomerManager = CostomerManager.GetInstance();
            partManager = PartManager.GetInstance();
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            DataDisplay();
            CostomerFill();
            PartFill();
            start = true;
        }
        void DataDisplay()
        {
            repairs = repairManager.GetList();
            dataBinder.DataSource = repairs.ToDataTable();
            DtgList.DataSource = dataBinder;

            DtgList.Columns["Id"].HeaderText = "RepCode";
            DtgList.Columns["Date"].HeaderText = "RepDate";
            DtgList.Columns["Costomer"].HeaderText = "Customer";
            DtgList.Columns["PhoneNumber"].HeaderText = "PhoneNamber";
            DtgList.Columns["DeviceName"].HeaderText = "DeviceName";
            DtgList.Columns["DeviceModel"].HeaderText = "DeviceModel";
            DtgList.Columns["Problem"].HeaderText = "Problem";
            DtgList.Columns["Spare"].HeaderText = "Spare";
            DtgList.Columns["TotalCost"].HeaderText = "TotalCost";
        }
        void CostomerFill()
        {
            CmbCostomer.DataSource = costomerManager.GetList();
            CmbCostomer.ValueMember = "Id";
            CmbCostomer.DisplayMember = "Name";
            CmbCostomer.SelectedValue = -1;
        }
        void PartFill()
        {
            CmbSpare.DataSource = partManager.GetList();
            CmbSpare.ValueMember = "Id";
            CmbSpare.DisplayMember = "Name";
            CmbSpare.SelectedValue = -1;
        }

        private void CmbSpare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (start == false)
            {
                return;
            }

            id = CmbSpare.SelectedIndex;
            Part part = partManager.Get(id);
            if (part != null)
            {
                TxtSpareCost.Text = part.Cost.ToString();
            }
        }

        private void TxtSpareCost_TextChanged(object sender, EventArgs e)
        {
            Calculate(TxtSpareCost.Text.ConInt(), TxtRepairCost.Text.ConInt());
        }

        private void TxtRepairCost_TextChanged(object sender, EventArgs e)
        {
            Calculate(TxtSpareCost.Text.ConInt(), TxtRepairCost.Text.ConInt());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bilgileri kaydetmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Repair repair = new Repair(DtRepairDate.Value, CmbCostomer.Text, TxtNuber.Text, TxtDeviceName.Text, TxtDeviceModel.Text, TxtProblem.Text, CmbSpare.Text, total);
                string control = repairManager.Add(repair);
                if (control != "OK")
                {
                    MessageBox.Show(control, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Bilgiler başarıyla kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataDisplay();
                Clear();
            }
        }
        void Clear()
        {
            CmbCostomer.SelectedIndex = -1;
            TxtNuber.Clear(); TxtDeviceName.Clear(); TxtDeviceModel.Clear(); TxtProblem.Clear(); CmbSpare.SelectedIndex = -1; TxtSpareCost.Clear();
            TxtRepairCost.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (id==0)
            {
                MessageBox.Show("Lütfen öncelikle silinecek olan kaydı seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = MessageBox.Show(id + " RepCode nolu kaydı silmek istediğinize emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string control = repairManager.Delete(id);
                if (control != "OK")
                {
                    MessageBox.Show(control, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Bilgiler başarıyla silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataDisplay();
                Clear();
                id = 0;
            }
        }

        private void DtgList_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DtgList.CurrentRow == null)
            {
                MessageBox.Show("Öncelikle bir kayıt seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            id = DtgList.CurrentRow.Cells["Id"].Value.ConInt();

            //DtRepairDate.Value = DtgList.CurrentRow.Cells["Date"].Value.ConDate();
            //CmbCostomer.Text = DtgList.CurrentRow.Cells["Costomer"].Value.ToString();
            //TxtNuber.Text = DtgList.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            //TxtDeviceName.Text = DtgList.CurrentRow.Cells["DeviceName"].Value.ToString();
            //TxtDeviceModel.Text = DtgList.CurrentRow.Cells["DeviceModel"].Value.ToString();
            //TxtProblem.Text = DtgList.CurrentRow.Cells["Problem"].Value.ToString();
            //TxtProblem.Text = DtgList.CurrentRow.Cells["Problem"].Value.ToString();
        }

        private void DtgList_FilterStringChanged(object sender, EventArgs e)
        {
            dataBinder.Filter = DtgList.FilterString;
        }

        private void DtgList_SortStringChanged(object sender, EventArgs e)
        {
            dataBinder.Sort = DtgList.SortString;
        }

        void Calculate(int spare, int repair)
        {
            total = spare + repair;
        }
    }
}
