using System;

namespace h5chocolate_teambla
{
    public class ChocolateFactory : ProductFactory
    {
        public override Product MakeProduct(params string[] args)
        {
            Product choco = new Chocolate(Convert.ToInt32(args[0]), args[1], Convert.ToDouble(args[2]), args[3]);
            return choco;
        }
    }
}