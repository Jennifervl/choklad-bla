using System.Collections.Generic;

namespace h5chocolate_teambla
{
    public class User
    {
        private string id;
        private OrderHistory userHistory = new OrderHistory();

        public OrderHistory UserHistory
        {
            get
            {
                return userHistory;
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
        }

        public List<Order> GetUserHistory()
        {
            return userHistory.OrderList;
        }
    }
}
