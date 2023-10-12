using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Abstact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vihicle car1 = new Vihicle(); // this is not possible as parent class is astract! to increase security 
            Corsa car2 = new Corsa();
                Console.WriteLine(car2.wheels);
            Console.ReadLine(); 
        }
    }
    abstract class Vehicle
    {
        public int wheels = 4;
    }
    class Corsa : Vehicle
    {
        public int sparewheels = 1;
    }
}
