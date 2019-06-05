using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace autoverhuurbedrijf
{
    public partial class klanten : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = YK\SQLEXPRESS; Initial Catalog = autoverhuur; Integrated Security = True");
        SqlCommand command = new SqlCommand();
        string cmd;
        SqlDataReader dr;
        int _result = 0;
        public klanten()
        {
            InitializeComponent();
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            try
            {
                con.Open();
                cmd = "select * from Klanten";
                SqlDataAdapter da = new SqlDataAdapter(cmd, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgView.DataSource = dt;
                    dgView.Columns[0].Width = 65;
                    dgView.Columns[0].HeaderText = "No";
                    dgView.Columns[1].Width = 100;
                    dgView.Columns[1].HeaderText = "Voornaam";
                    dgView.Columns[2].Width = 100;
                    dgView.Columns[2].HeaderText = "Achternaam";
                    dgView.Columns[3].Width = 100;
                    dgView.Columns[3].HeaderText = "Geboortedatum";
                    dgView.Columns[4].Width = 100;
                    dgView.Columns[4].HeaderText = "Geboorteplaats";
                    dgView.Columns[5].Width = 100;
                    dgView.Columns[5].HeaderText = "Geslacht";
                    dgView.Columns[6].Width = 100;
                    dgView.Columns[6].HeaderText = "Adres";
                    dgView.Columns[7].Width = 100;
                    dgView.Columns[7].HeaderText = "Telefoonnummer";

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
            txtFName.Text = "";
            txtLName.Text = "";
            dtBday.Value = DateTime.Now;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            txtbPlace.Text = "";
            txtAddress.Text = "";
            txtTele.Text = "";
            dgView.DataSource = null;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string _firstName = txtFName.Text;
            string _lastName = txtLName.Text;
            DateTime _dtBday = dtBday.Value;
            string _birthPlace = txtbPlace.Text;
            string _sex;
            string _address = txtAddress.Text;
            string _telephone = txtTele.Text;
            int _result = 0;

            if (rbtnMale.Checked == true)
            {
                _sex = "Man";
            }
            else if (rbtnFemale.Checked == true)
            {
                _sex = "Vrouw";
            }
            else
            {
                _sex = "Onduidelijk";
            }

            cmd = "insert into Klanten (voornaam,achternaam,geboortedatum,geboorteplaats,geslacht,adres,telefoonnummer) values(@voornaam,@achternaam,@geboortedatum,@geboorteplaats,@geslacht,@adres,@telefoonnummer)";
            command = new SqlCommand(cmd, con);

            command.Parameters.Add(new SqlParameter("@voornaam", _firstName));
            command.Parameters.Add(new SqlParameter("@achternaam", _lastName));
            command.Parameters.Add(new SqlParameter("@geboortedatum", _dtBday));
            command.Parameters.Add(new SqlParameter("@geboorteplaats", _birthPlace));
            command.Parameters.Add(new SqlParameter("@geslacht", _sex));
            command.Parameters.Add(new SqlParameter("@adres", _address));
            command.Parameters.Add(new SqlParameter("@telefoonnummer", _telephone));

            con.Open();
            _result = command.ExecuteNonQuery();

            if (_result > 0)
            {
                txtFName.Text = "";
                txtLName.Text = "";
                dtBday.Value = DateTime.Now;
                txtbPlace.Text = "";
                txtAddress.Text = "";
                txtTele.Text = "";
                rbtnMale.Checked = false;
                rbtnFemale.Checked = false;
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
            string _firstName = txtFName.Text;
            string _lastName = txtLName.Text;
            DateTime _dtBday = dtBday.Value;
            string _birthPlace = txtbPlace.Text;
            string _sex;
            string _address = txtAddress.Text;
            string _telephone = txtTele.Text;
            int _id = Convert.ToInt32(txtKlantId.Text);
            int _result = 0;

            if (rbtnMale.Checked == true)
            {
                _sex = "Man";
            }
            else if (rbtnFemale.Checked == true)
            {
                _sex = "Vrouw";
            }
            else
            {
                _sex = "Onduidelijk";
            }

            cmd = "update Klanten set voornaam = @voornaam,achternaam = @achternaam,geboortedatum = @geboortedatum,geboorteplaats = @geboorteplaats, geslacht = @geslacht,adres = @adres,telefoonnummer = @telefoonnummer where id = @id";
            command = new SqlCommand(cmd, con);

            command.Parameters.Add(new SqlParameter("@voornaam", _firstName));
            command.Parameters.Add(new SqlParameter("@achternaam", _lastName));
            command.Parameters.Add(new SqlParameter("@geboortedatum", _dtBday));
            command.Parameters.Add(new SqlParameter("@geboorteplaats", _birthPlace));
            command.Parameters.Add(new SqlParameter("@geslacht", _sex));
            command.Parameters.Add(new SqlParameter("@adres", _address));
            command.Parameters.Add(new SqlParameter("@telefoonnummer", _telephone));
            command.Parameters.Add(new SqlParameter("@id", _id));

            con.Open();
            _result = command.ExecuteNonQuery();

            if (_result > 0)
            {
                MessageBox.Show("Klant Updated");
                txtFName.Text = "";
                txtLName.Text = "";
                dtBday.Value = DateTime.Now;
                txtbPlace.Text = "";
                txtAddress.Text = "";
                txtTele.Text = "";
                rbtnMale.Checked = false;
                rbtnFemale.Checked = false;
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
            int _id = Convert.ToInt32(txtKlantId.Text);
            con.Open();
            cmd = "delete from Klanten where id = @id";
            command = new SqlCommand(cmd, con);
            command.Parameters.Add(new SqlParameter("@id", _id));
            int _result = command.ExecuteNonQuery();
            if (_result > 0)
            {
                MessageBox.Show("Record deleted");
                con.Close();
                txtKlantId.Text = "";
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
