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
    public partial class ucSearch : UserControl
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        // Event handlers
        public static EventHandler AddClicked;
        public static EventHandler EditClicked;

        public static string ttle, edtn, auth, pubs, copy;

        public ucSearch()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        private void ucSearch_Load(object sender, EventArgs e)
        {
            if (LogInForm.userType == "USER") // Load search control for ordinary users
            {
                loadgrid();
                dtgResult.Width = 745;
                dtgResult.Height = 454;
                btnAdd.Hide();
                btnEdit.Hide();
                btnDelete.Hide();
            }
            else // Load search control for admins
            {
                loadgrid();
                dtgResult.Width = 745;
                dtgResult.Height = 370;
            }
            
        }

        // Loads the data from the database
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

        // Search Button
        private void btnSearch_Click(object sender, EventArgs e)
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
            Com.CommandText = $"SELECT * FROM books WHERE {cmbSearchBy.Texts} LIKE '%{txtSearch.Text}%' ORDER BY title";
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

        // <Add, Edit, Delete>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClicked?.Invoke(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgResult.SelectedRows.Count > 0)
            {
                Books BK = new Books();

                ttle = dtgResult.SelectedCells[0].Value.ToString();
                edtn = dtgResult.SelectedCells[1].Value.ToString();
                auth = dtgResult.SelectedCells[2].Value.ToString();
                pubs = dtgResult.SelectedCells[3].Value.ToString();
                copy = dtgResult.SelectedCells[4].Value.ToString();

                EditClicked?.Invoke(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a book!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgResult.SelectedRows.Count > 0)
            {
                string title = dtgResult.SelectedCells[0].Value.ToString();
                int edition = Convert.ToInt32(dtgResult.SelectedCells[1].Value);
                string author = dtgResult.SelectedCells[2].Value.ToString();

                if (MessageBox.Show($"Are you sure you want to delete {title}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CN.Open();
                    Com.CommandText = $"DELETE FROM books WHERE Title = '{title}' && Edition = '{edition}' && Author = '{author}'";
                    Com.ExecuteNonQuery();
                    CN.Close();

                    MessageBox.Show("Successfuly deleted!");
                    loadgrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a book!");
            }
        }
        // <Add, Edit, Delete>
    }
}
