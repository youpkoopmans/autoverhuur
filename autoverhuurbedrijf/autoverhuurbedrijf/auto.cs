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
    public partial class auto : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = YK\SQLEXPRESS; Initial Catalog = autoverhuur; Integrated Security = True");
        SqlCommand command = new SqlCommand();
        string cmd;
        SqlDataReader dr;
        int _result = 0;
        public auto()
        {
            InitializeComponent();
            RefreshGridView();
        }

        private void RefreshGridView()
        {
            try
            {
                con.Open();
                cmd = "select * from Autos";
                SqlDataAdapter da = new SqlDataAdapter(cmd, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgView.DataSource = dt;
                    dgView.Columns[0].Width = 65;
                    dgView.Columns[0].HeaderText = "No";
                    dgView.Columns[1].Width = 160;
                    dgView.Columns[1].HeaderText = "Kenteken";
                    dgView.Columns[2].Width = 160;
                    dgView.Columns[2].HeaderText = "Merk";
                    dgView.Columns[3].Width = 160;
                    dgView.Columns[3].HeaderText = "Type";
                    dgView.Columns[4].Width = 160;
                    dgView.Columns[4].HeaderText = "Beschikbaar";
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
            txtKenteken.Text = "";
            txtMerk.Text = "";
            rbtnJa.Checked = false;
            rbtnNee.Checked = false;
            txtType.Text = "";
            dgView.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnOverview_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string _kenteken = txtKenteken.Text;
            string _merk = txtMerk.Text;
            string _type = txtType.Text;
            bool _beschikbaar;
            int _result = 0;

            if(rbtnJa.Checked == true)
            {
                _beschikbaar = true;
            }
            else if(rbtnNee.Checked == true)
            {
                _beschikbaar = false;
            }
            else
            {
                _beschikbaar = false;
            }

            cmd = "insert into Autos (kenteken,merk,type,beschikbaar) values(@kenteken,@merk,@type,@beschikbaar)";
            command = new SqlCommand(cmd, con);

            command.Parameters.Add(new SqlParameter("@kenteken", _kenteken));
            command.Parameters.Add(new SqlParameter("@merk", _merk));
            command.Parameters.Add(new SqlParameter("@type", _type));
            command.Parameters.Add(new SqlParameter("@beschikbaar", _beschikbaar));

            con.Open();
            _result = command.ExecuteNonQuery();

            if (_result > 0)
            {
                txtKenteken.Text = "";
                txtMerk.Text = "";
                txtType.Text = "";
                rbtnJa.Checked = false;
                rbtnNee.Checked = false;
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
            string _kenteken = txtKenteken.Text;
            string _merk = txtMerk.Text;
            string _type = txtType.Text;
            bool _beschikbaar;
            int _id = Convert.ToInt32(txtId.Text);
            int _result = 0;

            if (rbtnJa.Checked == true)
            {
                _beschikbaar = true;
            }
            else if (rbtnNee.Checked == true)
            {
                _beschikbaar = false;
            }
            else
            {
                _beschikbaar = false;
            }

            cmd = "update Autos set kenteken = @kenteken,merk = @merk,type = @type,beschikbaar = @beschikbaar where id = @id";
            command = new SqlCommand(cmd, con);

            command.Parameters.Add(new SqlParameter("@kenteken", _kenteken));
            command.Parameters.Add(new SqlParameter("@merk", _merk));
            command.Parameters.Add(new SqlParameter("@type", _type));
            command.Parameters.Add(new SqlParameter("@beschikbaar", _beschikbaar));
            command.Parameters.Add(new SqlParameter("@id", _id));

            con.Open();
            _result = command.ExecuteNonQuery();

            if (_result > 0)
            {
                MessageBox.Show("Auto Updated");
                txtKenteken.Text = "";
                txtId.Text = "";
                txtMerk.Text = "";
                txtType.Text = "";
                rbtnJa.Checked = false;
                rbtnNee.Checked = false;
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
            int _id = Convert.ToInt32(txtId.Text);
            con.Open();
            cmd = "delete from Autos where id = @id";
            command = new SqlCommand(cmd, con);
            command.Parameters.Add(new SqlParameter("@id", _id));
            int _result = command.ExecuteNonQuery();
            if (_result > 0)
            {
                MessageBox.Show("Record deleted");
                con.Close();
                txtId.Text = "";
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
