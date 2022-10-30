using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game
{
    internal class Manager
    {
        private Bricks bricks;
        private Ball ball;
        private Paddle paddle;
        private Control.ControlCollection controls;

        public static int BASIC_SCORE = 10;
        public static int BONUS_SCORE = 5;
        Random rnd = new Random();

        public int score { get; set; }
        public Manager(Bricks bricks, Ball ball, Paddle paddle, Control.ControlCollection controls)
        {
            this.bricks = bricks;
            this.ball = ball;
            this.paddle = paddle;
            this.controls = controls;
        }

        public void movePaddle(Boolean goLeft, Boolean goRight)
        {
            if (goLeft == true && paddle.picPaddle.Left > 0)
            {
                paddle.moveToLeft();
            }

            if (goRight == true && paddle.picPaddle.Left < 740)
            {
                paddle.moveToRight();
            }

        }

        public void moveBall()
        {

            if (ball.picBall.Left < 0)
            {
                ball.goLeft = false;
            }

            if (ball.picBall.Left > 850)
            {
                ball.goLeft = true;
            }
            if (ball.picBall.Top < 27)
            {
                ball.goTop = false;
            }

            bouncingPaddle();
            bouncingBricks();
            ball.move();
        }

        public void bouncingPaddle()
        {
            if (ball.picBall.Bounds.IntersectsWith(paddle.picPaddle.Bounds))
            {
                ball.goTop = true;
                ball.horizontalSpeed = rnd.Next(5, 12);
            }
        }

        public void bouncingBricks()
        {
            foreach (Control x in this.controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (ball.picBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        foreach (Control c in x.Controls)
                        {
                            if (c.GetType().Name == "Label")
                            {
                                int value = Int32.Parse(c.Text);
                                --value;

                                if (value == 0)
                                {
                                    this.controls.Remove(x);
                                    --this.bricks.currentNumberOfBricks;
                                    this.score += BONUS_SCORE;
                                }
                                else
                                {
                                    c.Text = value.ToString();

                                }

                            }
                        }

                        this.score += BASIC_SCORE;
                        ball.goTop = !ball.goTop;
                    }
                }
            }

        }

    }
}
