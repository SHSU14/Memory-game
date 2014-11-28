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
    public partial class MemoryCardControl : PictureBox
    {
        //Här lagras informationen om vilken bild kortet har
        private MemoryCard data;

        public MemoryCardControl()
        {
            InitializeComponent();
        }

        private void Flip()
        {
            this.Image = global::MemoryGame.Properties.Resources.star1;
          
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Flip();
        }

        private void Init()
        {
            this.Image = global::MemoryGame.Properties.Resources.CardBack;
            this.Size = new System.Drawing.Size(160, 160);
            //this.SizeMode = PictureBoxSizeMode.CenterImage;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }


    }
}
