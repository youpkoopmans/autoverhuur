using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace autoverhuurbedrijf
{
    public partial class customers : Form
    {
        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source = YK\SQLEXPRESS; Initial Catalog = autoverhuurbedrijfgo; Integrated Security = True");
        SqlCommand command = new SqlCommand();
        string cmd;
        int _result = 0;
        //End SQL Connection
        //------------------------------------------------------------

        //Show Customers form
        public customers()
        {
            InitializeComponent();
            RefreshGridView();
        }
        //End Show Customers form
        //------------------------------------------------------------



        private void RefreshGridView()
        {
            //Try select all Customers records 
            try
            {

                //DB Connection open
                con.Open();

                //SQL String & Data adapter
                cmd = "SELECT * ";
                cmd += "FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(cmd, con);
                //End SQL String & Data adapter

                //Create Data table & fill it 
                DataTable dt = new DataTable();
                da.Fill(dt);
                //End Create Data table & fill it 

                //Check if rows exists
                if (dt.Rows.Count > 0)
                {
                    //Check Success 
                    dgView.DataSource = dt;
                    dgView.Columns[0].Width = 87;
                    dgView.Columns[0].HeaderText = "Klantnummer";
                    dgView.Columns[1].Width = 70;
                    dgView.Columns[1].HeaderText = "Voornaam";
                    dgView.Columns[2].Width = 80;
                    dgView.Columns[2].HeaderText = "Achternaam";
                    dgView.Columns[3].Width = 100;
                    dgView.Columns[3].HeaderText = "Geboortedatum";
                    dgView.Columns[4].Width = 60;
                    dgView.Columns[4].HeaderText = "Geslacht";
                    dgView.Columns[5].Width = 90;
                    dgView.Columns[5].HeaderText = "Woonplaats";
                    dgView.Columns[6].Width = 120;
                    dgView.Columns[6].HeaderText = "Adres";
                    dgView.Columns[7].Width = 100;
                    dgView.Columns[7].HeaderText = "Telefoonnummer";
                    dgView.Columns[8].Width = 150;
                    dgView.Columns[8].HeaderText = "Emailadres";

                    //DB Connection close
                    con.Close();
                }
                else
                {
                    //Check Fail 
                    //DB Connection close
                    con.Close();
                }
                //End Check if rows exists
            }
            //End Try select all Customer records

            //Catch when try fails 
            catch
            {
                //DB Connection close
                con.Close();
            }
            //End Catch when try fails 
        }
        //End Create Gridview
        //------------------------------------------------------------

        //Create Customers record
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Fillable Variables
            string _firstName = txtFName.Text;
            string _lastName = txtLName.Text;
            DateTime _dateOfBirth = dtDateOfBirth.Value;
            string _gender;
            string _city = txtCity.Text;
            string _address = txtAddress.Text;
            string _telephone = txtTelephone.Text;
            string _email = txtEmail.Text;
            //End Fillable Variables

            //Gender check
            if (rbtnMale.Checked == true)
            {
                _gender = "Man";
            }
            else if (rbtnFemale.Checked == true)
            {
                _gender = "Vrouw";
            }
            else
            {
                _gender = "Onduidelijk";
            }
            //End Gender check

            //SQL String & Command
            cmd = "INSERT INTO Customers (first_name, last_name, date_of_birth, gender, city, address, telephone, email) ";
            cmd += "VALUES (@firstName, @lastName, @dateOfBirth, @birthPlace, @gender, @city, @address, @telephone, @email)";
            command = new SqlCommand(cmd, con);
            //End SQL String & Command

            //SQL Parameters
            command.Parameters.Add(new SqlParameter("@firstName", _firstName));
            command.Parameters.Add(new SqlParameter("@lastName", _lastName));
            command.Parameters.Add(new SqlParameter("@dateOfBirth", _dateOfBirth));
            command.Parameters.Add(new SqlParameter("@gender", _gender));
            command.Parameters.Add(new SqlParameter("@city", _city));
            command.Parameters.Add(new SqlParameter("@address", _address));
            command.Parameters.Add(new SqlParameter("@telephone", _telephone));
            command.Parameters.Add(new SqlParameter("@email", _email));
            //End SQL Parameters

            //DB Connection open
            con.Open();

            //Set Result variable
            _result = command.ExecuteNonQuery();

            //Check if result exists
            if (_result > 0)
            {
                //Result Success message
                MessageBox.Show("Klant opgeslagen");

                //Clear all inputfields
                txtFName.Text = "";
                txtLName.Text = "";
                dtDateOfBirth.Value = DateTime.Now;
                rbtnMale.Checked = false;
                rbtnFemale.Checked = false;
                txtCity.Text = "";
                txtAddress.Text = "";
                txtTelephone.Text = "";
                txtEmail.Text = "";
                //End Clear all inputfields

                //DB Connection close
                con.Close();
            }
            else
            {
                //Result Fail message
                MessageBox.Show("Klant opslaan niet gelukt");

                //DB Connection close
                con.Close();
            }
            //End Check if result exists

            //Refresh Gridview
            RefreshGridView();

        }
        //End Create Customers record
        //------------------------------------------------------------

        //Update Customers record
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Fillable Variables
            int _customerId = Convert.ToInt32(txtCustomerId.Text);
            string _firstName = txtFName.Text;
            string _lastName = txtLName.Text;
            DateTime _dateOfBirth = dtDateOfBirth.Value;
            string _gender;
            string _city = txtCity.Text;
            string _address = txtAddress.Text;
            string _telephone = txtTelephone.Text;
            string _email = txtEmail.Text;
            //End Fillable Variables

            //Gender check
            if (rbtnMale.Checked == true)
            {
                _gender = "Man";
            }
            else if (rbtnFemale.Checked == true)
            {
                _gender = "Vrouw";
            }
            else
            {
                _gender = "Onduidelijk";
            }
            //End Gender check

            //SQL String & Command
            cmd = "UPDATE Customers SET ";
            cmd += "first_name = @firstName, ";
            cmd += "last_name = @lastName, ";
            cmd += "date_of_birth = @dateOfBirth, ";
            cmd += "gender = @gender, ";
            cmd += "city = @city, ";
            cmd += "address = @address, ";
            cmd += "telephone = @telephone, ";
            cmd += "email = @email ";
            cmd += "WHERE id = @customerId";
            command = new SqlCommand(cmd, con);
            //End SQL String & Command

            //SQL Parameters
            command.Parameters.Add(new SqlParameter("@customerId", _customerId));
            command.Parameters.Add(new SqlParameter("@firstName", _firstName));
            command.Parameters.Add(new SqlParameter("@lastName", _lastName));
            command.Parameters.Add(new SqlParameter("@dateOfBirth", _dateOfBirth));
            command.Parameters.Add(new SqlParameter("@gender", _gender));
            command.Parameters.Add(new SqlParameter("@city", _city));
            command.Parameters.Add(new SqlParameter("@address", _address));
            command.Parameters.Add(new SqlParameter("@telephone", _telephone));
            command.Parameters.Add(new SqlParameter("@email", _email));
            //End SQL Parameters

            //DB Connection open
            con.Open();

            //Set Result variable
            _result = command.ExecuteNonQuery();

            //Check if result exists
            if (_result > 0)
            {
                //Result Success message
                MessageBox.Show("Klant gewijzigd");

                //Clear all inputfields
                txtCustomerId.Text = "";
                txtFName.Text = "";
                txtLName.Text = "";
                dtDateOfBirth.Value = DateTime.Now;
                rbtnMale.Checked = false;
                rbtnFemale.Checked = false;
                txtCity.Text = "";
                txtAddress.Text = "";
                txtTelephone.Text = "";
                txtEmail.Text = "";
                //End Clear all inputfields

                //DB Connection close
                con.Close();
            }
            else
            {
                //Result Fail message
                MessageBox.Show("Klant wijzigen niet gelukt");

                //DB Connection close
                con.Close();
            }
            //End Check if result exists

            //Refresh Gridview
            RefreshGridView();
        }
        //End Update Customers record
        //------------------------------------------------------------

        //Delete Customers record
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Fillable Variables
            int _customerId = Convert.ToInt32(txtCustomerId.Text);
            //End Fillable Variables

            //DB Connection open
            con.Open();

            //SQL String & Command
            cmd = "DELETE FROM Customers ";
            cmd += "WHERE id = @customerId";
            command = new SqlCommand(cmd, con);
            //End SQL String & Command

            //SQL Parameters
            command.Parameters.Add(new SqlParameter("@customerId", _customerId));

            //Set Result variable
            int _result = command.ExecuteNonQuery();

            //Check if result exists
            if (_result > 0)
            {
                //Result Success message
                MessageBox.Show("Klant verwijdert");

                //Clear rentId inputfield
                txtCustomerId.Text = "";

                //DB Connection close
                con.Close();
            }
            else
            {
                //Result Fail message
                MessageBox.Show("Klant verwijderen niet gelukt");

                //DB Connection close
                con.Close();
            }
            //End Check if result exists

            //Refresh Gridview
            RefreshGridView();
        }
        //End Delete Customers record
        //------------------------------------------------------------

        //Search Customers record
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Fillable Variables
            int _customerId = Convert.ToInt32(txtCustomerId.Text);
            //End Fillable Variables

            //DB Connection open
            con.Open();

            //Try select search customer records 
            try
            {
                //SQL String & Command 
                cmd = "SELECT * ";
                cmd += "FROM Customers ";
                cmd += "WHERE id like @customerId";
                command = new SqlCommand(cmd, con);
                SqlDataAdapter da = new SqlDataAdapter(command);
                //End SQL String & Command

                //SQL Parameter
                command.Parameters.Add(new SqlParameter("@customerId", "%" + _customerId));

                //Create Data table & fill it 
                DataTable dt = new DataTable();
                da.Fill(dt);
                //End Create Data table & fill it 

                //Check if row exists
                if (dt.Rows.Count > 0)
                {
                    //Check Success 
                    dgView.DataSource = dt;
                    dgView.Columns[0].Width = 87;
                    dgView.Columns[0].HeaderText = "Klantnummer";
                    dgView.Columns[1].Width = 70;
                    dgView.Columns[1].HeaderText = "Voornaam";
                    dgView.Columns[2].Width = 80;
                    dgView.Columns[2].HeaderText = "Achternaam";
                    dgView.Columns[3].Width = 100;
                    dgView.Columns[3].HeaderText = "Geboortedatum";
                    dgView.Columns[4].Width = 60;
                    dgView.Columns[4].HeaderText = "Geslacht";
                    dgView.Columns[5].Width = 90;
                    dgView.Columns[5].HeaderText = "Woonplaats";
                    dgView.Columns[6].Width = 120;
                    dgView.Columns[6].HeaderText = "Adres";
                    dgView.Columns[7].Width = 100;
                    dgView.Columns[7].HeaderText = "Telefoonnummer";
                    dgView.Columns[8].Width = 150;
                    dgView.Columns[8].HeaderText = "Emailadres";

                    //DB Connection close
                    con.Close();
                }
                else
                {
                    //Check Fail 
                    //Fail Message 
                    MessageBox.Show("Geen klant gevonden");

                    //DB Connection close
                    con.Close();
                }
                //End Check if rows exists
            }
            //End Try select all customer records

            //Catch when try fails 
            catch
            {
                //DB Connection close
                con.Close();
            }
            //End Catch when try fails 

            //Finally
            finally
            {
                con.Close();
            }
            //End Finally
        }
        //End Search Customers record
        //------------------------------------------------------------

        //Clear all inputfields
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            dtDateOfBirth.Value = DateTime.Now;
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            txtAddress.Text = "";
            txtTelephone.Text = "";
        }
        //End Clear all inputfields
        //------------------------------------------------------------

        //Hide Customers form
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //End Hide Customers form
        //------------------------------------------------------------

        //Exit Autoverhuurbedrijf GO application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //End Exit Autoverhuurbedrijf GO application
        //------------------------------------------------------------
    }
}
