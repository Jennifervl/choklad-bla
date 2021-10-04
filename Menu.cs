using System;

namespace h5chocolate_teambla
{
    static class Menu
    {
        public static User CreateNewUser()
        {
            Console.WriteLine("Enter ID: ");
            string userInput = Console.ReadLine();

            User createdUser = new User(userInput);
            return createdUser;
        }

        public static Order CreateNewOrder()
        {
            Order newOrder = new Order(0);
            string choice = "";
            while (true)
            {
                Console.WriteLine("[1] Chocolate");
                Console.WriteLine("[2] Cap");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Chocolate newChocolate = Chocolate.createChocolate();
                    newOrder.AddProduct(newChocolate);
                }
                else if (choice == "2")
                {
                    Cap newCap = Cap.CreateCap();
                    newOrder.AddProduct(newCap);
                }

                Console.WriteLine("Do you want to add another Product J/N?");
                choice = Console.ReadLine();

                if (choice == "J") continue;
                else break;

            }
            Console.WriteLine("Who do you want to donate to?");
            Console.WriteLine("1. WWF");
            Console.WriteLine("2. BRIS");
            Console.WriteLine("3. Röda korset");
            Console.WriteLine("4. Random");
            choice = Console.ReadLine();

            if (choice == "1") newOrder.DonationRecipient = "WWF";
            else if (choice == "2") newOrder.DonationRecipient = "BRIS";
            else if (choice == "3") newOrder.DonationRecipient = "Röda korset";

            newOrder.setTotal();
            return newOrder;
        }

        public static void ShowMenu()
        {
            Console.WriteLine("[1] Place order");
            Console.WriteLine("[2] Order history");
            Console.WriteLine("[3] Exit");

            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    {
                        Order.CreateOrder();
                        break;
                    }

                case "2":
                    {
                        User.printHistory();
                        break;
                    }

                case "3":
                    Environment.Exit(0);
                    break;
            }


        }
    }
}
