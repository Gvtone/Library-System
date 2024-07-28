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
    public partial class BorrowNew : UserControl
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();
        MySqlDataReader reader;

        public BorrowNew()
        {
            InitializeComponent();
            Com.Connection = CN;

            dtpDue.Value = DateTime.Today.AddDays(7);
            dtpRelease.Value = DateTime.Today;

            BookSelect.SelectBook += new EventHandler(UpadteSelectedBok);
            StudentSelect.SelectStudent += new EventHandler(UpdateSelectedstudent);
        }

        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            BookSelect BK = new BookSelect();
            BK.ShowDialog();
        }

        private void btnSelectStudent_Click(object sender, EventArgs e)
        {
            StudentSelect SS = new StudentSelect();
            SS.ShowDialog();
        }

        // Input book info
        private void UpadteSelectedBok(object sender, EventArgs e)
        {
            txtTitle.Text = BookSelect.ttle;
            txtEdition.Text = BookSelect.edtn;
            txtAuthor.Text = BookSelect.auth;
            txtPublisher.Text = BookSelect.pubs;
        }

        private void UpdateSelectedstudent(object sender, EventArgs e)
        {
            txtUsername.Text = StudentSelect.user;
            txtID.Text = StudentSelect.idno;
            txtFullName.Text = StudentSelect.name;
            txtProgram.Text = StudentSelect.prog;
            txtContact.Text = StudentSelect.cont;
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Title" && txtUsername.Text == "Username")
            {
                MessageBox.Show("Please select a book and a student!");
            }
            else if (txtTitle.Text == "Title")
            {
                MessageBox.Show("Please select a book!");
            }
            else if (txtUsername.Text == "Username")
            {
                MessageBox.Show("Please select a student!");
            }
            else if (txtCopies.Text == "Copies")
            {
                MessageBox.Show("Please state the number of copies!");
                txtCopies.Focus();
            }
            else
            {
                CN.Open();
                Com.CommandText = $"SELECT Book_ID FROM books WHERE Title = '{txtTitle.Text}'";
                reader = Com.ExecuteReader();
                reader.Read();
                string titleTemp = reader["Book_ID"].ToString();
                reader.Close();
                CN.Close();

                CN.Open();
                Com.CommandText = $"INSERT INTO borrow (Book_ID, Title, ID_Number, User_Name, Number_Of_Copies, Release_Date, Due_Date)" +
                    $"VALUES('{titleTemp}', '{txtTitle.Text}', '{txtID.Text}', '{txtUsername.Text}', '{txtCopies.Text}', '{dtpRelease.Value.ToString("yyyy/MM/dd")}', '{dtpDue.Value.ToString("yyyy/MM/dd")}')";
                Com.ExecuteNonQuery();
                CN.Close();

                CN.Open();
                Com.CommandText = $"SELECT Copies FROM books WHERE Title = '{txtTitle.Text}'";
                reader = Com.ExecuteReader();
                reader.Read();
                int numCopies = Convert.ToInt32(reader["Copies"]) - Convert.ToInt32(txtCopies.Text);
                reader.Close();
                CN.Close();

                CN.Open();
                Com.CommandText = $"UPDATE books set Copies = '{numCopies}' WHERE Title = '{txtTitle.Text}'";
                Com.ExecuteNonQuery();
                CN.Close();

                if (MessageBox.Show("Book successfully borrowed! Would you like to add another book for the same user?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtTitle.Text = "Title";
                    txtEdition.Text = "Edition";
                    txtAuthor.Text = "Author";
                    txtPublisher.Text = "Publisher";
                    txtCopies.Text = "Copies";

                    btnSelectBook_Click(sender, e);
                }
                else
                {
                    txtTitle.Text = "Title";
                    txtEdition.Text = "Edition";
                    txtAuthor.Text = "Author";
                    txtPublisher.Text = "Publisher";
                    txtCopies.Text = "Copies";

                    txtUsername.Text = "Username";
                    txtID.Text = "ID Number";
                    txtFullName.Text = "Full Name";
                    txtProgram.Text = "Program";
                    txtContact.Text = "Contact";
                }
            }
        }

        // <Copies>
        private void txtCopies_Enter(object sender, EventArgs e)
        {
            if (txtCopies.Text == "Copies")
                txtCopies.Text = "";

            // Higlights User
            txtCopies.ForeColor = Color.FromArgb(134, 185, 176);
            pnlCopies.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtCopies_Leave(object sender, EventArgs e)
        {
            if (txtCopies.Text == "")
                txtCopies.Text = "Copies";

            // Unhighlights User
            txtCopies.ForeColor = Color.FromArgb(255, 255, 255);
            pnlCopies.BackColor = Color.FromArgb(255, 255, 255);
        }

        // Prevents inputing non-numerical character
        private void txtCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // </Copies>
    }
}
