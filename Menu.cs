using System;
using System.Globalization;

namespace h5chocolate_teambla
{
    static class Menu
    {

        public static User LoginUser(TotallyRealBankID bankid)
        {
            while (true)
            {
                string userInput;
                long parsedInput;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("-- Enter your 10 digit Personal ID to log in --\n");
                    Console.WriteLine("Personal ID: ");
                    userInput = Console.ReadLine();
                    if (Int64.TryParse(userInput, out parsedInput) == false) continue;
                    else break;
                }

                User currentUser;

                try
                {
                    currentUser = bankid.LogIn(parsedInput);
                }
                catch (ArgumentException)
                {
                    continue;
                }

                return currentUser;
            }
        }

        public static bool ShowMenu(User currentUser)
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- SELECT MENU CHOICE --\n");
                Console.WriteLine("[1] Place an order");
                Console.WriteLine("[2] Browse order history");
                Console.WriteLine("[3] Log out");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {

                    case "1":
                        {
                            Order newOrder = CreateNewOrder();

                            while (menuChoice != "Y" | menuChoice != "N")
                            {
                                Console.Clear();
                                PrintOrderInfo(newOrder, currentUser);
                                Console.WriteLine("\n-- CONFIRM ORDER Y/N? --");
                                menuChoice = Console.ReadLine().ToUpper();

                                if (menuChoice == "Y")
                                {
                                    currentUser.AddOrderToHistory(newOrder);
                                    break;
                                }
                                else if (menuChoice == "N")
                                {
                                    Console.WriteLine("-- ORDER CANCELLED --");
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
                                Console.WriteLine("-- YOU HAVEN'T ORDERED ANYTHING YET --");

                            else
                                foreach (Order item in currentUser.GetUserHistory())
                                {

                                    PrintOrderInfo(item, currentUser);
                                }
                            Console.WriteLine("-- PRESS ANY KEY TO CONTINUE --");
                            Console.ReadKey();
                            break;
                        }

                    case "3":
                        Console.Clear();
                        return false;
                    default:
                        continue;

                }
                break;
            }
            return true;
        }

        public static Order CreateNewOrder()
        {
            Order newOrder = new Order();
            string choice = "";
            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("-- CHOOSE A PRODUCT --\n");
                    Console.WriteLine("[1] Chocolate");
                    Console.WriteLine("[2] Cap");

                    choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Product newChoco = Menu.CreateChocolate();
                        newOrder.AddProduct(newChoco);
                        break;

                    }
                    else if (choice == "2")
                    {
                        Product newCap = Menu.CreateCap();
                        newOrder.AddProduct(newCap);
                        break;
                    }
                    else continue;
                }
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("-- DO YOU WANT TO ADD ANOTHER PRODUCT Y/N? --");
                    choice = Console.ReadLine().ToUpper();
                    if (choice == "Y") break;

                    else if (choice == "N")
                    {
                        break;
                    }
                    else continue;
                }
                if (choice == "Y") continue;
                else break;
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- SELECT DONATION RECIPIENT --\n");
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
                else continue;

                Console.Clear();
                newOrder.SetTotalDonationPrice();
                return newOrder;

            }
        }

        public static Product CreateCap()
        {
            string colour;
            string choice;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- CHOOSE COLOUR --\n");
                Console.WriteLine("[1] Green");
                Console.WriteLine("[2] Blue");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    colour = "Green";
                    break;
                }
                else if (choice == "2")
                {
                    colour = "Blue";
                    break;
                }
            }

            string size;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- CHOOSE SIZE --\n");
                Console.WriteLine("[1] Medium");
                Console.WriteLine("[2] Large");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    size = "Medium";
                    break;
                }
                else if (choice == "2")
                {
                    size = "Large";
                    break;
                }
            }

            // Cap newCap = new Cap(colour, size, 50, "Cap");
            // return newCap;
            Product cap = new CapFactory().CreateProduct(colour, size, 50.ToString(), "cap");
            return cap;
        }

        public static Product CreateChocolate()
        {
            string filling = "";
            double price = 0;
            int cocoa;
            string userInput;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- SELECT COCOA CONTENT IN % (10 - 90) --\n");
                Console.WriteLine("Cocoa: ");
                Console.SetCursorPosition(7, 2);

                int.TryParse(userInput = Console.ReadLine(), out int CocoaAmount);

                if (CocoaAmount > 9 && CocoaAmount < 91)
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("-- CHOOSE FILLING --\n\n[1] Orangutan Orange\n[2] Powerful Peanutbutter\n[3] Masterful Maple Syrup\n[4] Nice Nectarine Surprise\n[5] No filling");
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
                                Console.WriteLine("-- YOU HAVE ENTERED AN INVALID CHOICE --");
                                continue;
                        }
                        break;
                    }
                    cocoa = CocoaAmount;
                    break;
                }

                else
                    Console.Clear();
                Console.WriteLine("-- YOU HAVE ENTERED AN INVALID AMOUNT OF COCOA CONTENT. ONLY USE VALUES BETWEEN 10 AND 90. --");
                Console.ReadKey();
            }

            // Chocolate newChocolate = new(cocoa, filling, price, "Chocolate");
            Product choco = new ChocolateFactory().CreateProduct(cocoa.ToString(), filling, price.ToString(), "Chocolate");
            return choco;
        }

        public static void PrintOrderInfo(Order newOrder, User currentUser)
        {

            Console.WriteLine("Order nr: " + newOrder.OrderNr);
            Console.WriteLine("Customer ID: " + currentUser.Id);
            Console.WriteLine("Donation amount: " + newOrder.Donation.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Donation recipient: " + newOrder.DonationRecipient);
            Console.WriteLine("Time of order: " + newOrder.GetDateTime.ToString("MM/dd/yyyy HH:mm\n\n"));

            PrintProductList(newOrder);
        }

        public static void PrintProductList(Order order)
        {
            foreach (Product item in order.ProductList)
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
