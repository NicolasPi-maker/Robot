using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Robot
{
    public class RobotMobile : Robots, IRobotNettoyage
    {
        private int _speed;

        public RobotMobile(string name, int positionX, int positionY, int speed) : base(name, positionX, positionY)
        {
            _speed = speed;
 
        }

        public int TravelTime(int newPositionX, int newPositionY)
        {
            int distance = (_positionX + _positionY) - (newPositionX + newPositionY);
            int travelTime = distance / _speed;
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
    }
}
