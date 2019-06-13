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
    public partial class rentals : Form
    {
        //SQL Connection
        SqlConnection con = new SqlConnection(@"Data Source = YK\SQLEXPRESS; Initial Catalog = autoverhuurbedrijfgo; Integrated Security = True");
        SqlCommand command = new SqlCommand();
        string cmd;
        int _result = 0;
        //End SQL Connection
        //------------------------------------------------------------

        //Show Rentals form
        public rentals()
        {
            InitializeComponent();
            RefreshGridView();
        }
        //End Show Rentals form
        //------------------------------------------------------------

        //Create Gridview
        private void RefreshGridView()
        {
            //Try select all Rentals records 
            try
            {
                
                //DB Connection open
                con.Open();

                //SQL String & Data adapter
                cmd =   "SELECT * ";
                cmd +=  "FROM Rentals";
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
                    dgView.Columns[0].Width = 137;
                    dgView.Columns[0].HeaderText = "Verhuurnummer";
                    dgView.Columns[1].Width = 180;
                    dgView.Columns[1].HeaderText = "Verhuurdatum";
                    dgView.Columns[2].Width = 180;
                    dgView.Columns[2].HeaderText = "Aantal auto's";
                    dgView.Columns[3].Width = 180;
                    dgView.Columns[3].HeaderText = "Verhuurperiode in dagen";
                    dgView.Columns[4].Width = 180;
                    dgView.Columns[4].HeaderText = "Te laat";
                    dgView.Columns[5].Width = 150;

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
            //End Try select all Rentals records
            
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

        //Create Rentals record
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Fillable Variables
            DateTime _rentDate =    dtRentDate.Value;
            int _amountCars =       Convert.ToInt32(txtAmountCars.Text);
            int _rentPeriod =       Convert.ToInt32(txtRentPeriod.Text);
            DateTime _endDate =     _rentDate.AddDays(_rentPeriod);            
            bool _tooLate;
            //End Fillable Variables

            //Too late check
            if(_endDate < DateTime.Now)
            {
                _tooLate = true;
            }
            else
            {
                _tooLate = false;
            }
            //End Too late check

            //SQL String & Command
            cmd =   "INSERT INTO Rentals (rent_date, amount_cars, rent_period, too_late) ";
            cmd +=  "VALUES (@rentDate, @amountCars, @rentPeriod, @tooLate)";
            command = new SqlCommand(cmd, con);
            //End SQL String & Command

            //SQL Parameters
            command.Parameters.Add(new SqlParameter("@rentDate", _rentDate));
            command.Parameters.Add(new SqlParameter("@amountCars", _amountCars));
            command.Parameters.Add(new SqlParameter("@rentPeriod", _rentPeriod));
            command.Parameters.Add(new SqlParameter("@tooLate", _tooLate));
            //End SQL Parameters

            //DB Connection open
            con.Open();

            //Set Result variable
            _result = command.ExecuteNonQuery();

            //Check if result exists
            if (_result > 0)
            {
                //Result Success message
                MessageBox.Show("Verhuring opgeslagen");

                //Clear all inputfields
                dtRentDate.Value = DateTime.Now;
                txtAmountCars.Text = "";
                txtRentPeriod.Text = "";
                //End Clear all inputfields

                //DB Connection close
                con.Close();
            }
            else
            {
                //Result Fail message
                MessageBox.Show("Verhuring opslaan niet gelukt");

                //DB Connection close
                con.Close();
            }
            //End Check if result exists

            //Refresh Gridview
            RefreshGridView();

        }
        //End Create Rentals record
        //------------------------------------------------------------

        //Update Rentals record
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Fillable Variables
            int _rentId =           Convert.ToInt32(txtRentId.Text);
            DateTime _rentDate =    dtRentDate.Value;
            int _amountCars =       Convert.ToInt32(txtAmountCars.Text);
            int _rentPeriod =       Convert.ToInt32(txtRentPeriod.Text);
            DateTime _endDate =     _rentDate.AddDays(_rentPeriod);           
            bool _tooLate;
            //End Fillable Variables

            //Too late check
            if (_endDate < DateTime.Now)
            {
                _tooLate = true;
            }
            else
            {
                _tooLate = false;
            }
            //End Too late check

            //SQL String & Command
            cmd =   "UPDATE Rentals SET ";
            cmd +=  "rent_date = @rentDate, ";
            cmd +=  "amount_cars = @amountCars, ";
            cmd +=  "rent_period = @rentPeriod, ";
            cmd +=  "too_late = @tooLate ";
            cmd +=  "WHERE id = @rentId";
            command = new SqlCommand(cmd, con);
            //End SQL String & Command

            //SQL Parameters
            command.Parameters.Add(new SqlParameter("@rentId", _rentId));
            command.Parameters.Add(new SqlParameter("@rentDate", _rentDate));
            command.Parameters.Add(new SqlParameter("@amountCars", _amountCars));
            command.Parameters.Add(new SqlParameter("@rentPeriod", _rentPeriod));
            command.Parameters.Add(new SqlParameter("@tooLate", _tooLate));
            //End SQL Parameters

            //DB Connection open
            con.Open();

            //Set Result variable
            _result = command.ExecuteNonQuery();

            //Check if result exists
            if (_result > 0)
            {
                //Result Success message
                MessageBox.Show("Verhuring gewijzigd");

                //Clear all inputfields
                txtRentId.Text = "";
                dtRentDate.Value = DateTime.Now;
                txtAmountCars.Text = "";
                txtRentPeriod.Text = "";
                //End Clear all inputfields

                //DB Connection close
                con.Close();
            }
            else
            {
                //Result Fail message
                MessageBox.Show("Verhuring wijzigen niet gelukt");

                //DB Connection close
                con.Close();
            }
            //End Check if result exists

            //Refresh Gridview
            RefreshGridView();
        }
        //End Update Rentals record
        //------------------------------------------------------------

        //Delete Rentals record
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //Fillable Variables
            int _rentId = Convert.ToInt32(txtRentId.Text);
            //End Fillable Variables

            //DB Connection open
            con.Open();

            //SQL String & Command
            cmd =   "DELETE FROM Rentals ";
            cmd +=  "WHERE id = @rentId";
            command = new SqlCommand(cmd, con);
            //End SQL String & Command

            //SQL Parameters
            command.Parameters.Add(new SqlParameter("@rentId", _rentId));

            //Set Result variable
            int _result = command.ExecuteNonQuery();

            //Check if result exists
            if (_result > 0)
            {
                //Result Success message
                MessageBox.Show("Verhuring verwijdert");

                //Clear rentId inputfield
                txtRentId.Text = "";

                //DB Connection close
                con.Close();
            }
            else
            {
                //Result Fail message
                MessageBox.Show("Verhuring verwijderen niet gelukt");

                //DB Connection close
                con.Close();
            }
            //End Check if result exists

            //Refresh Gridview
            RefreshGridView();
        }
        //End Delete Rentals record
        //------------------------------------------------------------

        //Search Rentals record
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Fillable Variables
            int _rentId = Convert.ToInt32(txtRentId.Text);
            //End Fillable Variables

            //DB Connection open
            con.Open();

            //Try select search rent records 
            try
            {
                //SQL String & Command 
                cmd =   "SELECT * ";
                cmd +=  "FROM Rentals ";
                cmd +=  "WHERE id like @rentId";
                command = new SqlCommand(cmd, con);
                SqlDataAdapter da = new SqlDataAdapter(command);
                //End SQL String & Command

                //SQL Parameter
                command.Parameters.Add(new SqlParameter("@rentId", "%" + _rentId));

                //Create Data table & fill it 
                DataTable dt = new DataTable();
                da.Fill(dt);
                //End Create Data table & fill it 

                //Check if row exists
                if (dt.Rows.Count > 0)
                {
                    //Check Success 
                    dgView.DataSource = dt;
                    dgView.Columns[0].Width = 137;
                    dgView.Columns[0].HeaderText = "Verhuurnummer";
                    dgView.Columns[1].Width = 180;
                    dgView.Columns[1].HeaderText = "Verhuurdatum";
                    dgView.Columns[2].Width = 180;
                    dgView.Columns[2].HeaderText = "Aantal auto's";
                    dgView.Columns[3].Width = 180;
                    dgView.Columns[3].HeaderText = "Verhuurperiode in dagen";
                    dgView.Columns[4].Width = 180;
                    dgView.Columns[4].HeaderText = "Te laat";
                    dgView.Columns[5].Width = 150;

                    //DB Connection close
                    con.Close();
                }
                else
                {
                    //Check Fail 
                    //Fail Message 
                    MessageBox.Show("Geen verhuring gevonden");

                    //DB Connection close
                    con.Close();
                }
                //End Check if rows exists
            }
            //End Try select all rent records

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
        //End Search Rentals record
        //------------------------------------------------------------

        //Clear all inputfields
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtRentId.Text = "";
            dtRentDate.Value = DateTime.Now;
            txtAmountCars.Text = "";
            txtRentPeriod.Text = "";
        }
        //End Clear all inputfields
        //------------------------------------------------------------

        //Hide Rentals form
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //End Hide Rentals form
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
