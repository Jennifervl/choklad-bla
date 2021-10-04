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
            Order newOrder = new Order(0, 0, "");
            Console.WriteLine("[1] Chocolate");
            Console.WriteLine("[2] Cap");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Chocolate.createChocolate();


            }
            else if (choice == "2")
            {

            }

            return newOrder;
        }

        public void ShowMenu()
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
