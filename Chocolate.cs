using System;

namespace h5chocolate_teambla
{
    class Chocolate : Product
    {
        private int cocoaAmount;
        private string filling;
        public int CocoaAmount
        {
            get
            {
                return cocoaAmount;
            }
            set
            {
                cocoaAmount = value;
            }
        }
        public string Filling
        {
            get
            {
                return filling;
            }
            set
            {
                filling = value;
            }
        }
        public Chocolate(int Cocoa, string Filling, double Price, string ProductType) : base(ProductType, Price)
        {
            this.cocoaAmount = Cocoa;
            this.filling = Filling;
        }
    }
}
