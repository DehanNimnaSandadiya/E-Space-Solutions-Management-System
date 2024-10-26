using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace E_Space_Solutions
{
    public partial class Jet : KryptonForm
    {
        private string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";

        public Jet()
        {
            InitializeComponent();
        }

        private void Jet_Load(object sender, EventArgs e)
        {
            LoadJetData();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            InsertJetData();
        }

        private void UpdateJetData()
        {
            try
            {
                string jetCode = txtjetcode.Text;
                int passengerSeats = int.Parse(txtpseats.Text);
                string engineType = txtenginetype.SelectedItem?.ToString();
                int? madeYear = string.IsNullOrWhiteSpace(txtmodelyear.Text) ? (int?)null : int.Parse(txtmodelyear.Text);
                decimal weight = decimal.Parse(txtweight.Text);
                string powerSource = txtpowersource.Text;

                UpdateJet(jetCode, passengerSeats, engineType, madeYear, weight, powerSource);

                MessageBox.Show("Jet information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateJet(string jetCode, int passengerSeats, string engineType, int? madeYear, decimal weight, string powerSource)
        {
            string query = "UPDATE Jet SET PassengerSeats = @PassengerSeats, EngineType = @EngineType, MadeYear = @MadeYear, Weight = @Weight, PowerSource = @PowerSource " +
                           "WHERE JetCode = @JetCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@JetCode", jetCode);
                    command.Parameters.AddWithValue("@PassengerSeats", passengerSeats);
                    command.Parameters.AddWithValue("@EngineType", string.IsNullOrEmpty(engineType) ? (object)DBNull.Value : engineType);
                    command.Parameters.AddWithValue("@MadeYear", madeYear.HasValue ? madeYear.Value : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Weight", weight);
                    command.Parameters.AddWithValue("@PowerSource", powerSource);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            LoadJetData();
        }

        private void InsertJetData()
        {
            try
            {
                string jetCode = txtjetcode.Text;
                int passengerSeats = int.Parse(txtpseats.Text);
                string engineType = txtenginetype.SelectedItem?.ToString();
                int? madeYear = string.IsNullOrWhiteSpace(txtmodelyear.Text) ? (int?)null : int.Parse(txtmodelyear.Text);
                decimal weight = decimal.Parse(txtweight.Text);
                string powerSource = txtpowersource.Text;

                InsertJet(jetCode, passengerSeats, engineType, madeYear, weight, powerSource);

                MessageBox.Show("Jet information inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertJet(string jetCode, int passengerSeats, string engineType, int? madeYear, decimal weight, string powerSource)
        {
            string query = "INSERT INTO Jet (JetCode, PassengerSeats, EngineType, MadeYear, Weight, PowerSource) " +
                           "VALUES (@JetCode, @PassengerSeats, @EngineType, @MadeYear, @Weight, @PowerSource)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@JetCode", jetCode);
                    command.Parameters.AddWithValue("@PassengerSeats", passengerSeats);
                    command.Parameters.AddWithValue("@EngineType", string.IsNullOrEmpty(engineType) ? (object)DBNull.Value : engineType);
                    command.Parameters.AddWithValue("@MadeYear", madeYear.HasValue ? madeYear.Value : (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Weight", weight);
                    command.Parameters.AddWithValue("@PowerSource", powerSource);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            LoadJetData();
        }

        private void LoadJetData()
        {
            string query = "SELECT JetCode, PassengerSeats, EngineType, MadeYear, Weight, PowerSource FROM Jet";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        pilotdataview.DataSource = dataTable;
                    }
                }
            }
        }

        private void ClearForm()
        {
            txtjetcode.Clear();
            txtpseats.Clear();
            txtenginetype.SelectedIndex = -1;
            txtmodelyear.Clear();
            txtweight.Clear();
            txtpowersource.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateJetData();
        }

       

        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteJetData();
        }

        // Method to delete data from the database
        private void DeleteJetData()
        {
            try
            {
                string jetCode = txtjetcode.Text; // Retrieve the JetCode from the input field

                // Confirm deletion with the user
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this jet record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteJet(jetCode);
                    MessageBox.Show("Jet information deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm(); // Clear the form fields after deletion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to delete a jet record from the database
        private void DeleteJet(string jetCode)
        {
            string query = "DELETE FROM Jet WHERE JetCode = @JetCode";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@JetCode", jetCode);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            // Reload data into the DataGridView after deletion
            LoadJetData();
        }

        private void pilotdataview_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Populate form fields with the selected row's data
            if (e.RowIndex >= 0 && pilotdataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                DataGridViewRow row = pilotdataview.Rows[e.RowIndex];
                txtjetcode.Text = row.Cells["JetCode"].Value.ToString();
                txtpseats.Text = row.Cells["PassengerSeats"].Value.ToString();
                txtenginetype.SelectedItem = row.Cells["EngineType"].Value.ToString();
                txtmodelyear.Text = row.Cells["MadeYear"].Value.ToString();
                txtweight.Text = row.Cells["Weight"].Value.ToString();
                txtpowersource.Text = row.Cells["PowerSource"].Value.ToString();
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
