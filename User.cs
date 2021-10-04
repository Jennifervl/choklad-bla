namespace h5chocolate_teambla
{
    public class User
    {
        private string id;
        private OrderHistory userHistory = new OrderHistory();

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
    }
}
