using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2Sql {
    public class OrderLine {
        public int Id;
        public int OrderId;
        public int ProductId;
        public int Quantity;

        public OrderLine( int id, int orderid, int productid, int quantity) {
            this.Id = id;
            this.OrderId = orderid;
            this.ProductId = productid;
            this.Quantity = quantity;
        }
    }
}
