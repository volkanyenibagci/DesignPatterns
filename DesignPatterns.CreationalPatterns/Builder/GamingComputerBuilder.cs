using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder
{
    //GamingComputerBuilder, IComputerBuilder arayüzünü uygular ve Computer nesnesini oluşturur
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer computer = new Computer();

        public void BuildCPU()
        {
            computer.CPU = "Intel Core i9";
        }

        public void BuildHDD()
        {
            computer.HDD = "1 TB SSD";
        }

        public void BuildRAM()
        {
            computer.RAM = "32 GB";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}