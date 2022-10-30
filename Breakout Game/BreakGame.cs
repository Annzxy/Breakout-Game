using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Breakout_Game
{
    public partial class BreakGame : Form
    {
        Random rnd = new Random();
        bool isGameOver;


        // paddle
        bool goLeft;
        bool goRight;
        int paddleSpeed;
        private Paddle picPaddle;

        // ball
        int verticalSpeed;
        int horizontalSpeed;
        private Ball picBall;

        // bricks
        int totalNumberOfBricks;
        private Bricks picBricks;

        // manager
        private Manager manager;

        SoundPlayer palyS = new SoundPlayer();


        public BreakGame()
        {
            InitializeComponent();

            this.paddleSpeed = 10;
            picPaddle = new Paddle(paddle, paddleSpeed);

            this.totalNumberOfBricks =15;
            picBricks = new Bricks(this.Controls, totalNumberOfBricks);

            this.verticalSpeed = 10;
            this.horizontalSpeed = 12;
            picBall = new Ball(ball, this.verticalSpeed, this.horizontalSpeed);

            manager = new Manager(picBricks, picBall, picPaddle, Controls);
            loadGame();
            palyS.SoundLocation = "guitar.wav";
            palyS.Play();



        }

        private void loadGame()
        {
            gameTimer.Start();
            
        }

        // Key events for paddle
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        // Key events for paddle
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {

                // removeBlocks();
                // PlaceBlocks();
            }
            if (e.KeyCode == Keys.Enter)
            {
                gameTimer.Stop();
                // removeBlocks();
                // PlaceBlocks();
            }
            if (e.KeyCode == Keys.B)
            {
                gameTimer.Start();
                // removeBlocks();
                // PlaceBlocks();
            }
        }

        private void mainRun(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + manager.score;

            manager.movePaddle(goLeft, goRight);

            manager.moveBall();


            // end game if it is the last brick
            if (picBricks.currentNumberOfBricks == 0)
            {

                gameTimer.Stop();
                palyS.Stop();
                this.Hide();
                Win win = new Win(manager.score);
                win.Show();
                
            }
          

            if (ball.Top > 531)
            {
                gameTimer.Stop();
                palyS.Stop();
                this.Hide();
                Loss loss = new Loss(manager.score);
                loss.Show();
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
        }

        

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            palyS.Stop();
            Welcome welcome = new Welcome();    
            welcome.Show();
 
        }

    }
}
