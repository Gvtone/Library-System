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
    public partial class BorrowHistory : UserControl
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public BorrowHistory()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        private void BorrowHistory_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadgrid2();
        }

        void loadgrid()
        {
            // Header for borrowed books
            dtgBorrowed.Rows.Clear();
            dtgBorrowed.ColumnCount = 5;
            dtgBorrowed.Columns[0].Name = "Student";
            dtgBorrowed.Columns[1].Name = "Title";
            dtgBorrowed.Columns[2].Name = "Number of Copies";
            dtgBorrowed.Columns[3].Name = "Release Date";
            dtgBorrowed.Columns[4].Name = "Due Date";
            dtgBorrowed.RowTemplate.Height = 30;
            dtgBorrowed.ColumnHeadersHeight = 50;

            // Loads the history of returned books by the searched user
            CN.Open();
            Com.CommandText = "SELECT * FROM borrow INNER JOIN users WHERE borrow.User_name = users.Username ORDER BY borrow.Borrow_ID";
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                dtgBorrowed.Rows.Add(reader["Username"].ToString(), reader["Title"].ToString(), reader["Number_Of_Copies"].ToString(), reader["Release_Date"].ToString(), reader["Due_Date"].ToString());
            }

            reader.Close();
            CN.Close();

            // Settings for borrowed books
            dtgBorrowed.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBorrowed.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBorrowed.ClearSelection();
        }

        void loadgrid2()
        {
            // Header for borrowed books
            dtgBorrowed.Rows.Clear();
            dtgBorrowed.ColumnCount = 5;
            dtgBorrowed.Columns[0].Name = "Student";
            dtgBorrowed.Columns[1].Name = "Title";
            dtgBorrowed.Columns[2].Name = "Number of Copies";
            dtgBorrowed.Columns[3].Name = "Release Date";
            dtgBorrowed.Columns[4].Name = "Due Date";
            dtgBorrowed.RowTemplate.Height = 30;
            dtgBorrowed.ColumnHeadersHeight = 50;

            dtgBorrowed.Rows.Clear();

            CN.Open();
            if (txtSearch.Text == "")
            {
                Com.CommandText = "SELECT * FROM borrow INNER JOIN users WHERE borrow.User_name = users.Username ORDER BY borrow.Borrow_ID";
            }
            else
            {
                Com.CommandText = $"SELECT * FROM borrow INNER JOIN users WHERE borrow.User_name = users.Username AND users.Username LIKE '%{txtSearch.Text}%' ORDER BY borrow.Borrow_ID";
            }

            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                dtgBorrowed.Rows.Add(reader["Username"].ToString(), reader["Title"].ToString(), reader["Number_Of_Copies"].ToString(), reader["Release_Date"].ToString(), reader["Due_Date"].ToString());
            }

            reader.Close();
            CN.Close();

            // Settings for borrowed books
            dtgBorrowed.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBorrowed.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgBorrowed.ClearSelection();
        }

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
    }
}
