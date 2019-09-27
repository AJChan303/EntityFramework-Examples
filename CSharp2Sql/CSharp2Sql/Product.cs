using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp2Sql {
    class Product {
        public int Id;
        public string Name;
        public decimal Price;

        public Product( int id, string name, decimal price) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
    }
}
