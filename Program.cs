using System;

namespace h5chocolate_teambla
{
    class Program
    {
        static void Main(string[] args)
        {
            TotallyRealBankID bankID = new();
            while (true)
            {
                User currentUser = Menu.LoginUser(bankID);
                while (true)
                {
                    bool run = Menu.ShowMenu(currentUser);
                    if (run == false) break;
                }
            }
        }
    }
}
