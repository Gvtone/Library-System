
namespace Library_System
{
    partial class UserMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlLeftTop = new System.Windows.Forms.Panel();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dragControl1 = new Library_System.DragControl();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.picDisplayPicture = new Library_System.CircularPictureBox();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftTop.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(20)))), ((int)(((byte)(33)))));
            this.pnlLeft.Controls.Add(this.btnUserInfo);
            this.pnlLeft.Controls.Add(this.btnHistory);
            this.pnlLeft.Controls.Add(this.btnBook);
            this.pnlLeft.Controls.Add(this.btnReturn);
            this.pnlLeft.Controls.Add(this.btnBorrow);
            this.pnlLeft.Controls.Add(this.btnSearch);
            this.pnlLeft.Controls.Add(this.btnSettings);
            this.pnlLeft.Controls.Add(this.btnLogOut);
            this.pnlLeft.Controls.Add(this.pnlLeftTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(220, 650);
            this.pnlLeft.TabIndex = 0;
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.picDisplayPicture);
            this.pnlLeftTop.Controls.Add(this.lblUserType);
            this.pnlLeftTop.Controls.Add(this.lblUser);
            this.pnlLeftTop.Controls.Add(this.panel3);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(220, 220);
            this.pnlLeftTop.TabIndex = 0;
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.lblUserType.Location = new System.Drawing.Point(3, 177);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(217, 26);
            this.lblUserType.TabIndex = 2;
            this.lblUserType.Text = "User Type";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.lblUser.Location = new System.Drawing.Point(3, 148);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(217, 26);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(221, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 650);
            this.panel3.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(220, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(780, 30);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(220, 30);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(780, 620);
            this.pnlMain.TabIndex = 2;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pnlTop;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            this.btnMinimize.BackgroundImage = global::Library_System.Properties.Resources.minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(716, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            this.btnExit.BackgroundImage = global::Library_System.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(748, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserInfo.FlatAppearance.BorderSize = 0;
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnUserInfo.Image = global::Library_System.Properties.Resources.file_mini;
            this.btnUserInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserInfo.Location = new System.Drawing.Point(0, 445);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btnUserInfo.Size = new System.Drawing.Size(220, 45);
            this.btnUserInfo.TabIndex = 3;
            this.btnUserInfo.TabStop = false;
            this.btnUserInfo.Text = "User Info";
            this.btnUserInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnHistory.Image = global::Library_System.Properties.Resources.history;
            this.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.Location = new System.Drawing.Point(0, 400);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btnHistory.Size = new System.Drawing.Size(220, 45);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.TabStop = false;
            this.btnHistory.Text = "History";
            this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnBook
            // 
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnBook.Image = global::Library_System.Properties.Resources.bookmark_mini;
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBook.Location = new System.Drawing.Point(0, 355);
            this.btnBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btnBook.Size = new System.Drawing.Size(220, 45);
            this.btnBook.TabIndex = 4;
            this.btnBook.TabStop = false;
            this.btnBook.Text = "Books";
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnReturn.Image = global::Library_System.Properties.Resources.return_mini;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.Location = new System.Drawing.Point(0, 310);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btnReturn.Size = new System.Drawing.Size(220, 45);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "Return";
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnBorrow.Image = global::Library_System.Properties.Resources.borrow_mini;
            this.btnBorrow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrow.Location = new System.Drawing.Point(0, 265);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btnBorrow.Size = new System.Drawing.Size(220, 45);
            this.btnBorrow.TabIndex = 3;
            this.btnBorrow.TabStop = false;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnSearch.Image = global::Library_System.Properties.Resources.search_mini;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(0, 220);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btnSearch.Size = new System.Drawing.Size(220, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TabStop = false;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnSettings.Image = global::Library_System.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(0, 559);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(220, 45);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(185)))), ((int)(((byte)(176)))));
            this.btnLogOut.Image = global::Library_System.Properties.Resources.log_out;
            this.btnLogOut.Location = new System.Drawing.Point(0, 605);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(220, 45);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // picDisplayPicture
            // 
            this.picDisplayPicture.Image = global::Library_System.Properties.Resources.pic_placeholder;
            this.picDisplayPicture.Location = new System.Drawing.Point(59, 30);
            this.picDisplayPicture.Margin = new System.Windows.Forms.Padding(2);
            this.picDisplayPicture.Name = "picDisplayPicture";
            this.picDisplayPicture.Size = new System.Drawing.Size(100, 100);
            this.picDisplayPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplayPicture.TabIndex = 3;
            this.picDisplayPicture.TabStop = false;
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(38)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblUserType;
        private DragControl dragControl1;
        public CircularPictureBox picDisplayPicture;
        public System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBorrow;
    }
}