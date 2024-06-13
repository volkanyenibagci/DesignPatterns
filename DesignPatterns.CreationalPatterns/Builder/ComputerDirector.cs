using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Builder
{
    //builder arayüzünü kullanarak Computer nesnesini oluşturacak olan director sınıfı
    public class ComputerDirector
    {
        private IComputerBuilder computerBuilder;

        public ComputerDirector(IComputerBuilder computerBuilder)
        {
            this.computerBuilder = computerBuilder;
        }

        public void BuildComputer()
        {
            computerBuilder.BuildCPU();
            computerBuilder.BuildRAM();
            computerBuilder.BuildHDD();
        }

        public Computer GetComputer()
        {
            return computerBuilder.GetComputer();
        }
    }
}