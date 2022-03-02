using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Ayakkabi
{
    public class Products
    {
        public class Bot : IShoe
        {
            public void Type()
            {
                Console.WriteLine("Category Bot");
            }
        }
        public class Sneaker : IShoe
        {
            public void Type()
            {
                Console.WriteLine("Category Snekars");
            }
        }
        public class Cizme : IShoe
        {
            public void Type()
            {
                Console.WriteLine("Category Cizme");
            }
        }
    }
}
