using System.Drawing;

namespace Robot
{
    public class RobotLinq
    {
        #region attributs
        public string Name { get; set; }
        public int Year { get; set; }
        public int _x { get; set; }
        public int _y { get; set; }
        #endregion

        #region constructor
        public RobotLinq(string name, int year, int x, int y)
        {
            Name = name;
            Year = year;
            _x = x;
            _y = y;
        }
        #endregion

        #region Methods
        #endregion
    }
}