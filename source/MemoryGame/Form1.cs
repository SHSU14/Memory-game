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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var settings = new Settings();


            int total = 20;
            int columns = (int)Math.Ceiling(Math.Sqrt(total));

            int xOffset = 165;
            int yOffset = 165;

            for (int i = 0; i < total; i++)
            {
                var y = yOffset * (i / columns) + 20;
                var x = xOffset * (i % columns) + 20;
                    var control = new MemoryCardControl();
                    control.Location = new System.Drawing.Point(x, y);
                    this.Controls.Add(control);      
            }

            this.Size = new Size(columns * xOffset + 50, (total + columns - 1) /columns*yOffset + 70);
            Shuffle();

        }

        private void Shuffle()
        {
            var mcList = new System.Collections.Generic.List<MemoryCardControl>();
            mcList = this.Controls.OfType<MemoryCardControl>().ToList();
            CardShuffler shuffler = new CardShuffler(new Settings());
            shuffler.Shuffle(mcList);
        }
      
    }
}
