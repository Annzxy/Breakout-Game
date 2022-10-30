using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game
{
    public partial class Win : Form

    {
        public int score { get; set; }
        public Win(int managerScore)
        {
            InitializeComponent();

            winScore.Text = managerScore.ToString();
        }


  
        private void lossExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void winRetry_Click(object sender, EventArgs e)
        {
            this.Hide();
            BreakGame breakGame = new BreakGame();
            breakGame.Show();
        }
    }
}
