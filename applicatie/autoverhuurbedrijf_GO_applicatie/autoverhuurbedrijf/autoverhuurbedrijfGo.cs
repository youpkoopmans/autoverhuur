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
    public partial class autoverhuurbedrijfGo : Form
    {
        private rentals rentals;
        private customers customers;
        private reservations reservations;
        private cars cars;


        public autoverhuurbedrijfGo()
        {
            InitializeComponent();
        }


        private void btnReservations_Click(object sender, EventArgs e)
        {
            reservations = new reservations();
            reservations.Show();
        }


        private void btnCustomers_Click(object sender, EventArgs e)
        {
            customers = new customers();
            customers.Show();
        }


        private void btnRentals_Click(object sender, EventArgs e)
        {
            rentals = new rentals();
            rentals.Show();
        }


        private void btnCars_Click(object sender, EventArgs e)
        {
            cars = new cars();
            cars.Show();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
