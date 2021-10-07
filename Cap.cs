namespace h5chocolate_teambla
{
    class Cap : Product
    {
        string colour;
        string size;

        public string Size { get => size; set => size = value; }

        public string Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;
            }
        }

        public Cap(string colour, string size, double price, string productType) : base(productType, price)
        {
            this.colour = colour;
            this.size = size;
        }
    }
}
