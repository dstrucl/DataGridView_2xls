using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataGridView_2xls_DEMO
{
    public partial class Form1 : Form
    {
        int PictureBox1_initial_pos = -1;
        int PictureBox1_pos = 0;
        DataTable dt_Demo = new DataTable();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataColumn dcol_Item_Name = new DataColumn("Item", typeof(string));
            DataColumn dcol_Price_per_unit = new DataColumn("Price per unit", typeof(decimal));
            DataColumn dcol_Unit = new DataColumn("Unit", typeof(string));
            DataColumn dcol_Quantity = new DataColumn("Quantity", typeof(decimal));
            DataColumn dcol_Currency = new DataColumn("Currency", typeof(string));
            DataColumn dcol_Supplier = new DataColumn("Supplier", typeof(string));
            DataColumn dcol_PurchaseTime = new DataColumn("Purchase time", typeof(DateTime));
            dt_Demo.Columns.Add(dcol_Item_Name);
            dt_Demo.Columns.Add(dcol_Quantity);
            dt_Demo.Columns.Add(dcol_Unit);
            dt_Demo.Columns.Add(dcol_Price_per_unit);
            dt_Demo.Columns.Add(dcol_Currency);
            dt_Demo.Columns.Add(dcol_Supplier);
            dt_Demo.Columns.Add(dcol_PurchaseTime);
            DataRow dr = dt_Demo.NewRow();
            dr["Item"] = "Apples";
            dr["Price per unit"] = 0.5;
            dr["Unit"] = "kg";
            dr["Quantity"] = 2;
            dr["Currency"] = "EURO";
            dr["Supplier"] = "ALDI";
            dr["Purchase time"] = DateTime.Now - TimeSpan.FromDays(30);
            dt_Demo.Rows.Add(dr);
            dr = dt_Demo.NewRow();
            dr["Item"] = "Cherries";
            dr["Price per unit"] = 0.8;
            dr["Unit"] = "kg";
            dr["Quantity"] = 3;
            dr["Currency"] = "EURO";
            dr["Supplier"] = "HOFFER";
            dr["Purchase time"] = DateTime.Now - TimeSpan.FromDays(20);
            dt_Demo.Rows.Add(dr);
            dr = dt_Demo.NewRow();
            dr["Item"] = "Pears";
            dr["Price per unit"] = 1;
            dr["Unit"] = "kg";
            dr["Quantity"] = 0.5;
            dr["Currency"] = "USD";
            dr["Supplier"] = "WallMart";
            dr["Purchase time"] = DateTime.Now - TimeSpan.FromDays(10);
            dt_Demo.Rows.Add(dr);
            dr = dt_Demo.NewRow();
            dr["Item"] = "Plums";
            dr["Price per unit"] = 1;
            dr["Unit"] = "kg";
            dr["Quantity"] = 1.5;
            dr["Currency"] = "HRK";
            dr["Supplier"] = "Plodine";
            dr["Purchase time"] = DateTime.Now - TimeSpan.FromDays(15);
            dt_Demo.Rows.Add(dr);
            dr = dt_Demo.NewRow();
            dr["Item"] = "Strawberries";
            dr["Price per unit"] = 1;
            dr["Unit"] = "kg";
            dr["Quantity"] = 1.2;
            dr["Currency"] = "SIT";
            dr["Supplier"] = "Merkator";
            dr["Purchase time"] = DateTime.Now - TimeSpan.FromDays(12);
            dt_Demo.Rows.Add(dr);
            this.dataGridView2xls1.DataSource = dt_Demo;
            PictureBox1_initial_pos = pictureBox1.Top;
            PictureBox1_pos = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (PictureBox1_pos < 20)
            {
                PictureBox1_pos++;
            }
            else
            {
                PictureBox1_pos = 0;
            }
            pictureBox1.Top = PictureBox1_initial_pos + PictureBox1_pos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
