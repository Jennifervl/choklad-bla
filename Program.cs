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

            foreach (User item in userList.GetList())
            {
                Console.WriteLine(item.Id);

            }

            Console.WriteLine(newUser.Id);
        }
    }
}
