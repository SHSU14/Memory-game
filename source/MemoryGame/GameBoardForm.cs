using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameBoardForm : Form
    {
        public GameBoardForm()
        {
            InitializeComponent();
            this.FormClosing += GameBoardForm_FormClosing;
        }
        private void GameBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Vill du verkligen avsluta?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            ResultForm frm = new ResultForm();
            frm.Show();
            this.Hide();
        }

        private void startaOmSpeletToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nyttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartForm frm = new StartForm();
            if(MessageBox.Show("Vill du starta nytt spel?", "Nytt spel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            frm.Show();
            this.Hide();
            }
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //if (MessageBox.Show("Vill du verkligen avsluta?", "Avslutar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
