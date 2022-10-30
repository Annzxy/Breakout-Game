using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout_Game
{
    public class Bricks
    {
        private PictureBox[] bricks;
        public int currentNumberOfBricks { get; set; }

        Random rnd = new Random();

        public Bricks(Control.ControlCollection controls, int totalNumberOfBricks)
        {
            this.bricks = new PictureBox[totalNumberOfBricks];
            this.currentNumberOfBricks = bricks.Length;

            int a = 0;
            int top = 50;
            int left = 120;

            for (int i = 0; i < bricks.Length; i++)
            {
                bricks[i] = new PictureBox();
                bricks[i].Height = 32;
                bricks[i].Width = 100;
                bricks[i].Tag = "blocks";
                bricks[i].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                Label label = new Label();

                label.Text = rnd.Next(1, 5).ToString();
                label.Font= new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.ForeColor = System.Drawing.SystemColors.MenuText;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                label.TabIndex = 3;
                bricks[i].Controls.Add(label);

                if (a == 5)
                {
                    top = top + 50;
                    left = 120;
                    a = 0;
                }

                if (a < 5)
                {

                    a++;
                    bricks[i].Left = left;
                    bricks[i].Top = top;
                    controls.Add(bricks[i]);
                    left = left + 130;
                }

            }
        }

    }
}
