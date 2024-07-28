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
    public partial class StudentSelect : Form
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public static EventHandler SelectStudent;

        public static string user, idno, name, prog, cont;

        public StudentSelect()
        {
            InitializeComponent();
            Com.Connection = CN;
        }

        private void btnSelectStudent_Click(object sender, EventArgs e)
        {
            if (dtgResult.SelectedRows.Count > 0)
            {
                Books BK = new Books();

                user = dtgResult.SelectedCells[0].Value.ToString();
                idno = dtgResult.SelectedCells[1].Value.ToString();
                name = dtgResult.SelectedCells[2].Value.ToString() + " " + dtgResult.SelectedCells[3].Value.ToString();
                prog = dtgResult.SelectedCells[4].Value.ToString();
                cont = dtgResult.SelectedCells[5].Value.ToString();

                SelectStudent?.Invoke(sender, e);

                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a student!");
            }
        }

        // <Search>
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
        // </Search>

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Column header titles
            dtgResult.Rows.Clear();
            dtgResult.ColumnCount = 6;
            dtgResult.Columns[0].Name = "Username";
            dtgResult.Columns[1].Name = "ID Number";
            dtgResult.Columns[2].Name = "First Name";
            dtgResult.Columns[3].Name = "Last Name";
            dtgResult.Columns[4].Name = "Program";
            dtgResult.Columns[5].Name = "Contact";
            dtgResult.RowTemplate.Height = 30;
            dtgResult.ColumnHeadersHeight = 50;

            CN.Open();
            Com.CommandText = $"SELECT * FROM users WHERE Username LIKE '%{txtSearch.Text}%' AND User_Type = 'USER' ORDER BY Username";
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                dtgResult.Rows.Add(reader["Username"].ToString(), reader["ID_Number"].ToString(), reader["First_Name"].ToString(), reader["Last_Name"].ToString(), reader["Program"].ToString(), reader["Contact_Number"].ToString());
            }

            reader.Close();
            CN.Close();

            dtgResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgResult.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // dtgResult.Columns[2].Width = 230;
            // dtgResult.Columns[1].Width = 60;
            // dtgResult.Columns[4].Width = 250;
            dtgResult.ClearSelection();
        }

        private void StudentSelect_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        void loadgrid()
        {
            // Column header titles
            dtgResult.Rows.Clear();
            dtgResult.ColumnCount = 6;
            dtgResult.Columns[0].Name = "Username";
            dtgResult.Columns[1].Name = "ID Number";
            dtgResult.Columns[2].Name = "First Name";
            dtgResult.Columns[3].Name = "Last Name";
            dtgResult.Columns[4].Name = "Program";
            dtgResult.Columns[5].Name = "Contact";
            dtgResult.RowTemplate.Height = 30;
            dtgResult.ColumnHeadersHeight = 50;

            CN.Open();
            Com.CommandText = "SELECT * FROM users WHERE User_Type = 'USER' ORDER BY Username";
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                dtgResult.Rows.Add(reader["Username"].ToString(), reader["ID_Number"].ToString(), reader["First_Name"].ToString(), reader["Last_Name"].ToString(), reader["Program"].ToString(), reader["Contact_Number"].ToString());
            }

            reader.Close();
            CN.Close();

            dtgResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgResult.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // dtgResult.Columns[2].Width = 230;
            // dtgResult.Columns[1].Width = 60;
            // dtgResult.Columns[4].Width = 250;
            dtgResult.ClearSelection();
        }
    }
}
