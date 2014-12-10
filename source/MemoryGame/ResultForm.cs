using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class ResultForm : Form
    {
        private StartForm startForm;
        private Game game;
        

        public ResultForm(GameBoardForm board)
        {
            this.startForm = board.startForm;
            this.game = board.Game;
            InitializeComponent();
            if(game.equalscore)
            {
                 this.winner_label.Text = " Det blev oavgjort";
            }
            else
            {
                 this.winner_label.Text = game.Winner.Name + " har vunnit!";
                 this.winner_label.ForeColor = game.Winner.Color;
            }  
            
            GenerateLables();
 

        }

        private void GenerateLables()
        {

            int y = 100;
            int yOffset = 30;
            for (int i = 0; i < game.Players.Length; i++)
            {
                var player = game.Players[i];
                var playerLabel = new Label();
                playerLabel.AutoSize = true;
                playerLabel.Location = new System.Drawing.Point(36, y);
                playerLabel.Text = player.Name;
                playerLabel.ForeColor = player.Color;
                this.Controls.Add(playerLabel);

                var scoreLabel = new Label();
                scoreLabel.Location = new System.Drawing.Point(328, y);
                scoreLabel.Text = player.Score.ToString();
                scoreLabel.ForeColor = player.Color;

                this.Controls.Add(scoreLabel);

                y += yOffset;

            }
        }


        // Spela igen knappen
        private void button1_Click(object sender, EventArgs e)
        {
            GameBoardForm SpelaIgen = new GameBoardForm(this.startForm);
            SpelaIgen.Show();
            this.Close();
        }

        //Nytt spel knappen
        private void button2_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Close();
        }

        //Avsluta knappen
        private void button3_Click(object sender, EventArgs e)
        {
            if (startForm.ExitGame() == DialogResult.Yes)
                Application.Exit();

        }

       
        
        private void ResultForm_Load(object sender, EventArgs e)
        {
            
           if (startForm.settings.Themes.Trim() == "Frukt") 
            {
                BackgroundImage = MemoryGame.Properties.Resources.fruktBg;


            }
           else if (startForm.settings.Themes.Trim() == "Djur")
           {
               BackgroundImage = MemoryGame.Properties.Resources.djurBg;


           } else
               BackgroundImage = MemoryGame.Properties.Resources.vägmärkenBg;
        }

        

    }
}
