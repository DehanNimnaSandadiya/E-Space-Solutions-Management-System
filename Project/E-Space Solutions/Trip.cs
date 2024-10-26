using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace E_Space_Solutions
{
    public partial class Trip : KryptonForm
    {
        private string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True"; // Replace with your actual connection string

        public Trip()
        {
            InitializeComponent();
        }

        private void Trip_Load(object sender, EventArgs e)
        {
            LoadJetCodes(); // Load JetCodes into the ComboBox when the form loads
            LoadTripData(); // Load trip data into the DataGridView when the form loads
        }

        private void LoadJetCodes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT JetCode FROM Jet"; // Adjust this query based on your JetCodes table structure
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboJetCodes.Items.Add(reader["JetCode"].ToString()); // Add JetCode to the ComboBox
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                int tripID = int.Parse(txttid.Text); // Ensure this is the correct textbox name
                DateTime launchDate = ldate.Value; // Ensure this is the correct datepicker
                DateTime returnDate = rdate.Value; // Ensure this is the correct datepicker
                string selectedJetCode = comboJetCodes.SelectedItem?.ToString(); // Get selected JetCode from ComboBox

                InsertTripData(tripID, launchDate, returnDate, selectedJetCode); // Call the data insertion method
                LoadTripData(); // Refresh the DataGridView after inserting data
            }
            else
            {
                MessageBox.Show("Please enter valid data for all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputFields()
        {
            if (!int.TryParse(txttid.Text, out _))
            {
                MessageBox.Show("Trip ID must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ldate.Value < DateTime.Now)
            {
                MessageBox.Show("Launch date must be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (rdate.Value <= ldate.Value) // Corrected the comparison here
            {
                MessageBox.Show("Return date must be after launch date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboJetCodes.SelectedItem == null) // Ensure a JetCode is selected
            {
                MessageBox.Show("Please select a JetCode.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All validations passed
        }

        private void InsertTripData(int tripID, DateTime launchDate, DateTime returnDate, string jetCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TRIP (TripID, LaunchDate, ReturnDate, JetCode) VALUES (@TripID, @LaunchDate, @ReturnDate, @JetCode)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TripID", tripID);
                    command.Parameters.AddWithValue("@LaunchDate", launchDate);
                    command.Parameters.AddWithValue("@ReturnDate", returnDate);
                    command.Parameters.AddWithValue("@JetCode", jetCode); // Add JetCode parameter

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Trip data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadTripData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TripID, LaunchDate, ReturnDate, JetCode FROM TRIP"; // Adjust the query to include JetCode
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable); // Fill the DataTable with the results from the query

                    // Bind the DataTable to the DataGridView
                    tripdataview.DataSource = dataTable; // Assuming tripdataview is your DataGridView control
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tripdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is selected
            if (e.RowIndex >= 0 && tripdataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Set the selected TripID
                txttid.Text = tripdataview.Rows[e.RowIndex].Cells["TripID"].FormattedValue.ToString();
                ldate.Value = Convert.ToDateTime(tripdataview.Rows[e.RowIndex].Cells["LaunchDate"].FormattedValue); // Fixed to assign to DateTimePicker
                rdate.Value = Convert.ToDateTime(tripdataview.Rows[e.RowIndex].Cells["ReturnDate"].FormattedValue); // Fixed to assign to DateTimePicker
                comboJetCodes.Text = tripdataview.Rows[e.RowIndex].Cells["JetCode"].FormattedValue.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (ValidateInputFields())
            {
                int tripID = int.Parse(txttid.Text); // TripID must be entered
                DateTime launchDate = ldate.Value; // LaunchDate from DateTimePicker
                DateTime returnDate = rdate.Value; // ReturnDate from DateTimePicker
                string selectedJetCode = comboJetCodes.SelectedItem?.ToString(); // Get selected JetCode from ComboBox

                UpdateTripData(tripID, launchDate, returnDate, selectedJetCode); // Call the update method
                LoadTripData(); // Refresh the DataGridView after updating data
            }
            else
            {
                MessageBox.Show("Please enter valid data for all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTripData(int tripID, DateTime launchDate, DateTime returnDate, string jetCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE TRIP SET LaunchDate = @LaunchDate, ReturnDate = @ReturnDate, JetCode = @JetCode WHERE TripID = @TripID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TripID", tripID);
                    command.Parameters.AddWithValue("@LaunchDate", launchDate);
                    command.Parameters.AddWithValue("@ReturnDate", returnDate);
                    command.Parameters.AddWithValue("@JetCode", jetCode); // Update JetCode

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trip data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No trip found with the specified Trip ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttid.Text))
            {
                MessageBox.Show("Please select a trip to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tripID = int.Parse(txttid.Text); // Get the Trip ID from the textbox
            DeleteTripData(tripID); // Call the delete method
            LoadTripData(); // Refresh the DataGridView after deleting data
        }

        private void DeleteTripData(int tripID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM TRIP WHERE TripID = @TripID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TripID", tripID); // Add TripID parameter

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trip data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No trip found with the specified Trip ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show("SQL Error: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
