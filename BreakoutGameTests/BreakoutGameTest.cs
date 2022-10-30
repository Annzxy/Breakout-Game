using Breakout_Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Media;

namespace BreakoutGameTests
{
    [TestClass]
    public class BreakoutGameTest
    {

      

        [TestMethod]
        public void should_move_paddle_to_left()
        {
            // Arrange
            int paddleSpeed = 10;
            PictureBox paddle = new PictureBox();
            paddle.Location = new System.Drawing.Point(100, 100);
            Paddle picPaddle = new Paddle(paddle, paddleSpeed);

            // Act
            picPaddle.moveToLeft();

            // Assert
            Assert.AreEqual(paddle.Left, 90);
        }


        [TestMethod]
        public void should_move_paddle_to_right()
        {
            // Arrange
            int paddleSpeed = 20;
            PictureBox paddle = new PictureBox();
            paddle.Location = new System.Drawing.Point(200, 100);
            Paddle picPaddle = new Paddle(paddle, paddleSpeed);

            // Act
            picPaddle.moveToRight();

            // Assert
            Assert.AreEqual(paddle.Left, 220);

        }

        [TestMethod]
        public void should_ball_move_left()
        {
            // Arrange
            int verticalSpeed = 0;
            int horizontalSpeed = 15;
            PictureBox ball = new PictureBox();
            ball.Location = new System.Drawing.Point(100, 100);
            Ball picBall = new Ball(ball, verticalSpeed, horizontalSpeed);

            // Act
            picBall.move();
            
            // Assert
            Assert.AreEqual(ball.Left, 115);
          

        }


        [TestMethod]
        public void should_create_correct_number_of_bricks()
        {
            // Arrange
            int totalNumberOfBricks = 5;
            Form testForm = new Form();
            Control.ControlCollection controls = new Control.ControlCollection(testForm) ;

            // Act
            Bricks picBricks = new Bricks(controls, totalNumberOfBricks);

            // Assert
            Assert.AreEqual(picBricks.currentNumberOfBricks, totalNumberOfBricks);
           
        }

        [TestMethod]
        public void should_render_correct_label()
        {
            // Arrange
            int totalNumberOfBricks = 5;
            Form testForm = new Form();
            Control.ControlCollection controls = new Control.ControlCollection(testForm);
            Bricks picBricks = new Bricks(controls, totalNumberOfBricks);

            int hightestRandomNumber = 4;
            int lowestRandomNumber = 1;

            // Act
            Boolean isCorrectLabel = true;

            foreach (Control x in controls)
            {
                if (x.GetType().Name == "Label")
                {
                    int labelValue = Int32.Parse(x.Text);
                    if (labelValue > hightestRandomNumber || labelValue < lowestRandomNumber)
                    {
                        isCorrectLabel = false;
                    }
                }
               
            }

            // Assert
            Assert.IsTrue(isCorrectLabel);

        }

        [TestMethod]
        public void should_place_bricks_in_order()
        {
            // Arrange

            
            int totalNumberOfBricks = 10;
            Form testForm = new Form();
            Control.ControlCollection controls = new Control.ControlCollection(testForm);
            
            // Act
            Bricks picBricks = new Bricks(controls, totalNumberOfBricks);


            int boxLeft = controls[5].Left ;
            int boxTop = controls[5].Top;
            
            //Assert
            Assert.AreEqual(boxLeft, 120);
            Assert.AreEqual(boxTop, 100);
        }

        [TestMethod]
        public void should_place_bricks_in_three_layer()
        {
            // Arrange

            int totalNumberOfBricks = 15;
            Form testForm = new Form();
            Control.ControlCollection controls = new Control.ControlCollection(testForm);

            // Act
            Bricks picBricks = new Bricks(controls, totalNumberOfBricks);

            int boxLeft = controls[10].Left;
            int boxTop = controls[10].Top;

            //Assert
            Assert.AreEqual(boxLeft, 120);
            Assert.AreEqual(boxTop, 150);
        }

        [TestMethod]
        public void should_ball_move_top()
        {
            // Arrange
            int verticalSpeed = 15;
            int horizontalSpeed = 0;
            PictureBox ball = new PictureBox();
            ball.Location = new System.Drawing.Point(100, 100);
            Ball picBall = new Ball(ball, verticalSpeed, horizontalSpeed);

            // Act
            picBall.move();
            picBall.move();
            // Assert
            
            Assert.AreEqual(ball.Top, 130);

        }


    }
}
