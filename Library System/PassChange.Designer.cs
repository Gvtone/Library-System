
namespace Library_System
{
    partial class PassChange
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlPassConfirm = new System.Windows.Forms.Panel();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.btnConfirm = new Library_System.RJButton();
            this.rjButton2 = new Library_System.RJButton();
            this.rjButton1 = new Library_System.RJButton();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            this.btnExit.BackgroundImage = global::Library_System.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(421, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlPassConfirm
            // 
            this.pnlPassConfirm.BackColor = System.Drawing.Color.White;
            this.pnlPassConfirm.Location = new System.Drawing.Point(39, 160);
            this.pnlPassConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPassConfirm.Name = "pnlPassConfirm";
            this.pnlPassConfirm.Size = new System.Drawing.Size(376, 2);
            this.pnlPassConfirm.TabIndex = 9;
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.txtPassConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassConfirm.ForeColor = System.Drawing.Color.White;
            this.txtPassConfirm.Location = new System.Drawing.Point(39, 131);
            this.txtPassConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Size = new System.Drawing.Size(376, 25);
            this.txtPassConfirm.TabIndex = 8;
            this.txtPassConfirm.TabStop = false;
            this.txtPassConfirm.Text = "Confirm Password";
            this.txtPassConfirm.Enter += new System.EventHandler(this.txtPassConfirm_Enter);
            this.txtPassConfirm.Leave += new System.EventHandler(this.txtPassConfirm_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(39, 67);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(376, 25);
            this.txtPass.TabIndex = 8;
            this.txtPass.TabStop = false;
            this.txtPass.Text = "New Password";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.White;
            this.pnlPass.Location = new System.Drawing.Point(39, 96);
            this.pnlPass.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(376, 2);
            this.pnlPass.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnConfirm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 10;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(165, 190);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(120, 40);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 10;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Enabled = false;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(25, 56);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(400, 50);
            this.rjButton2.TabIndex = 7;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(25, 120);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(400, 50);
            this.rjButton1.TabIndex = 7;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.pnlPassConfirm);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rjButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private RJButton rjButton1;
        private System.Windows.Forms.Panel pnlPassConfirm;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private RJButton btnConfirm;
        private RJButton rjButton2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pnlPass;
    }
}