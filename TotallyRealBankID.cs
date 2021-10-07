using System;
using System.Collections.Generic;

namespace h5chocolate_teambla
{
    class TotallyRealBankID
    {
        List<User> userList = new List<User>();

        List<User> listOfUsers = new();

        public User LogIn(long parsedInput)
        {
            if (IsValidID(Convert.ToInt64(parsedInput)) == false) throw new ArgumentException("Invalid ID");

            foreach (User user in listOfUsers)
            {
                if (user.Id == parsedInput.ToString())
                {
                    return user;
                }
            }
            return CreateNewUser(parsedInput.ToString(), userList);
        }

        private static User CreateNewUser(string id, List<User> list)
        {
            User createdUser = new User(id);
            list.Add(createdUser);
            return createdUser;
        }

        private static bool IsValidID(long id) // Ska vara private?
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