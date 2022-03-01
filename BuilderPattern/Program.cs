using BuilderPattern.BuildDesignPattern;
using System;
using static BuilderPattern.Pizza;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder pizzaBuilder = new PizzaBuilder(15,"Italy");
            pizzaBuilder.WithOptinalOlive(true);
            pizzaBuilder.WithOptinal(true);
            Pizza pizza = pizzaBuilder.BuildPizza();

            ComputerBuilder computerBuilder = new ComputerBuilder();
            Computer computer = computerBuilder.SetBrand("Asus").SetCpu("2.4").SetPirce("5.000").BuildComputer();
            Console.WriteLine(computer);
            Console.ReadLine();
        }
    }
}
