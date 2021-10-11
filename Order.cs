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
        //Flytta de två metoderna till anv.gränssnittet, lägg till properties med get

        public void PrintProductList()
        {
            foreach (Product item in productList)
            {
                if (item is Cap)
                {
                    var tempCap = item as Cap;
                    Console.WriteLine($"Product: {tempCap.ProductType}".PadRight(25) + $"Size: {tempCap.Size}".PadRight(25) + $"Colour:  {tempCap.Colour}".PadRight(35) + $"Price: {tempCap.Price.ToString("C", CultureInfo.CurrentCulture)}");
                }
                else if (item is Chocolate)
                {
                    var tempChocolate = item as Chocolate;
                    Console.WriteLine($"Product: {tempChocolate.ProductType}".PadRight(25) + $"Cocoa content: {tempChocolate.CocoaAmount}%".PadRight(25) + $"Filling: {tempChocolate.Filling}".PadRight(35) + $"Price: {tempChocolate.Price.ToString("C", CultureInfo.CurrentCulture)}");
                }
            }
        }
    }

}
