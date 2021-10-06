using System;

namespace h5chocolate_teambla
{
    class Program
    {
        static void Main(string[] args)
        {
            UserList userList = new UserList();
            while (true)
            {
                User currentUser = TotallyRealBankID.LogIn(userList);
                while (true)
                {
                    bool run = Menu.ShowMenu(currentUser);
                    if (run == false) break;
                }
            }
        }
    }
}
