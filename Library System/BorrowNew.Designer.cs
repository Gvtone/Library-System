
namespace Library_System
{
    partial class BorrowNew
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.rjButton7 = new Library_System.RJButton();
            this.rjButton11 = new Library_System.RJButton();
            this.rjButton9 = new Library_System.RJButton();
            this.rjButton8 = new Library_System.RJButton();
            this.rjButton6 = new Library_System.RJButton();
            this.btnBorrowBook = new Library_System.RJButton();
            this.btnSelectStudent = new Library_System.RJButton();
            this.btnSelectBook = new Library_System.RJButton();
            this.rjButton2 = new Library_System.RJButton();
            this.rjButton5 = new Library_System.RJButton();
            this.rjButton4 = new Library_System.RJButton();
            this.rjButton3 = new Library_System.RJButton();
            this.rjButton1 = new Library_System.RJButton();
            this.rjButton10 = new Library_System.RJButton();
            this.rjButton12 = new Library_System.RJButton();
            this.pnlCopies = new System.Windows.Forms.Panel();
            this.dtpDue = new Library_System.RJDatePicker();
            this.rjButton13 = new Library_System.RJButton();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.rjButton14 = new Library_System.RJButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpRelease = new Library_System.RJDatePicker();
            this.SuspendLayout();
            // 
            // txtEdition
            // 
            this.txtEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtEdition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.ForeColor = System.Drawing.Color.White;
            this.txtEdition.Location = new System.Drawing.Point(619, 28);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.ReadOnly = true;
            this.txtEdition.Size = new System.Drawing.Size(104, 34);
            this.txtEdition.TabIndex = 19;
            this.txtEdition.TabStop = false;
            this.txtEdition.Text = "Edition";
            this.txtEdition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCopies
            // 
            this.txtCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtCopies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCopies.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopies.ForeColor = System.Drawing.Color.White;
            this.txtCopies.Location = new System.Drawing.Point(38, 260);
            this.txtCopies.Margin = new System.Windows.Forms.Padding(2);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(105, 34);
            this.txtCopies.TabIndex = 20;
            this.txtCopies.TabStop = false;
            this.txtCopies.Text = "Copies";
            this.txtCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCopies.Enter += new System.EventHandler(this.txtCopies_Enter);
            this.txtCopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCopies_KeyPress);
            this.txtCopies.Leave += new System.EventHandler(this.txtCopies_Leave);
            // 
            // txtPublisher
            // 
            this.txtPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublisher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.ForeColor = System.Drawing.Color.White;
            this.txtPublisher.Location = new System.Drawing.Point(38, 182);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(686, 34);
            this.txtPublisher.TabIndex = 21;
            this.txtPublisher.TabStop = false;
            this.txtPublisher.Text = "Publisher";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.Color.White;
            this.txtAuthor.Location = new System.Drawing.Point(38, 104);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(686, 34);
            this.txtAuthor.TabIndex = 22;
            this.txtAuthor.TabStop = false;
            this.txtAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(38, 28);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(534, 34);
            this.txtTitle.TabIndex = 23;
            this.txtTitle.TabStop = false;
            this.txtTitle.Text = "Title";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(38, 382);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(480, 34);
            this.txtUsername.TabIndex = 26;
            this.txtUsername.TabStop = false;
            this.txtUsername.Text = "Username";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(565, 382);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(158, 34);
            this.txtID.TabIndex = 26;
            this.txtID.TabStop = false;
            this.txtID.Text = "ID Number";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(38, 460);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(685, 34);
            this.txtFullName.TabIndex = 26;
            this.txtFullName.TabStop = false;
            this.txtFullName.Text = "Full Name";
            // 
            // txtProgram
            // 
            this.txtProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtProgram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProgram.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgram.ForeColor = System.Drawing.Color.White;
            this.txtProgram.Location = new System.Drawing.Point(38, 538);
            this.txtProgram.Margin = new System.Windows.Forms.Padding(2);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ReadOnly = true;
            this.txtProgram.Size = new System.Drawing.Size(685, 34);
            this.txtProgram.TabIndex = 26;
            this.txtProgram.TabStop = false;
            this.txtProgram.Text = "Program";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.Color.White;
            this.txtContact.Location = new System.Drawing.Point(38, 612);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(388, 34);
            this.txtContact.TabIndex = 26;
            this.txtContact.TabStop = false;
            this.txtContact.Text = "Contact";
            // 
            // rjButton7
            // 
            this.rjButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton7.BorderRadius = 10;
            this.rjButton7.BorderSize = 0;
            this.rjButton7.Enabled = false;
            this.rjButton7.FlatAppearance.BorderSize = 0;
            this.rjButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton7.ForeColor = System.Drawing.Color.White;
            this.rjButton7.Location = new System.Drawing.Point(550, 371);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Size = new System.Drawing.Size(188, 55);
            this.rjButton7.TabIndex = 25;
            this.rjButton7.TextColor = System.Drawing.Color.White;
            this.rjButton7.UseVisualStyleBackColor = false;
            // 
            // rjButton11
            // 
            this.rjButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton11.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton11.BorderRadius = 10;
            this.rjButton11.BorderSize = 0;
            this.rjButton11.Enabled = false;
            this.rjButton11.FlatAppearance.BorderSize = 0;
            this.rjButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton11.ForeColor = System.Drawing.Color.White;
            this.rjButton11.Location = new System.Drawing.Point(23, 601);
            this.rjButton11.Name = "rjButton11";
            this.rjButton11.Size = new System.Drawing.Size(418, 55);
            this.rjButton11.TabIndex = 25;
            this.rjButton11.TextColor = System.Drawing.Color.White;
            this.rjButton11.UseVisualStyleBackColor = false;
            // 
            // rjButton9
            // 
            this.rjButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton9.BorderRadius = 10;
            this.rjButton9.BorderSize = 0;
            this.rjButton9.Enabled = false;
            this.rjButton9.FlatAppearance.BorderSize = 0;
            this.rjButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton9.ForeColor = System.Drawing.Color.White;
            this.rjButton9.Location = new System.Drawing.Point(23, 527);
            this.rjButton9.Name = "rjButton9";
            this.rjButton9.Size = new System.Drawing.Size(715, 55);
            this.rjButton9.TabIndex = 25;
            this.rjButton9.TextColor = System.Drawing.Color.White;
            this.rjButton9.UseVisualStyleBackColor = false;
            // 
            // rjButton8
            // 
            this.rjButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton8.BorderRadius = 10;
            this.rjButton8.BorderSize = 0;
            this.rjButton8.Enabled = false;
            this.rjButton8.FlatAppearance.BorderSize = 0;
            this.rjButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton8.ForeColor = System.Drawing.Color.White;
            this.rjButton8.Location = new System.Drawing.Point(23, 449);
            this.rjButton8.Name = "rjButton8";
            this.rjButton8.Size = new System.Drawing.Size(715, 55);
            this.rjButton8.TabIndex = 25;
            this.rjButton8.TextColor = System.Drawing.Color.White;
            this.rjButton8.UseVisualStyleBackColor = false;
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 10;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.Enabled = false;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(23, 371);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(510, 55);
            this.rjButton6.TabIndex = 25;
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnBorrowBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnBorrowBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnBorrowBook.BorderRadius = 10;
            this.btnBorrowBook.BorderSize = 0;
            this.btnBorrowBook.FlatAppearance.BorderSize = 0;
            this.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnBorrowBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnBorrowBook.Location = new System.Drawing.Point(257, 885);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(276, 50);
            this.btnBorrowBook.TabIndex = 24;
            this.btnBorrowBook.TabStop = false;
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnSelectStudent
            // 
            this.btnSelectStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnSelectStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnSelectStudent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnSelectStudent.BorderRadius = 10;
            this.btnSelectStudent.BorderSize = 0;
            this.btnSelectStudent.FlatAppearance.BorderSize = 0;
            this.btnSelectStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnSelectStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnSelectStudent.Location = new System.Drawing.Point(462, 602);
            this.btnSelectStudent.Name = "btnSelectStudent";
            this.btnSelectStudent.Size = new System.Drawing.Size(276, 50);
            this.btnSelectStudent.TabIndex = 24;
            this.btnSelectStudent.TabStop = false;
            this.btnSelectStudent.Text = "Select Student";
            this.btnSelectStudent.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnSelectStudent.UseVisualStyleBackColor = false;
            this.btnSelectStudent.Click += new System.EventHandler(this.btnSelectStudent_Click);
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnSelectBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnSelectBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnSelectBook.BorderRadius = 10;
            this.btnSelectBook.BorderSize = 0;
            this.btnSelectBook.FlatAppearance.BorderSize = 0;
            this.btnSelectBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnSelectBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnSelectBook.Location = new System.Drawing.Point(460, 251);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(276, 50);
            this.btnSelectBook.TabIndex = 24;
            this.btnSelectBook.TabStop = false;
            this.btnSelectBook.Text = "Select Book";
            this.btnSelectBook.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnSelectBook.UseVisualStyleBackColor = false;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Enabled = false;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(604, 17);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(132, 55);
            this.rjButton2.TabIndex = 14;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton5.BorderRadius = 10;
            this.rjButton5.BorderSize = 0;
            this.rjButton5.Enabled = false;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(23, 249);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(133, 55);
            this.rjButton5.TabIndex = 15;
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton4.BorderRadius = 10;
            this.rjButton4.BorderSize = 0;
            this.rjButton4.Enabled = false;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(23, 171);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(713, 55);
            this.rjButton4.TabIndex = 16;
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton3.BorderRadius = 10;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.Enabled = false;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(23, 93);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(713, 55);
            this.rjButton3.TabIndex = 17;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(23, 17);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(564, 55);
            this.rjButton1.TabIndex = 18;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton10
            // 
            this.rjButton10.BackColor = System.Drawing.Color.Transparent;
            this.rjButton10.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton10.BorderColor = System.Drawing.Color.White;
            this.rjButton10.BorderRadius = 10;
            this.rjButton10.BorderSize = 3;
            this.rjButton10.Enabled = false;
            this.rjButton10.FlatAppearance.BorderSize = 0;
            this.rjButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton10.ForeColor = System.Drawing.Color.White;
            this.rjButton10.Location = new System.Drawing.Point(14, 3);
            this.rjButton10.Name = "rjButton10";
            this.rjButton10.Size = new System.Drawing.Size(736, 314);
            this.rjButton10.TabIndex = 27;
            this.rjButton10.TextColor = System.Drawing.Color.White;
            this.rjButton10.UseVisualStyleBackColor = false;
            // 
            // rjButton12
            // 
            this.rjButton12.BackColor = System.Drawing.Color.Transparent;
            this.rjButton12.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton12.BorderColor = System.Drawing.Color.White;
            this.rjButton12.BorderRadius = 10;
            this.rjButton12.BorderSize = 3;
            this.rjButton12.Enabled = false;
            this.rjButton12.FlatAppearance.BorderSize = 0;
            this.rjButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton12.ForeColor = System.Drawing.Color.White;
            this.rjButton12.Location = new System.Drawing.Point(14, 357);
            this.rjButton12.Name = "rjButton12";
            this.rjButton12.Size = new System.Drawing.Size(736, 308);
            this.rjButton12.TabIndex = 27;
            this.rjButton12.TextColor = System.Drawing.Color.White;
            this.rjButton12.UseVisualStyleBackColor = false;
            // 
            // pnlCopies
            // 
            this.pnlCopies.BackColor = System.Drawing.Color.White;
            this.pnlCopies.Location = new System.Drawing.Point(38, 292);
            this.pnlCopies.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCopies.Name = "pnlCopies";
            this.pnlCopies.Size = new System.Drawing.Size(105, 2);
            this.pnlCopies.TabIndex = 28;
            // 
            // dtpDue
            // 
            this.dtpDue.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpDue.BorderSize = 0;
            this.dtpDue.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.dtpDue.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.dtpDue.CustomFormat = "yyyy-MM-dd";
            this.dtpDue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.dtpDue.Location = new System.Drawing.Point(175, 807);
            this.dtpDue.Margin = new System.Windows.Forms.Padding(0);
            this.dtpDue.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(548, 41);
            this.dtpDue.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.dtpDue.TabIndex = 29;
            this.dtpDue.TabStop = false;
            this.dtpDue.TextColor = System.Drawing.Color.White;
            this.dtpDue.Value = new System.DateTime(2021, 11, 30, 0, 0, 0, 0);
            // 
            // rjButton13
            // 
            this.rjButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton13.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton13.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton13.BorderRadius = 10;
            this.rjButton13.BorderSize = 0;
            this.rjButton13.Enabled = false;
            this.rjButton13.FlatAppearance.BorderSize = 0;
            this.rjButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton13.ForeColor = System.Drawing.Color.White;
            this.rjButton13.Location = new System.Drawing.Point(23, 798);
            this.rjButton13.Name = "rjButton13";
            this.rjButton13.Size = new System.Drawing.Size(715, 55);
            this.rjButton13.TabIndex = 25;
            this.rjButton13.TextColor = System.Drawing.Color.White;
            this.rjButton13.UseVisualStyleBackColor = false;
            // 
            // txtDue
            // 
            this.txtDue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDue.ForeColor = System.Drawing.Color.White;
            this.txtDue.Location = new System.Drawing.Point(38, 809);
            this.txtDue.Margin = new System.Windows.Forms.Padding(2);
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(142, 34);
            this.txtDue.TabIndex = 26;
            this.txtDue.TabStop = false;
            this.txtDue.Text = "Due Date:";
            // 
            // rjButton14
            // 
            this.rjButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton14.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.rjButton14.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton14.BorderRadius = 10;
            this.rjButton14.BorderSize = 0;
            this.rjButton14.Enabled = false;
            this.rjButton14.FlatAppearance.BorderSize = 0;
            this.rjButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton14.ForeColor = System.Drawing.Color.White;
            this.rjButton14.Location = new System.Drawing.Point(23, 722);
            this.rjButton14.Name = "rjButton14";
            this.rjButton14.Size = new System.Drawing.Size(715, 55);
            this.rjButton14.TabIndex = 25;
            this.rjButton14.TextColor = System.Drawing.Color.White;
            this.rjButton14.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(38, 733);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(142, 34);
            this.textBox1.TabIndex = 26;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Release:";
            // 
            // dtpRelease
            // 
            this.dtpRelease.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpRelease.BorderSize = 0;
            this.dtpRelease.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.dtpRelease.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.dtpRelease.CustomFormat = "yyyy-MM-dd";
            this.dtpRelease.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.dtpRelease.Location = new System.Drawing.Point(175, 731);
            this.dtpRelease.Margin = new System.Windows.Forms.Padding(0);
            this.dtpRelease.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(548, 41);
            this.dtpRelease.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.dtpRelease.TabIndex = 29;
            this.dtpRelease.TabStop = false;
            this.dtpRelease.TextColor = System.Drawing.Color.White;
            this.dtpRelease.Value = new System.DateTime(2021, 11, 30, 0, 0, 0, 0);
            // 
            // BorrowNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.dtpDue);
            this.Controls.Add(this.pnlCopies);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.rjButton7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.rjButton14);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.rjButton13);
            this.Controls.Add(this.rjButton11);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.rjButton9);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.rjButton8);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.rjButton6);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.btnSelectStudent);
            this.Controls.Add(this.btnSelectBook);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjButton5);
            this.Controls.Add(this.rjButton4);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.rjButton12);
            this.Controls.Add(this.rjButton10);
            this.Name = "BorrowNew";
            this.Size = new System.Drawing.Size(763, 954);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private RJButton rjButton2;
        private RJButton rjButton5;
        private RJButton rjButton4;
        private RJButton rjButton3;
        private RJButton rjButton1;
        private RJButton btnSelectBook;
        private System.Windows.Forms.TextBox txtUsername;
        private RJButton rjButton6;
        private RJButton rjButton7;
        private System.Windows.Forms.TextBox txtID;
        private RJButton rjButton8;
        private System.Windows.Forms.TextBox txtFullName;
        private RJButton rjButton9;
        private System.Windows.Forms.TextBox txtProgram;
        private RJButton btnSelectStudent;
        private RJButton btnBorrowBook;
        private RJButton rjButton11;
        private System.Windows.Forms.TextBox txtContact;
        private RJButton rjButton10;
        private RJButton rjButton12;
        private System.Windows.Forms.Panel pnlCopies;
        private RJDatePicker dtpDue;
        private RJButton rjButton13;
        private System.Windows.Forms.TextBox txtDue;
        private RJButton rjButton14;
        private System.Windows.Forms.TextBox textBox1;
        private RJDatePicker dtpRelease;
    }
}
