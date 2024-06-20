// See https://aka.ms/new-console-template for more information
using DesignPatterns.StructuralPatterns.Adapter;

Console.WriteLine("STRUCTURAL PATTERNS!");
Console.WriteLine("_______________________________________________\r\n");

#region Adapter

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());

#endregion Adapter

Console.WriteLine("_______________________________________________\r\n");

#region Bridge

//Bridge

#endregion Bridge