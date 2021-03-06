﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using Dapper;


namespace InventoryDatabaseUITest
{
    public partial class UPCfrm : Form
    {
        public UPCfrm()
        {
            InitializeComponent();
        }

        private void Encode_button_Click(object sender, EventArgs e)
        {
            BarcodeWriter newUPC = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            pic.Image = newUPC.Write(UPCcode.Text);
        }

        private void Print_Button_Click(object sender, EventArgs e)
        {
       
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homefrm HomeForm = new Homefrm();
            HomeForm.ShowDialog();
            this.Close();
        }
    }
}
