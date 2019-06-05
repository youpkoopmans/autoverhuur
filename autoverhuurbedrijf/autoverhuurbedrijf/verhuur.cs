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
    public partial class verhuur : Form
    {
        public verhuur()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtAutomerk.Text = "";
            txtType.Text = "";
            dtVerhuurdatum.Value = DateTime.Now;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            txtAantal.Text = "";
            txtVerhuur.Text = "";
            txtTele.Text = "";
            dgView.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
