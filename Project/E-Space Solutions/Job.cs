using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace E_Space_Solutions
{
    public partial class Job : KryptonForm
    {
        public Job()
        {
            InitializeComponent();
        }

        private void Job_Load(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    LoadColonistIDs(connection);
                    LoadTripIDs(connection);
                    LoadJobsData(connection); // Load existing job data into DataGridView on form load
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void LoadColonistIDs(SqlConnection connection)
        {
            // Query to retrieve Colonist IDs
            string colonistQuery = "SELECT ColonistID FROM Colonist"; // Ensure the table name is correct
            using (SqlCommand command = new SqlCommand(colonistQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["ColonistID"] != DBNull.Value)
                        {
                            int colonistID = reader.GetInt32(0);
                            colonistid.Items.Add(colonistID);
                        }
                    }
                }
            }
        }

        private void LoadTripIDs(SqlConnection connection)
        {
            // Query to retrieve Trip IDs
            string tripQuery = "SELECT TripID FROM Trip"; // Ensure the table name is correct
            using (SqlCommand command = new SqlCommand(tripQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["TripID"] != DBNull.Value)
                        {
                            int tripID = reader.GetInt32(0);
                            tripid.Items.Add(tripID);
                        }
                    }
                }
            }
        }

        private void LoadJobsData(SqlConnection connection)
        {
            // Query to retrieve data from the Job table
            string selectQuery = "SELECT ColonistID, TripID, JobName, JobID FROM Job"; // Ensure the table name is correct
            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable); // Fill the DataTable with the result set
                    jetdataview.DataSource = dataTable; // Bind the DataTable to the DataGridView
                }
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve selected values from combo boxes
                    int selectedColonistID = (int)colonistid.SelectedItem; // Assuming this is an integer
                    int selectedTripID = (int)tripid.SelectedItem; // Assuming this is an integer

                    // Insert query to add a record to Job
                    string insertQuery = "INSERT INTO Job (ColonistID, TripID, JobName, JobID) VALUES (@ColonistID, @TripID, @JobName, @JobID)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@ColonistID", selectedColonistID);
                        command.Parameters.AddWithValue("@TripID", selectedTripID);
                        command.Parameters.AddWithValue("@JobName", txtjname.Text);
                        command.Parameters.AddWithValue("@JobID", txtjid.Text); // Add JobID parameter

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                            LoadJobsData(connection); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No data was inserted.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Update query to modify a record in Job table
                    string updateQuery = "UPDATE Job SET ColonistID = @ColonistID, TripID = @TripID, JobName = @JobName WHERE JobID = @JobID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@ColonistID", int.Parse(colonistid.Text));
                        command.Parameters.AddWithValue("@TripID", int.Parse(tripid.Text));
                        command.Parameters.AddWithValue("@JobName", txtjname.Text);
                        command.Parameters.AddWithValue("@JobID", txtjid.Text); // Add JobID parameter

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                            LoadJobsData(connection); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No data was updated.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

            // Ensure the JobID is not empty before attempting to delete
            if (string.IsNullOrEmpty(txtjid.Text))
            {
                MessageBox.Show("Please select a job to delete.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Delete query to remove a record from Job table
                    string deleteQuery = "DELETE FROM Job WHERE JobID = @JobID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@JobID", txtjid.Text); // Add JobID parameter

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully!");
                            LoadJobsData(connection); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No data was deleted.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void jetdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate form fields with the selected row's data
            if (e.RowIndex >= 0 && jetdataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = jetdataview.Rows[e.RowIndex];
                txtjid.Text = row.Cells["JobID"].Value.ToString();
                txtjname.Text = row.Cells["JobName"].Value.ToString();
                colonistid.Text = jetdataview.Rows[e.RowIndex].Cells["ColonistID"].FormattedValue.ToString();
                tripid.Text = jetdataview.Rows[e.RowIndex].Cells["TripID"].FormattedValue.ToString();
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
