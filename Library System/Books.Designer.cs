
namespace Library_System
{
    partial class Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.pnlPublisher = new System.Windows.Forms.Panel();
            this.pnlCopies = new System.Windows.Forms.Panel();
            this.pnlEdition = new System.Windows.Forms.Panel();
            this.btnEdit = new Library_System.RJButton();
            this.btnAdd = new Library_System.RJButton();
            this.rjButton2 = new Library_System.RJButton();
            this.rjButton5 = new Library_System.RJButton();
            this.rjButton4 = new Library_System.RJButton();
            this.rjButton3 = new Library_System.RJButton();
            this.rjButton1 = new Library_System.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(43, 77);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(534, 34);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.TabStop = false;
            this.txtTitle.Text = "Title";
            this.txtTitle.Enter += new System.EventHandler(this.txtTitle_Enter);
            this.txtTitle.Leave += new System.EventHandler(this.txtTitle_Leave);
            // 
            // txtEdition
            // 
            this.txtEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtEdition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEdition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.ForeColor = System.Drawing.Color.White;
            this.txtEdition.Location = new System.Drawing.Point(624, 77);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(104, 34);
            this.txtEdition.TabIndex = 5;
            this.txtEdition.TabStop = false;
            this.txtEdition.Text = "Edition";
            this.txtEdition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEdition.Enter += new System.EventHandler(this.txtEdition_Enter);
            this.txtEdition.Leave += new System.EventHandler(this.txtEdition_Leave);
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.ForeColor = System.Drawing.Color.White;
            this.txtAuthor.Location = new System.Drawing.Point(43, 153);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(686, 34);
            this.txtAuthor.TabIndex = 5;
            this.txtAuthor.TabStop = false;
            this.txtAuthor.Text = "Author";
            this.txtAuthor.Enter += new System.EventHandler(this.txtAuthor_Enter);
            this.txtAuthor.Leave += new System.EventHandler(this.txtAuthor_Leave);
            // 
            // txtPublisher
            // 
            this.txtPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublisher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.ForeColor = System.Drawing.Color.White;
            this.txtPublisher.Location = new System.Drawing.Point(43, 231);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(686, 34);
            this.txtPublisher.TabIndex = 5;
            this.txtPublisher.TabStop = false;
            this.txtPublisher.Text = "Publisher";
            this.txtPublisher.Enter += new System.EventHandler(this.txtPublisher_Enter);
            this.txtPublisher.Leave += new System.EventHandler(this.txtPublisher_Leave);
            // 
            // txtCopies
            // 
            this.txtCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.txtCopies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCopies.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopies.ForeColor = System.Drawing.Color.White;
            this.txtCopies.Location = new System.Drawing.Point(43, 309);
            this.txtCopies.Margin = new System.Windows.Forms.Padding(2);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(105, 34);
            this.txtCopies.TabIndex = 5;
            this.txtCopies.TabStop = false;
            this.txtCopies.Text = "Copies";
            this.txtCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCopies.Enter += new System.EventHandler(this.txtCopies_Enter);
            this.txtCopies.Leave += new System.EventHandler(this.txtCopies_Leave);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Location = new System.Drawing.Point(43, 108);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(534, 2);
            this.pnlTitle.TabIndex = 13;
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.BackColor = System.Drawing.Color.White;
            this.pnlAuthor.Location = new System.Drawing.Point(43, 185);
            this.pnlAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(686, 2);
            this.pnlAuthor.TabIndex = 13;
            // 
            // pnlPublisher
            // 
            this.pnlPublisher.BackColor = System.Drawing.Color.White;
            this.pnlPublisher.Location = new System.Drawing.Point(43, 263);
            this.pnlPublisher.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPublisher.Name = "pnlPublisher";
            this.pnlPublisher.Size = new System.Drawing.Size(686, 2);
            this.pnlPublisher.TabIndex = 13;
            // 
            // pnlCopies
            // 
            this.pnlCopies.BackColor = System.Drawing.Color.White;
            this.pnlCopies.Location = new System.Drawing.Point(43, 341);
            this.pnlCopies.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCopies.Name = "pnlCopies";
            this.pnlCopies.Size = new System.Drawing.Size(105, 2);
            this.pnlCopies.TabIndex = 13;
            // 
            // pnlEdition
            // 
            this.pnlEdition.BackColor = System.Drawing.Color.White;
            this.pnlEdition.Location = new System.Drawing.Point(624, 109);
            this.pnlEdition.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEdition.Name = "pnlEdition";
            this.pnlEdition.Size = new System.Drawing.Size(105, 2);
            this.pnlEdition.TabIndex = 13;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnEdit.Location = new System.Drawing.Point(510, 545);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(231, 50);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnAdd.Location = new System.Drawing.Point(254, 545);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(231, 50);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.rjButton2.Location = new System.Drawing.Point(609, 66);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(132, 55);
            this.rjButton2.TabIndex = 2;
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
            this.rjButton5.Location = new System.Drawing.Point(28, 298);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(133, 55);
            this.rjButton5.TabIndex = 2;
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
            this.rjButton4.Location = new System.Drawing.Point(28, 220);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(713, 55);
            this.rjButton4.TabIndex = 2;
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
            this.rjButton3.Location = new System.Drawing.Point(28, 142);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(713, 55);
            this.rjButton3.TabIndex = 2;
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
            this.rjButton1.Location = new System.Drawing.Point(28, 66);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(564, 55);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.pnlEdition);
            this.Controls.Add(this.pnlCopies);
            this.Controls.Add(this.pnlPublisher);
            this.Controls.Add(this.pnlAuthor);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
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
            this.Controls.Add(this.label1);
            this.Name = "Books";
            this.Size = new System.Drawing.Size(780, 620);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJButton rjButton1;
        private RJButton rjButton2;
        private RJButton rjButton3;
        private RJButton rjButton4;
        private RJButton rjButton5;
        private RJButton btnEdit;
        private RJButton btnAdd;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlAuthor;
        private System.Windows.Forms.Panel pnlPublisher;
        private System.Windows.Forms.Panel pnlCopies;
        private System.Windows.Forms.Panel pnlEdition;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtCopies;
    }
}
