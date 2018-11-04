using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Demo
{
    public class MotorcycleCreator
    {
        private readonly IBuilder motorCycleBuilder;

        public MotorcycleCreator(IBuilder _builder)
        {
            motorCycleBuilder = _builder;
        }

        public void BuildMotorcycle()
        {
            motorCycleBuilder.BuildFrame();
            motorCycleBuilder.BuildForks();
            motorCycleBuilder.BuildEngine();
            motorCycleBuilder.BuildTransmission();
        }

        public Motorcycle GetMotorcycle()
        {
            return motorCycleBuilder.GetMotorcycle();
        }
    }
}
