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
            Order newOrder = new Order();
            string choice = "";
            while (true)
            {
                Console.WriteLine("[1] Chocolate");
                Console.WriteLine("[2] Cap");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    // Chocolate newChocolate = Chocolate.CreateChocolate();
                    // newOrder.AddProduct(newChocolate);
                }
                else if (choice == "2")
                {
                    Cap newCap = Menu.CreateCap();
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
                        Order newOrder = CreateNewOrder();

                        break;
                    }

                // case "2":
                //     {
                //         User.printHistory();
                //         break;
                //     }

                case "3":
                    Environment.Exit(0);
                    break;
            }


        }
        public static Cap CreateCap()
        {
            Console.WriteLine("What colour do you want for your cap?");
            Console.WriteLine("1. Green");
            Console.WriteLine("2. Blue");

            string choice = Console.ReadLine();

            string colour = "";
            if (choice == "1") colour = "Green";
            else if (choice == "2") colour = "Blue";

            Console.WriteLine("What size do you want?");
            Console.WriteLine("1. Medium");
            Console.WriteLine("2. Large");
            choice = Console.ReadLine();

            string size = "";
            if (choice == "1") size = "Medium";
            else if (choice == "2") size = "Large";

            Cap newCap = new Cap(colour, size, 50, "Cap");
            return newCap;
        }
    }
}
