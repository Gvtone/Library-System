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

namespace Library_System
{
    public partial class LogInForm : Form
    {
        //for connection
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public static string username = null;
        public static string userType = null;

        public LogInForm()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        // Exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        // Minimizes the window
        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // <Username>
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
                txtUser.Text = "";

            // Higlights User
            txtUser.ForeColor = Color.FromArgb(134, 185, 176);
            pnlUser.BackColor = Color.FromArgb(134, 185, 176);
            picUser.Image = Properties.Resources.user_selected;
        }
        
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
                txtUser.Text = "Username";

            // Unhighlights User
            txtUser.ForeColor = Color.FromArgb(255, 255, 255);
            pnlUser.BackColor = Color.FromArgb(255, 255, 255);
            picUser.Image = Properties.Resources.user_unselected;
        }
        // </Username>

        // <Password>
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
                txtPass.Text = "";
            txtPass.PasswordChar = '*';

            // Higlights Pass
            txtPass.ForeColor = Color.FromArgb(134, 185, 176);
            pnlPass.BackColor = Color.FromArgb(134, 185, 176);
            picPass.Image = Properties.Resources.key_selected;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.PasswordChar = '\0';
            }

            // Unhighlights Pass
            txtPass.ForeColor = Color.FromArgb(255, 255, 255);
            pnlPass.BackColor = Color.FromArgb(255, 255, 255);
            picPass.Image = Properties.Resources.key_unselected;
        }
        // </Password>

        // Checks if mysql server is running
        public bool ShowException()
        {
            string mySelectQuery = "SELECT column1 FROM users";
            MySqlConnection myConnection = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
            MySqlCommand myCommand = new MySqlCommand(mySelectQuery, myConnection);

            try // If successful return true
            {
                myCommand.Connection.Open();
                return true;
            }
            catch (MySqlException e) // If failed, it will catch the exception and throw the error to the user
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        // Sign in button
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Check if textboxes are blank
            if (txtUser.Text == "Username" && txtPass.Text == "Password")
            {
                MessageBox.Show("Please enter your username and password!");
            }
            else if (txtPass.Text == "Password")
            {
                MessageBox.Show("Please enter your password!");
                txtPass.Focus();
            }
            else if (txtUser.Text == "Username")
            {
                MessageBox.Show("Please enter your username!");
                txtUser.Focus();
            }
            else
            {
                if (ShowException())
                {
                    // Checks if the given username is in the database
                    CN.Open();
                    Com.CommandText = $"SELECT * FROM users WHERE username = '{txtUser.Text}'";
                    reader = Com.ExecuteReader();

                    if (reader.Read())
                    {
                        // Checks if the password match with the username
                        reader.Close();
                        Com.CommandText = $"SELECT * FROM users WHERE username = '{txtUser.Text}' && password = '{decrypt(txtPass.Text, txtUser.Text)}'";
                        reader = Com.ExecuteReader();

                        if (reader.Read())
                        {
                            UserMain UM = new UserMain();
                            // Gets the user type and username
                            reader.Close();
                            Com.CommandText = $"SELECT Username, User_Type FROM users WHERE username = '{txtUser.Text}'";
                            reader = Com.ExecuteReader();
                            reader.Read();
                            username = reader["Username"].ToString();
                            userType = reader["User_Type"].ToString();
                            reader.Close();
                            CN.Close();

                            UM.Show();
                            this.Hide();
                            
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password");
                        }
                        reader.Close();
                        CN.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                    reader.Close();
                    CN.Close();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegister F2 = new UserRegister();

            F2.Show();
            this.Hide();
        }

        // Contradicting its name, decrypt encrypts the given password and compare it to the database
        private string decrypt(string pass, string user)
        {
            int[] letter = new int[pass.Length];
            char[] origPass = pass.ToCharArray();

            // Converting letters to ascii values
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(pass);
            for (int i = 0; i < pass.Length; i++)
            {
                letter[i] = ASCIIvalues[i];
            }

            // Assigning every character to a custom alphabetical container
            int[] c = new int[pass.Length];
            for (int i = 0; i < pass.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (letter[i] == 65 + j || letter[i] == 97 + j)
                    {
                        c[i] = 0 + j;
                    }
                    if (!char.IsLetter(origPass[i]))
                    {
                        c[i] = origPass[i];
                    }
                }
            }

            // Gets the new user's id
            Com.CommandText = $"SELECT ID FROM users WHERE Username = '{user}'";
            reader = Com.ExecuteReader();
            reader.Read();
            int key = Convert.ToInt32(reader["ID"]) % 26;
            reader.Close();

            // Shifts the letters of the password corresponding to their id
            int[] shift = new int[pass.Length];
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsLetter(origPass[i]))
                {
                    shift[i] = (c[i] + key) % 26;
                }
            }

            // Sets the asxii value of the shifted letters
            int[] alphabet = new int[pass.Length];
            for (int i = 0; i < pass.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (shift[i] == 0 + j)
                    {
                        alphabet[i] = 65 + j;
                    }
                }
            }

            // Getting the corresponding cases of each letters
            char[] charPass = new char[pass.Length];
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(origPass[i]))
                {
                    charPass[i] = char.ToUpper((char)alphabet[i]);
                }
                if (char.IsLower(origPass[i]))
                {
                    charPass[i] = char.ToLower((char)alphabet[i]);
                }
                if (!char.IsLetter(origPass[i]))
                {
                    charPass[i] = origPass[i];
                }
            }

            // Joining the array of char to one string
            string secPass = new string(charPass);
            return secPass;
        }
    }
}
