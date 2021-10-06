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
                User currentUser = TotallyRealBankID.LogIn(userList);
                while (true)
                {
                    Menu.ShowMenu(currentUser);
                }
            }
        }
    }
}
