
namespace Library_System
{
    partial class AdminRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRegister));
            this.btnMini = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassCheck = new System.Windows.Forms.TextBox();
            this.pnlPassCheck = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.picPassCheck = new System.Windows.Forms.PictureBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new Library_System.DragControl();
            this.btnRegister = new Library_System.RJButton();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlIDNumber = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPassCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMini
            // 
            this.btnMini.BackgroundImage = global::Library_System.Properties.Resources.minimize;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Location = new System.Drawing.Point(296, 11);
            this.btnMini.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(20, 20);
            this.btnMini.TabIndex = 5;
            this.btnMini.TabStop = false;
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Library_System.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(329, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.White;
            this.pnlPass.Location = new System.Drawing.Point(27, 359);
            this.pnlPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(306, 2);
            this.pnlPass.TabIndex = 12;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.Location = new System.Drawing.Point(27, 307);
            this.pnlUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(306, 2);
            this.pnlUser.TabIndex = 13;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(67, 328);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(266, 25);
            this.txtPass.TabIndex = 11;
            this.txtPass.TabStop = false;
            this.txtPass.Text = "Password";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(67, 276);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(266, 25);
            this.txtUser.TabIndex = 8;
            this.txtUser.TabStop = false;
            this.txtUser.Text = "Username";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPassCheck
            // 
            this.txtPassCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.txtPassCheck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassCheck.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCheck.ForeColor = System.Drawing.Color.White;
            this.txtPassCheck.Location = new System.Drawing.Point(67, 379);
            this.txtPassCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassCheck.Name = "txtPassCheck";
            this.txtPassCheck.Size = new System.Drawing.Size(266, 25);
            this.txtPassCheck.TabIndex = 11;
            this.txtPassCheck.TabStop = false;
            this.txtPassCheck.Text = "Confirm Password";
            this.txtPassCheck.Enter += new System.EventHandler(this.txtPassCheck_Enter);
            this.txtPassCheck.Leave += new System.EventHandler(this.txtPassCheck_Leave);
            // 
            // pnlPassCheck
            // 
            this.pnlPassCheck.BackColor = System.Drawing.Color.White;
            this.pnlPassCheck.Location = new System.Drawing.Point(27, 411);
            this.pnlPassCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPassCheck.Name = "pnlPassCheck";
            this.pnlPassCheck.Size = new System.Drawing.Size(306, 2);
            this.pnlPassCheck.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(67, 180);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(266, 25);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TabStop = false;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.White;
            this.pnlEmail.Location = new System.Drawing.Point(27, 211);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(306, 2);
            this.pnlEmail.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnBack.BackgroundImage = global::Library_System.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(11, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 24);
            this.btnBack.TabIndex = 15;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picPassCheck
            // 
            this.picPassCheck.Image = global::Library_System.Properties.Resources.reenter_unselected;
            this.picPassCheck.Location = new System.Drawing.Point(27, 374);
            this.picPassCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPassCheck.Name = "picPassCheck";
            this.picPassCheck.Size = new System.Drawing.Size(35, 33);
            this.picPassCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassCheck.TabIndex = 9;
            this.picPassCheck.TabStop = false;
            // 
            // picPass
            // 
            this.picPass.Image = global::Library_System.Properties.Resources.key_unselected;
            this.picPass.Location = new System.Drawing.Point(27, 323);
            this.picPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(35, 33);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPass.TabIndex = 9;
            this.picPass.TabStop = false;
            // 
            // picEmail
            // 
            this.picEmail.Image = global::Library_System.Properties.Resources.mail_unselected;
            this.picEmail.Location = new System.Drawing.Point(27, 175);
            this.picEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(35, 33);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmail.TabIndex = 10;
            this.picEmail.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = global::Library_System.Properties.Resources.user_unselected;
            this.picUser.Location = new System.Drawing.Point(27, 271);
            this.picUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(35, 33);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 10;
            this.picUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Library_System.Properties.Resources.block_user;
            this.pictureBox1.Location = new System.Drawing.Point(135, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnRegister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnRegister.BorderRadius = 10;
            this.btnRegister.BorderSize = 0;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnRegister.Location = new System.Drawing.Point(27, 454);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(306, 54);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.txtIDNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNumber.ForeColor = System.Drawing.Color.White;
            this.txtIDNumber.Location = new System.Drawing.Point(67, 227);
            this.txtIDNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(266, 25);
            this.txtIDNumber.TabIndex = 8;
            this.txtIDNumber.TabStop = false;
            this.txtIDNumber.Text = "ID Number";
            this.txtIDNumber.Enter += new System.EventHandler(this.txtIDNumber_Enter);
            this.txtIDNumber.Leave += new System.EventHandler(this.txtIDNumber_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Library_System.Properties.Resources.id_unselected;
            this.pictureBox2.Location = new System.Drawing.Point(27, 222);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pnlIDNumber
            // 
            this.pnlIDNumber.BackColor = System.Drawing.Color.White;
            this.pnlIDNumber.Location = new System.Drawing.Point(27, 258);
            this.pnlIDNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlIDNumber.Name = "pnlIDNumber";
            this.pnlIDNumber.Size = new System.Drawing.Size(306, 2);
            this.pnlIDNumber.TabIndex = 13;
            // 
            // AdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(360, 601);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlPassCheck);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.pnlIDNumber);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.picPassCheck);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picEmail);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.txtPassCheck);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picPassCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassCheck;
        private System.Windows.Forms.PictureBox picPassCheck;
        private System.Windows.Forms.Panel pnlPassCheck;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.Panel pnlEmail;
        private DragControl dragControl1;
        private RJButton btnRegister;
        private System.Windows.Forms.Panel pnlIDNumber;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtIDNumber;
    }
}