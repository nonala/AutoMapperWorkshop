using AutoMapperWorkshop.Model;
using System.Collections.Generic;
using System.Linq;

namespace AutoMapperWorkshop
{
    public class Order
    {
        private readonly IList<OrderLineItem> _orderLineItems = new List<OrderLineItem>();

        public Customer Customer { get; set; }

        public OrderLineItem[] GetOrderLineItems()
        {
            return _orderLineItems.ToArray();
        }

        public void AddOrderLineItem(Product product, int quantity)
        {
            _orderLineItems.Add(new OrderLineItem(product, quantity));
        }

        public IList<OrderLineItem> OrderLineItems { get { return _orderLineItems; } }

        //public decimal GetTotal()
        //{
        //    return _orderLineItems.Sum(li => li.GetTotal());
        //}
    }
}
