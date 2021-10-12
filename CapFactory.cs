using System;

namespace h5chocolate_teambla
{
    public class CapFactory : ProductFactory
    {
        public override Product MakeProduct(params string[] args)
        {
            Product cap = new Cap(args[0], args[1], Convert.ToDouble(args[2]), args[3]);
            return cap;
        }
    }
}