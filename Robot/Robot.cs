using System.Drawing;

namespace Robot
{
    public class Robots : RobotAbstrait
    {
        #region attributs
        protected string _name;
        protected RobotPoint _position;
        #endregion

        #region constructor
        public Robots(string name, RobotPoint point)
        {
            _name = name;
            _position = point;
        }
        #endregion

        #region Methods
        public void Go(int directionX, int directionY)
        {
            _position._x += directionX;
            _position._y += directionY;
        }

        public virtual string ShowPosition()
        {
            return _position._x + " " + _position._y;
        }

        public override string start()
        {
            return "Le robot démarre";
        }

        public string GetName()
        { 
            return _name; 
        }

        public string SetName(string newName)
        {
            return _name = newName;
        }
        #endregion
    }
}