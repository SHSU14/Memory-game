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
        private MemoryCard data;

        public MemoryCardControl()
        {
            InitializeComponent();
        }

        private void Flip()
        {
            this.Image = global::MemoryGame.Properties.Resources.arrow ;
          
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Flip();
        }

    }
}
