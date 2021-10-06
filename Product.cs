using System;
using System.Collections.Generic;

namespace h5chocolate_teambla
{
    public abstract class Product
    {
        private double price;
        private string productType;
        public Product(string ProductType, double Price)
        {
            this.productType = ProductType;
            this.price = Price;
        }
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
    }
}
