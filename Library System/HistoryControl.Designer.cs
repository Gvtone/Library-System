
namespace Library_System
{
    partial class ucHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgBorrowed = new Library_System.GTDataGrid();
            this.dtgReturned = new Library_System.GTDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBorrowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReturned)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "History";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgBorrowed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBorrowed.ColumnHeadersHeight = 29;
            this.dtgBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBorrowed.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBorrowed.EnableHeadersVisualStyles = false;
            this.dtgBorrowed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.dtgBorrowed.Location = new System.Drawing.Point(23, 96);
            this.dtgBorrowed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgBorrowed.Name = "dtgBorrowed";
            this.dtgBorrowed.ReadOnly = true;
            this.dtgBorrowed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgBorrowed.RowHeadersVisible = false;
            this.dtgBorrowed.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.dtgBorrowed.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgBorrowed.Size = new System.Drawing.Size(993, 279);
            this.dtgBorrowed.TabIndex = 2;
            this.dtgBorrowed.TabStop = false;
            this.dtgBorrowed.TextColor = System.Drawing.Color.White;
            // 
            // dtgReturned
            // 
            this.dtgReturned.AllowUserToAddRows = false;
            this.dtgReturned.AllowUserToDeleteRows = false;
            this.dtgReturned.AllowUserToResizeColumns = false;
            this.dtgReturned.AllowUserToResizeRows = false;
            this.dtgReturned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReturned.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.dtgReturned.BackgroundColors = System.Drawing.Color.MediumSlateBlue;
            this.dtgReturned.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtgReturned.BorderRadius = 20;
            this.dtgReturned.BorderSize = 0;
            this.dtgReturned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgReturned.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgReturned.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReturned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgReturned.ColumnHeadersHeight = 29;
            this.dtgReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgReturned.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgReturned.EnableHeadersVisualStyles = false;
            this.dtgReturned.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.dtgReturned.Location = new System.Drawing.Point(23, 446);
            this.dtgReturned.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgReturned.Name = "dtgReturned";
            this.dtgReturned.ReadOnly = true;
            this.dtgReturned.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgReturned.RowHeadersVisible = false;
            this.dtgReturned.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.dtgReturned.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgReturned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgReturned.Size = new System.Drawing.Size(993, 279);
            this.dtgReturned.TabIndex = 2;
            this.dtgReturned.TabStop = false;
            this.dtgReturned.TextColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(385, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Borrowed Books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(392, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 34);
            this.label3.TabIndex = 1;
            this.label3.Text = "Returned Books";
            // 
            // ucHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.dtgReturned);
            this.Controls.Add(this.dtgBorrowed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucHistory";
            this.Size = new System.Drawing.Size(1040, 763);
            this.Load += new System.EventHandler(this.ucHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBorrowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReturned)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private GTDataGrid dtgBorrowed;
        private GTDataGrid dtgReturned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
