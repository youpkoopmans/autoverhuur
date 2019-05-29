using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoverhuurbedrijf
{
    public partial class Form1 : Form
    {
        private verhuur verhuur;
        private klanten klanten;
        private reserveringen reserveringen;
        private auto auto;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            reserveringen = new reserveringen();
            reserveringen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            klanten = new klanten();
            klanten.Show();
        }

        private void btnVerhuur_Click(object sender, EventArgs e)
        {
            verhuur = new verhuur();
            verhuur.Show();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            auto = new auto();
            auto.Show();
        }
    }
}
