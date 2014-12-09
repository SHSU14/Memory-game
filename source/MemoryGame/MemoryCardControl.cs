using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{

    //Custom Control som ska representera ett Memorykort. 
    public partial class MemoryCardControl : PictureBox
    {
        //Här lagras informationen om vilken bild kortet har
        public MemoryCard Data;
        public bool matched;
        private Timer cardTimer;
        private Timer thinkTimer;
        private Game game;
        private GameBoardForm gameBoardForm;

        private bool open = false; //sant om kortet är öppet, alltså visar sin symbol och inte baksidebilden

        public MemoryCardControl(GameBoardForm form)
        {
            InitializeComponent();
            this.gameBoardForm = form;
            this.thinkTimer = form.thinkTimer;
            this.cardTimer = form.cardTimer;
            this.game = form.Game;
            this.Data = new MemoryCard();
            //
            this.Size = new System.Drawing.Size(80, 80);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        //Anropas när timern som håller koll på hur länge ett kort ska vara öppet gått ut.
        public void HandleCardtimer(Object sender, EventArgs e)
        {
            cardTimer.Stop();
            if (!IsMatched() && open)
            {
                Close();
                if(!game.Ignore())
                gameBoardForm.NextPlayer(); 
            }

        }

        //Anropas när timern som håller koll på hur lång betänketid man har innan man måste öppna nästa kort gått ut.
        public void HandleThinkTimer(Object sender, EventArgs e)
        {
            if ( !IsMatched() && open)
            {
                Close();
                MessageBox.Show("Betänketiden är slut!");
                thinkTimer.Stop();
                gameBoardForm.NextPlayer();

            }

        }

        //"Öppnar" kortet d v s visar bilden
        public void Open(bool isAIPlayer)
        {
            if (thinkTimer.Enabled)
            {
                thinkTimer.Stop();
                if (!isAIPlayer)
                    cardTimer.Start();
            }
            else if (!isAIPlayer)
            {
                thinkTimer.Start();
            }
            Image = (Image)global::MemoryGame.Properties.Resources.ResourceManager.GetObject(Data.Symbol);
            Data.Counter++;
            this.gameBoardForm.closedCardList.Remove(this);  

            if (Data.Counter == 2)
            {
                
                gameBoardForm.AddScore();
            }
            this.Refresh();
            open = true;
        }

        //"Stänger kortet" d v s visar baksidan
        public void Close()
        {
            Data.Counter--;
            Image = (Image)global::MemoryGame.Properties.Resources.ResourceManager.GetObject(Data.BackSide);
            open = false;
            this.gameBoardForm.closedCardList.Add(this);
            this.Refresh();
        }
        

        public bool IsMatched()
        {
            return (this.Data.Counter == 2);
        }

        //overridar basklassens OnClick event
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (open || this.cardTimer.Enabled)
                return;
            else
            {
                Open(false);
            }
        }

    }
}
