using System;

namespace h5chocolate_teambla
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                UserList userList = new UserList();
                User newUser = Menu.CreateNewUser();
                userList.AddUser(newUser);
                while (true)
                {
                    Menu.ShowMenu(newUser);
                }
            }
        }
    }
}
