using System;

namespace h5chocolate_teambla
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList userList = new UserList();

            User newUser = Menu.CreateNewUser();
            userList.AddUser(newUser);

            Menu.ShowMenu();

            foreach (var item in newUser.GetUserHistory())
            {
                Console.WriteLine(item);
            }
        }
    }
}
