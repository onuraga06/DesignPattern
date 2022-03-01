using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
   public class Pizza
    {
        private int size;
        private string name;
        private bool cheese;
        private bool olive;
        private bool mozerella;
        public Pizza()
        {

        }
        private Pizza(PizzaBuilder pizzaBuilder)
        {
            this.size = pizzaBuilder.size;
            this.olive = pizzaBuilder.olive;
            this.cheese = pizzaBuilder.cheese;
            this.name = pizzaBuilder.name;
        }

       public class PizzaBuilder
        {
            public int size;
            public string name;
            public bool cheese;
            public bool olive;
            public bool mozerella;
            public PizzaBuilder(int size,string name)
            {
                this.size = size;
                this.name = name;
            }
            public PizzaBuilder WithOptinal(bool cheese)
            {
                this.cheese = cheese;
                return this;
            }
            public PizzaBuilder WithOptinalOlive(bool olive)
            {
                this.olive = olive;
                return this;
            }
            public Pizza BuildPizza()
            {
                return new Pizza(this);
            }
        }
    }
}
