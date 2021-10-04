using System;
using System.Collections.Generic;

namespace h5chocolate_teambla
{
    class Product 
    {
        private double price; //får inte vara negativt!
        private string productType; //choklad eller keps?
        // private int productAmount; //hur många? minimum 1, max 10}

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

        // public int ProductAmount
        // {
        //     get
        //     {
        //         return productAmount;
        //     }
            
        //     set
        //     {
        //         productAmount = value;
        //     }
        // }
    }
}
