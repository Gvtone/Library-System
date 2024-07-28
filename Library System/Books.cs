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
    public partial class Books : UserControl
    {
        MySqlConnection CN = new MySqlConnection("server=localhost;uid=root; password=''; database=library");
        MySqlCommand Com = new MySqlCommand();

        public static EventHandler DoneEdit;

        public Books()
        {
            InitializeComponent();
            Com.Connection = CN;

            UserMain.Clicked_Edit += new EventHandler(Edit_Clicked);
        }

        // <Title>
        private void txtTitle_Enter(object sender, EventArgs e)
        {
            if (txtTitle.Text == "Title")
                txtTitle.Text = "";

            // Higlights User
            txtTitle.ForeColor = Color.FromArgb(134, 185, 176);
            pnlTitle.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
                txtTitle.Text = "Title";

            // Unhighlights User
            txtTitle.ForeColor = Color.FromArgb(255, 255, 255);
            pnlTitle.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </Title>

        // <Edition>
        private void txtEdition_Enter(object sender, EventArgs e)
        {
            if (txtEdition.Text == "Edition")
                txtEdition.Text = "";

            // Higlights User
            txtEdition.ForeColor = Color.FromArgb(134, 185, 176);
            pnlEdition.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtEdition_Leave(object sender, EventArgs e)
        {
            if (txtEdition.Text == "")
                txtEdition.Text = "Edition";

            // Unhighlights User
            txtEdition.ForeColor = Color.FromArgb(255, 255, 255);
            pnlEdition.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </Edition>

        // <Author>
        private void txtAuthor_Enter(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "Author")
                txtAuthor.Text = "";

            // Higlights User
            txtAuthor.ForeColor = Color.FromArgb(134, 185, 176);
            pnlAuthor.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtAuthor_Leave(object sender, EventArgs e)
        {
            if (txtAuthor.Text == "")
                txtAuthor.Text = "Author";

            // Unhighlights User
            txtAuthor.ForeColor = Color.FromArgb(255, 255, 255);
            pnlAuthor.BackColor = Color.FromArgb(255, 255, 255);
        }
        // </Author>

        // <Publisher>
        private void txtPublisher_Enter(object sender, EventArgs e)
        {
            if (txtPublisher.Text == "Publisher")
                txtPublisher.Text = "";

            // Higlights User
            txtPublisher.ForeColor = Color.FromArgb(134, 185, 176);
            pnlPublisher.BackColor = Color.FromArgb(134, 185, 176);
        }

        private void txtPublisher_Leave(object sender, EventArgs e)
        {
            if (txtPublisher.Text == "")
                txtPublisher.Text = "Publisher";

            // Unhighlights User
            txtPublisher.ForeColor = Color.FromArgb(255, 255, 255);
            pnlPublisher.BackColor = Color.FromArgb(255, 255, 255);
        }
        // <Publisher>

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
        // </Copies>

        // Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if textboxes are blank
            if (txtTitle.Text == "Title" && txtAuthor.Text == "Author"
                && txtPublisher.Text == "Publisher" && txtCopies.Text == "Copies")
            {
                MessageBox.Show("Please enter the required informations!");
            }
            else if (txtTitle.Text == "Title")
            {
                MessageBox.Show("Please enter the book title!");
                txtTitle.Focus();
            }
            else if (txtAuthor.Text == "Author")
            {
                MessageBox.Show("Please enter the book author!");
                txtAuthor.Focus();
            }
            else if (txtPublisher.Text == "Publisher")
            {
                MessageBox.Show("Please enter the book publisher!");
                txtPublisher.Focus();
            }
            else if (txtCopies.Text == "Copies")
            {
                MessageBox.Show("Please enter the number of copies available!");
                txtCopies.Focus();
            }
            else if (!IsDigit(txtEdition.Text) && txtEdition.Text != "Edition")
            {
                MessageBox.Show("Invalid edition number!");
                txtEdition.Focus();
            }
            else if (!IsDigit(txtCopies.Text))
            {
                MessageBox.Show("Invalid number of copies!");
                txtCopies.Focus();
            }
            else if (txtEdition.Text != "Edition")
            {
                CN.Open();
                Com.CommandText = $"INSERT INTO books(Title, Edition, Author, Publisher, Copies)" +
                    $"VALUES('{txtTitle.Text}', '{txtEdition.Text}', '{txtAuthor.Text}', '{txtPublisher.Text}', '{txtCopies.Text}')";
                Com.ExecuteNonQuery();
                CN.Close();

                MessageBox.Show("Book successfully added!");

                txtTitle.Text = "Title";
                txtEdition.Text = "Edition";
                txtAuthor.Text = "Author";
                txtPublisher.Text = "Publisher";
                txtCopies.Text = "Copies";
            }
            else if (txtEdition.Text == "Edition")
            {
                CN.Open();
                Com.CommandText = $"INSERT INTO books(Title, Edition, Author, Publisher, Copies)" +
                    $"VALUES('{txtTitle.Text}', '1', '{txtAuthor.Text}', '{txtPublisher.Text}', '{txtCopies.Text}')";
                Com.ExecuteNonQuery();
                CN.Close();

                MessageBox.Show("Book successfully added!");

                txtTitle.Text = "Title";
                txtEdition.Text = "Edition";
                txtAuthor.Text = "Author";
                txtPublisher.Text = "Publisher";
                txtCopies.Text = "Copies";
            }
        }

        // Edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            CN.Open();
            Com.CommandText = $"UPDATE books SET Title = '{txtTitle.Text}', Edition = '{txtEdition.Text}', Author = '{txtAuthor.Text}', " +
                $"Publisher = '{txtPublisher.Text}', Copies = '{txtCopies.Text}' WHERE Title = '{ucSearch.ttle}' && Edition = '{ucSearch.edtn}' && Author = '{ucSearch.auth}'";
            Com.ExecuteNonQuery();
            CN.Close();
            
            if (MessageBox.Show("Book successfuly update!", "Updated", MessageBoxButtons.OK) == DialogResult.OK)
            {
                DoneEdit?.Invoke(sender, e);
            }
        }

        // Triggered from search user control
        private void Edit_Clicked(object sender, EventArgs e)
        {
            txtTitle.Text = ucSearch.ttle;
            txtEdition.Text = ucSearch.edtn;
            txtAuthor.Text = ucSearch.auth;
            txtPublisher.Text = ucSearch.pubs;
            txtCopies.Text = ucSearch.copy;

            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
        }

        static bool IsDigit(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
