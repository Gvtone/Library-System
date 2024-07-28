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
    public partial class ReturnHistory : UserControl
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public ReturnHistory()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        private void ReturnHistory_Load(object sender, EventArgs e)
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
            dtgReturned.Rows.Clear();
            dtgReturned.ColumnCount = 6;
            dtgReturned.Columns[0].Name = "Student";
            dtgReturned.Columns[1].Name = "Title";
            dtgReturned.Columns[2].Name = "Number of Copies";
            dtgReturned.Columns[3].Name = "Release Date";
            dtgReturned.Columns[4].Name = "Due Date";
            dtgReturned.Columns[5].Name = "Return Date";
            dtgReturned.RowTemplate.Height = 30;
            dtgReturned.ColumnHeadersHeight = 50;

            // Loads the history of returned books by the searched user
            CN.Open();
            Com.CommandText = "SELECT * FROM library.return INNER JOIN users  WHERE return.User_name = users.Username ORDER BY return.Return_ID";
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                dtgReturned.Rows.Add(reader["Username"].ToString(), reader["Title"].ToString(), reader["Number_Of_Copies"].ToString(), reader["Release_Date"].ToString(), reader["Due_Date"].ToString(), reader["Return_Date"].ToString());
            }

            reader.Close();
            CN.Close();

            // Settings for borrowed books
            dtgReturned.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgReturned.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgReturned.ClearSelection();
        }

        void loadgrid2()
        {
            // Header for borrowed books
            dtgReturned.Rows.Clear();
            dtgReturned.ColumnCount = 6;
            dtgReturned.Columns[0].Name = "Student";
            dtgReturned.Columns[1].Name = "Title";
            dtgReturned.Columns[2].Name = "Number of Copies";
            dtgReturned.Columns[3].Name = "Release Date";
            dtgReturned.Columns[4].Name = "Due Date";
            dtgReturned.Columns[5].Name = "Return Date";
            dtgReturned.RowTemplate.Height = 30;
            dtgReturned.ColumnHeadersHeight = 50;

            dtgReturned.Rows.Clear();

            CN.Open();
            if (txtSearch.Text == "")
            {
                Com.CommandText = "SELECT * FROM library.return INNER JOIN users  WHERE return.User_name = users.Username ORDER BY return.Return_ID";
            }
            else
            {
                Com.CommandText = $"SELECT * FROM library.return INNER JOIN users WHERE return.User_name = users.Username AND users.Username LIKE '%{txtSearch.Text}%' ORDER BY return.Return_ID";
            }

            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                dtgReturned.Rows.Add(reader["Username"].ToString(), reader["Title"].ToString(), reader["Number_Of_Copies"].ToString(), reader["Release_Date"].ToString(), reader["Due_Date"].ToString(), reader["Return_Date"].ToString());
            }

            reader.Close();
            CN.Close();

            // Settings for borrowed books
            dtgReturned.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgReturned.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgReturned.ClearSelection();
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
