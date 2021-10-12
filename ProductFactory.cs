namespace h5chocolate_teambla
{
    public abstract class ProductFactory
    {
        public abstract Product MakeProduct(params string[] args);

        public Product CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}