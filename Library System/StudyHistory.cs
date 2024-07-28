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
    public partial class StudentHistory : UserControl
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public StudentHistory()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        // <Search bar>
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }

            // Higlights Search
            txtSearch.ForeColor = Color.FromArgb(134, 185, 176);
            pnlSearch.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
                loadgrid();
            }

            // Unhiglights Search
            txtSearch.ForeColor = Color.FromArgb(255, 255, 255);
            pnlSearch.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </Search bar>

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtgBorrowed.Rows.Clear();
            dtgReturned.Rows.Clear();
            bool noBorrowed = false, noReturned = false;

            CN.Open();
            Com.CommandText = $"SELECT * FROM users WHERE Username = '{txtSearch.Text}'";
            reader = Com.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("User does not exist!");
                reader.Close();
                CN.Close();
            }
            else
            {
                reader.Close();
                CN.Close();

                // Loads the history of borrowed books by the searched user
                CN.Open();
                Com.CommandText = $"SELECT * FROM borrow INNER JOIN users WHERE borrow.User_name = users.Username AND users.Username = '{txtSearch.Text}' ORDER BY borrow.Borrow_ID";
                reader = Com.ExecuteReader();
                while (reader.Read())
                {
                    dtgBorrowed.Rows.Add(reader["Title"].ToString(), reader["Number_Of_Copies"].ToString(), reader["Release_Date"].ToString(), reader["Due_Date"].ToString());
                }

                if (!reader.HasRows)
                {
                    noBorrowed = true;
                }

                reader.Close();
                CN.Close();

                // Loads the history of returned books by the searched user
                CN.Open();
                Com.CommandText = $"SELECT * FROM library.return INNER JOIN users WHERE return.User_name = users.Username AND users.Username = '{txtSearch.Text}' ORDER BY return.Return_ID";
                reader = Com.ExecuteReader();
                while (reader.Read())
                {
                    dtgReturned.Rows.Add(reader["Title"].ToString(), reader["Number_Of_Copies"].ToString(), reader["Release_Date"].ToString(), reader["Due_Date"].ToString(), reader["Return_Date"].ToString());
                }

                if (!reader.HasRows)
                {
                    noReturned = true;
                }

                reader.Close();
                CN.Close();


                // Checks if user has a history record
                if (noBorrowed == true && noReturned == true)
                {
                    MessageBox.Show("No records found");
                }
                

                // Settings for borrowed books
                dtgBorrowed.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgBorrowed.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dtgBorrowed.Columns[0].Width = 230;
                //dtgBorrowed.Columns[1].Width = 60;
                //dtgBorrowed.Columns[4].Width = 80;
                dtgBorrowed.ClearSelection();

                // Settings for returned books
                dtgReturned.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgReturned.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dtgReturned.Columns[0].Width = 230;
                //dtgReturned.Columns[1].Width = 60;
                //dtgReturned.Columns[4].Width = 80;
                dtgReturned.ClearSelection();
            }
        }


        private void ucHistory_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        void loadgrid()
        {
            // Header for borrowed books
            dtgBorrowed.Rows.Clear();
            dtgBorrowed.ColumnCount = 4;
            dtgBorrowed.Columns[0].Name = "Title";
            dtgBorrowed.Columns[1].Name = "Number of Copies";
            dtgBorrowed.Columns[2].Name = "Release Date";
            dtgBorrowed.Columns[3].Name = "Due Date";
            dtgBorrowed.RowTemplate.Height = 30;
            dtgBorrowed.ColumnHeadersHeight = 50;

            // Header for returned books
            dtgReturned.Rows.Clear();
            dtgReturned.ColumnCount = 5;
            dtgReturned.Columns[0].Name = "Title";
            dtgReturned.Columns[1].Name = "Number of Copies";
            dtgReturned.Columns[2].Name = "Release Date";
            dtgReturned.Columns[3].Name = "Due Date";
            dtgReturned.Columns[4].Name = "Return Date";
            dtgReturned.RowTemplate.Height = 30;
            dtgReturned.ColumnHeadersHeight = 50;

            // Settings for borrowed books
            dtgBorrowed.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBorrowed.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtgBorrowed.Columns[0].Width = 230;
            //dtgBorrowed.Columns[1].Width = 60;
            //dtgBorrowed.Columns[4].Width = 80;
            dtgBorrowed.ClearSelection();

            // Settings for returned books
            dtgReturned.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgReturned.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dtgReturned.Columns[0].Width = 230;
            //dtgReturned.Columns[1].Width = 60;
            //dtgReturned.Columns[4].Width = 80;
            dtgReturned.ClearSelection();
        }
    }
}
