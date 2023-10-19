namespace Robot
{
    public class Robots
    {
        public string Name { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public Robots(string name, int positionX, int positionY)
        {
            Name = name;
            PositionX = positionX;
            PositionY = positionY;
        }

        public void Go(int directionX, int directionY)
        {
            PositionX += directionX;
            PositionY += directionY;
        }

        public string ShowPosition()
        {
            return PositionX + " " + PositionY;
        }
    }
}