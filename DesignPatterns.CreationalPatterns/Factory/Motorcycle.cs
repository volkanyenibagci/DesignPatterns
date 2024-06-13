using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Factory
{
    //IVehicle interface'sini uygulayan Motorcycle sınıfı
    public class Motorcycle : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Motorcycle has been created with Factory DP.");
        }
    }
}