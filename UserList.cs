using System.Collections.Generic;

namespace h5chocolate_teambla
{
    public class UserList
    {
        private List<User> userList = new List<User>();

        public void AddUser(User user)
        {
            userList.Add(user);
        }
        public IList<User> GetList()
        {
            IList<User> privateList = userList.AsReadOnly();
            return privateList;
        }
    }
}