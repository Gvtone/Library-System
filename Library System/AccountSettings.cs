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
    public partial class AccountSettings : UserControl
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;
        MySqlDataAdapter da;

        public static EventHandler UpdateMain;

        public AccountSettings()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        // Show the current settings of the user
        private void AccountSettings_Load(object sender, EventArgs e)
        {
            // Check if the user has a picture, if not, then default picture is added
            CN.Open();
            Com.CommandText = $"SELECT User_Image FROM users WHERE username = '{LogInForm.username}' AND User_Image IS NULL OR User_Image = ''";
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
                String selectQuery = $"SELECT User_Image FROM users WHERE username = '{LogInForm.username}'";
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
            txtUser.Text = LogInForm.username;

            // Gets the email of the user
            CN.Open();
            Com.CommandText = $"SELECT Email FROM users WHERE username = '{LogInForm.username}'";
            reader = Com.ExecuteReader();
            reader.Read();
            txtEmail.Text = reader["Email"].ToString();
            reader.Close();
            CN.Close();

            // Gets the password of the user
            CN.Open();
            Com.CommandText = $"SELECT Password FROM users WHERE username = '{LogInForm.username}'";
            reader = Com.ExecuteReader();
            reader.Read();
            txtPass.Text = reader["Password"].ToString();
            reader.Close();
            CN.Close();

            // Gets the id number of the user
            CN.Open();
            Com.CommandText = $"SELECT ID_Number FROM users WHERE username = '{LogInForm.username}'";
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
            Com.CommandText = $"SELECT First_Name FROM users WHERE username = '{LogInForm.username}'";
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
            Com.CommandText = $"SELECT Last_Name FROM users WHERE username = '{LogInForm.username}'";
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
            Com.CommandText = $"SELECT Address FROM users WHERE username = '{LogInForm.username}'";
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
            Com.CommandText = $"SELECT Birthday FROM users WHERE username = '{LogInForm.username}'";
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
            Com.CommandText = $"SELECT Program FROM users WHERE username = '{LogInForm.username}'";
            reader = Com.ExecuteReader();
            if (reader.Read() && reader["Program"].ToString() != "")
            {
                cmbPrograms.Texts = reader["Program"].ToString();
                reader.Close();
                CN.Close();
            }
            else
            {
                cmbPrograms.Texts = "Program";
                reader.Close();
                CN.Close();
            }

            // Gets the contact number of the user
            CN.Open();
            Com.CommandText = $"SELECT Contact_Number FROM users WHERE username = '{LogInForm.username}'";
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

            changedImage = false;
        }

        // <image>
        bool changedImage = false;
        Image tempImage;
        // If picture is click, user is prompted to file explorer to select a picture
        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            //Upload Photo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose Image File";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.gif, *.png)|*.bmp;*.jpg;*.gif;*.png;";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picDisplayPicture.Image = Image.FromFile(openFileDialog.FileName);
                changedImage = true;
                tempImage = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void picDisplayPicture_MouseEnter(object sender, EventArgs e)
        {
            picDisplayPicture.Image = Properties.Resources.pic_replacement;
        }

        private void picDisplayPicture_MouseLeave(object sender, EventArgs e)
        {
            // Check if the user has a picture, if not, then default picture is added
            CN.Open();
            Com.CommandText = $"SELECT User_Image FROM users WHERE username = '{LogInForm.username}' AND User_Image IS NULL OR User_Image = ''";
            reader = Com.ExecuteReader();

            if (reader.Read())
            {
                CN.Close();
                reader.Close();

                picDisplayPicture.Image = Properties.Resources.pic_placeholder;
            }
            else if (changedImage == true)
            {
                CN.Close();
                reader.Close();

                picDisplayPicture.Image = tempImage;
            }
            else
            {
                CN.Close();
                reader.Close();

                // Retrieves the user's picture
                String selectQuery = $"SELECT User_Image FROM users WHERE username = '{LogInForm.username}'";
                Com = new MySqlCommand(selectQuery, CN);
                da = new MySqlDataAdapter(Com);
                DataTable table = new DataTable();
                da.Fill(table);
                byte[] img = (byte[])table.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                picDisplayPicture.Image = Image.FromStream(ms);
                da.Dispose();
            }
        }
        // </image>


        // Saves the settings
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtIDNumber.Text == "Eg. 0000-0000" || txtFirstName.Text == "First Name" ||
                txtLastName.Text == "Last Name" || txtAddress.Text == "Address" || cmbPrograms.Text == "Program" ||
                txtEmail.Text == "" || txtContactNumber.Text == "Eg. 09123456789")
            {
                MessageBox.Show("Please fill in all the fields!");
            }
            else
            {
                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Invalid email");
                }
                else
                {
                    if (!IsPhoneNumber(txtContactNumber.Text))
                    {
                        MessageBox.Show("Invalid contact number");
                    }
                    else
                    {
                        if (!IsIDNumber(txtIDNumber.Text))
                        {
                            MessageBox.Show("Invalid id number");
                        }
                        else
                        {
                            // Updates record in the database
                            MemoryStream ms = new MemoryStream();
                            picDisplayPicture.Image.Save(ms, picDisplayPicture.Image.RawFormat);
                            Byte[] img = ms.ToArray();
                            CN.Open();

                            Com.CommandText = $"UPDATE users set User_Image = @img WHERE Username = '{LogInForm.username}'";
                            Com.Parameters.Add("@img", MySqlDbType.Blob).Value = img;
                            Com.ExecuteNonQuery();
                            Com.Dispose();
                            CN.Close();

                            // Updates all parameters
                            CN.Open();
                            Com.CommandText = $"UPDATE users set Username = '{txtUser.Text}', ID_Number = '{txtIDNumber.Text}', " +
                                $"First_Name = '{txtFirstName.Text}', Last_Name = '{txtLastName.Text}', Address = '{txtAddress.Text}', " +
                                $"Birthday = '{dtpBirthday.Value.ToString("yyyy/MM/dd")}', Program = '{cmbPrograms.Texts}', Contact_Number = '{txtContactNumber.Text}' " +
                                $"WHERE Username = '{LogInForm.username}'";
                            Com.ExecuteNonQuery();
                            CN.Close();
                            LogInForm.username = txtUser.Text;

                            UpdateMain?.Invoke(sender, e);

                            // Updates data in the interface
                            String selectQuery = $"SELECT User_Image FROM users WHERE username = '{LogInForm.username}'";
                            Com = new MySqlCommand(selectQuery, CN);
                            da = new MySqlDataAdapter(Com);
                            DataTable table = new DataTable();
                            da.Fill(table);
                            picDisplayPicture.Image = Image.FromStream(ms);
                            da.Dispose();

                            MessageBox.Show("Settings Saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        // Delete account
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "CONFIRM DELETE ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                PassConfirm PC = new PassConfirm();
                if (PC.ShowDialog() == DialogResult.OK && PassConfirm.samePass == true)
                {
                    CN.Open();
                    Com.CommandText = $"Delete FROM users WHERE Username = '{LogInForm.username}'";
                    Com.ExecuteNonQuery();
                    CN.Close();

                    LogInForm LF = new LogInForm();
                    LF.Show();

                    for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                    {
                        if (Application.OpenForms[i].Name != "LogInForm")
                            Application.OpenForms[i].Close();
                    }
                }
            }
        }

        // Change Password
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            PassConfirm PC = new PassConfirm();
            if (PC.ShowDialog() == DialogResult.OK && PassConfirm.samePass == true)
            {
                using (PassChange PX = new PassChange())
                {
                    if (PX.ShowDialog() == DialogResult.OK)
                    {
                        txtPass.Text = PX.Pass;
                    }
                }
            }
        }

        // <Username>
        private void txtUser_Enter(object sender, EventArgs e)
        {
            // Highlights User
            txtUser.ForeColor = Color.FromArgb(134, 185, 176);
            pnlUser.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            // Unhighlights User
            txtUser.ForeColor = Color.FromArgb(255, 255, 255);
            pnlUser.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </Username>

        // <IDNumber>
        private void txtIDNumber_Enter(object sender, EventArgs e)
        {
            if (txtIDNumber.Text == "Eg. 0000-0000")
                txtIDNumber.Text = "";

            // Highlights IDNumber
            txtIDNumber.ForeColor = Color.FromArgb(134, 185, 176);
            pnlIDNum.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtIDNumber_Leave(object sender, EventArgs e)
        {
            if (txtIDNumber.Text == "")
                txtIDNumber.Text = "Eg. 0000-0000";

            // Unhighlights IDNumber
            txtIDNumber.ForeColor = Color.FromArgb(255, 255, 255);
            pnlIDNum.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </IDNumber>

        // <FirstName>
        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
                txtFirstName.Text = "";

            // Highlights FirstName
            txtFirstName.ForeColor = Color.FromArgb(134, 185, 176);
            pnlFirstName.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
                txtFirstName.Text = "First Name";

            // Unhighlights FirstName
            txtFirstName.ForeColor = Color.FromArgb(255, 255, 255);
            pnlFirstName.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </FirstName>

        // <LastName>
        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
                txtLastName.Text = "";

            // Highlights LastName
            txtLastName.ForeColor = Color.FromArgb(134, 185, 176);
            pnlLastName.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
                txtLastName.Text = "Last Name";

            // Unhighlights LastName
            txtLastName.ForeColor = Color.FromArgb(255, 255, 255);
            pnlLastName.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </LastName>

        // <Address>
        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address")
                txtAddress.Text = "";

            // Highlights Address
            txtAddress.ForeColor = Color.FromArgb(134, 185, 176);
            pnlAddress.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text == "")
                txtAddress.Text = "Address";

            // Unhighlights Address
            txtAddress.ForeColor = Color.FromArgb(255, 255, 255);
            pnlAddress.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </Address>

        // <Birthday>
        private void dtpBirthday_Enter(object sender, EventArgs e)
        {
            // Highlights Birthday
            dtpBirthday.ForeColor = Color.FromArgb(134, 185, 176);
            pnlBirthday.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void dtpBirthday_Leave(object sender, EventArgs e)
        {
            // Unhighlights Birthday
            dtpBirthday.ForeColor = Color.FromArgb(255, 255, 255);
            pnlBirthday.BackColor = Color.FromArgb(255, 255, 255);
        }
        // <Birthday>

        // <Program>
        private void cmbPrograms_Enter(object sender, EventArgs e)
        {
            // Highlights Program
            cmbPrograms.ForeColor = Color.FromArgb(134, 185, 176);
            cmbPrograms.IconColor = Color.FromArgb(134, 185, 176);
            pnlProgram.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void cmbPrograms_Leave(object sender, EventArgs e)
        {
            // Unhighlights Program
            cmbPrograms.ForeColor = Color.FromArgb(255, 255, 255);
            cmbPrograms.IconColor = Color.FromArgb(255, 255, 255);
            pnlProgram.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </Program>

        // <Email>
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            // Highlights Email
            txtEmail.ForeColor = Color.FromArgb(134, 185, 176);
            pnlEmail.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            // Unhighlights Email
            txtEmail.ForeColor = Color.FromArgb(255, 255, 255);
            pnlEmail.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </Email>

        // <ContactNumber>
        private void txtContactNumber_Enter(object sender, EventArgs e)
        {
            if (txtContactNumber.Text == "Eg. 09123456789")
                txtContactNumber.Text = "";

            // Highlights ContactNumber
            txtContactNumber.ForeColor = Color.FromArgb(134, 185, 176);
            pnlContact.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtContactNumber_Leave(object sender, EventArgs e)
        {
            if (txtContactNumber.Text == "")
                txtContactNumber.Text = "Eg. 09123456789";

            // Unhighlights ContactNumber
            txtContactNumber.ForeColor = Color.FromArgb(255, 255, 255);
            pnlContact.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </ContactNumber>

        // Checks if the given email is valid
        static bool IsValidEmail(string email)
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

        // Checks if the given phone number is valid
        static bool IsPhoneNumber(string number)
        {
            return number[0] == '0' && number[1] == '9' && number.Length == 11 & IsDigit(number);
        }

        static bool IsDigit(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        static bool IsIDNumber(string ID)
        {
            if (ID.Count(char.IsDigit) == 8 && ID[4] == '-')
                return true;
            else
                return false;
        }
    }
}
