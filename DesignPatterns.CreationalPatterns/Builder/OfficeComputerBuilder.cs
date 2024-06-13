using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder
{
    //GamingComputerBuilder, IComputerBuilder arayüzünü uygular ve Computer nesnesini oluşturur
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();

        public void BuildCPU()
        {
            computer.CPU = "Intel Core i3";
        }

        public void BuildHDD()
        {
            computer.HDD = "256 GB HDD";
        }

        public void BuildRAM()
        {
            computer.RAM = "8 GB";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}