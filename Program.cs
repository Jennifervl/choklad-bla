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
                User currentUser = Menu.LogIn(userList);
                userList.AddUser(currentUser);
                while (true)
                {
                    Menu.ShowMenu(currentUser);
                }
                //Ny kommentar
            }
        }
    }
}
