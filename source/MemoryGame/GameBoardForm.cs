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

            var settings = new Settings();


            int total = 26;
            int columns = (int)Math.Ceiling(Math.Sqrt(total));

            int xOffset = 65;
            int yOffset = 65;

            for (int i = 0; i < total; i++)
            {
                var y = yOffset * (i / columns) + 20;
                var x = xOffset * (i % columns) + 20;
                var control = new MemoryCardControl();
                control.Location = new System.Drawing.Point(x, y);
                this.Controls.Add(control);
            }

            this.Size = new Size(columns * xOffset + 50, (total + columns - 1) / columns * yOffset + 70);
            Shuffle();

         Shuffle();

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
