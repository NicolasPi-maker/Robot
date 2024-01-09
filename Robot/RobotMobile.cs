using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Robot
{
    public class RobotMobile : Robots, IRobotNettoyage
    {
        private int _speed;

        public RobotMobile(string name, RobotPoint position, int speed) : base(name, position)
        {
            _speed = speed;
        }

        public int TravelTime(int newPositionX, int newPositionY)
        {
            int travelTime = move(new RobotPoint(newPositionX, newPositionY)) / _speed;
            return travelTime;
        }

        public override string ShowPosition()
        {
            return "test";
        }

        public string clean()
        {
            return $"Le robot mobile {_name} nettoie le sol";
        }

        public int move(RobotPoint newPosition)
        {
            int distance = Utils.CalculateDistance(_position, newPosition);
            return Math.Abs(distance);
        }

        public int getSpeed()
        {
            return _speed; 
        }
    }
}
