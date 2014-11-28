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
        private MemoryCard data;

        private bool flipped = false;

        public MemoryCardControl()
        {
            InitializeComponent();
            this.data = new MemoryCard();
            this.Image = data.BackSide;
            this.Size = new System.Drawing.Size(160, 160);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //"vänder" memorykortet, d v s byter bild.
        private void Flip()
        {
            if (flipped)
                Image = data.BackSide;
            else
                Image = data.Symbol;
            flipped = !flipped;
        }

        //overridar OnClick så att den alltid anropar Flip()
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Flip();
        }



    }
}
