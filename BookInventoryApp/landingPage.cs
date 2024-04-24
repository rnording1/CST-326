using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInventoryApp
{
    public partial class landingPage : Form
    {
        public landingPage()
        {
            InitializeComponent();
        }

        private void landingPage_Load(object sender, EventArgs e)
        {
            LoadBooksIntoDataGridView();
        }

        private void LoadBooksIntoDataGridView()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    BookName AS Title, 
                    Author, 
                    Category, 
                    PublishedYear AS [Year Published], 
                    ISBN, 
                    InventoryQty AS Quantity
                FROM Books";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }


    }
}
