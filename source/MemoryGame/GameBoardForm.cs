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
        public StartForm startForm;
        public Timer thinkTimer = new Timer();
        public Timer cardTimer = new Timer();

        public GameBoardForm(StartForm startForm)
        {
            this.startForm = startForm;
            var settings = startForm.settings;
            this.Game = new Game(settings);
            this.Text = Game.CurrentPlayer.Name;

            InitializeComponent();


            thinkTimer.Interval = settings.PlayersTurnTimer*1000;
            cardTimer.Interval = settings.ShowCardTimer*1000;


            int total = settings.CardNumber;
            int columns = (int) Math.Ceiling(Math.Sqrt(total));


            int xOffset = 85; 
            int yOffset = 85;

            for (int i = 0; i < total; i++)
            {
                var y = yOffset*(i/columns) + 20;
                var x = xOffset*(i%columns) + 20;
                var control = new MemoryCardControl(this);

                thinkTimer.Tick += new EventHandler(control.HandleThinkTimer);
                cardTimer.Tick += new EventHandler(control.HandleCardtimer);
                control.Location = new System.Drawing.Point(x, y);
                this.Controls.Add(control);
            }


            var px = xOffset*columns + 30;
            var py = 40;
            for (int i = 0; i < settings.Players; i++)
            {
                var player = Game.Players[i];
                var playerlabel = new Label();
                playerlabel.Text = player.Name + " :  " + player.Score.ToString();
                playerlabel.Location = new System.Drawing.Point(px, py);
                playerlabel.Name = player.Name;
                playerlabel.ForeColor = player.Color;
                this.Controls.Add(playerlabel);

                py += 22;
            }

            this.Size = new Size(columns*xOffset + 150, (total + columns - 1)/columns*yOffset + 90);

            Shuffle();

        }

        private void Shuffle()
        {
            var mcList = new System.Collections.Generic.List<MemoryCardControl>();
            mcList = this.Controls.OfType<MemoryCardControl>().ToList();
            CardShuffler shuffler = new CardShuffler(startForm.settings);
            shuffler.Shuffle(mcList);
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            ResultForm frm = new ResultForm(this);
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

        public Game Game { get; set; }

        public void NextPlayer()
        {
            Game.NextPlayer();
            this.Text = Game.CurrentPlayer.Name;
        }

        public void AddScore()
        {
            Game.CurrentPlayer.Score += 1;
            Game.Score += 1;


            var playerLabel = (Label)this.Controls.Find(Game.CurrentPlayer.Name, false).First();
            playerLabel.Text = Game.CurrentPlayer.Name + " :  " + Game.CurrentPlayer.Score.ToString();
            if (Game.Score == this.startForm.settings.CardNumber / 2)
            {
                System.Threading.Thread.Sleep(800);
                Game.SetWinner();
                ResultForm frm = new ResultForm(this);
                frm.Show();
                this.Close();
            }
            
        }
    }
}
