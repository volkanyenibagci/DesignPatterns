using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Factory
{
    //Araçları oluşturacak olan Factory sınıfı
    public class VehicleFactory
    {
        public IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();

                case "motorcycle":
                    return new Motorcycle();

                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}