﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login2
{
    public partial class Form2 : Form
    {
        static Panel lastMenupanel = new Panel();
        List<Label> ibanList = new List<Label>();
        public Form2()
        {
            InitializeComponent();
            panelMainDashboard.BackColor = Color.FromArgb(100, 100, 40);
            panelMainPaySomething.BackColor = Color.FromArgb(100, 100, 40);
            panelMainSendMail.BackColor = Color.FromArgb(100, 100, 40);
            panelMainSettings.BackColor = Color.FromArgb(100, 100, 40);
            panelMainTransfer.BackColor = Color.FromArgb(100, 100, 40);
            
            panelMainDashboard.Visible = true;
            panelMainPaySomething.Visible = false;
            panelMainSendMail.Visible = false;
            panelMainTransfer.Visible = false;
            panelMainSettings.Visible = false;

            lastMenupanel = panelMainDashboard;
            ibanList.Clear();
            int i = 0;
            List<string> list = DataManagement.getDashboardInfo();
            foreach (string iban in list)
            {
                var context = new MitBankDBEntities2();
     
                Label lb = UIDashboardAccountFrame.createFrame(iban, i);
                i++;
                ibanList.Add(lb);
            }

            foreach (Label lb in ibanList)
            {
                panelMainDashboard.Controls.Add(lb);
                lb.BringToFront();
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Dashboard_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelMainDashboard.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelMainDashboard;
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelMainPaySomething.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelMainPaySomething;

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelMainTransfer.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelMainTransfer;


            using (var context =new MitBankDBEntities2())
            {
              int idSession = DataManagement.getIdUsername();
                if (idSession != 0)
                {
                    
                    var result = context.showAllMyAccounts(idSession).ToArray();
                        foreach (var item in result)
                        {
                            comboBoxIBAN.Items.Add(item.ToString());
                        }
                }

            }




        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelMainSendMail.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelMainSendMail;

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            lastMenupanel.Visible = false;
            panelMainSettings.Visible = true;
            lastMenupanel.SendToBack();
            lastMenupanel = panelMainSettings;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelMainTransfer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Are you sure?","Info",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm = new Form1();
                this.Refresh();
                this.Invalidate();
                frm.Refresh();
                frm.Invalidate();
                frm.Show();
            }
           // idSession = -1;
        }

    }
}
