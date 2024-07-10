using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniproject1
{
    public partial class deleteWork : Form
    {
        string connectionString = "Data Source=DESKTOP-GOMOOL3;Initial Catalog=worker;Integrated Security=True";

        public deleteWork()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected category and ID
            string category = comboBox1.SelectedItem.ToString();
            int id;
            if (!int.TryParse(textBox1.Text, out id))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            // Construct the DELETE query
            string query = $"DELETE FROM {category} WHERE ID = @ID";

            // Execute the query
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No data found for the given ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message);
            }
        }

        private void deleteWork_Load(object sender, EventArgs e)
        {

        }
    }
}
