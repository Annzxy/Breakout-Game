using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game
{
    public class Ball
    {
        public PictureBox picBall { set; get; }
        public int verticalSpeed { set; get; }
        public int horizontalSpeed { set; get; }
   
        public Boolean goLeft { set; get; }
        public Boolean goTop { set; get; }
        public Ball(PictureBox picBall, int verticalSpeed, int horizontalSpeed)
        {
            this.picBall = picBall;
            this.verticalSpeed = verticalSpeed;
            this.horizontalSpeed = horizontalSpeed;
        }
        
        public void move()
        {
            this.picBall.Left += goLeft ? -horizontalSpeed : horizontalSpeed;
            this.picBall.Top += goTop ? -verticalSpeed: verticalSpeed;
        }
    }
}
