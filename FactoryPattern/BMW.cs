using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class BMW:CarBrand
    {
        public override void BrandName()
        {
            Console.WriteLine("Car Brand BMW");
        }
    }
}
