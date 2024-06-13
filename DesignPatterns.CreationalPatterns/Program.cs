// See https://aka.ms/new-console-template for more information
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.Factory;
using DesignPatterns.CreationalPatterns.Prototype;
using DesignPatterns.CreationalPatterns.Singleton;

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

#region Singleton

//Bu örnekte, Singleton sınıfı, kendisinden yalnızca bir örnek oluşturulmasını sağlar. GetInstance metodunu kullanarak Singleton sınıfının bir örneğine erişilir. Eğer bir örnek zaten mevcutsa, bu mevcut örnek döndürülür; aksi takdirde yeni bir örnek oluşturulur ve döndürülür. Bu, Singleton deseninin temel bir uygulamasıdır ve global olarak erişilebilir bir tek nesne örneği sağlar.

// Singleton nesnesini al.
Singleton singleton1 = Singleton.GetInstance();
singleton1.DisplayMessage();

// Tekrar Singleton nesnesini al.
Singleton singleton2 = Singleton.GetInstance();

// İki referansın da aynı nesneye işaret ettiğini doğrula.
if (singleton1 == singleton2)
{
    Console.WriteLine("Singleton1 and Singleton2 refer to the same instance.");
}

#endregion Singleton

Console.WriteLine("_______________________________________________\r\n");

#region Prototype

//Copying an object “from the outside” isn’t always possible.
//ConcretePrototype sınıfı IPrototype arayüzünü uygular ve Clone metodunu kullanarak kendisinin bir kopyasını oluşturur. MemberwiseClone metodu, nesnenin yüzeysel bir kopyasını oluşturur. Bu, Prototype Design Pattern'in temel bir uygulamasıdır ve nesneleri klonlamak için bir yol sağlar.

// Orijinal nesneyi oluştur.
ConcretePrototype original = new ConcretePrototype(1, "original");
Console.WriteLine("Original: " + original);

// Orijinal nesnenin bir kopyasını oluştur.
ConcretePrototype clone = original.Clone() as ConcretePrototype;
Console.WriteLine("Clone: " + clone);

// Klonlanmış nesnenin alanlarını değiştir.
clone.Field1 = 2;
clone.Field2 = "modified clone";

// Orijinal ve klonlanmış nesnelerin son durumunu göster.
Console.WriteLine("Modified Original: " + original);
Console.WriteLine("Modified Clone: " + clone);

#endregion Prototype