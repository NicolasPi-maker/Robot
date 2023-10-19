using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public static class Utils
    {
        public static int CalculateDistance(RobotPoint p1, RobotPoint p2)
        {
            int distance = (p1._x + p1._y) - (p2._x + p2._y);
            return distance;
        }
    }
}
