﻿using System;
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
            this.winner_label.Text = game.Winner.Name + " har vunnit!"; 
            GenerateLables();
 

        }

        private void GenerateLables()
        {

            int y = 100;
            int yOffset = 30;
            for (int i = 0; i < game.Players.Length; i++)
            {
                var playerLabel = new Label();
                playerLabel.AutoSize = true;
                playerLabel.Location = new System.Drawing.Point(36, y);
                playerLabel.Text = game.Players[i].Name;
                y += yOffset;
                this.Controls.Add(playerLabel);

                var scoreLabel = new Label();

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
    }
}
