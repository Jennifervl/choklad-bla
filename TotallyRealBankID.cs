using System;
using System.Linq;
using System.Threading;

namespace h5chocolate_teambla
{
    class TotallyRealBankID
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
    }
}