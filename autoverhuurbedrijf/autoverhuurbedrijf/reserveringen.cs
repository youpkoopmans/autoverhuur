using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoverhuurbedrijf
{
    public partial class reserveringen : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = YK\SQLEXPRESS; Initial Catalog = autoverhuur; Integrated Security = True");
        SqlCommand command = new SqlCommand();
        string cmd;
        SqlDataReader dr;
        int _result = 0;
        public reserveringen()
        {
            InitializeComponent();
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            try
            {
                con.Open();
                cmd = "select * from Reserveringen";
                SqlDataAdapter da = new SqlDataAdapter(cmd, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgView.DataSource = dt;
                    dgView.Columns[0].Width = 65;
                    dgView.Columns[0].HeaderText = "reserveringsId";
                    dgView.Columns[1].Width = 160;
                    dgView.Columns[1].HeaderText = "klantNr";
                    dgView.Columns[2].Width = 160;
                    dgView.Columns[2].HeaderText = "autoId";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No Records found");
                    con.Close();
                }
            }
            catch
            {
                //MessageBox.Show("There is an error!");
                con.Close();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtKlantnr.Text = "";
            txtReserveringsId.Text = "";
            dgView.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _reserveringsId = txtReserveringsId.Text;
            string _klantNr = txtKlantnr.Text;
            string _autoId = txtAutoId.Text;
            int _result = 0;

            cmd = "insert into Reserveringen (reserveringsId,klantNr,autoId) values(@reserveringsid,@klantNr,@autoId)";
            command = new SqlCommand(cmd, con);

            command.Parameters.Add(new SqlParameter("@reserveringsId", _reserveringsId));
            command.Parameters.Add(new SqlParameter("@klantNr", _klantNr));
            command.Parameters.Add(new SqlParameter("@autoId", _autoId));

            con.Open();
            _result = command.ExecuteNonQuery();

            if (_result > 0)
            {
                txtReserveringsId.Text = "";
                txtKlantnr.Text = "";
                txtAutoId.Text = "";
                con.Close();
            }
            else
            {
                con.Close();
            }
            RefreshGridView();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }

        //private void btnOverview_Click(object sender, EventArgs e)
        //{
        //    RefreshGridView();
        //}
    }
}
