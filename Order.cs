using System;
using System.Collections.Generic;
using System.Globalization;

namespace h5chocolate_teambla
{
    public class Order
    {
        List<Product> productList = new List<Product>();
        static int currentOrderNr = 1;
        int orderNr;
        double donation;
        string donationRecipient;
        DateTime dateTime;

        public List<Product> ProductList
        {
            get { return productList; }
        }
        public int OrderNr
        {
            get
            {
                return orderNr;
            }
            set
            {
                orderNr = value;
            }
        }

        public double Donation
        {
            get
            {
                return donation;
            }
            set
            {
                donation = value;
            }
        }

        public DateTime GetDateTime
        {
            get
            {
                return dateTime;
            }
            set
            {
                dateTime = DateTime.Now;
            }
        }

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
            dateTime = DateTime.Now;
        }

        public void AddProduct(Product product)
        {
            productList.Add(product);
        }

        public void SetTotalDonationPrice()
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
