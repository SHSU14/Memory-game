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
        public List<MemoryCardControl> closedCardList;
        public List<MemoryCardControl> memoryList;
        public int memoryCapacity = 0;

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
                var y = yOffset*(i/columns) + 30;
                var x = xOffset*(i%columns) + 20;
                var control = new MemoryCardControl(this);

                thinkTimer.Tick += new EventHandler(control.HandleThinkTimer);
                cardTimer.Tick += new EventHandler(control.HandleCardtimer);
                control.Location = new System.Drawing.Point(x, y);
                this.panel1.Controls.Add(control);
            }
            closedCardList = this.panel1.Controls.OfType<MemoryCardControl>().ToList();

            memoryList = new List<MemoryCardControl>();
            if (settings.AILevels == "Medel")
                this.memoryCapacity = 5;
            else if (settings.AILevels == "Svår")
                this.memoryCapacity = 50;


            var px = xOffset*columns + 30;
            var py = 40;
    
            for (int i = 0; i < settings.Playerlist.Length; i++)
            {
                var player = Game.Players[i];
                var playerlabel = new Label();
                playerlabel.Text = player.Name + " : " + player.Score.ToString();
                playerlabel.Location = new System.Drawing.Point(px, py);
                playerlabel.Name = player.Name;
                playerlabel.ForeColor = player.Color;
                playerlabel.BackColor = Color.Transparent;
                playerlabel.AutoSize = true;
                this.panel1.Controls.Add(playerlabel);

                py += 22;
            }

            foreach (AIPlayer player in settings.Playerlist.OfType<AIPlayer>())
            {
                player.mcList = this.memoryList; 
            }

            this.Size = new Size(columns*xOffset + 150, (total + columns - 1)/columns*yOffset + 90);
            this.panel1.Size = new Size(columns * xOffset + 170, (total + columns - 1) / columns * yOffset + 70);

            this.panel1.BackgroundImageLayout = ImageLayout.Stretch;
            this.panel1.Size = new Size(this.Size.Width - 10, this.Size.Height - this.playerTurn_label.Size.Height - 8);
            

            if (startForm.settings.Themes.Trim() == "Frukt")
            {
                panel1.BackgroundImage = MemoryGame.Properties.Resources.fruktBg; 
            }
            else if (startForm.settings.Themes.Trim() == "Djur")
            {
                panel1.BackgroundImage = MemoryGame.Properties.Resources.djurBg;
            }
            else
                panel1.BackgroundImage = MemoryGame.Properties.Resources.vägmärkenBg;

            Shuffle();

            this.playerTurn_label.Text = "Börja spelet " + this.Game.CurrentPlayer.Name + "!";    

        }

        private void Shuffle()
        {
            CardShuffler shuffler = new CardShuffler(startForm.settings);
            shuffler.Shuffle(closedCardList);
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
            Player player = frm.Game.CurrentPlayer;
            if (player is AIPlayer)
            {
                ((AIPlayer)player).OpenNewCard(frm.closedCardList);
                frm.NextPlayer();
            }
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
            if (Game.Score == this.startForm.settings.CardNumber / 2)
            {
                EndGame();
                return;
            }
            Game.NextPlayer();
            Player player = Game.CurrentPlayer;
            if (player is AIPlayer){
                this.playerTurn_label.Text = player.Name + " spelar!";
                this.playerTurn_label.Refresh();
        }
            else
                this.playerTurn_label.Text = "Din tur " + player.Name + "!";
            if (player is AIPlayer)
            {
                ((AIPlayer)player).OpenNewCard(closedCardList);
                NextPlayer();
            }
            
        }



        public void EndGame()
        {
            Game.SetWinner();
            ResultForm frm = new ResultForm(this);
             frm.Show();
            this.Close();
        }

        public void AddScore()
        {
            Game.CurrentPlayer.Score += 1;
            Game.Score += 1;

            var playerLabel = (Label)this.panel1.Controls.Find(Game.CurrentPlayer.Name, false).First();
            playerLabel.Text = Game.CurrentPlayer.Name + " : " + Game.CurrentPlayer.Score.ToString();
            playerLabel.Refresh();
            
        }
    }
}
