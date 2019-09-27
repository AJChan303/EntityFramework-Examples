using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CSharp2Sql {
    class Program {
        static void Main(string[] args) {
            //var Osql = "Select * from Orders";
            //var orders = SelectOrder(Osql);
            //foreach (var order in orders) {
            //    Console.WriteLine($"Customer ID is {order.CustomerId} { order.Date}");

            //}
            //var OLsql = "Select * from OrderLines";
            //var orderLine = SelectOrderLine(OLsql);
            //foreach (var oline in orderLine) {
            //    Console.WriteLine($"{oline.ProductId} matches with {oline.OrderId}");
            //}
            //var customers = SelectCustomer(sql);
            //foreach (var customer in customers) {
            //    Console.WriteLine(customer.Name);
            //}
            //var Psql = "select * from Products";
            //var products = SelectProduct(Psql);
            //foreach (var pro in products) {
            //    Console.WriteLine($"Product name: {pro.Name} Price: {pro.Price}");

            //}
            //    var cust = GetCustomerById(1028);
            //    if (cust == null) {
            //        Console.WriteLine("Customer not Found");
            //    }
            //    else {
            //        Console.WriteLine(cust.Name);
            //    }
            var od = GetOrderById(2001);
            if(od == null) {
                Console.WriteLine("Customer not Found");
            }
            else { Console.WriteLine($"order id {od.CustomerId} {od.Date}"); }
        }
        static List<Product> SelectProduct(string Psql) {
            var connStr = "server=localhost\\sqlexpress;database=CustomerOrderDb;trusted_connection=true;";
            var connection = new SqlConnection(connStr);
            connection.Open();
            if(connection.State != System.Data.ConnectionState.Open) {
                throw new Exception("Connection did not happen my dude");
            }
            var products = new List<Product>();
            var cmd = new SqlCommand(Psql, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                var id = (int)reader["Id"];
                var name = reader["Name"].ToString();
                var price = (decimal)reader["Price"];

                var prod = new Product(id, name, price);
                products.Add(prod);
            }
            reader.Close();
            connection.Close();
            return products;
        }
        static List<OrderLine> SelectOrderLine(string OLsql) {
            var connStr = "server=localhost\\sqlexpress;database=CustomerOrderDb;trusted_connection=true;";
            var connection = new SqlConnection(connStr);
            connection.Open();
            if(connection.State != System.Data.ConnectionState.Open) {
                throw new Exception("connection was interrupted");
            }
            var orderlinelist = new List<OrderLine>();
            var cmd = new SqlCommand(OLsql, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                var id = (int)reader["Id"];
                var orderid = (int)reader["OrderId"];
                var productid = (int)reader["ProductId"];
                var quantity = (int)reader["Quantity"];

                var orderLine = new OrderLine(id, orderid, productid, quantity);
                orderlinelist.Add(orderLine);
            }
            reader.Close();
            connection.Close();
            return orderlinelist;
        }
        static List<Order> SelectOrder(string Osql) {
            var connStr = "server=localhost\\sqlexpress;database=CustomerOrderDb;trusted_connection=true;";
            var connection = new SqlConnection(connStr);
            connection.Open();
            if (connection.State != System.Data.ConnectionState.Open) {
                throw new Exception("connection did not open!");
            }
            var orderList = new List<Order>();
            var cmd = new SqlCommand(Osql, connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read()) {
                var id = (int)reader["Id"];
                var date = (DateTime)reader["Date"];
                var note = reader.IsDBNull(reader.GetOrdinal("Note")) ? null : reader["Code"].ToString();
                var customerid = reader.IsDBNull(reader.GetOrdinal("CustomerID"))? 0 :(int)reader["CustomerId"]; // can be null

                var order = new Order(id, date, note, customerid);

                 orderList.Add(order);
            }
            reader.Close();
            connection.Close();
            return orderList;
        }
        static List<Customer> SelectCustomer(string sql) { 
            var connStr = @"server=localhost\sqlexpress;database=CustomerOrderDb;trusted_connection=true;";
           var connection = new SqlConnection(connStr);
            connection.Open();
            if(connection.State != System.Data.ConnectionState.Open) {
                throw new Exception("connection did not open!");
            }
            var customerList = new List<Customer>();
            
            var cmd = new SqlCommand(sql, connection);
            var reader =  cmd.ExecuteReader();
            while (reader.Read()) {
                var id = (int)reader["Id"];
                var name = reader["Name"].ToString();
                var city = reader["City"].ToString();
                var state = reader["State"].ToString();
                var active = (bool)reader["Active"];
                var code = reader.IsDBNull(reader.GetOrdinal("Code"))? null:reader["Code"].ToString();

                var customer = new Customer(id, name, city, state, active, code);
                customerList.Add(customer);

               
            }
            
            reader.Close();
            connection.Close();
            return customerList;
        }
        static Customer GetCustomerById(int pid) {
            var connStr = @"server=localhost\sqlexpress;database=CustomerOrderDb;trusted_connection=true;";
            var connection = new SqlConnection(connStr);
            connection.Open();
            if (connection.State != System.Data.ConnectionState.Open) {
                throw new Exception("connection did not open!");
            }
            var sql = "Select * from Customers Where Id = @myid;";
            var cmd = new SqlCommand(sql, connection);
            var theId = new SqlParameter("@myid", pid);
            cmd.Parameters.Add(theId);
            var reader = cmd.ExecuteReader();
            Customer cust = null;
            if (reader.Read()) {
                var id = (int)reader["Id"];
                var name = reader["Name"].ToString();
                var city = reader["City"].ToString();
                var state = reader["State"].ToString();
                var active = (bool)reader["Active"];
                var code = reader.IsDBNull(reader.GetOrdinal("Code")) ? null : reader["Code"].ToString();
                 cust = new Customer(id, name, city, state, active, code);
                
            }
            reader.Close();
            connection.Close();
            return cust;
        } 
        static Order GetOrderById(int oid) {
            var connStr = "server=localhost\\sqlexpress;database=CustomerOrderDb;trusted_connection=true;";
            var conn = new SqlConnection(connStr);
            conn.Open();
            if(conn.State != System.Data.ConnectionState.Open) {
                throw new Exception("Connection failed");
            }
            Order ord = null;
            var osql = "select * from Orders where Id = @oid;";
            var cmd = new SqlCommand(osql, conn);
            var did = new SqlParameter("@oid", oid);
            cmd.Parameters.Add(did);
            var reader = cmd.ExecuteReader();
            if (reader.Read()) {
                var id = (int)reader["Id"];
                var date = (DateTime)reader["Date"];
                var note = reader.IsDBNull(reader.GetOrdinal("Note")) ? null : reader["Code"].ToString();
                var customerid = reader.IsDBNull(reader.GetOrdinal("CustomerID")) ? 0 : (int)reader["CustomerId"];
                 ord = new Order(id, date, note, customerid);
                
            }
            reader.Close();
            conn.Close();
            return ord;
        }

    }
}
