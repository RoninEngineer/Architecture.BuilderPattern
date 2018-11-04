using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Demo
{
    public class Motorcycle
    {
        public string Frame { get; set; }
        public string Forks { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }

        public void ShowMotorcycleInfo()
        {
            Console.WriteLine($"Frame : {Frame}");
            Console.WriteLine($"Forks : {Forks}");
            Console.WriteLine($"Engine : {Engine}");
            Console.WriteLine($"Transmission : {Transmission}");
        }
    }
}
