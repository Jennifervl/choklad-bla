using System.Collections.Generic;

namespace h5chocolate_teambla
{
    public class User
    {
        private string id;
        private List<Order> userHistory;
        public List<Order> UserHistory
        {
            get
            {
                return UserHistory;
            }
        }
        public string Id
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }
        public User(string id)
        {
            this.id = id;
            userHistory = new();
        }
        public List<Order> GetUserHistory()
        {
            return userHistory;
        }
        public void AddOrderToHistory(Order order)
        {
            userHistory.Add(order);
        }
    }
}
