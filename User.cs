namespace h5chocolate_teambla
{
    class User
    {
        private string id;
        private OrderHistory UserHistory = new OrderHistory();

        public User(string id)
        {
            this.id = id;
        }
    }
}
