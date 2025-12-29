using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagement_Information_Management_2
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string conString = "server=localhost;username=root;password=;database=im_etr";
            MySqlCommand cmd;
            MySqlDataReader dr;
            MySqlConnection conn;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            try
            {
                using (conn = new MySqlConnection(conString))
                {
                    string sql = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    conn.Open();
                    using (cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }
                }
                DialogResult result = MessageBox.Show(
                   "Account created successfully.",
                   "Success",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
               );

                if (result == DialogResult.OK)
                {
                    this.Close();
                } 
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) 
                {
                    MessageBox.Show(
                        "This username is already taken. Please choose a different one.",
                        "Duplicate Username",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Database error: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
