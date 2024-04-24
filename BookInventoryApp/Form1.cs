using System.Configuration;
using System.Data.SqlClient;

namespace BookInventoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Users WHERE UserName = @username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", textBox1.Text);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader["Password"].ToString();
                                if (storedPassword == textBox2.Text)
                                {
                                    landingPage landingForm = new landingPage();
                                    this.Hide();
                                    landingForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("The password is wrong.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("The user does not exist.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
