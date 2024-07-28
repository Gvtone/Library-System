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
    public partial class ucHistory : UserControl
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public ucHistory()
        {
            InitializeComponent();
            Com.Connection = CN;
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

            CN.Open();
            Com.CommandText = $"SELECT * FROM borrow WHERE User_Name = '{LogInForm.username}' ORDER BY Borrow_ID";
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                dtgBorrowed.Rows.Add(reader["Title"].ToString(), reader["Number_Of_Copies"].ToString(), reader["Release_Date"].ToString(), reader["Due_Date"].ToString());
            }

            reader.Close();
            CN.Close();

            CN.Open();
            Com.CommandText = $"SELECT * FROM library.return WHERE User_Name = '{LogInForm.username}' ORDER BY Return_ID";
            reader = Com.ExecuteReader();
            while (reader.Read())
            {
                dtgReturned.Rows.Add(reader["Title"].ToString(), reader["Number_Of_Copies"].ToString(), reader["Release_Date"].ToString(), reader["Due_Date"].ToString(), reader["Return_Date"].ToString());
            }

            reader.Close();
            CN.Close();

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
