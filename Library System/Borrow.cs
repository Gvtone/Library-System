﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Borrow : UserControl
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            pnlBorrow.Controls.Clear();
            BorrowNew BN = new BorrowNew();
            pnlBorrow.Controls.Add(BN);
            BN.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlBorrow.Controls.Clear();
            BorrowNew BN = new BorrowNew();
            pnlBorrow.Controls.Add(BN);
            BN.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlBorrow.Controls.Clear();
            BorrowHistory BH = new BorrowHistory();
            pnlBorrow.Controls.Add(BH);
            BH.Show();
        }
    }
}
