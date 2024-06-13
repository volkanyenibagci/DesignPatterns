// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationalPatterns.Factory;

Console.WriteLine("DESIGN PATTERNS!");

#region Factory

//Bu örnekte, VehicleFactory sınıfı, istemcinin istediği araç türüne göre Car veya Motorcycle nesneleri oluşturur. Bu, Factory Design Pattern'in temel bir uygulamasıdır ve nesne oluşturma sürecini merkezi bir noktada toplayarak sistemin genişletilmesini ve bakımını kolaylaştırır.
VehicleFactory factory = new VehicleFactory();

IVehicle myCar = factory.GetVehicle("car");
myCar.DisplayInfo();

IVehicle myMotorcycle = factory.GetVehicle("motorcycle");
myMotorcycle.DisplayInfo();

#endregion Factory