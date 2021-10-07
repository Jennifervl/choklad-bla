using System;
using System.Collections.Generic;

namespace h5chocolate_teambla
{
    class TotallyRealBankID
    {
        List<User> listOfUsers = new();

        public void AddUser(User user)
        {
            listOfUsers.Add(user);
        }

        internal User LogIn(long parsedInput)
        {

            string id;
            while (true)
            {
                if (IsValidID(Convert.ToInt64(parsedInput)) == false)
                    continue;
                else
                    break;
            }


            foreach (User user in listOfUsers)
            {
                if (user.Id == parsedInput)
                {
                    return user;
                }
            }
            return CreateNewUser(parsedInput, listOsUsers);
        }

        private User CreateNewUser(string id, TotallyRealBankID list)
        {
            User createdUser = new User(id);
            listOfUsers.AddUser(createdUser);
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
