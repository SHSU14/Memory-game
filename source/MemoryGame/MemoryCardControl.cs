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
        public Timer cardTimer;
        public Timer thinkTimer;
        private bool sentTimer = false;


        private bool flipped = false; //sant om kortet är öppet, alltså visar sin symbol och inte baksidebilden

        public MemoryCardControl(GameBoardForm form)
        {
            InitializeComponent();
            this.thinkTimer = form.thinkTimer;
            this.cardTimer = form.cardTimer;
            this.Data = new MemoryCard();
            this.Image = (Image)global::MemoryGame.Properties.Resources.ResourceManager.GetObject(Data.BackSide);
            this.Size = new System.Drawing.Size(60, 60);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void HandleCardtimer(Object sender, EventArgs e)
        {
            if (!IsMatched() && flipped)
            {
                Flip();
                cardTimer.Stop();
                sentTimer = false;
            }

        }

        public void HandleThinkTimer(Object sender, EventArgs e)
        {
            if (sentTimer && !IsMatched() && flipped)
            {
                Flip();
                MessageBox.Show("Tiden är ute!");
                thinkTimer.Stop();
                sentTimer = false;
            }

        }

        //"vänder" memorykortet, d v s byter bild.
        private void Flip()
        {
            if (flipped)
            {
                Data.Counter--;
                Image = (Image) global::MemoryGame.Properties.Resources.ResourceManager.GetObject(Data.BackSide);
            }
            else
            {
                if (!sentTimer && thinkTimer.Enabled)
                {
                    thinkTimer.Stop();
                    cardTimer.Start();
                }
                else
                {
                    thinkTimer.Start();
                    sentTimer = true;
                }
                Image = (Image) global::MemoryGame.Properties.Resources.ResourceManager.GetObject(Data.Symbol);
                Data.Counter++;
            }
            flipped = !flipped;
        }

        private bool IsMatched()
        {
            return (this.Data.Counter == 2);
        }

        //overridar OnClick så att den alltid anropar Flip()
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Flip();
        }



    }
}
