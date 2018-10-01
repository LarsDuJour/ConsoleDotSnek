namespace ConsoleDotSnek
{
    public class Snake
    {
        //initial location data for debugging
        private int locX = 1;
        private int prevLocX; //for storing previous location
        private int locY = 1;
        private int prevLocY; //for storing previous location

        //initial movement velocity
        private int velX = 0; //left and right
        private int velY = 1; //up and down

        //more info
        public char snakeChar = 'O'; //show the snake using an O
        //private int snakeLength = 1; //temp for setting the max length of an array




        public Snake()
        {
            //empty for now
        }


        //for updating the location of the snake
        public void updateLocation()
        {
            prevLocX = locX;
            locX = locX + velX;

            prevLocY = locY;
            locY = locY + velY;
        }



        public int getSnakeLocX()
        {
            return locX;
        }

        public int getSnakeLocY()
        {
            return locY;
        }


        public int getPrevSnakeLocX()
        {
            return prevLocX;
        }

        public int getPrevSnakeLocY()
        {
            return prevLocY;
        }

    }
}