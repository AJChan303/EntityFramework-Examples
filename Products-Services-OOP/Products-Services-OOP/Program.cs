using System;

namespace Products_Services_OOP {
    class Program {
        static void Main(string[] args) {
            Products b_widget = new Products("Basic Widget", 10, 2500);
            Products a_widget = new Products("Advanced Widget", 25, 1500);
            Products s_widget = new Products("Supreme Widget", 50, 1000);
            
            Services b_services = new Services("Basic Service", 25, 1000);
            Services a_services = new Services("Priority Service", 50, 550);
            Services s_services = new Services("24x7 Service", 100, 750);



            Sales[] items = { b_widget, a_widget, s_widget, b_services, a_services, s_services,
                new Membership("Basic Memebership", 100, 1500),
                new Membership("Advanced Membership", 200, 700),
                new Membership("Premere Memebership", 400, 300)

            };
            foreach(Sales itm in items) {
                var n = itm.Print();
                Console.WriteLine(n);
                
            } 
            decimal p = 0;
            foreach (Sales pro in items) {           
                p += pro.GetTotals();                
            }
            Console.WriteLine($"Total Sales is {p}");
            
        }
    }
}
