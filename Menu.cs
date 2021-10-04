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
    }
}
