using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Laba_6__Task_2_.Class1;

namespace Laba_6__Task_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcParal_Click(object sender, EventArgs e)
        {
            double baseA = double.Parse(ParalBase.Text);
            double heightH = double.Parse(ParalHeight.Text);

            Parallelogram parallelogram = new Parallelogram(baseA, heightH);

            double area = parallelogram.GetArea();

            lbResultParal.Text = area.ToString();
        }

        private void btnCalcTrapez_Click(object sender, EventArgs e)
        {
            double base1 = double.Parse(TrapBase1.Text);
            double base2 = double.Parse(TrapBase2.Text);
            double height = double.Parse(TrapHeight.Text);

            Trapezium trapezium = new Trapezium(base1, base2, height);

            double area = trapezium.GetArea();

            lbResultTrapez.Text = area.ToString();
        }

    }
}
