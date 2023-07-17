using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public partial class frmgameover : Form
    {
        public frmgameover()
        {
            InitializeComponent();
        }

        private void frmgameover_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            txttotalscore.Text = "Your Score is " + Form1.score;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmstarting a = new frmstarting();
            a.Show();
        }

        private void txttotalscore_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
