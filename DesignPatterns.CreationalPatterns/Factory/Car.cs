using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Factory
{
    //IVehicle interface'sini uygulayan Car sınıfı
    public class Car : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Car has been created with Factory DP.");
        }
    }
}