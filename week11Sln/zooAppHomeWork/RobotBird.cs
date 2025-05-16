using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooAppHomeWork
{
    internal class RobotBird : Animal, IRobot
    {
        private int _batteryLevel;

        public RobotBird(string name, COLOR color) : base(name, color)
        {
        }

        public int BatteryLevel
        {
            get { return _batteryLevel; }
            set
            {
                if (value > 50)
                {
                    _batteryLevel = 50;
                }
                else
                {
                    _batteryLevel = value;
                }
            }
        }

        
        public void Charge()
        {
            _batteryLevel = 1000;
        }

        protected override bool AddLevel(int level)
        {
            if (level < 0)
            {
                return false;
            }
            if (_level + level > 50)
            {
                _level = 50;
                return false;
            }
            else
            {
                _level += level;
                return true;
            }
        }

        public string Fly(int count)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < count; ++i)
            {
                s.Append("푸드득~ ");
            }
            return s.ToString();
        }

        public override string ToString()
        {
            return $"ROBOTBIRD : {Name}";
        }
    }
}
