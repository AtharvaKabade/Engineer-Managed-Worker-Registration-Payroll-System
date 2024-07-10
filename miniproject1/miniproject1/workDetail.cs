using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace miniproject1
{
    public partial class workDetail : Form
    {
        // Define DataTables for each type of data
        DataTable engineerTable;
        DataTable centringTable;
        DataTable workerTable;

        // Connection string for your database
        string connectionString = "Data Source=DESKTOP-GOMOOL3;Initial Catalog=worker;Integrated Security=True;";

        public workDetail()
        {
            InitializeComponent();

            // Initialize DataTables
            engineerTable = new DataTable();
            centringTable = new DataTable();
            workerTable = new DataTable();
        }

        private void Engineer_Click(object sender, EventArgs e)
        {
            // Fetch data for engineers from the database
            FetchData("SELECT * FROM Engineer", engineerTable);
            // Display engineerTable in DataGridView
            dataGridView1.DataSource = engineerTable;
        }

        private void Centring_Click(object sender, EventArgs e)
        {
            // Fetch data for centring from the database
            FetchData("SELECT * FROM Centring", centringTable);
            // Display centringTable in DataGridView
            dataGridView1.DataSource = centringTable;
        }

        private void Worker_Click(object sender, EventArgs e)
        {
            // Fetch data for workers from the database
            FetchData("SELECT * FROM Worker", workerTable);
            // Display workerTable in DataGridView
            dataGridView1.DataSource = workerTable;
        }

        private void FetchData(string query, DataTable dataTable)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                
                dataTable.Clear();
                
                adapter.Fill(dataTable);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is a button cell and if it belongs to a specific column
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Assuming the first column is a button column for editing
                if (dataGridView1.Columns[e.ColumnIndex].Name == "EditColumn")
                {
                    // Perform edit action based on the row clicked
                    int rowIndex = e.RowIndex;
                    // Example: Display a message with the ID of the row clicked
                    MessageBox.Show("Edit button clicked for row with ID: " + dataGridView1.Rows[rowIndex].Cells["ID"].Value.ToString());
                }
                // You can add more conditions for other buttons or columns if needed
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteFromDatabase(string id, string tableName)
        {
            // Implement your logic to delete from the specified table using the provided ID
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"DELETE FROM {tableName} WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                string id = dataGridView1.Rows[rowIndex].Cells["ID"].Value.ToString();
                string tableName = "";

                // Determine the table name based on which button was clicked
                if (dataGridView1.DataSource == engineerTable)
                    tableName = "Engineer";
                else if (dataGridView1.DataSource == centringTable)
                    tableName = "Centring";
                else if (dataGridView1.DataSource == workerTable)
                    tableName = "Worker";

                DeleteFromDatabase(id, tableName);

                // Refresh the DataGridView
                FetchData($"SELECT * FROM {tableName}", dataGridView1.DataSource as DataTable);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                string id = dataGridView1.Rows[rowIndex].Cells["ID"].Value.ToString();
                
                MessageBox.Show("Update button clicked for row with ID: " + id);
            }
        }

    }
}
