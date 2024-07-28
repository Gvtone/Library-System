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
    public partial class UserMain : Form
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;
        MySqlDataAdapter da;

        public static EventHandler Clicked_Edit;

        public UserMain()
        {
            InitializeComponent();
            Com.Connection = CN;

            // Event Handlers
            ucSearch.AddClicked += new EventHandler(btnBook_Click);
            ucSearch.EditClicked += new EventHandler(Book_Edit);
            Books.DoneEdit += new EventHandler(btnSearch_Click);
            AccountSettings.UpdateMain += new EventHandler(Update_Main);

            // Automatically selects the first option
            btnSearch.BackColor = Color.FromArgb(4, 38, 48);

            // Prepare the form before showing the user
            this.pnlMain.Controls.Clear();
            ucSearch uc = new ucSearch();
            this.pnlMain.Controls.Add(uc);
            uc.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Personalizing window based on user
            lblUser.Text = LogInForm.username;
            int x = (pnlLeftTop.Size.Width - lblUser.Size.Width) / 2;
            lblUser.Location = new Point(x, lblUser.Location.Y);
            lblUserType.Text = LogInForm.userType;

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

            // Hides tabs that are no use for USER
            if (LogInForm.userType == "USER")
            {
                btnBook.Hide();
                btnUserInfo.Hide();
                btnBorrow.Hide();
                btnReturn.Hide();
            }

        }

        // Closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimizes the window
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // </Main left pannel buttons>
        // Search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Change selected button color
            btnSearch.BackColor = Color.FromArgb(4, 38, 48);

            // Reset color of unselected buttons
            btnHistory.BackColor = Color.FromArgb(4, 20, 33);
            btnBook.BackColor = Color.FromArgb(4, 20, 33);
            btnUserInfo.BackColor = Color.FromArgb(4, 20, 33);
            btnBorrow.BackColor = Color.FromArgb(4, 20, 33);
            btnReturn.BackColor = Color.FromArgb(4, 20, 33);

            // Display the corresponding option
            pnlMain.Controls.Clear();
            ucSearch uc = new ucSearch();
            pnlMain.Controls.Add(uc);
            uc.Show();
        }

        // History button
        private void btnHistory_Click(object sender, EventArgs e)
        {
            // Change selected button color
            btnHistory.BackColor = Color.FromArgb(4, 38, 48);

            // Reset color of unselected buttons
            btnSearch.BackColor = Color.FromArgb(4, 20, 33);
            btnBook.BackColor = Color.FromArgb(4, 20, 33);
            btnUserInfo.BackColor = Color.FromArgb(4, 20, 33);
            btnBorrow.BackColor = Color.FromArgb(4, 20, 33);
            btnReturn.BackColor = Color.FromArgb(4, 20, 33);

            // Display the corresponding option depending on the user type
            if (LogInForm.userType == "USER")
            {
                pnlMain.Controls.Clear();
                ucHistory uc = new ucHistory();
                pnlMain.Controls.Add(uc);
                uc.Show();
            }
            else
            {
                pnlMain.Controls.Clear();
                StudentHistory SH = new StudentHistory();
                pnlMain.Controls.Add(SH);
                SH.Show();
            }
            
        }
        
        // Book Button
        private void btnBook_Click(object sender, EventArgs e)
        {
            // Change selected button color
            btnBook.BackColor = Color.FromArgb(4, 38, 48);

            // Reset color of unselected buttons
            btnSearch.BackColor = Color.FromArgb(4, 20, 33);
            btnHistory.BackColor = Color.FromArgb(4, 20, 33);
            btnUserInfo.BackColor = Color.FromArgb(4, 20, 33);
            btnBorrow.BackColor = Color.FromArgb(4, 20, 33);
            btnReturn.BackColor = Color.FromArgb(4, 20, 33);

            pnlMain.Controls.Clear();
            Books BK = new Books();
            pnlMain.Controls.Add(BK);
            BK.Show();
        }

        private void Book_Edit(object sender, EventArgs e)
        {
            // Change selected button color
            btnBook.BackColor = Color.FromArgb(4, 38, 48);

            // Reset color of unselected buttons
            btnSearch.BackColor = Color.FromArgb(4, 20, 33);
            btnHistory.BackColor = Color.FromArgb(4, 20, 33);
            btnUserInfo.BackColor = Color.FromArgb(4, 20, 33);
            btnBorrow.BackColor = Color.FromArgb(4, 20, 33);
            btnReturn.BackColor = Color.FromArgb(4, 20, 33);

            pnlMain.Controls.Clear();
            Books BK = new Books();
            pnlMain.Controls.Add(BK);
            BK.Show();

            Clicked_Edit?.Invoke(sender, e);
        }

        // User information button
        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            // Change selected button color
            btnUserInfo.BackColor = Color.FromArgb(4, 38, 48);

            // Reset color of unselected buttons
            btnSearch.BackColor = Color.FromArgb(4, 20, 33);
            btnHistory.BackColor = Color.FromArgb(4, 20, 33);
            btnBook.BackColor = Color.FromArgb(4, 20, 33);
            btnBorrow.BackColor = Color.FromArgb(4, 20, 33);
            btnReturn.BackColor = Color.FromArgb(4, 20, 33);

            pnlMain.Controls.Clear();
            UserInfo UI = new UserInfo();
            pnlMain.Controls.Add(UI);
            UI.Show();
        }

        // Borrow button
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            // Change selected button color
            btnBorrow.BackColor = Color.FromArgb(4, 38, 48);

            // Reset color of unselected buttons
            btnSearch.BackColor = Color.FromArgb(4, 20, 33);
            btnHistory.BackColor = Color.FromArgb(4, 20, 33);
            btnBook.BackColor = Color.FromArgb(4, 20, 33);
            btnUserInfo.BackColor = Color.FromArgb(4, 20, 33);
            btnReturn.BackColor = Color.FromArgb(4, 20, 33);

            pnlMain.Controls.Clear();
            Borrow BW = new Borrow();
            pnlMain.Controls.Add(BW);
            BW.Show();
        }

        // Return button
        private void btnReturn_Click(object sender, EventArgs e)
        {
            // Change selected button color
            btnReturn.BackColor = Color.FromArgb(4, 38, 48);

            // Reset color of unselected buttons
            btnSearch.BackColor = Color.FromArgb(4, 20, 33);
            btnHistory.BackColor = Color.FromArgb(4, 20, 33);
            btnBook.BackColor = Color.FromArgb(4, 20, 33);
            btnUserInfo.BackColor = Color.FromArgb(4, 20, 33);
            btnBorrow.BackColor = Color.FromArgb(4, 20, 33);

            pnlMain.Controls.Clear();
            Return RT = new Return();
            RT.TopLevel = false;
            pnlMain.Controls.Add(RT);
            RT.Show();
        }
        // </Main left pannel buttons>

        // <Secondary buttons>
        private void btnSettings_Click(object sender, EventArgs e)
        {
            UserSettings US = new UserSettings();
            US.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInForm LI = new LogInForm();

            LI.Show();
            this.Hide();
        }
        // </Secondary buttons>

        private void Update_Main(object sender, EventArgs e)
        {
            CN.Open();
            Com.CommandText = $"SELECT Username, User_Type FROM users WHERE username = '{LogInForm.username}'";
            reader = Com.ExecuteReader();
            reader.Read();
            lblUser.Text = reader["Username"].ToString();
            reader.Close();
            CN.Close();

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
}
