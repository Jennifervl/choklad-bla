using System;
using System.Collections.Generic;

namespace h5chocolate_teambla
{
    public class Product
    {
        private double price; //får inte vara negativt!
        private string productType; //choklad eller keps?
        // private int productAmount; //hur många? minimum 1, max 10}

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
