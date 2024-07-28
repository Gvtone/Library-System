
namespace Library_System
{
    partial class Borrow
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
            this.pnlBorrow = new System.Windows.Forms.Panel();
            this.btnHistory = new Library_System.RJButton();
            this.btnNew = new Library_System.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Borrow";
            // 
            // pnlBorrow
            // 
            this.pnlBorrow.AutoScroll = true;
            this.pnlBorrow.Location = new System.Drawing.Point(0, 80);
            this.pnlBorrow.Name = "pnlBorrow";
            this.pnlBorrow.Size = new System.Drawing.Size(780, 540);
            this.pnlBorrow.TabIndex = 15;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnHistory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnHistory.BorderRadius = 10;
            this.btnHistory.BorderSize = 0;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnHistory.Location = new System.Drawing.Point(613, 10);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(156, 50);
            this.btnHistory.TabIndex = 13;
            this.btnHistory.TabStop = false;
            this.btnHistory.Text = "History";
            this.btnHistory.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnNew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnNew.BorderRadius = 10;
            this.btnNew.BorderSize = 0;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnNew.Location = new System.Drawing.Point(447, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(156, 50);
            this.btnNew.TabIndex = 14;
            this.btnNew.TabStop = false;
            this.btnNew.Text = "New";
            this.btnNew.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.pnlBorrow);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Name = "Borrow";
            this.Size = new System.Drawing.Size(780, 620);
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RJButton btnHistory;
        private RJButton btnNew;
        private System.Windows.Forms.Panel pnlBorrow;
    }
}
