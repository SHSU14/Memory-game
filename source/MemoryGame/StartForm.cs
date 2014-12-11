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
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // Öppna spelplanen(GameBoardForm)
        private void btn_starta_Click(object sender, EventArgs e)
        {
            getSettings();


            GameBoardForm frm = new GameBoardForm(this);
            frm.Show();
            var player = frm.Game.CurrentPlayer;
            this.Hide();
            frm.Refresh();
            if (player is AIPlayer)
            {
                ((AIPlayer)player).OpenNewCard(frm.closedCardList);
                frm.NextPlayer();
            }


        }

        public DialogResult ExitGame()
        {
            return MessageBox.Show("Vill du verkligen avsluta?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void getSettings()
        {

            var value2 = this.cmb_Level.Text.Trim();
            settings.AILevels = value2;


            var value3 = this.num_Cardnumber.Value.ToString();
            settings.CardNumber = int.Parse(value3);


            var value4 = this.cmb_Themes.Text;
            settings.Themes = value4;


            var value5 = this.nud_PlayerTurnTimer.Value.ToString();
            settings.PlayersTurnTimer = int.Parse(value5);


            var value6 = this.nud_ShowCardTimer.Value.ToString();
            settings.ShowCardTimer = int.Parse(value6);


            this.settings.Playerlist = new Player[playerListView.Items.Count];
            for (int i = 0; i < this.playerListView.Items.Count; i++)
            {
                var value7 = this.playerListView.Items[i].Text.Trim();
                if (value7.StartsWith("AI"))
                {
                    settings.Playerlist[i] = new AIPlayer(value7, settings.AILevels);

                }
                else
                    settings.Playerlist[i] = new Player(value7);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { textBox1.Text };
            string[] checkboxName = { checkBox1.Name };
            var listViewItem = new ListViewItem(row);
            if (checkBox1.Checked)
            {
                playerListView.Items.Add("AI " + listViewItem.Text);

            }
            else
                playerListView.Items.Add(listViewItem);
            textBox1.Clear();
            checkBox1.Checked = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = textBox1.Name;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem listViewItem in playerListView.SelectedItems)
            {
                listViewItem.Remove();
            }
        }

        private void Tema_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Themes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object sel = cmb_Themes.SelectedItem;

            if (sel.ToString() == "Frukt")
            {

                BackgroundImage = MemoryGame.Properties.Resources.fruktBg;


            }


            else if (sel.ToString() == "Djur")
                BackgroundImage = MemoryGame.Properties.Resources.djurBg;

            else
            {

                BackgroundImage = MemoryGame.Properties.Resources.vägmärkenBg;
            }

        }

       
    }
}
