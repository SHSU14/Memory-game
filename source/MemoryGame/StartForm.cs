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
    public partial class StartForm : Form
    {
        public Settings settings = new Settings();
        

        public StartForm()
        {
            InitializeComponent();
            this.cmb_Themes.SelectedIndex = 0;
            this.cmb_Level.SelectedIndex = 0;
        }

        // Öppna spelplanen(GameBoardForm)
        private void btn_starta_Click(object sender, EventArgs e)
        {
            getSettings();    
         
            GameBoardForm frm = new GameBoardForm(this);
            frm.Show();
            this.Hide();
        }

        public DialogResult ExitGame()
        {
           return MessageBox.Show("Vill du verkligen avsluta?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);   
        }

        public void getSettings()
        {
            var value = this.cmb_spelare.SelectedItem.ToString();
            settings.Players = int.Parse(value);
           

            var value1 = this.cmb_AI.SelectedItem.ToString();
            settings.AIPlayers = int.Parse(value1);


            var value2 = this.cmb_Level.Text;
            settings.AILevels = value2;
   

            var value3 = this.num_Cardnumber.Value.ToString();
            settings.CardNumber = int.Parse(value3);
        

            var value4 = this.cmb_Themes.Text;
            settings.Themes = value4;
           

            var value5 = this.nud_PlayerTurnTimer.Value.ToString();
            settings.PlayersTurnTimer = int.Parse(value5);
           

            var value6 = this.nud_ShowCardTimer.Value.ToString();
            settings.ShowCardTimer = int.Parse(value6);
          
        }

        private void cmb_spelare_Validated(object sender, EventArgs e)
        {
            var AIplayer = this.cmb_AI.Text;
            var player = this.cmb_spelare.Text;

            if (int.Parse(player) > 10)
            {
                MessageBox.Show("Du har valt för många spelare!");
            }
        }
        private void cmb_AI_Validated(object sender, EventArgs e)
        {
            var AIplayer = this.cmb_AI.Text;
            var player = this.cmb_spelare.Text;

            if (int.Parse(AIplayer) > 10)
            {
                MessageBox.Show("Du har valt för många AIspelare!");
            }
        }
        private void cmb_AI_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartForm frm = new StartForm();
            var player = this.cmb_AI.Text;
            if (int.Parse(player) == 10)
            {
                cmb_spelare.Hide();
                frm.Refresh();
            }
            if (int.Parse(player) <= 9)
            {
                cmb_spelare.Show();
                frm.Refresh();
            }
        }

        private void cmb_spelare_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartForm frm = new StartForm();
            var player = this.cmb_spelare.Text;
            if (int.Parse(player) == 10)
            {
                cmb_AI.Hide();
                frm.Refresh();
            }
            if (int.Parse(player) <= 9)
            {
                cmb_AI.Show();
                frm.Refresh();
            }
        }

        private void num_Cardnumber_ValueChanged(object sender, EventArgs e)
        {
            var crdNr = this.num_Cardnumber.Value;
            if (crdNr % 2 != 0 || crdNr > 120)
            {
                MessageBox.Show("Du måste välja ett jämt antal kort mellan 12 - 120");
            }           
        }           
    }
}
