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
                    dgView.Columns[0].Width = 230;
                    dgView.Columns[0].HeaderText = "reservering id";
                    dgView.Columns[1].Width = 235;
                    dgView.Columns[1].HeaderText = "klant Nummer";
                    dgView.Columns[2].Width = 240;
                    dgView.Columns[2].HeaderText = "auto id";
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
            txtKlantId.Text = "";
            txtReserveringId.Text = "";
            dgView.DataSource = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int _klantId = Convert.ToInt32(txtKlantId.Text);
            int _autoId = Convert.ToInt32(txtAutoId.Text);
            int _result = 0;

            cmd = "insert into Reserveringen (klant_id,auto_id) values(@klantNr,@autoId)";
            command = new SqlCommand(cmd, con);

            command.Parameters.Add(new SqlParameter("@klantNr", _klantId));
            command.Parameters.Add(new SqlParameter("@autoId", _autoId));

            con.Open();
            _result = command.ExecuteNonQuery();

            if (_result > 0)
            {
                txtKlantId.Text = "";
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
            int _id = Convert.ToInt32(txtReserveringId.Text);
            int _klantId = Convert.ToInt32(txtKlantId.Text);
            int _autoId = Convert.ToInt32(txtAutoId.Text);
            int _result = 0;

            cmd = "update Reserveringen set klant_id = @klantNr,auto_id = @autoId where id = @id";
            command = new SqlCommand(cmd, con);

            command.Parameters.Add(new SqlParameter("@id", _id));
            command.Parameters.Add(new SqlParameter("@klantNr", _klantId));
            command.Parameters.Add(new SqlParameter("@autoId", _autoId));

            con.Open();
            _result = command.ExecuteNonQuery();

            if (_result > 0)
            {
                MessageBox.Show("Reservering Updated");
                txtReserveringId.Text = "";
                txtKlantId.Text = "";
                txtAutoId.Text = "";
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
            int _id = Convert.ToInt32(txtReserveringId.Text);
            con.Open();
            cmd = "delete from Reserveringen where id = @id";
            command = new SqlCommand(cmd, con);
            command.Parameters.Add(new SqlParameter("@id", _id));
            int _result = command.ExecuteNonQuery();
            if (_result > 0)
            {
                MessageBox.Show("Record deleted");
                con.Close();
                txtReserveringId.Text = "";
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
