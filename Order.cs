using System;
using System.Collections.Generic;

namespace h5chocolate_teambla
{
    class Order
    {
        List<Product> productList = new List<Product>();

        int orderNr;
        int donation; // sum of all the products.

        string donationRecipient; // oganisation donated to.

        DateTime dateTime;

        public Order(int OrderNr, int Donation, string DonationRecipient)
        {
            orderNr = OrderNr;
            donation = Donation;
            donationRecipient = DonationRecipient;
            dateTime = DateTime.Today;
        }




    }
}
