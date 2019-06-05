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
    public partial class verhuur : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = YK\SQLEXPRESS; Initial Catalog = autoverhuur; Integrated Security = True");
        SqlCommand command = new SqlCommand();
        string cmd;
        SqlDataReader dr;
        int _result = 0;
        public verhuur()
        {
            InitializeComponent();
            RefreshGridView();

        }

        private void RefreshGridView()
        {
            try
            {
                con.Open();
                cmd = "select * from Verhuur";
                SqlDataAdapter da = new SqlDataAdapter(cmd, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgView.DataSource = dt;
                    dgView.Columns[0].Width = 100;
                    dgView.Columns[0].HeaderText = "No";
                    dgView.Columns[1].Width = 150;
                    dgView.Columns[1].HeaderText = "Verhuur Datum";
                    dgView.Columns[2].Width = 150;
                    dgView.Columns[2].HeaderText = "Aantal";
                    dgView.Columns[3].Width = 150;
                    dgView.Columns[3].HeaderText = "Verhuur periode in dagen";
                    dgView.Columns[4].Width = 150;
                    dgView.Columns[4].HeaderText = "Te laat";
                    dgView.Columns[5].Width = 150;

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
            dtVerhuurdatum.Value = DateTime.Now;
            txtAantal.Text = "";
            txtVerhuurPeriode.Text = "";
            dgView.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DateTime _verhuurDatum = dtVerhuurdatum.Value;
            int _aantal = Convert.ToInt32(txtAantal.Text);
            int _verhuurPeriode = Convert.ToInt32(txtVerhuurPeriode.Text);
            DateTime _eindDatum = _verhuurDatum.AddDays(_verhuurPeriode);
            
            bool _teLaat;

            if(_eindDatum < DateTime.Now)
            {
                _teLaat = true;
            }
            else
            {
                _teLaat = false;
            }

            cmd = "insert into Verhuur (verhuur_datum,aantal,verhuur_periode,beschikbaar) values(@verhuurDatum,@aantal,@verhuurPeriode,@beschikbaar)";
            command = new SqlCommand(cmd, con);

            command.Parameters.Add(new SqlParameter("@verhuurDatum", _verhuurDatum));
            command.Parameters.Add(new SqlParameter("@aantal", _aantal));
            command.Parameters.Add(new SqlParameter("@verhuurPeriode", _verhuurPeriode));
            command.Parameters.Add(new SqlParameter("@beschikbaar", _teLaat));

            con.Open();
            _result = command.ExecuteNonQuery();

            if (_result > 0)
            {
                dtVerhuurdatum.Value = DateTime.Now;
                txtAantal.Text = "";
                txtVerhuurPeriode.Text = "";
                con.Close();
            }
            else
            {
                con.Close();
            }
            RefreshGridView();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DateTime _verhuurDatum = dtVerhuurdatum.Value;
            int _aantal = Convert.ToInt32(txtAantal.Text);
            int _verhuurPeriode = Convert.ToInt32(txtVerhuurPeriode.Text);
            DateTime _eindDatum = _verhuurDatum.AddDays(_verhuurPeriode);
            int _id = Convert.ToInt32(txtVerhuurId.Text);


            bool _teLaat;

            if (_eindDatum < DateTime.Now)
            {
                _teLaat = true;
            }
            else
            {
                _teLaat = false;
            }

            cmd = "update Verhuur set verhuur_datum = @verhuurDatum,aantal = @aantal,verhuur_periode = @verhuurPeriode,beschikbaar = @beschikbaar where id = @id";
            command = new SqlCommand(cmd, con);

            command.Parameters.Add(new SqlParameter("@id", _id));
            command.Parameters.Add(new SqlParameter("@verhuurDatum", _verhuurDatum));
            command.Parameters.Add(new SqlParameter("@aantal", _aantal));
            command.Parameters.Add(new SqlParameter("@verhuurPeriode", _verhuurPeriode));
            command.Parameters.Add(new SqlParameter("@beschikbaar", _teLaat));

            con.Open();
            _result = command.ExecuteNonQuery();

            if (_result > 0)
            {
                MessageBox.Show("Klant Updated");
                dtVerhuurdatum.Value = DateTime.Now;
                txtAantal.Text = "";
                txtVerhuurPeriode.Text = "";
                txtVerhuurId.Text = "";
                con.Close();
            }
            else
            {
                con.Close();
            }
            RefreshGridView();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int _id = Convert.ToInt32(txtVerhuurId.Text);
            con.Open();
            cmd = "delete from Verhuur where id = @id";
            command = new SqlCommand(cmd, con);
            command.Parameters.Add(new SqlParameter("@id", _id));
            int _result = command.ExecuteNonQuery();
            if (_result > 0)
            {
                MessageBox.Show("Record deleted");
                con.Close();
                txtVerhuurId.Text = "";
            }
            else
            {
                MessageBox.Show("Record not deleted?");
                con.Close();
            }
            RefreshGridView();
        }
    }
}
