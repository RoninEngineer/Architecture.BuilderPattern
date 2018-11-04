using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Demo
{
    public class DevastatorBuilder : IBuilder
    {
        private Motorcycle _motorcycle = new Motorcycle();

        public void BuildFrame()
        {
            _motorcycle.Frame = "Devastator";
        }

        public void BuildForks()
        {
            _motorcycle.Forks = "Girder";
        }

        public void BuildEngine()
        {
            _motorcycle.Engine = "KnuckleHead";
        }

        public void BuildTransmission()
        {
            _motorcycle.Transmission = "4 speed kick start";
        }

        public Motorcycle GetMotorcycle()
        {
            return _motorcycle;
        }
    }
}
