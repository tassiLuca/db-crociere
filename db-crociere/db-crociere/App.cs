﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_crociere
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void initNavigation()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var res = from porti in db.PORTIs
                      select new { porti.CodPorto };
            NavigationDropDownMenu.DataSource = res;
        }

        private void initShipInfo()
        {
            NameShipLabel.Text = "NAME_TEST";
            ShipCodeLabel.Text = "CODE_TEST";
            HeightLabel.Text = "HEIGHT_TEST";
            WeightLabel.Text = "WEIGHT_TEST";
            WidthLabel.Text = "WIDTH_TEST";
            LengthLabel.Text = "LENGTH_TEST";
            CabinsNumberLabel.Text = "NUM_CABINS_TEST";
        }

        private void initPathInfo()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            var res = from porti in db.PORTIs
                      select porti;
            LegGridView.DataSource = res;
        }

        private void onShipTabClick(object sender, EventArgs e)
        {
            /**
             * Un esempio con i porti...
             */
            DataClasses1DataContext db = new DataClasses1DataContext();
            var res = from porti in db.PORTIs
                      select new { porti.Città };
            shipListBox.DataSource = res;
            initShipInfo();
            initPathInfo();
            initNavigation();
        }

        private void shipListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Console.WriteLine("" + lb.SelectedIndex);
        }

        private void AddShipBtn_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
