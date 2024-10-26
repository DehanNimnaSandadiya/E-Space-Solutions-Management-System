using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace E_Space_Solutions
{
    public partial class HouseForm : KryptonForm // Renamed class to HouseForm for clarity
    {
        private string _connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

        public HouseForm()
        {
            InitializeComponent();
        }

        private void HouseForm_Load(object sender, EventArgs e)
        {
            LoadHouseData(); // Load data when the form loads
        }

        private void LoadHouseData()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM House"; // Select all records from House table
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        tripdataview.DataSource = dataTable; // Set the DataGridView's data source
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading house data: " + ex.Message);
                }
            }
        }

        private void InsertHouseData(int lotNumber, int numberOfRooms, decimal squareFeet, int? colonistsAssigned)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO House (LotNumber, NumberOfRooms, SquareFeet, ColonistsAssigned) VALUES (@LotNumber, @NumberOfRooms, @SquareFeet, @ColonistsAssigned)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LotNumber", lotNumber);
                        command.Parameters.AddWithValue("@NumberOfRooms", numberOfRooms);
                        command.Parameters.AddWithValue("@SquareFeet", squareFeet);
                        command.Parameters.AddWithValue("@ColonistsAssigned", (object)colonistsAssigned ?? DBNull.Value); // Handle nullable parameter

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting house data: " + ex.Message);
                }
            }
        }

        private void UpdateHouseData(int lotNumber, int numberOfRooms, decimal squareFeet, int? colonistsAssigned)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE House SET NumberOfRooms = @NumberOfRooms, SquareFeet = @SquareFeet, ColonistsAssigned = @ColonistsAssigned WHERE LotNumber = @LotNumber";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LotNumber", lotNumber);
                        command.Parameters.AddWithValue("@NumberOfRooms", numberOfRooms);
                        command.Parameters.AddWithValue("@SquareFeet", squareFeet);
                        command.Parameters.AddWithValue("@ColonistsAssigned", (object)colonistsAssigned ?? DBNull.Value); // Handle nullable parameter

                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating house data: " + ex.Message);
                }
            }
        }

        private void DeleteHouseData(int lotNumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM House WHERE LotNumber = @LotNumber";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LotNumber", lotNumber);
                        command.ExecuteNonQuery();
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Database error: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting house data: " + ex.Message);
                }
            }
        }

        private void ClearForm()  // Optional method to clear form fields after successful insertion
        {
            txtlnumber.Text = "";
            txtnor.Text = "";
            txtsf.Text = "";
            txtca.Text = "";
        }

 

        private void btnlogin_Click(object sender, EventArgs e)
        {
            int lotNumber;
            int numberOfRooms;
            decimal squareFeet;
            int? colonistsAssigned;  // Declare as nullable integer

            try
            {
                // Get data from form elements
                lotNumber = int.Parse(txtlnumber.Text);
                numberOfRooms = int.Parse(txtnor.Text);
                squareFeet = decimal.Parse(txtsf.Text);
                colonistsAssigned = string.IsNullOrWhiteSpace(txtca.Text) ? (int?)null : int.Parse(txtca.Text);  // Handle empty ColonistAssigned input

                // Validate data
                if (colonistsAssigned > 4)
                {
                    MessageBox.Show("Colonists assigned cannot exceed 4.");
                    return;
                }

                InsertHouseData(lotNumber, numberOfRooms, squareFeet, colonistsAssigned);
                LoadHouseData(); // Refresh data grid after insert
                MessageBox.Show("House data inserted successfully!");
                ClearForm();  // Clear form fields after successful insertion (optional)
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter valid numbers for Lot Number, Number of Rooms, and Square Feet.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting house data: " + ex.Message);
            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            int lotNumber;
            int numberOfRooms;
            decimal squareFeet;
            int? colonistsAssigned;

            try
            {
                // Get data from form elements
                lotNumber = int.Parse(txtlnumber.Text);
                numberOfRooms = int.Parse(txtnor.Text);
                squareFeet = decimal.Parse(txtsf.Text);
                colonistsAssigned = string.IsNullOrWhiteSpace(txtca.Text) ? (int?)null : int.Parse(txtca.Text);  // Handle empty ColonistAssigned input

                // Validate data
                if (colonistsAssigned > 4)
                {
                    MessageBox.Show("Colonists assigned cannot exceed 4.");
                    return;
                }

                UpdateHouseData(lotNumber, numberOfRooms, squareFeet, colonistsAssigned);
                LoadHouseData(); // Refresh data grid after update
                MessageBox.Show("House data updated successfully!");
                ClearForm();  // Clear form fields after successful update (optional)
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter valid numbers for Lot Number, Number of Rooms, and Square Feet.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating house data: " + ex.Message);
            }
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            if (tripdataview.SelectedRows.Count > 0) // Check if any row is selected
            {
                int lotNumber = Convert.ToInt32(tripdataview.SelectedRows[0].Cells["LotNumber"].Value); // Get selected lot number

                var confirmResult = MessageBox.Show("Are you sure to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DeleteHouseData(lotNumber);
                    LoadHouseData(); // Refresh data grid after delete
                    MessageBox.Show("House data deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.");
            }
        }

        private void tripdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is selected
            if (e.RowIndex >= 0 && tripdataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Set the selected TripID
                txtlnumber.Text = tripdataview.Rows[e.RowIndex].Cells["LotNumber"].FormattedValue.ToString();
                txtca.Text = tripdataview.Rows[e.RowIndex].Cells["ColonistsAssigned"].FormattedValue.ToString();
                txtnor.Text = tripdataview.Rows[e.RowIndex].Cells["NumberOfRooms"].FormattedValue.ToString();
                txtsf.Text = tripdataview.Rows[e.RowIndex].Cells["SquareFeet"].FormattedValue.ToString();
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
