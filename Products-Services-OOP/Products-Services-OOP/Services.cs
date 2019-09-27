using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Services_OOP {
    public class Services : Sales {
        public int Rate;
        public int Hours;
        public override decimal  GetTotals() {
            return this.Rate * this.Hours;

        }
        public override string Print() {
            return base.Print() + $" |Rate: {this.Rate} |Hours: {this.Hours} |Totals: {this.GetTotals()}";
        }
        public Services(string Name, int Rate, int Hours) {
            this.name = Name;
            this.Rate = Rate;
            this.Hours = Hours;
        }
    }
}
