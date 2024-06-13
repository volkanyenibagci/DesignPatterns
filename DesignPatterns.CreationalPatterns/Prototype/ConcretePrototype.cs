using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    //Iprototype arayüzünü uygulayar ve kendisinin bir kopyasını oluşturur.
    public class ConcretePrototype : IPrototype
    {
        public int Field1 { get; set; }
        public string Field2 { get; set; }

        // Constructor
        public ConcretePrototype(int field1, string field2)
        {
            this.Field1 = field1;
            this.Field2 = field2;
        }

        // Clone metodu bu nesnenin bir kopyasını oluşturur ve döndürür.
        public IPrototype Clone()
        {
            return this.MemberwiseClone() as IPrototype;
        }

        public override string ToString()
        {
            return $"Field1: {Field1}, Field2: {Field2}";
        }
    }
}