using System;
using System.Collections.Generic;
using System.Globalization;

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
            dateTime = DateTime.Now;
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
        public void PrintOrderInfo()
        {
            Console.WriteLine("Order nr: " + orderNr);
            Console.WriteLine("Donation amount: " + donation.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Donation recipient: " + donationRecipient);
            Console.WriteLine("Time of order: " + dateTime.ToString("MM/dd/yyyy HH:mm"));

            Console.WriteLine();
            PrintProductList();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey(true);
        }
        public void PrintProductList()
        {
            Console.WriteLine("Products:");
            foreach (Product item in productList)
            {
                if (item is Cap)
                {
                    var tempCap = item as Cap;
                    Console.WriteLine($"Product: {tempCap.ProductType}      Size: {tempCap.Size}        Colour: {tempCap.Colour}        Price: {tempCap.Price.ToString("C", CultureInfo.CurrentCulture)}");
                }
            }
        }
    }
}
