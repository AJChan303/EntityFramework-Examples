using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Services_OOP {
    public class Membership : Sales {
        public int Fee;
        public int Units;

        public override string Print() {
            return base.Print() + $"|Fee: {Fee}|Units: {Units} |Totals: {this.GetTotals()}";
        }

        public override decimal GetTotals() {
            return this.Fee * this.Units;
        }
            
        public Membership(string name, int fee, int units) {
            this.name = name;
            this.Fee = fee;
            this.Units = units;
        }
    }
}
