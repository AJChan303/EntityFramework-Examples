using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Services_OOP {
   public class Products : Sales {
        public decimal Price;
        public int Units;
        public override decimal GetTotals() {
            return this.Price * this.Units;
        }
        
        public override string Print() {
            return base.Print() + $" |Price: {this.Price} |Units Sold: {this.Units} |Total: {this.GetTotals()}";
        }
        public Products (string Name, decimal Price, int Units) {
            this.name = Name;
            this.Price = Price;
            this.Units = Units;
                
        }
    }
}
