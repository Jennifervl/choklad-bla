using System;
using System.Collections.Generic;

namespace h5chocolate_teambla
{
    public abstract class Product
    {
        private double price;

        private string productType;

        public double Price

        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string ProductType
        {
            get
            {
                return productType;
            }

            set
            {
                productType = value;
            }

        }

         public Product(string productType, double Price)
        {
            this.productType = productType;
            this.price = Price;
        }

    }
}
