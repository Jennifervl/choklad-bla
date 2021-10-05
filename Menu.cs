using System;

namespace h5chocolate_teambla
{
    static class Menu
    {
        public static User LogIn(UserList list)
        {
            Console.Write("Enter ID to log in: ");
            string id = Console.ReadLine();
            foreach (User user in list.GetList())
            {
                if (user.Id == id)
                {
                    return user;
                }
            }
            return CreateNewUser(id, list);
        }
        public static User CreateNewUser(string id, UserList list)
        {
            User createdUser = new User(id);
            list.AddUser(createdUser);
            return createdUser;
        }

        public static Order CreateNewOrder()
        {
            Chocolate newChocolate = new Chocolate(0, "", 0, "");
            Order newOrder = new Order();
            string choice = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] Chocolate");
                Console.WriteLine("[2] Cap");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    newChocolate.CreateChocolate();
                    newOrder.AddProduct(newChocolate);
                }
                else if (choice == "2")
                {
                    Cap newCap = Menu.CreateCap();
                    newOrder.AddProduct(newCap);
                }

                Console.WriteLine("Do you want to add another Product J/N?");
                choice = Console.ReadLine().ToUpper();

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
            else if (choice == "4")
            {
                Random random = new Random();
                int randomizer = random.Next(1, 4);
                if (randomizer == 1) newOrder.DonationRecipient = "WWF";
                else if (randomizer == 2) newOrder.DonationRecipient = "BRIS";
                else if (randomizer == 3) newOrder.DonationRecipient = "Röda korset";
            }

            newOrder.setTotal();
            return newOrder;
        }

        public static void ShowMenu(User currentUser)
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
                        newOrder.PrintOrderInfo();
                        Console.WriteLine("Do you confirm J/N?");
                        menuChoice = Console.ReadLine().ToUpper();

                        if (menuChoice == "J")
                        {
                            currentUser.UserHistory.AddOrder(newOrder);
                        }
                        break;
                    }

                case "2":
                    {
                        foreach (Order item in currentUser.UserHistory.GetList())
                        {
                            item.PrintOrderInfo();
                        }
                        break;
                    }

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
