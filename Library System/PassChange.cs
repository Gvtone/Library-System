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
    public partial class PassChange : Form
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public string Pass { get; set; }

        public PassChange()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        // Exits the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // <New Confirm>
        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "New Password")
                txtPass.Text = "";
            txtPass.PasswordChar = '*';

            // Highlights Password Confirm
            txtPass.ForeColor = Color.FromArgb(134, 185, 176);
            pnlPass.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "New Password";
                txtPass.PasswordChar = '\0';
            }

            // Unhighlights Password Confirm
            txtPass.ForeColor = Color.FromArgb(255, 255, 255);
            pnlPass.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </New Confirm>

        // <Password Confirm>
        private void txtPassConfirm_Enter(object sender, EventArgs e)
        {
            if (txtPassConfirm.Text == "Confirm Password")
                txtPassConfirm.Text = "";
            txtPassConfirm.PasswordChar = '*';

            // Highlights Password Confirm
            txtPassConfirm.ForeColor = Color.FromArgb(134, 185, 176);
            pnlPassConfirm.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtPassConfirm_Leave(object sender, EventArgs e)
        {
            if (txtPassConfirm.Text == "")
            {
                txtPassConfirm.Text = "Confirm Password";
                txtPassConfirm.PasswordChar = '\0';
            }

            // Unhighlights Password Confirm
            txtPassConfirm.ForeColor = Color.FromArgb(255, 255, 255);
            pnlPassConfirm.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </Password Confirm>

        // Saves the new password to the database
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CN.Open();
            Com.CommandText = $"SELECT Password FROM users WHERE Username = '{LogInForm.username}'";
            reader = Com.ExecuteReader();
            reader.Read();
            string userPass = reader["Password"].ToString();
            reader.Close();

            if (txtPass.Text == "New Password")
            {
                MessageBox.Show("Please enter new passowrd!");
                CN.Close();
            }
            else if (txtPassConfirm.Text == "Confirm Password!")
            {
                MessageBox.Show("Please confirm password!");
                CN.Close();
            }
            else if (encrypt(txtPass.Text, LogInForm.username) == userPass)
            {
                MessageBox.Show("New password cannot be the same as your old password!");
                CN.Close();
            }
            else
            {
                if (txtPass.Text == txtPassConfirm.Text)
                {
                    Pass = txtPass.Text;

                    Com.CommandText = $"UPDATE users set Password = '{encrypt(txtPass.Text, LogInForm.username)}' WHERE Username = '{LogInForm.username}'";
                    Com.ExecuteNonQuery();
                    CN.Close();

                    MessageBox.Show("Password changed successfuly!");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Password do not match!");
                }
            }
        }

        // Encrypts the user's password
        private string encrypt(string pass, string user)
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
