using System;
using System.Collections.Generic; 
using System.Linq;

// I'm using LINQ - Langague Integrated Query so I can make use of it's powerful methods
// Namespaces help organize my code and avoid naming conflicts, not necessary here though. Just using it for good practice
namespace ProductOrderingSystem
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        private const double USA_SHIPPING_COST = 5.00;
        private const double OVERSEAS_SHIPPING_COST = 35.00;

        public Order(Customer customer)
        {
            // Using null checks to ensure the order has a valid customer
            _customer = customer ?? throw new ArgumentNullException(nameof(customer), "Order must have a customer.");
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Cannot add a null product to the order.");
            }
            _products.Add(product);
        }

        public double GetTotalPrice()
        {
            double productsTotal = 0;
            foreach (Product product in _products)
            {
                productsTotal += product.GetTotalCost();
            }

            // Uses the ternary operator to determine the shipping cost based on the customer's location
            // If the customer lives in the USA, the shipping cost is USA_SHIPPING_COST, otherwise it's OVERSEAS_SHIPPING_COST
            double shippingCost = _customer.LivesInUSA() ? USA_SHIPPING_COST : OVERSEAS_SHIPPING_COST;
            return productsTotal + shippingCost;
        }

        public string GetPackingLabel()
        {
            string label = "--- Packing Label ---\n";
            foreach (Product product in _products)
            {
                label += $"Product: {product.GetName()}, ID: {product.GetProductId()}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            string label = "--- Shipping Label ---\n";
            label += $"Customer: {_customer.GetName()}\n";
            label += $"Address:\n{_customer.GetAddress().GetFullAddressString()}";
            return label;
        }
    }
}