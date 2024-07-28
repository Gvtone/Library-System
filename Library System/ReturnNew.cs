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
    public partial class ReturnNew : UserControl
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public ReturnNew()
        {
            InitializeComponent();
            Com.Connection = CN;

            dtpReturn.Value = DateTime.Today;
        }

        private void ReturnNew_Load(object sender, EventArgs e)
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

        // Return Button
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dtgBorrowed.SelectedRows.Count > 0)
            {
                string sdnt = dtgBorrowed.SelectedCells[0].Value.ToString();
                string ttle = dtgBorrowed.SelectedCells[1].Value.ToString();

                CN.Open();
                Com.CommandText = $"SELECT Title, Number_Of_Copies FROM borrow WHERE User_Name = '{sdnt}' && Title = '{ttle}'";
                reader = Com.ExecuteReader();
                reader.Read();
                string title = reader["Title"].ToString();
                string copy = reader["Number_Of_Copies"].ToString();
                reader.Close();
                CN.Close();

                // Migrate the data from the borrow table to the return table
                CN.Open();
                Com.CommandText = $"INSERT INTO library.return (Book_ID, Title, ID_Number,User_Name, Number_Of_Copies, Release_Date, Due_Date) " +
                    $"SELECT Book_ID, Title, ID_Number, User_Name, Number_Of_Copies, Release_Date, Due_Date FROM library.borrow WHERE Title = '{title}' && User_Name = '{sdnt}'";
                Com.ExecuteNonQuery();
                CN.Close();

                // Updates the return date of the book
                CN.Open();
                Com.CommandText = $"UPDATE library.return set Return_Date = '{dtpReturn.Value.ToString("yyyy/MM/dd")}' WHERE Title = '{title}' && User_Name = '{sdnt}'";
                Com.ExecuteNonQuery();
                CN.Close();

                // Increment the number of books based on how many books were returned
                CN.Open();
                Com.CommandText = $"SELECT Copies FROM books WHERE Title = '{title}'";
                reader = Com.ExecuteReader();
                reader.Read();
                int numCopies = Convert.ToInt32(reader["Copies"]) + Convert.ToInt32(copy);
                reader.Close();
                CN.Close();

                // Upsate the number of copies
                CN.Open();
                Com.CommandText = $"UPDATE books set Copies = '{numCopies}' WHERE Title = '{title}'";
                Com.ExecuteNonQuery();
                CN.Close();

                // Delete the borrowed book in the user's data base
                CN.Open();
                Com.CommandText = $"Delete FROM borrow WHERE User_Name = '{sdnt}' && Title = '{ttle}'";
                Com.ExecuteNonQuery();
                CN.Close();

                loadgrid();
                MessageBox.Show("Books successfully returned!");
            }
            else
            {
                MessageBox.Show("Please select a borrowed book!");
            }
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
