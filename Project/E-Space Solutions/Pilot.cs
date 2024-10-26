using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace E_Space_Solutions
{
    public partial class Pilot : KryptonForm
    {
        private int selectedPilotID; // Variable to hold the selected PilotID

        private static string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

        public Pilot()
        {
            InitializeComponent();
        }

        private void Pilot_Load(object sender, EventArgs e)
        {
            LoadPilotData(); // Load pilot data
            LoadJetCodes();  // Load jet codes into the ComboBox
        }

        private void LoadJetCodes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT JetCode FROM Jet"; // Query to select JetCode from Jet table
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing items in the ComboBox
                    jetcode.Items.Clear();

                    // Load the JetCodes into the ComboBox
                    while (reader.Read())
                    {
                        jetcode.Items.Add(reader["JetCode"].ToString());
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

        private void LoadPilotData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT PilotID, PilotName, SpaceHours, Qualification, Designation, JetCode FROM Pilot"; // Adjust query as needed
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable); // Fill the DataTable with the results from the query

                    // Bind the DataTable to the DataGridView
                    pilotdataview.DataSource = dataTable; // Assuming pilotdataview is your DataGridView control
                    pilotdataview.Columns["PilotID"].Visible = false; // Hides the PilotID column
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
            // SQL query to insert a new pilot without specifying PilotID
            string query = @"INSERT INTO Pilot (PilotName, SpaceHours, Qualification, Designation, JetCode) 
                             VALUES (@PilotName, @SpaceHours, @Qualification, @Designation, @JetCode)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Validate the inputs
                    if (string.IsNullOrWhiteSpace(txtpname.Text) ||
                        string.IsNullOrWhiteSpace(txtspacehours.Text) ||
                        string.IsNullOrWhiteSpace(txtpqualification.Text) ||
                        string.IsNullOrWhiteSpace(txtpdesignation.Text) ||
                        string.IsNullOrWhiteSpace(jetcode.Text)) // Check for JetCode
                    {
                        MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate SpaceHours as a number
                    long spaceHours;
                    if (!long.TryParse(txtspacehours.Text, out spaceHours) || spaceHours < 0)
                    {
                        MessageBox.Show("Space Hours must be a valid non-negative number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Add the parameters
                    command.Parameters.AddWithValue("@PilotName", txtpname.Text);
                    command.Parameters.AddWithValue("@SpaceHours", spaceHours);
                    command.Parameters.AddWithValue("@Qualification", txtpqualification.Text);
                    command.Parameters.AddWithValue("@Designation", txtpdesignation.Text);
                    command.Parameters.AddWithValue("@JetCode", jetcode.Text); // Include JetCode parameter

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the query
                        int result = command.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (result > 0)
                        {
                            MessageBox.Show("Pilot successfully inserted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPilotData(); // Refresh the DataGridView after inserting a new pilot
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert pilot.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void pilotdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is selected
            if (e.RowIndex >= 0 && pilotdataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Set the selected PilotID
                selectedPilotID = Convert.ToInt32(pilotdataview.Rows[e.RowIndex].Cells["PilotID"].Value);
                txtpname.Text = pilotdataview.Rows[e.RowIndex].Cells["PilotName"].FormattedValue.ToString();
                txtspacehours.Text = pilotdataview.Rows[e.RowIndex].Cells["SpaceHours"].FormattedValue.ToString();
                txtpqualification.Text = pilotdataview.Rows[e.RowIndex].Cells["Qualification"].FormattedValue.ToString();
                txtpdesignation.Text = pilotdataview.Rows[e.RowIndex].Cells["Designation"].FormattedValue.ToString();

                // Set the selected JetCode in the ComboBox
                jetcode.SelectedItem = pilotdataview.Rows[e.RowIndex].Cells["JetCode"].FormattedValue.ToString(); // Assuming JetCode is a column in the pilotdataview
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // SQL query to update the pilot information
            string query = @"UPDATE Pilot 
                             SET PilotName = @PilotName, SpaceHours = @SpaceHours, Qualification = @Qualification, Designation = @Designation, JetCode = @JetCode 
                             WHERE PilotID = @PilotID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Validate the inputs
                    if (string.IsNullOrWhiteSpace(txtpname.Text) ||
                        string.IsNullOrWhiteSpace(txtspacehours.Text) ||
                        string.IsNullOrWhiteSpace(txtpqualification.Text) ||
                        string.IsNullOrWhiteSpace(txtpdesignation.Text) ||
                        string.IsNullOrWhiteSpace(jetcode.Text)) // Check for JetCode
                    {
                        MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate SpaceHours as a number
                    long spaceHours;
                    if (!long.TryParse(txtspacehours.Text, out spaceHours) || spaceHours < 0)
                    {
                        MessageBox.Show("Space Hours must be a valid non-negative number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Add the parameters
                    command.Parameters.AddWithValue("@PilotID", selectedPilotID); // Use the selected PilotID
                    command.Parameters.AddWithValue("@PilotName", txtpname.Text);
                    command.Parameters.AddWithValue("@SpaceHours", spaceHours);
                    command.Parameters.AddWithValue("@Qualification", txtpqualification.Text);
                    command.Parameters.AddWithValue("@Designation", txtpdesignation.Text);
                    command.Parameters.AddWithValue("@JetCode", jetcode.Text); // Include JetCode parameter

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the update query
                        int result = command.ExecuteNonQuery();

                        // Check if the update was successful
                        if (result > 0)
                        {
                            MessageBox.Show("Pilot successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPilotData(); // Refresh the DataGridView after updating
                        }
                        else
                        {
                            MessageBox.Show("Failed to update pilot.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Ensure a pilot is selected for deletion
            if (selectedPilotID == 0)
            {
                MessageBox.Show("Please select a pilot to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm the deletion
            var confirmResult = MessageBox.Show("Are you sure you want to delete this pilot?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // SQL query to delete the selected pilot
                string query = "DELETE FROM Pilot WHERE PilotID = @PilotID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the parameters
                        command.Parameters.AddWithValue("@PilotID", selectedPilotID);

                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Execute the delete query
                            int result = command.ExecuteNonQuery();

                            // Check if the delete was successful
                            if (result > 0)
                            {
                                MessageBox.Show("Pilot successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadPilotData(); // Refresh the DataGridView after deletion
                                ClearInputFields(); // Clear the input fields after deletion
                            }
                            else
                            {
                                MessageBox.Show("Failed to delete pilot.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }

        private void ClearInputFields()
        {
            // Clears the input fields after deletion
            txtpname.Clear();
            txtspacehours.Clear();
            txtpqualification.Clear();
            txtpdesignation.Clear();
            jetcode.SelectedItem = null; // Clear JetCode selection
            selectedPilotID = 0; // Reset the selected PilotID
        }

        private void jetcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optionally handle any logic if JetCode selection changes
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
