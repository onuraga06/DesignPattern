using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class CarFactory
    {
        public CarBrand FactoryMethod(Brands carbrands)
        {
            CarBrand car = null;
            switch (carbrands)
            {
                case Brands.BMW:
                    car = new BMW();
                    break;
                case Brands.Mercedes:
                    car = new Mercedes();
                    break;
                default:
                    break;
            }
            return car;
        }
        
    }
}
