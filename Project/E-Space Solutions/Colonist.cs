using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;

namespace E_Space_Solutions
{
    public partial class Colonist : KryptonForm
    {

        private DataTable colonistsDataTable; // Store the data table for later use

        public Colonist()
        {
            InitializeComponent();
        }

        private void Colonist_Load(object sender, EventArgs e)
        {
            LoadColonistsData();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Connection String
            string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL INSERT Command
                    string query = @"INSERT INTO Colonist (FirstName, LastName, Surname, EarthAddress, DateOfBirth, Age, Gender, Qualification, ContactNo, CivilStatus, FamilyCount, IsBringingFamily)
                                     VALUES (@FirstName, @LastName, @Surname, @EarthAddress, @DateOfBirth, @Age, @Gender, @Qualification, @ContactNo, @CivilStatus, @FamilyCount, @IsBringingFamily)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@FirstName", txtfname.Text);
                        command.Parameters.AddWithValue("@LastName", txtlname.Text);
                        command.Parameters.AddWithValue("@Surname", txtsname.Text);
                        command.Parameters.AddWithValue("@EarthAddress", txtearthaddress.Text);

                        // Date String to DATETIME Conversion
                        if (!DateTime.TryParse(date.Text, out DateTime dateOfBirth))
                        {
                            MessageBox.Show("Please enter a valid date of birth.");
                            return;
                        }
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);  // Assuming DateOfBirth is a DATE type

                        // Age Input Validation
                        if (!int.TryParse(txtage.Text, out int age) || age < 0)
                        {
                            MessageBox.Show("Please enter a valid age.");
                            return;
                        }
                        command.Parameters.AddWithValue("@Age", age);

                        // Gender Validation
                        string genderValue = gender.SelectedItem != null ? gender.SelectedItem.ToString() : null;
                        if (genderValue != null && genderValue.Length > 1)
                        {
                            genderValue = genderValue.Substring(0, 1);  // Limit to the first character
                        }
                        command.Parameters.AddWithValue("@Gender", genderValue);

                        command.Parameters.AddWithValue("@Qualification", txtqualification.Text);
                        command.Parameters.AddWithValue("@ContactNo", txtcn.Text);

                        // Civil Status Validation
                        command.Parameters.AddWithValue("@CivilStatus", civilstatus.SelectedItem != null ? civilstatus.SelectedItem.ToString() : null);

                        // Family Count
                        if (!int.TryParse(txtfamilycount.Text, out int familyCount) || familyCount < 0)
                        {
                            MessageBox.Show("Please enter a valid family member count.");
                            return;
                        }
                        command.Parameters.AddWithValue("@FamilyCount", familyCount);

                        //
                        command.Parameters.AddWithValue("@IsBringingFamily", familycheck.Checked);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                        }

                        // Reload DataGrid
                        LoadColonistsData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close(); // Disconnecting Connection if an Error Occurs
                }
            }    }

        private string GenerateRegistrationNumber()
        {
            // Automatically Genarating a Registration Number
            return Guid.NewGuid().ToString();
        }

        private void LoadColonistsData()
        {
            string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Colonist";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        colonistsDataTable = new DataTable();
                        adapter.Fill(colonistsDataTable);

                        colonistdataview.DataSource = colonistsDataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Selecting the Specific Row
            if (colonistdataview.SelectedRows.Count > 0)
            {
                // Selecting Row by Colonist ID
                string selectedRegistrationNumber = colonistdataview.SelectedRows[0].Cells["ColonistID"].Value.ToString();

                // Connection string
                string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // SQL UPDATE Command
                        string query = @"UPDATE Colonist
                                 SET FirstName = @FirstName, 
                                     LastName = @LastName, 
                                     Surname = @Surname, 
                                     EarthAddress = @EarthAddress, 
                                     DateOfBirth = @DateOfBirth, 
                                     Age = @Age, 
                                     Gender = @Gender, 
                                     Qualification = @Qualification, 
                                     ContactNo = @ContactNo, 
                                     CivilStatus = @CivilStatus, 
                                     FamilyCount = @FamilyCount, 
                                     IsBringingFamily = @IsBringingFamily
                                 WHERE ColonistID = @ColonistID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {

                            command.Parameters.AddWithValue("@FirstName", txtfname.Text ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@LastName", txtlname.Text ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@Surname", txtsname.Text ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@EarthAddress", txtearthaddress.Text ?? (object)DBNull.Value);

                            // Date String to DATETIME Conversion
                            if (!DateTime.TryParse(date.Text, out DateTime dateOfBirth))
                            {
                                MessageBox.Show("Please enter a valid date of birth.");
                                return;
                            }
                            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                            // Age Input Validation
                            if (!int.TryParse(txtage.Text, out int age) || age < 0)
                            {
                                MessageBox.Show("Please enter a valid age.");
                                return;
                            }
                            command.Parameters.AddWithValue("@Age", age);

                            // Gender Validation
                            string genderValue = gender.SelectedItem != null ? gender.SelectedItem.ToString() : null;
                            if (string.IsNullOrEmpty(genderValue))
                            {
                                command.Parameters.AddWithValue("@Gender", DBNull.Value); // Set to null if not provided
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@Gender", genderValue);
                            }


                            command.Parameters.AddWithValue("@Qualification", txtqualification.Text ?? (object)DBNull.Value);
                            command.Parameters.AddWithValue("@ContactNo", txtcn.Text ?? (object)DBNull.Value);

                            // Civil Status Validation
                            if (civilstatus.SelectedItem == null)
                            {
                                command.Parameters.AddWithValue("@CivilStatus", DBNull.Value);
                            }
                            else
                            {
                                command.Parameters.AddWithValue("@CivilStatus", civilstatus.SelectedItem.ToString());
                            }

                            // Family Count
                            if (!int.TryParse(txtfamilycount.Text, out int familyCount) || familyCount < 0)
                            {
                                MessageBox.Show("Please enter a valid family member count.");
                                return;
                            }
                            command.Parameters.AddWithValue("@FamilyCount", familyCount);

                            //  Checking "Is Bringing Family ?"
                            command.Parameters.AddWithValue("@IsBringingFamily", familycheck.Checked);

                            // Finding the Specific Row by Colonist ID
                            command.Parameters.AddWithValue("@ColonistID", selectedRegistrationNumber);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data updated successfully!");

                                // Reload DataGrid
                                LoadColonistsData();

                            }
                            else
                            {
                                MessageBox.Show("Update failed. Please ensure the record exists.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close(); //  Disconnecting Connection if an Error Occurs
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void colonistdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (colonistdataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                colonistdataview.CurrentRow.Selected = true;
                txtfname.Text = colonistdataview.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString();
                txtlname.Text = colonistdataview.Rows[e.RowIndex].Cells["LastName"].FormattedValue.ToString();
                txtsname.Text = colonistdataview.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
                txtearthaddress.Text = colonistdataview.Rows[e.RowIndex].Cells["EarthAddress"].FormattedValue.ToString();
                date.Text = colonistdataview.Rows[e.RowIndex].Cells["DateOfBirth"].FormattedValue.ToString();
                txtage.Text = colonistdataview.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                gender.Text = colonistdataview.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                txtqualification.Text = colonistdataview.Rows[e.RowIndex].Cells["Qualification"].FormattedValue.ToString();
                txtcn.Text = colonistdataview.Rows[e.RowIndex].Cells["ContactNo"].FormattedValue.ToString();
                civilstatus.Text = colonistdataview.Rows[e.RowIndex].Cells["CivilStatus"].FormattedValue.ToString();
                txtfamilycount.Text = colonistdataview.Rows[e.RowIndex].Cells["FamilyCount"].FormattedValue.ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Select the Row
            if (colonistdataview.SelectedRows.Count > 0)
            {
                // Selecting the Row by Colonist ID
                string selectedRegistrationNumber = colonistdataview.SelectedRows[0].Cells["ColonistID"].Value.ToString();

                // Confirmation Message
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Connection string
                    string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            // SQL DELETE Command
                            string query = @"DELETE FROM Colonist WHERE ColonistID = @ColonistID";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Identifying the Record by Colonist ID
                                command.Parameters.AddWithValue("@ColonistID", selectedRegistrationNumber);

                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Record deleted successfully!");

                                    // Reload DataGrid
                                    LoadColonistsData();

                                }
                                else
                                {
                                    MessageBox.Show("Delete failed. The record may not exist.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                        finally
                        {
                            connection.Close(); // Disconnecting Connection if an Error Occurs
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
    }
