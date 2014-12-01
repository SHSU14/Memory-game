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
        StartForm startForm;

        public GameBoardForm(StartForm startForm)
        {
            this.startForm = startForm;
            InitializeComponent();
#if ALI
         Shuffle();
#endif
        }

        private void Shuffle()
        {
            var mcList = new System.Collections.Generic.List<MemoryCardControl>();
            mcList = this.Controls.OfType<MemoryCardControl>().ToList();
            CardShuffler shuffler = new CardShuffler(new Settings());
            shuffler.Shuffle(mcList);
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            ResultForm frm = new ResultForm(this.startForm);
            frm.Show();
            this.Close();
        }

        private void startaOmSpeletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameBoardForm frm = new GameBoardForm(this.startForm);
            frm.Show();
            this.Close();
        }

        private void nyttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vill du starta nytt spel?", "Nytt spel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.startForm.Show();
                this.Close();
            }
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (startForm.ExitGame() == DialogResult.Yes)
                Application.Exit();
        }
    }
}
