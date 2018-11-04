using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Demo
{
    public interface IBuilder
    {
        void BuildFrame();
        void BuildForks();
        void BuildEngine();
        void BuildTransmission();
        Motorcycle GetMotorcycle();
    }
}
