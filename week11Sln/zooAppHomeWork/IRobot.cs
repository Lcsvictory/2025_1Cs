using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooAppHomeWork
{
    internal interface IRobot
    {
        int BatteryLevel { get; set; }

        void Charge();
    }
}
