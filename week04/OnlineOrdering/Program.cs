using System;
using System.Collections.Generic; 
namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Product Ordering System Demonstration ---");
            Console.WriteLine("---------------------------------------------\n");

            // --- Order 1: USA Customer ---
            Console.WriteLine("--- Order 1: USA Customer ---");

            // Create Address for USA customer
            Address usaAddress = new Address("123 Main St", "Anytown", "CA", "USA");

            // Create USA Customer
            Customer usaCustomer = new Customer("Silicon Slopes Encorporation", usaAddress);

            // Create Products for Order 1
            Product productA = new Product("Silicon Memory Chips", "COCOA001", 12.50, 2); 
            Product productB = new Product("PCBs", "PFK002", 50.00, 1);  

            // Create Order 1
            Order order1 = new Order(usaCustomer);
            order1.AddProduct(productA);
            order1.AddProduct(productB);

            // Display results for Order 1
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("\n" + order1.GetShippingLabel());
            Console.WriteLine($"\nOrder 1 Total Price: ${order1.GetTotalPrice():F2}"); 
            Console.WriteLine("---------------------------------------------\n");


            // --- Order 2: International Customer ---
            Console.WriteLine("--- Order 2: International Customer ---");

            // Create Address for International customer (e.g., Nigeria)
            Address internationalAddress = new Address("42 Zion Street", "PortHarcourt", "Rivers", "Nigeria");

            // Create International Customer
            Customer internationalCustomer = new Customer("Victor Mba Enterprises", internationalAddress);

            // Create Products for Order 2
            Product productC = new Product("Eco-Packaging Supplies (Bulk)", "ECOPKG003", 120, 3); 
            Product productD = new Product("Sustainability Audit Service", "AUDIT004", 500, 1);    
            Product productE = new Product("Agroforestry Starter Pack", "AGRO005", 85, 2);        

            // Create Order 2
            Order order2 = new Order(internationalCustomer);
            order2.AddProduct(productC);
            order2.AddProduct(productD);
            order2.AddProduct(productE);

            // Display results for Order 2
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("\n" + order2.GetShippingLabel());
            Console.WriteLine($"\nOrder 2 Total Price: ${order2.GetTotalPrice():F2}");
            Console.WriteLine("---------------------------------------------\n");

            Console.WriteLine("--- Demonstration Complete ---");
            // Wait for user input before closing the console window
            // User input can be any keystroke
            // This gives the user time to read the output before the console closes
            Console.ReadKey();
        }
    }
}