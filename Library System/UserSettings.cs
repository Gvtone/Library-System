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
    public partial class UserSettings : Form
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();

        public UserSettings()
        {
            InitializeComponent();
            Com.Connection = CN;

            // Automatically selects the first option
            btnAccount.BackColor = Color.FromArgb(4, 38, 48);

            // Prepare the form before showing the user
            this.pnlMain.Controls.Clear();
            AccountSettings uc = new AccountSettings();
            this.pnlMain.Controls.Add(uc);
            uc.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
