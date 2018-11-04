using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikeCreator = new MotorcycleCreator(new DevastatorBuilder());
            bikeCreator.BuildMotorcycle();
            var motorcycle = bikeCreator.GetMotorcycle();
            motorcycle.ShowMotorcycleInfo();

            Console.WriteLine("Press any key to see the next motorcycle build.");
            Console.ReadLine();

            bikeCreator = new MotorcycleCreator(new DominatorBuilder());
            bikeCreator.BuildMotorcycle();
            motorcycle = bikeCreator.GetMotorcycle();
            motorcycle.ShowMotorcycleInfo();
            Console.ReadLine();
        }
    }
}
