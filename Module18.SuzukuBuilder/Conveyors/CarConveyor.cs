using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18.SuzukuBuilder.Conveyors
{
    class CarConveyor : Conveyor
    {
        public CarConveyor()
        {
            _product = new Product("automobill!!!");
        }

        public override void BuildFrame()
        {
            _product["frame"] = "noframe, just power body";
        }

        public override void BuildEngine()
        {
            _product["engine"] = "gazoline, 112 hp";
        }

        public override void BuildWheels()
        {
            _product["wheels"] = "four";
        }

        public override void BuildDoors()
        {
            _product["doors"] = "four";
        }
    }
}
