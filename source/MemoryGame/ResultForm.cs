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
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameBoardForm SpelaIgen = new GameBoardForm();
            SpelaIgen.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartForm SpelaIgen = new StartForm();
            SpelaIgen.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
