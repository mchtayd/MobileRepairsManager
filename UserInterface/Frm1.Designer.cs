
namespace UserInterface
{
    partial class Frm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtRepairCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSpareCost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbSpare = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtProblem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDeviceModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDeviceName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNuber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbCostomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtRepairDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataBinder = new System.Windows.Forms.BindingSource(this.components);
            this.DtgList = new ADGV.AdvancedDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgList)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Orange;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(157, 605);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(120, 39);
            this.BtnDelete.TabIndex = 47;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSave.Location = new System.Drawing.Point(12, 605);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 39);
            this.BtnSave.TabIndex = 46;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtRepairCost
            // 
            this.TxtRepairCost.Location = new System.Drawing.Point(157, 567);
            this.TxtRepairCost.Name = "TxtRepairCost";
            this.TxtRepairCost.Size = new System.Drawing.Size(102, 20);
            this.TxtRepairCost.TabIndex = 45;
            this.TxtRepairCost.TextChanged += new System.EventHandler(this.TxtRepairCost_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(154, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "Repair Cost";
            // 
            // TxtSpareCost
            // 
            this.TxtSpareCost.Enabled = false;
            this.TxtSpareCost.Location = new System.Drawing.Point(14, 567);
            this.TxtSpareCost.Name = "TxtSpareCost";
            this.TxtSpareCost.Size = new System.Drawing.Size(102, 20);
            this.TxtSpareCost.TabIndex = 43;
            this.TxtSpareCost.TextChanged += new System.EventHandler(this.TxtSpareCost_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(11, 548);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "Spare Cost";
            // 
            // CmbSpare
            // 
            this.CmbSpare.FormattingEnabled = true;
            this.CmbSpare.Location = new System.Drawing.Point(54, 460);
            this.CmbSpare.Name = "CmbSpare";
            this.CmbSpare.Size = new System.Drawing.Size(205, 21);
            this.CmbSpare.TabIndex = 41;
            this.CmbSpare.SelectedIndexChanged += new System.EventHandler(this.CmbSpare_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(51, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Spare";
            // 
            // TxtProblem
            // 
            this.TxtProblem.Location = new System.Drawing.Point(54, 393);
            this.TxtProblem.Name = "TxtProblem";
            this.TxtProblem.Size = new System.Drawing.Size(205, 20);
            this.TxtProblem.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(51, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Problem";
            // 
            // TxtDeviceModel
            // 
            this.TxtDeviceModel.Location = new System.Drawing.Point(54, 320);
            this.TxtDeviceModel.Name = "TxtDeviceModel";
            this.TxtDeviceModel.Size = new System.Drawing.Size(205, 20);
            this.TxtDeviceModel.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(51, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Device Model";
            // 
            // TxtDeviceName
            // 
            this.TxtDeviceName.Location = new System.Drawing.Point(54, 245);
            this.TxtDeviceName.Name = "TxtDeviceName";
            this.TxtDeviceName.Size = new System.Drawing.Size(205, 20);
            this.TxtDeviceName.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(51, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Device Name";
            // 
            // TxtNuber
            // 
            this.TxtNuber.Location = new System.Drawing.Point(54, 182);
            this.TxtNuber.Name = "TxtNuber";
            this.TxtNuber.Size = new System.Drawing.Size(205, 20);
            this.TxtNuber.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(51, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Phone Number";
            // 
            // CmbCostomer
            // 
            this.CmbCostomer.FormattingEnabled = true;
            this.CmbCostomer.Location = new System.Drawing.Point(54, 116);
            this.CmbCostomer.Name = "CmbCostomer";
            this.CmbCostomer.Size = new System.Drawing.Size(205, 21);
            this.CmbCostomer.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(51, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Repair Date";
            // 
            // DtRepairDate
            // 
            this.DtRepairDate.CalendarMonthBackground = System.Drawing.Color.Orange;
            this.DtRepairDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtRepairDate.Location = new System.Drawing.Point(54, 48);
            this.DtRepairDate.Name = "DtRepairDate";
            this.DtRepairDate.Size = new System.Drawing.Size(205, 20);
            this.DtRepairDate.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(324, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 724);
            this.panel2.TabIndex = 27;
            // 
            // DtgList
            // 
            this.DtgList.AllowUserToAddRows = false;
            this.DtgList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DtgList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgList.AutoGenerateContextFilters = true;
            this.DtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgList.DateWithTime = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DtgList.Location = new System.Drawing.Point(340, 12);
            this.DtgList.Name = "DtgList";
            this.DtgList.ReadOnly = true;
            this.DtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgList.Size = new System.Drawing.Size(905, 724);
            this.DtgList.TabIndex = 56;
            this.DtgList.TimeFilter = false;
            this.DtgList.SortStringChanged += new System.EventHandler(this.DtgList_SortStringChanged);
            this.DtgList.FilterStringChanged += new System.EventHandler(this.DtgList_FilterStringChanged);
            this.DtgList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgList_CellMouseClick_1);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 737);
            this.Controls.Add(this.DtgList);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtRepairCost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtSpareCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CmbSpare);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtProblem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtDeviceModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDeviceName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNuber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbCostomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtRepairDate);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm1";
            this.Text = "Frm1";
            this.Load += new System.EventHandler(this.Frm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtRepairCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSpareCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbSpare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtProblem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDeviceModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDeviceName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNuber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbCostomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtRepairDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource dataBinder;
        private ADGV.AdvancedDataGridView DtgList;
    }
}