using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerDataApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData(); // Load data when the form loads
        }

        private void LoadCustomerData()
        {
            // Define the connection string
            string connectionString = "Data Source=DESKTOP-H92GP94\\SQLEXPRESS02;Initial Catalog=CustomerDB;Integrated Security=True";

            // Create a connection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Define the query
                    string query = "SELECT * FROM CustomerTable";

                    // Create a command object
                    SqlCommand command = new SqlCommand(query, connection);

                    // Use a data adapter to fetch data
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Use a dataset to hold the data
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    // Bind the data to the DataGridView
                    dgvCustomer.DataSource = dataSet.Tables[0];
                }
                catch (Exception ex)
                {
                    // Show an error message if something goes wrong
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
