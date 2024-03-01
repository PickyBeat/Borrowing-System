﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StaffForm : Form
    {

        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

        }

        public void loadform(object Form)
        {
            if (this.staffFormPanel.Controls.Count > 1)
            {
                this.staffFormPanel.Controls.RemoveAt(1);
            }

            Form f = Form as Form;
            f.TopLevel = false;
            this.staffFormPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            this.staffFormPanel.Tag = f;
            f.Show();
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            loadform(new DashBoard());
        }

        private void dashBoard_Click(object sender, EventArgs e)
        {
            loadform(new DashBoard());
        }

        private void borrowingPage_Click(object sender, EventArgs e)
        {
            loadform(new BorrowingPage());
        }
    }
}
