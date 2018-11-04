using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Demo
{
    public class DominatorBuilder : IBuilder
    {
        private Motorcycle _motorcycle = new Motorcycle();

        public void BuildFrame()
        {
            _motorcycle.Frame = "Dominator";
        }

        public void BuildForks()
        {
            _motorcycle.Forks = "Inverted";
        }

        public void BuildEngine()
        {
            _motorcycle.Engine = "ShovelHead";
        }

        public void BuildTransmission()
        {
            _motorcycle.Transmission = "4 speed kick";
        }

        public Motorcycle GetMotorcycle()
        {
            return _motorcycle;
        }
    }
}
