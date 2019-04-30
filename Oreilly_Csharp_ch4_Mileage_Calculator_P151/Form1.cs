using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter4_Mileage_Calculator
{
    public partial class Form1 : Form
    {
        int startMile;
        int endMile;
        double milesTraveled;
        double reimburseRate = 0.39;//每英哩補貼0.39元
        double amountOwnd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Calaulator_Click(object sender, EventArgs e)
        {
            startMile = (int)startMile_UpDown.Value;
            endMile = (int)endMileUpDown.Value;
            milesTraveled = endMile - startMile;
            if (endMile > startMile)
            {
                milesTraveled = endMile - startMile;
                amountOwnd = milesTraveled * reimburseRate;
                label_amountOwed.Text = "$" + amountOwnd;
            }
            else
            {
                MessageBox.Show("startMile and endMile setting error \n ");
            }
        }

        private void StartMile_UpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}