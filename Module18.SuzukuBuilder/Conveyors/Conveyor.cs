using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.SuzukuBuilder.Conveyors
{
    /// <summary>
    /// abstract Builder Class
    /// </summary>
    abstract class Conveyor
    {
        protected Product _product;
        public Product Product { get { return _product; } }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
