using System;

namespace CMS.BusinessLayer
{
    public class Order
    {
        public Order() : this(0)
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            ShippingAddress = new Address();
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public Address ShippingAddress { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
