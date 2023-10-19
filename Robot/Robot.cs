namespace Robot
{
    public class Robots : RobotAbstrait
    {
        #region attributs
        protected string _name;
        protected int _positionX;
        protected int _positionY;
        #endregion

        #region constructor
        public Robots(string name, int positionX, int positionY)
        {
            _name = name;
            _positionX = positionX;
            _positionY = positionY;
        }
        #endregion

        #region Methods
        public void Go(int directionX, int directionY)
        {
            _positionX += directionX;
            _positionY += directionY;
        }

        public virtual string ShowPosition()
        {
            return _positionX + " " + _positionY;
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

        public int GetPositionX()
        {
            return _positionX;
        }

        public int SetPositionX(int newPositionX)
        {
            return _positionX = newPositionX;
        }

        public int GetPositionY()
        {
            return _positionY;
        }

        public int SetPositionY(int newPositionY)
        {
            return _positionY = newPositionY;
        }
        #endregion
    }
}