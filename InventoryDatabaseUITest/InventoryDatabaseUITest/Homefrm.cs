﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDatabaseUITest
{
    public partial class Homefrm : Form
    {
        public Homefrm()
        {
            InitializeComponent();
        }

        private void addStock_Click(object sender, EventArgs e)
        {
            addStockfrm addStockform = new addStockfrm();
            addStockform.Show();
            this.Hide();

        }

        private void viewInv_Click(object sender, EventArgs e)
        {

        }
    }
}
