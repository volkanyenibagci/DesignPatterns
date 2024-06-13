using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder
{
    //Computer nesnesinin oluşturulma sürecini tanımlayan builder arayüzü
    public interface IComputerBuilder
    {
        void BuildCPU();

        void BuildRAM();

        void BuildHDD();

        Computer GetComputer();
    }
}