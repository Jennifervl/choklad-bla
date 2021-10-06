using System;
using System.Linq;
using System.Threading;

namespace h5chocolate_teambla
{
    static class Menu
    {
        public static User LogIn(UserList list)
        {

            string id;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- Enter you 10 digit Personal ID to log in --\n");
                Console.WriteLine("ID: ");
                Console.SetCursorPosition(4, 2);

                string input = Console.ReadLine();

                if (input.All(c => Char.IsWhiteSpace(c) || Char.IsLetter(c)) || input.Length != 10)
                {
                    Console.WriteLine("Invalid Personal ID");
                    Thread.Sleep(2000);
                }
                else
                {
                    id = input;
                    break;
                }
            }

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
            Order newOrder = new Order();
            string choice = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- PRODUCTS --\n");
                Console.WriteLine("[1] Chocolate");
                Console.WriteLine("[2] Cap");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Chocolate newChoco = Menu.CreateChocolate();
                    newOrder.AddProduct(newChoco);
                }
                else if (choice == "2")
                {
                    Cap newCap = Menu.CreateCap();
                    newOrder.AddProduct(newCap);
                }

                Console.Clear();
                Console.WriteLine("Do you want to add another Product Y/N?");
                choice = Console.ReadLine().ToUpper();

                if (choice == "Y") continue;
                else break;

            }
            Console.Clear();
            Console.WriteLine("-- DONATION --\n");
            Console.WriteLine("1. WWF");
            Console.WriteLine("2. BRIS");
            Console.WriteLine("3. Red Cross");
            Console.WriteLine("4. Random");
            choice = Console.ReadLine();

            if (choice == "1") newOrder.DonationRecipient = "WWF";
            else if (choice == "2") newOrder.DonationRecipient = "BRIS";
            else if (choice == "3") newOrder.DonationRecipient = "Red Cross";
            else if (choice == "4")
            {
                Random random = new Random();
                int randomizer = random.Next(1, 4);
                if (randomizer == 1) newOrder.DonationRecipient = "WWF";
                else if (randomizer == 2) newOrder.DonationRecipient = "BRIS";
                else if (randomizer == 3) newOrder.DonationRecipient = "Red Cross";
            }
            Console.Clear();
            newOrder.setTotal();
            return newOrder;
        }

        public static void ShowMenu(User currentUser)
        {
            Console.Clear();
            Console.WriteLine("-- MENU --\n");
            Console.WriteLine("[1] Place an order");
            Console.WriteLine("[2] Browse order history");
            Console.WriteLine("[3] Exit program");

            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    {
                        Order newOrder = CreateNewOrder();
                        newOrder.PrintOrderInfo(currentUser);

                        while (menuChoice != "Y" | menuChoice != "N")
                        {
                            Console.WriteLine("Do you confirm Y/N?");
                            menuChoice = Console.ReadLine().ToUpper();

                            if (menuChoice == "Y")
                            {
                                currentUser.AddOrderToHistory(newOrder);
                                break;
                            }
                            else if (menuChoice == "N")
                            {
                                Console.WriteLine("--Order cancelled--");
                                Console.ReadKey();
                                break;
                            }
                        }
                        break;
                    }

                case "2":
                    {
                        Console.Clear();

                        if (currentUser.GetUserHistory().Count == 0)
                            Console.WriteLine("You haven't ordered anything yet.");

                        else
                            foreach (Order item in currentUser.GetUserHistory())
                            {
                                item.PrintOrderInfo(currentUser);
                            }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    }

                case "3":
                    Environment.Exit(0);
                    break;
            }
        }
        public static Cap CreateCap()
        {
            Console.Clear();
            Console.WriteLine("-- COLOR --\n");
            Console.WriteLine("[1] Green");
            Console.WriteLine("[2] Blue");

            string choice = Console.ReadLine();

            string colour = "";
            if (choice == "1") colour = "Green";
            else if (choice == "2") colour = "Blue";

            Console.Clear();
            Console.WriteLine("-- SIZE --\n");
            Console.WriteLine("[1] Medium");
            Console.WriteLine("[2] Large");
            choice = Console.ReadLine();

            string size = "";
            if (choice == "1") size = "Medium";
            else if (choice == "2") size = "Large";

            Cap newCap = new Cap(colour, size, 50, "Cap");
            return newCap;
        }
        public static Chocolate CreateChocolate()
        {
            string filling = "";
            double price = 0;
            int cocoa;
            string userInput;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- Cocoa content in % (10 - 91) --\n");
                Console.WriteLine("Cocoa: ");
                Console.SetCursorPosition(7, 2);

                int.TryParse(userInput = Console.ReadLine(), out int CocoaAmount);

                if (CocoaAmount > 9 && CocoaAmount < 91)
                {
                    Console.Clear();
                    Console.WriteLine("-- FILLING --\n\n[1]: Orangutan Orange\n[2]: Powerful Peanutbutter\n[3]: Masterful Maple Syrup\n[4]: Nice Nectarine Surprise\n[5]: No filling, thank you!");
                    int.TryParse(userInput = Console.ReadLine(), out int Choice);

                    switch (Choice)
                    {
                        case 1:
                            filling = "Orangutan Orange";
                            price = (CocoaAmount * 2 + 75);
                            break;

                        case 2:
                            filling = "Powerful Peanutbutter";
                            price = (CocoaAmount * 2 + 50);
                            break;

                        case 3:
                            filling = "Master Maple Syrup";
                            price = (CocoaAmount * 2 + 100);
                            break;

                        case 4:
                            filling = "Nice Nectarine Surprise";
                            price = (CocoaAmount * 2 + 60);
                            break;

                        case 5:
                            filling = "No filling";
                            price = (CocoaAmount * 2);
                            break;

                        default:
                            Console.WriteLine("You have entered an invalid choice.");
                            break;
                    }
                    cocoa = CocoaAmount;
                    break;
                }

                else
                    Console.Clear();
                Console.WriteLine("You have entered an invalid amount of cocoa content. Only use values between 10 and 90, please.");
            }

            Chocolate newChocolate = new(cocoa, filling, price, "Chocolate");
            return newChocolate;
        }
    }
}
