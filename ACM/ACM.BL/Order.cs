using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
            
        }

        public Order(int orderId)
        {
            OrderID = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; set; }

        /// <summary>
        /// Retrieve one order.
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public Order Retrieve(int orderID)
        {
            // Code that retrieves the defined order.

            return new Order();
        }

        /// <summary>
        /// Saves the current order.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            // Code that saves the defined order

            return true;
        }


        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
                isValid = false;

            return isValid;
        }
    }
}
