using System;
using System.Linq;
using System.Threading;

namespace h5chocolate_teambla
{
    class TotallyRealBankID 
    {
        internal static User LogIn(UserList list)
        {

            string id;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-- Enter your 10 digit Personal ID to log in --\n");
                Console.WriteLine("Personal ID: ");
                Console.SetCursorPosition(13, 2);

                string input = Console.ReadLine();
                if (IsValidID(Convert.ToInt64(input)) == false)
                    continue;

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
        
        private static User CreateNewUser(string id, UserList list)
        {
            User createdUser = new User(id);
            list.AddUser(createdUser);
            return createdUser;
        }

        public static bool IsValidID(long id) // Ska vara private?
        {
            if (!(id.ToString().Length == 10))
                return false;

            string birthdate = id.ToString().Substring(0, 6);
            string dateString = string.Join('/', birthdate.Substring(0, 2), birthdate.Substring(2, 2), birthdate.Substring(4, 2));

            DateTime parsedDate;

            try
            {
                parsedDate = DateTime.Parse(dateString);
            }
            catch (FormatException)
            {
                return false;
            }

            if (parsedDate > DateTime.Now)
                return false;

            return true;
        }
    }
}
