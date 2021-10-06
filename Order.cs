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
        public void PrintOrderInfo(User currentUser)
        {

            Console.WriteLine("Order nr: " + orderNr);
            Console.WriteLine("Customer ID: " + currentUser.Id);
            Console.WriteLine("Donation amount: " + donation.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Donation recipient: " + donationRecipient);
            Console.WriteLine("Time of order: " + dateTime.ToString("MM/dd/yyyy HH:mm"));

            Console.WriteLine();
            PrintProductList();
            Console.WriteLine();

        }
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
