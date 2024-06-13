using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    //Klonlama işlemini destekleyen interface
    public interface IPrototype
    {
        IPrototype Clone();
    }
}