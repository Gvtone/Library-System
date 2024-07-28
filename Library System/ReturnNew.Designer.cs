
namespace Library_System
{
    partial class ReturnNew
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rjButton1 = new Library_System.RJButton();
            this.dtgBorrowed = new Library_System.GTDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpReturn = new Library_System.RJDatePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rjButton14 = new Library_System.RJButton();
            this.btnReturnBook = new Library_System.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBorrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(32, 47);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(449, 2);
            this.pnlSearch.TabIndex = 22;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(32, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(449, 25);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TabStop = false;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
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
            this.rjButton1.Location = new System.Drawing.Point(11, 13);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(491, 46);
            this.rjButton1.TabIndex = 20;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // dtgBorrowed
            // 
            this.dtgBorrowed.AllowUserToAddRows = false;
            this.dtgBorrowed.AllowUserToDeleteRows = false;
            this.dtgBorrowed.AllowUserToResizeColumns = false;
            this.dtgBorrowed.AllowUserToResizeRows = false;
            this.dtgBorrowed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgBorrowed.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.dtgBorrowed.BackgroundColors = System.Drawing.Color.MediumSlateBlue;
            this.dtgBorrowed.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtgBorrowed.BorderRadius = 20;
            this.dtgBorrowed.BorderSize = 0;
            this.dtgBorrowed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgBorrowed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgBorrowed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBorrowed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgBorrowed.ColumnHeadersHeight = 29;
            this.dtgBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBorrowed.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgBorrowed.EnableHeadersVisualStyles = false;
            this.dtgBorrowed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.dtgBorrowed.Location = new System.Drawing.Point(9, 103);
            this.dtgBorrowed.Name = "dtgBorrowed";
            this.dtgBorrowed.ReadOnly = true;
            this.dtgBorrowed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgBorrowed.RowHeadersVisible = false;
            this.dtgBorrowed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.dtgBorrowed.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBorrowed.Size = new System.Drawing.Size(745, 445);
            this.dtgBorrowed.TabIndex = 19;
            this.dtgBorrowed.TabStop = false;
            this.dtgBorrowed.TextColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Borrowed History";
            // 
            // dtpReturn
            // 
            this.dtpReturn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpReturn.BorderSize = 0;
            this.dtpReturn.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.dtpReturn.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.dtpReturn.CustomFormat = "yyyy-MM-dd";
            this.dtpReturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.dtpReturn.Location = new System.Drawing.Point(185, 599);
            this.dtpReturn.Margin = new System.Windows.Forms.Padding(0);
            this.dtpReturn.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(541, 41);
            this.dtpReturn.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.dtpReturn.TabIndex = 32;
            this.dtpReturn.TabStop = false;
            this.dtpReturn.TextColor = System.Drawing.Color.White;
            this.dtpReturn.Value = new System.DateTime(2021, 7, 11, 0, 0, 0, 0);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(41, 601);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(142, 34);
            this.textBox1.TabIndex = 31;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Returned:";
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
            this.rjButton14.Location = new System.Drawing.Point(26, 590);
            this.rjButton14.Name = "rjButton14";
            this.rjButton14.Size = new System.Drawing.Size(715, 55);
            this.rjButton14.TabIndex = 30;
            this.rjButton14.TextColor = System.Drawing.Color.White;
            this.rjButton14.UseVisualStyleBackColor = false;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnReturnBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnReturnBook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnReturnBook.BorderRadius = 10;
            this.btnReturnBook.BorderSize = 0;
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnReturnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnReturnBook.Location = new System.Drawing.Point(242, 663);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(276, 50);
            this.btnReturnBook.TabIndex = 33;
            this.btnReturnBook.TabStop = false;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // ReturnNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rjButton14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.dtgBorrowed);
            this.Name = "ReturnNew";
            this.Size = new System.Drawing.Size(763, 725);
            this.Load += new System.EventHandler(this.ReturnNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBorrowed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private RJButton rjButton1;
        private GTDataGrid dtgBorrowed;
        private System.Windows.Forms.Label label1;
        private RJDatePicker dtpReturn;
        private System.Windows.Forms.TextBox textBox1;
        private RJButton rjButton14;
        private RJButton btnReturnBook;
    }
}
