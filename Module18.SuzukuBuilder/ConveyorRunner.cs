using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module18.SuzukuBuilder.Conveyors;

namespace Module18.SuzukuBuilder
{
    /// <summary>
    /// Auto-Moto factory
    /// </summary>
    class ConveyorRunner
    {
        /// <summary>
        /// 
        /// </summary>
        public void Construct(Conveyor conveyor)
        {
            conveyor.BuildFrame();
            conveyor.BuildWheels();
            conveyor.BuildEngine();
            conveyor.BuildDoors();
        }
    }
}
