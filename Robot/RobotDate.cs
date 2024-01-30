using System.Drawing;

namespace Robot
{
    public class RobotDate
    {
        #region attributs
        public int _id;
        public string _name;
        public string _state;
        public DateTime _creationDate = DateTime.Now;
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