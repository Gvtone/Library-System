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
    public partial class BookSelect : Form
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public static EventHandler SelectBook;

        public static string ttle, edtn, auth, pubs;

        public BookSelect()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            if (dtgResult.SelectedRows.Count > 0)
            {
                Books BK = new Books();

                ttle = dtgResult.SelectedCells[0].Value.ToString();
                edtn = dtgResult.SelectedCells[1].Value.ToString();
                auth = dtgResult.SelectedCells[2].Value.ToString();
                pubs = dtgResult.SelectedCells[3].Value.ToString();

                SelectBook?.Invoke(sender, e);

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a book!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Column header titles
            dtgResult.Rows.Clear();
            dtgResult.ColumnCount = 5;
            dtgResult.Columns[0].Name = "Title";
            dtgResult.Columns[1].Name = "Edition";
            dtgResult.Columns[2].Name = "Author";
            dtgResult.Columns[3].Name = "Publisher";
            dtgResult.Columns[4].Name = "Available Copies";
            dtgResult.RowTemplate.Height = 30;
            dtgResult.ColumnHeadersHeight = 50;

            CN.Open();
            Com.CommandText = $"SELECT * FROM books WHERE title LIKE '%{txtSearch.Text}%' ORDER BY title";
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                dtgResult.Rows.Add(reader["Title"].ToString(), reader["Edition"].ToString(), reader["Author"].ToString(), reader["Publisher"].ToString(), reader["Copies"].ToString());
            }

            reader.Close();
            CN.Close();

            // Additional settings for easier reading
            dtgResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgResult.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgResult.Columns[0].Width = 230;
            dtgResult.Columns[1].Width = 60;
            dtgResult.Columns[4].Width = 80;
            dtgResult.ClearSelection();
        }

        private void BookSelect_Load(object sender, EventArgs e)
        {
            loadgrid();
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

        void loadgrid()
        {
            dtgResult.Rows.Clear();
            dtgResult.ColumnCount = 5;
            dtgResult.Columns[0].Name = "Title";
            dtgResult.Columns[1].Name = "Edition";
            dtgResult.Columns[2].Name = "Author";
            dtgResult.Columns[3].Name = "Publisher";
            dtgResult.Columns[4].Name = "Available Copies";
            dtgResult.RowTemplate.Height = 30;
            dtgResult.ColumnHeadersHeight = 50;

            CN.Open();
            Com.CommandText = "SELECT * FROM books ORDER BY Title";
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                dtgResult.Rows.Add(reader["Title"].ToString(), reader["Edition"].ToString(), reader["Author"].ToString(), reader["Publisher"].ToString(), reader["Copies"].ToString());
            }

            reader.Close();
            CN.Close();

            dtgResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgResult.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgResult.Columns[0].Width = 230;
            dtgResult.Columns[1].Width = 60;
            dtgResult.Columns[4].Width = 80;
            dtgResult.ClearSelection();
        }
    }
}
