using System;
using System.Collections.Generic;

namespace h5chocolate_teambla
{
    public class Order
    {
        List<Product> productList = new List<Product>();
        static int currentOrderNr = 0;
        int orderNr;
        double donation; // sum of all the products.

        string donationRecipient; // oganisation donated to.

        DateTime dateTime;

        public string DonationRecipient
        {
            get
            {
                return donationRecipient;
            }
            set
            {
                donationRecipient = value;
            }
        }
        public Order()
        {
            orderNr = currentOrderNr;
            currentOrderNr += 1;
            dateTime = DateTime.Today;
        }
        public void AddProduct(Product product)
        {
            productList.Add(product);
        }
        public void setTotal()
        {
            double total = 0;
            foreach (Product item in productList)
            {
                total += item.Price;
            }
            donation = total;
        }
    }
}
