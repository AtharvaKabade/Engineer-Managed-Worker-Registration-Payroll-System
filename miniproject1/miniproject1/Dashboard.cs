using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data.SqlClient;


namespace miniproject1
{
    public partial class Dashboard : Form
    {
        // Define the connection string
        private string connectionString = "Data Source=DESKTOP-GOMOOL3;Initial Catalog=worker;Integrated Security=True";

        private bool canClose = true; // Flag to control form closing

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void idText_TextChanged(object sender, EventArgs e)
        {
            string idInput = idText.Text.Trim();

            if (!int.TryParse(idInput, out _))
            {
                MessageBox.Show("ID must be an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally, clear the TextBox or take other actions to handle the invalid input
            }
        }

        private void ValidateTextBox(TextBox textBox, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                canClose = false;
            }
            else
            {
                canClose = true;
            }
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(nameText, "Name cannot be empty");
        }

        private void ValidateEmailBox(TextBox textBox, string errorMessage)
        {
            string email = emailText.Text.Trim().ToLower(); // Convert to lowercase for case-insensitive comparison

            // Check if the email ends with "@gmail.com"
            if (email.EndsWith("@gmail.com"))
            {
                // Perform the full email validation
                Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                if (!emailRegex.IsMatch(email))
                {
                    MessageBox.Show("Invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    canClose = false;
                   
                }
                else
                {
                    canClose = true;
                }
            }
        }

        private void emailText_TextChanged(object sender, EventArgs e)
        {
            ValidateEmailBox(emailText, "Email cannot be empty");
        }


        private void ValidatePhoneBox(TextBox textBox, string errorMessage)
        {
            
            string phoneNumber = phoneText.Text.Trim();

            // Check if the length is exactly 10 characters
            if (phoneNumber.Length == 10)
            {
                // Check if the string consists of numeric characters
                if (phoneNumber.All(char.IsDigit))
                {
                    // If the code reaches here, the phone number is valid
                    canClose = true;
                }
                else
                {
                    MessageBox.Show("Phone number must contain only digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    canClose = false;
                }
            }
            else
            {
                canClose = false;
            }
        }


        private void phoneText_TextChanged(object sender, EventArgs e)
        {
            ValidatePhoneBox(phoneText, "Phone number cannot be empty");
        }





        private void ageText_TextChanged(object sender, EventArgs e)
        {
            int age;
            if (!int.TryParse(ageText.Text, out age) || age <= 0)
            {
                MessageBox.Show("Age must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                canClose = false;
            }
            else
            {
                canClose = true;
            }
        }


        private bool ValidateEmail(string email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!emailRegex.IsMatch(email))
            {
                MessageBox.Show("Invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!canClose) // Check flag before closing
            {
                e.Cancel = true; // Prevent closing if validation failed
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if a category is selected
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an INSERT query based on the selected category
            string category = comboBox1.SelectedItem.ToString();
            string insertQuery = "";

            switch (category)
            {
                case "Engineer":
                    insertQuery = "INSERT INTO engineer (Id, Name, Email, PhoneNo, Age) VALUES (@Id, @Name, @Email, @PhoneNo, @Age)";
                    break;
                case "Centring":
                    insertQuery = "INSERT INTO centring (Id, Name, Email, PhoneNO, Age) VALUES (@Id, @Name, @Email, @PhoneNo, @Age)";
                    break;
                case "Worker":
                    insertQuery = "INSERT INTO worker (Id, Name, Email, PhoneNo, Age) VALUES (@Id, @Name, @Email, @PhoneNo, @Age)";
                    break;

                default:
                    MessageBox.Show("Invalid category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Insert data into the database
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@Id", idText.Text);
                        command.Parameters.AddWithValue("@Name", nameText.Text);
                        command.Parameters.AddWithValue("@Email", emailText.Text);
                        command.Parameters.AddWithValue("@PhoneNo", phoneText.Text);
                        command.Parameters.AddWithValue("@Age", ageText.Text);

                        // Execute the command
                        command.ExecuteNonQuery();

                        MessageBox.Show("Data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            workDetail work = new workDetail();
            work.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            workDetail work = new workDetail();
            work.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
