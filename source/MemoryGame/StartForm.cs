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
      
        public StartForm()
        {
            InitializeComponent();
        }

        // Öppna spelplanen(GameBoardForm)
        private void btn_starta_Click(object sender, EventArgs e)
        {
            GameBoardForm frm = new GameBoardForm(this);
            frm.Show();
            this.Hide();
        }

        public DialogResult ExitGame()
        {
           return MessageBox.Show("Vill du verkligen avsluta?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);   
        }


    }
}
