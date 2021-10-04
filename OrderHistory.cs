using System.Collections.Generic;
using System;

namespace h5chocolate_teambla
{
    public class OrderHistory
    {
        List<Order> orderList = new List<Order>();

        public List<Order> OrderList
        {
            get
            {
                return orderList;
            }
        }
        public List<Order> GetList()
        {
            return this.OrderList;
        }
        public void AddOrder(Order Order)
        {
            orderList.Add(Order);
        }
    }
}
