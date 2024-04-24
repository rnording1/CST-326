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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                textBox1.Text = row.Cells["Title"].Value.ToString();
                textBox2.Text = row.Cells["Author"].Value.ToString();
                textBox3.Text = row.Cells["Category"].Value.ToString();
                textBox4.Text = row.Cells["Year Published"].Value.ToString();
                textBox5.Text = row.Cells["ISBN"].Value.ToString();
                textBox6.Text = row.Cells["Quantity"].Value.ToString();
            }

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO Books (ISBN, BookName, Author, Category, PublishedYear, InventoryQty)
                    VALUES (@isbn, @title, @author, @category, @year, @quantity);";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        // Add the parameters and their values
                        insertCmd.Parameters.AddWithValue("@title", textBox1.Text);
                        insertCmd.Parameters.AddWithValue("@author", textBox2.Text);
                        insertCmd.Parameters.AddWithValue("@category", textBox3.Text);
                        insertCmd.Parameters.AddWithValue("@year", textBox4.Text);
                        insertCmd.Parameters.AddWithValue("@isbn", textBox5.Text);
                        insertCmd.Parameters.AddWithValue("@quantity", textBox6.Text);

                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } catch (SqlException)
                {
                    MessageBox.Show("Book already exists");
                }
                catch
                {
                    MessageBox.Show("Something Broke");
                }

                LoadBooksIntoDataGridView();
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string updateQuery = @"UPDATE Books
                                       SET BookName = @title, Author = @author, 
                                           Category = @category, PublishedYear = @year, 
                                           InventoryQty = @quantity
                                       WHERE ISBN = @isbn;";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            // Add the parameters and their values
                            updateCmd.Parameters.AddWithValue("@title", textBox1.Text);
                            updateCmd.Parameters.AddWithValue("@author", textBox2.Text);
                            updateCmd.Parameters.AddWithValue("@category", textBox3.Text);
                            updateCmd.Parameters.AddWithValue("@year", textBox4.Text);
                            updateCmd.Parameters.AddWithValue("@isbn", textBox5.Text);
                            updateCmd.Parameters.AddWithValue("@quantity", textBox6.Text);

                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadBooksIntoDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }

        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string isbnToDelete = dataGridView1.SelectedRows[0].Cells["ISBN"].Value.ToString();
                string connectionString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM Books WHERE ISBN = @isbn;";

                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                        {
                            deleteCmd.Parameters.AddWithValue("@isbn", isbnToDelete);
                            deleteCmd.ExecuteNonQuery();

                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadBooksIntoDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }

        }
    }
}
