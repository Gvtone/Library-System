using System;
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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            pnlBorrow.Controls.Clear();
            ReturnNew RN = new ReturnNew();
            pnlBorrow.Controls.Add(RN);
            RN.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlBorrow.Controls.Clear();
            ReturnNew RN = new ReturnNew();
            pnlBorrow.Controls.Add(RN);
            RN.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlBorrow.Controls.Clear();
            ReturnHistory RH = new ReturnHistory();
            pnlBorrow.Controls.Add(RH);
            RH.Show();
        }
    }
}
