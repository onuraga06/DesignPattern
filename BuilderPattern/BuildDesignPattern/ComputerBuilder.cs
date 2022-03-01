using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.BuildDesignPattern
{
   public class ComputerBuilder
    {
        private string brand { get; set; }
        private string price { get; set; }
        private string cpu { get; set; }
        private string ram { get; set; }
        public ComputerBuilder SetBrand(string brand)
        {
             this.brand = brand;
            return this;
        }
        public ComputerBuilder SetPirce(string price)
        {
            this.price = price;
            return this;
        }
        public ComputerBuilder SetCpu(string cpu)
        {
            this.cpu = cpu;
            return this;
        }
        public ComputerBuilder SetCram(string ram)
        {
            this.ram = ram;
            return this;
        }
        public Computer BuildComputer()
        {
            return new Computer(this.brand, this.cpu, this.price, this.ram);
        }

    }
}
