using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Services_OOP {
    public class Sales {
        public string name;

        public virtual string Print() {
            return $"Item: {this.name}";
        }

        public virtual decimal GetTotals() {// might be better to throw an NotImplemented Exception
            return 0;
        }
    }
}
