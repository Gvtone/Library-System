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
    public partial class AdminRegister : Form
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public AdminRegister()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // <Email>
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
                txtEmail.Text = "";

            // Higlights Email
            txtEmail.ForeColor = Color.FromArgb(134, 185, 176);
            pnlEmail.BackColor = Color.FromArgb(134, 185, 176);
            picEmail.Image = Properties.Resources.mail_selected;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                txtEmail.Text = "Email";

            // Unhighlights Email
            txtEmail.ForeColor = Color.FromArgb(255, 255, 255);
            pnlEmail.BackColor = Color.FromArgb(255, 255, 255);
            picEmail.Image = Properties.Resources.mail_unselected;
        }
        // </Email>

        // <ID Number>
        private void txtIDNumber_Enter(object sender, EventArgs e)
        {
            if (txtIDNumber.Text == "ID Number")
                txtIDNumber.Text = "";

            // Higlights Email
            txtIDNumber.ForeColor = Color.FromArgb(134, 185, 176);
            pnlIDNumber.BackColor = Color.FromArgb(134, 185, 176);
            picEmail.Image = Properties.Resources.id_selected;
        }

        private void txtIDNumber_Leave(object sender, EventArgs e)
        {
            if (txtIDNumber.Text == "")
                txtIDNumber.Text = "ID Number";

            // Unhighlights Email
            txtIDNumber.ForeColor = Color.FromArgb(255, 255, 255);
            pnlIDNumber.BackColor = Color.FromArgb(255, 255, 255);
            picEmail.Image = Properties.Resources.id_unselected;
        }
        // </ID Number>

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

        // <Password confirmation>
        private void txtPassCheck_Enter(object sender, EventArgs e)
        {
            if (txtPassCheck.Text == "Confirm Password")
                txtPassCheck.Text = "";
            txtPassCheck.PasswordChar = '*';

            // Higlights Pass Check
            txtPassCheck.ForeColor = Color.FromArgb(134, 185, 176);
            pnlPassCheck.BackColor = Color.FromArgb(134, 185, 176);
            picPassCheck.Image = Properties.Resources.reenter_selected;
        }

        private void txtPassCheck_Leave(object sender, EventArgs e)
        {
            if (txtPassCheck.Text == "")
            {
                txtPassCheck.Text = "Confirm Password";
                txtPassCheck.PasswordChar = '\0';
            }

            // Unhighlights Pass Check
            txtPassCheck.ForeColor = Color.FromArgb(255, 255, 255);
            pnlPassCheck.BackColor = Color.FromArgb(255, 255, 255);
            picPassCheck.Image = Properties.Resources.reenter_unselected;
        }
        // </Password confirmation>

        // Checks if mysql server is running
        public bool ShowException()
        {
            string mySelectQuery = "SELECT column1 FROM users";
            MySqlConnection myConnection = new MySqlConnection("server=localhost; uid=root; password=''; database=library");
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

        // Register button
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check if textboxes are blank
            if (txtEmail.Text == "Email" && txtUser.Text == "Username" && txtPass.Text == "Password"
                && txtPassCheck.Text == "Confirm Password")
            {
                MessageBox.Show("Please enter the required informations!");
            }
            else if (txtEmail.Text == "Email")
            {
                MessageBox.Show("Please enter your email!");
                txtEmail.Focus();
            }
            else if (txtIDNumber.Text == "ID Number")
            {
                MessageBox.Show("Please enter your ID Number!");
                txtEmail.Focus();
            }
            else if (txtUser.Text == "Username")
            {
                MessageBox.Show("Please enter your uesrname!");
                txtUser.Focus();
            }
            else if (txtPass.Text == "Password")
            {
                MessageBox.Show("Please enter your password!");
                txtPass.Focus();
            }
            else if (txtPassCheck.Text == "Confirm Password")
            {
                MessageBox.Show("Please enter your re-enter your password!");
                txtPassCheck.Focus();
            }
            else
            {
                if (ShowException())
                {
                    // Checks if the given username is already in the data base
                    CN.Open();
                    Com.CommandText = $"SELECT * FROM users WHERE username = '{txtUser.Text}'";
                    reader = Com.ExecuteReader();

                    if (reader.Read())
                    {
                        MessageBox.Show("Username already taken, please choose another one.");
                        reader.Close();
                        CN.Close();
                    }
                    else
                    {
                        // Checks if the given passwords do not match each other
                        if (txtPass.Text == txtPassCheck.Text)
                        {
                            if (IsValidEmail(txtEmail.Text) == true)
                            {
                                // >>>>>>>>>>>ADD ID CHECKER HERE<<<<<<<<<<<<
                                reader.Close();
                                Com.CommandText = $"INSERT INTO users(Username, Password, Email, User_Type) VALUES('{txtUser.Text}', '{encrypt(txtPass.Text)}', '{txtEmail.Text}', 'ADMIN')";
                                Com.ExecuteNonQuery();
                                CN.Close();


                                if (MessageBox.Show("Record Saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.Yes)
                                {
                                    LogInForm LF = new LogInForm();
                                    LF.Show();
                                    this.Hide();
                                }
                            }
                            else
                                MessageBox.Show("Invalid Email!");
                            
                        }
                        else
                            MessageBox.Show("Password do not match!");
                    }
                }
            }
        }

        // For going back to the log in form
        private void btnBack_Click(object sender, EventArgs e)
        {
            UserRegister UR = new UserRegister();

            UR.Show();
            this.Hide();
        }

        // Encrypts the user's password
        private string encrypt(string pass)
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
            Com.CommandText = "SELECT `auto_increment` AS ID FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'users'";
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

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }
}
