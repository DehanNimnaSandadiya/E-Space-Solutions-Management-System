using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace E_Space_Solutions
{
    public partial class Dependent : KryptonForm
    {
        // Connection String
        private readonly string connectionString = "Data Source=DESKTOP-7N38SB5\\SQLEXPRESS;Initial Catalog=ESpaceSolutions;Integrated Security=True";
        private int selectedDependentId; // To store the ID of the selected dependent

        public Dependent()
        {
            InitializeComponent();
        }

        private void Dependent_Load(object sender, EventArgs e)
        {
            LoadColonists(); 
            LoadDependents(); 
        }

        // DataGrid Show on Application
        private void LoadDependents()
        {
            string query = "SELECT DependentID, DependentName, DateOfBirth, Age, Gender, RelationshipToColonist, ColonistID FROM Dependent"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dependentsTable = new DataTable();
                    adapter.Fill(dependentsTable);

                    // Bind data to DataGridView
                    dependentdataview.DataSource = dependentsTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading dependents: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadColonists()
        {
            string query = "SELECT ColonistID, FirstName + ' ' + LastName AS FullName FROM Colonist"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable colonistsTable = new DataTable();
                    adapter.Fill(colonistsTable);

                   
                    if (colonistsTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No colonists found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                   
                    colonistid.DataSource = colonistsTable;
                    colonistid.DisplayMember = "FullName"; 
                    colonistid.ValueMember = "ColonistID"; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading colonists: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // DATA INSERT SECTION -------------------------------------------------------------------------------------------------------------------------------------

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Getting Inputs
            string dependentName = txtdname.Text.Trim();  // Dependent Name

            // Dependent Name Validation
            if (string.IsNullOrEmpty(dependentName))
            {
                MessageBox.Show("Please enter the dependent's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Date of Birth

            DateTime dateOfBirth = ddob.Value;  
            int age;

            // Age Validation
            if (!int.TryParse(txtdage.Text, out age) || age < 0 || age > 150)  
            {
                MessageBox.Show("Please enter a valid age (between 0 and 150).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gender 

            string gender = dgender.SelectedItem?.ToString();  
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Relationship to Colonist

            string relationshipToColonist = txtdrelationship.Text.Trim(); 
            if (string.IsNullOrEmpty(relationshipToColonist))
            {
                MessageBox.Show("Please enter the relationship to the colonist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Colonist ID Validation

            if (colonistid.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a colonist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int colonistID = Convert.ToInt32(colonistid.SelectedValue);  // Selected Colonist ID (ComboBox)

            // SQL INSERT Command

            string insertQuery = @"INSERT INTO Dependent 
                           (DependentName, DateOfBirth, Age, Gender, RelationshipToColonist, ColonistID) 
                           VALUES (@DependentName, @DateOfBirth, @Age, @Gender, @RelationshipToColonist, @ColonistID)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {

                        command.Parameters.AddWithValue("@DependentName", dependentName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@RelationshipToColonist", relationshipToColonist);
                        command.Parameters.AddWithValue("@ColonistID", colonistID);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dependent added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reload DataGrid
                            LoadDependents();

                            // Clearing Input Fields
                            ClearFormFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add dependent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Clearing Input Fields after Inserting 
        private void ClearFormFields()
        {
            txtdname.Clear();
            txtdage.Clear();
            dgender.SelectedIndex = -1;
            txtdrelationship.Clear();
            colonistid.SelectedIndex = -1;
            ddob.Value = DateTime.Now;
            selectedDependentId = 0; 
        }

        private void dependentdataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dependentdataview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dependentdataview.CurrentRow.Selected = true;
                selectedDependentId = Convert.ToInt32(dependentdataview.Rows[e.RowIndex].Cells["DependentID"].Value); 
                txtdname.Text = dependentdataview.Rows[e.RowIndex].Cells["DependentName"].FormattedValue.ToString();
                ddob.Value = Convert.ToDateTime(dependentdataview.Rows[e.RowIndex].Cells["DateOfBirth"].FormattedValue);
                dgender.Text = dependentdataview.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                txtdage.Text = dependentdataview.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                txtdrelationship.Text = dependentdataview.Rows[e.RowIndex].Cells["RelationshipToColonist"].FormattedValue.ToString();
            }
        }


        // DATA UPDATE SECTION -------------------------------------------------------------------------------------------------------------------------------------

        private void btnupdate_Click(object sender, EventArgs e)
        {
            // Getting Inputs

            string dependentName = txtdname.Text.Trim();
            DateTime dateOfBirth = ddob.Value;
            int age;

            if (string.IsNullOrEmpty(dependentName))
            {
                MessageBox.Show("Please enter the dependent's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtdage.Text, out age) || age < 0 || age > 150)
            {
                MessageBox.Show("Please enter a valid age (between 0 and 150).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string gender = dgender.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string relationshipToColonist = txtdrelationship.Text.Trim();
            if (string.IsNullOrEmpty(relationshipToColonist))
            {
                MessageBox.Show("Please enter the relationship to the colonist.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validating if The Dependent is Selected
            if (selectedDependentId == 0)
            {
                MessageBox.Show("Please select a dependent to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // SQL UPDATE Command
            string updateQuery = @"UPDATE Dependent 
                                   SET DependentName = @DependentName, 
                                       DateOfBirth = @DateOfBirth, 
                                       Age = @Age, 
                                       Gender = @Gender, 
                                       RelationshipToColonist = @RelationshipToColonist 
                                   WHERE DependentID = @DependentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {

                        command.Parameters.AddWithValue("@DependentName", dependentName);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Age", age);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@RelationshipToColonist", relationshipToColonist);
                        command.Parameters.AddWithValue("@DependentID", selectedDependentId); 

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dependent updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reload DataGrid
                            LoadDependents();

                            // Clear Input Fields
                            ClearFormFields(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to update dependent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // DATA DELETE SECTION -------------------------------------------------------------------------------------------------------------------------------------

        private void btndelete_Click(object sender, EventArgs e)
        {
            // Selecting the Dependent
            if (selectedDependentId == 0)
            {
                MessageBox.Show("Please select a dependent to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Delete Confirmation
            var confirmResult = MessageBox.Show("Are you sure you want to delete this dependent?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult != DialogResult.Yes)
                return;

            // SQL DELETE Command

            string deleteQuery = "DELETE FROM Dependent WHERE DependentID = @DependentID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DependentID", selectedDependentId); 

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Dependent deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Reload DataGrid
                            LoadDependents();

                            // Clearing Input Fields
                            ClearFormFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete dependent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
