using System.Drawing;

namespace Robot
{
    public class RobotDate
    {
        #region attributs
        protected int _id;
        protected string _name;
        protected string _state;
        protected DateTime _creationDate = DateTime.Now;
        #endregion

        #region constructor
        public RobotDate(int id, string name, string state)
        {
            _id = id;
            _name = name;
            _state = state;
        }
        #endregion

        #region Methods
        
        #endregion
    }
}