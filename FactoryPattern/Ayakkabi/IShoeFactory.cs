using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryPattern.Ayakkabi.Products;

namespace FactoryPattern.Ayakkabi
{
    public enum ShoeType
    {
        bot = 0, sneaker = 1, cizme = 2,
    }
    public interface IShoeFactory
    {
        IShoe ProduceShoe(ShoeType type);
    }
    public class ShoeFactory : IShoeFactory
    {
        public IShoe ProduceShoe(ShoeType type)
        {
            switch (type)
            {
                case ShoeType.bot:
                    return new Bot();
                case ShoeType.sneaker:
                    return new Sneaker();
                default:
                    return new Cizme();
            }
        }
    }
}
