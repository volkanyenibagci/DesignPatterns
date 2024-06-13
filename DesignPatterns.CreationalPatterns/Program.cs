// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.Factory;

Console.WriteLine("DESIGN PATTERNS!");
Console.WriteLine("_______________________________________________\r\n");

#region Factory

//Bu örnekte, VehicleFactory sınıfı, istemcinin istediği araç türüne göre Car veya Motorcycle nesneleri oluşturur. Bu, Factory Design Pattern'in temel bir uygulamasıdır ve nesne oluşturma sürecini merkezi bir noktada toplayarak sistemin genişletilmesini ve bakımını kolaylaştırır.
VehicleFactory factory = new VehicleFactory();

IVehicle myCar = factory.GetVehicle("car");
myCar.DisplayInfo();

IVehicle myMotorcycle = factory.GetVehicle("motorcycle");
myMotorcycle.DisplayInfo();

#endregion Factory

Console.WriteLine("_______________________________________________\r\n");

#region Builder

//Computer nesnesinin oluşturulma sürecini tanımlayan builder arayüzü

//Oyun Bilgisayarı Oluşturma
IComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();
ComputerDirector director = new ComputerDirector(gamingComputerBuilder);
director.BuildComputer();
Computer myGamingComputer = director.GetComputer();
Console.WriteLine(myGamingComputer.ToString());

//Ofis Bilgisayarı Oluşturma
IComputerBuilder officeComputerBuilder = new OfficeComputerBuilder();
director = new ComputerDirector(officeComputerBuilder);
director.BuildComputer();
Computer myOfficeComputer = director.GetComputer();
Console.WriteLine(myOfficeComputer.ToString());

#endregion Builder

Console.WriteLine("_______________________________________________\r\n");