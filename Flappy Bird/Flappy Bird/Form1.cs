namespace Flappy_Bird
{
    public partial class Flappy : Form
    {
        //public variables
        int obstacleSpeed = 5; //movement of obstacles (pipes)
        int gravity = 5; //movement of bird (player)
        int score = 0; //player survival rate!

        public Flappy()
        {
            InitializeComponent();
            gameTimer.Start();
        }

        //function defining what will happn during game start 
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //affects the birds' margin according to the value of gravity
            birdPlayer.Top += gravity;

            //will affect the obstacles margin so that it moves out of the screen area (giving the illusion that the bird is moving forward) 
            obstacleBottom.Left -= obstacleSpeed;
            obstacleTop.Left -= obstacleSpeed;

            //we update the score throughout the game by casting our value as string
            scoreText.Text = score.ToString();

            //this will allow us to spawn the obstacles again and again
            if(obstacleBottom.Left < -150 )
            {
                obstacleBottom.Left = 950;
                //the score increases if the pipe spawns since we haven't hit it.
                score++;
            }

            if (obstacleTop.Left < -180)
            {
                obstacleTop.Left = 950;
                //the score increases if the pipe spawns since we haven't hit it.
                score++;
            }

            //this will prevent our bird from "falling" off the screen if it goes beyond the bounds of our screen it is game over
            if (birdPlayer.Bounds.IntersectsWith(obstacleBottom.Bounds) || birdPlayer.Bounds.IntersectsWith(obstacleTop.Bounds) || birdPlayer.Bounds.IntersectsWith(ground.Bounds) || birdPlayer.Top < -25)
            {
                if (score > 0)
                {
                   score--;
                }
                else
                {
                    gameOver();
                }
            }

            //this will increase the obstacle speed as the game runs to make it harder
            if (score > 10)
            {
                obstacleSpeed += 5;
            }
        }

        //function for when the player pressed the up arrow key
        private void onKeyUp(object sender, KeyEventArgs e)
        {
            //the bird will be "pushed" up
            if (e.KeyCode == Keys.Up)
            {
                gravity = -5;
            }  
        }

        //function for when the player releases the down arrow key
        private void onKeyDown(object sender, KeyEventArgs e)
        {
            //the bird will be "pushed" down
            if (e.KeyCode == Keys.Down)
            {
                gravity = 5;
            }
        }

        private void gameOver()
        {
            gameTimer.Stop();
            scoreText.Text = "Oops! Game Over";
        }
    }
}