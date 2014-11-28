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
        private StartForm startForm;

        public ResultForm(StartForm startForm)
        {
            this.startForm = startForm;
            InitializeComponent();
        }

        // Spela igen knappen
        private void button1_Click(object sender, EventArgs e)
        {
            GameBoardForm SpelaIgen = new GameBoardForm(this.startForm);
            SpelaIgen.Show();
            this.Close();
        }

        //Nytt spel knappen
        private void button2_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Close();
        }

        //Avsluta knappen
        private void button3_Click(object sender, EventArgs e)
        {
            if (startForm.ExitGame() == DialogResult.Yes)
                Application.Exit();

        }
    }
}
