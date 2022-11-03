
namespace UserInterface
{
    partial class FrmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureEx = new System.Windows.Forms.PictureBox();
            this.PictureSettings = new System.Windows.Forms.PictureBox();
            this.PictureCustomer = new System.Windows.Forms.PictureBox();
            this.PictureHome = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.PictureEx);
            this.panel1.Controls.Add(this.PictureSettings);
            this.panel1.Controls.Add(this.PictureCustomer);
            this.panel1.Controls.Add(this.PictureHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 828);
            this.panel1.TabIndex = 2;
            // 
            // PictureEx
            // 
            this.PictureEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureEx.Image = ((System.Drawing.Image)(resources.GetObject("PictureEx.Image")));
            this.PictureEx.Location = new System.Drawing.Point(7, 757);
            this.PictureEx.Name = "PictureEx";
            this.PictureEx.Size = new System.Drawing.Size(59, 59);
            this.PictureEx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureEx.TabIndex = 4;
            this.PictureEx.TabStop = false;
            this.PictureEx.Click += new System.EventHandler(this.PictureEx_Click);
            // 
            // PictureSettings
            // 
            this.PictureSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureSettings.Image = ((System.Drawing.Image)(resources.GetObject("PictureSettings.Image")));
            this.PictureSettings.Location = new System.Drawing.Point(11, 321);
            this.PictureSettings.Name = "PictureSettings";
            this.PictureSettings.Size = new System.Drawing.Size(55, 59);
            this.PictureSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureSettings.TabIndex = 5;
            this.PictureSettings.TabStop = false;
            // 
            // PictureCustomer
            // 
            this.PictureCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureCustomer.Image = ((System.Drawing.Image)(resources.GetObject("PictureCustomer.Image")));
            this.PictureCustomer.Location = new System.Drawing.Point(12, 209);
            this.PictureCustomer.Name = "PictureCustomer";
            this.PictureCustomer.Size = new System.Drawing.Size(52, 59);
            this.PictureCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureCustomer.TabIndex = 4;
            this.PictureCustomer.TabStop = false;
            // 
            // PictureHome
            // 
            this.PictureHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureHome.Image = ((System.Drawing.Image)(resources.GetObject("PictureHome.Image")));
            this.PictureHome.Location = new System.Drawing.Point(9, 442);
            this.PictureHome.Name = "PictureHome";
            this.PictureHome.Size = new System.Drawing.Size(59, 59);
            this.PictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureHome.TabIndex = 3;
            this.PictureHome.TabStop = false;
            this.PictureHome.Click += new System.EventHandler(this.PictureHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(80, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1244, 10);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mobile Repair Management System";
            // 
            // tabPanel
            // 
            this.tabPanel.Location = new System.Drawing.Point(80, 54);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(1251, 762);
            this.tabPanel.TabIndex = 6;
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 828);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHomePage";
            this.Load += new System.EventHandler(this.FrmHomePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureHome;
        private System.Windows.Forms.PictureBox PictureCustomer;
        private System.Windows.Forms.PictureBox PictureSettings;
        private System.Windows.Forms.PictureBox PictureEx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel tabPanel;
    }
}