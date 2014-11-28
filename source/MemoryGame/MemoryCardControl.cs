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

        public MemoryCardControl()
        {
            InitializeComponent();
            this.Image = global::MemoryGame.Properties.Resources.CardBack;
            this.Size = new System.Drawing.Size(160, 160);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //"vänder" memorykortet, d v s byter bild.
        private void Flip()
        {
            this.Image = global::MemoryGame.Properties.Resources.star;
          
        }

        //overridar OnClick så att den alltid anropar Flip()
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Flip();
        }



    }
}
