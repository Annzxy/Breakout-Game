using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game
{
    public class Paddle
    {
        public PictureBox picPaddle { get; set; }

        public int speed { get; set; }
        public void moveToLeft()
        {
             picPaddle.Left -= speed;
            
        }

        public void moveToRight()
        {
            picPaddle.Left += speed;

        }
        public Paddle(PictureBox picPaddle, int speed)
        {
            this.speed = speed;
            this.picPaddle= picPaddle; 
        }



    }
}
