using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public abstract class RobotAbstrait
    {
        public abstract string start();
        
        protected string stop()
        {
            return "Robot arrêté";
        }
    }
}
