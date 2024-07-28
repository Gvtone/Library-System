using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_System
{
    public partial class UserInfo : UserControl
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;
        MySqlDataAdapter da;

        public UserInfo()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        // <Search>
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
                txtSearch.Text = "";

            // Higlights User
            txtSearch.ForeColor = Color.FromArgb(134, 185, 176);
            pnlSearch.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                txtSearch.Text = "Search";

            // Unhighlights User
            txtSearch.ForeColor = Color.FromArgb(255, 255, 255);
            pnlSearch.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </Search>

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string user = txtSearch.Text;

            CN.Open();
            Com.CommandText = $"SELECT * FROM users WHERE Username = '{txtSearch.Text}'";
            reader = Com.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("No user found!");
                reader.Close();
                CN.Close();
            }
            else
            {
                reader.Close();
                CN.Close();
                // Check if the user has a picture, if not, then default picture is added
                CN.Open();
                Com.CommandText = $"SELECT User_Image FROM users WHERE username = '{user}' AND User_Image IS NULL OR User_Image = ''";
                reader = Com.ExecuteReader();

                if (reader.Read())
                {
                    CN.Close();
                    reader.Close();

                    picDisplayPicture.Image = Properties.Resources.pic_placeholder;
                }
                else
                {
                    CN.Close();
                    reader.Close();

                    // Retrieves the user's picture
                    String selectQuery = $"SELECT User_Image FROM users WHERE username = '{user}'";
                    Com = new MySqlCommand(selectQuery, CN);
                    da = new MySqlDataAdapter(Com);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    byte[] img = (byte[])table.Rows[0][0];
                    MemoryStream ms = new MemoryStream(img);
                    picDisplayPicture.Image = Image.FromStream(ms);
                    da.Dispose();
                }

                // Sets username
                txtUser.Text = user;

                // Gets the email of the user
                CN.Open();
                Com.CommandText = $"SELECT Email FROM users WHERE username = '{user}'";
                reader = Com.ExecuteReader();
                reader.Read();
                txtEmail.Text = reader["Email"].ToString();
                reader.Close();
                CN.Close();

                // Gets the id number of the user
                CN.Open();
                Com.CommandText = $"SELECT ID_Number FROM users WHERE username = '{user}'";
                reader = Com.ExecuteReader();
                if (reader.Read() && reader["ID_Number"].ToString() != "")
                {
                    txtIDNumber.Text = reader["ID_Number"].ToString();
                    reader.Close();
                    CN.Close();
                }
                else
                {
                    txtIDNumber.Text = "Eg. 0000-0000";
                    reader.Close();
                    CN.Close();
                }

                // Gets the first name of the user
                CN.Open();
                Com.CommandText = $"SELECT First_Name FROM users WHERE username = '{user}'";
                reader = Com.ExecuteReader();
                if (reader.Read() && reader["First_Name"].ToString() != "")
                {
                    txtFirstName.Text = reader["First_Name"].ToString();
                    reader.Close();
                    CN.Close();
                }
                else
                {
                    txtFirstName.Text = "First Name";
                    reader.Close();
                    CN.Close();
                }

                // Gets the last name of the user
                CN.Open();
                Com.CommandText = $"SELECT Last_Name FROM users WHERE username = '{user}'";
                reader = Com.ExecuteReader();
                if (reader.Read() && reader["Last_Name"].ToString() != "")
                {
                    txtLastName.Text = reader["Last_Name"].ToString();
                    reader.Close();
                    CN.Close();
                }
                else
                {
                    txtLastName.Text = "Last Name";
                    reader.Close();
                    CN.Close();
                }

                // Gets the address of the user
                CN.Open();
                Com.CommandText = $"SELECT Address FROM users WHERE username = '{user}'";
                reader = Com.ExecuteReader();
                if (reader.Read() && reader["Address"].ToString() != "")
                {
                    txtAddress.Text = reader["Address"].ToString();
                    reader.Close();
                    CN.Close();
                }
                else
                {
                    txtAddress.Text = "Address";
                    reader.Close();
                    CN.Close();
                }

                // Gets the birthday of the user
                CN.Open();
                Com.CommandText = $"SELECT Birthday FROM users WHERE username = '{user}'";
                reader = Com.ExecuteReader();
                if (reader.Read() && reader["Birthday"].ToString() != "")
                {
                    dtpBirthday.Value = Convert.ToDateTime(reader["Birthday"]);
                    reader.Close();
                    CN.Close();
                }
                else
                {
                    reader.Close();
                    CN.Close();
                }

                // Gets the program of the user
                CN.Open();
                Com.CommandText = $"SELECT Program FROM users WHERE username = '{user}'";
                reader = Com.ExecuteReader();
                if (reader.Read() && reader["Program"].ToString() != "")
                {
                    txtProgram.Text = reader["Program"].ToString();
                    reader.Close();
                    CN.Close();
                }
                else
                {
                    txtProgram.Text = "Program";
                    reader.Close();
                    CN.Close();
                }

                // Gets the contact number of the user
                CN.Open();
                Com.CommandText = $"SELECT Contact_Number FROM users WHERE username = '{user}'";
                reader = Com.ExecuteReader();
                if (reader.Read() && reader["Contact_Number"].ToString() != "")
                {
                    txtContactNumber.Text = reader["Contact_Number"].ToString();
                    reader.Close();
                    CN.Close();
                }
                else
                {
                    txtContactNumber.Text = "Eg. 09123456789";
                    reader.Close();
                    CN.Close();
                }
            }
        }
    }
}
