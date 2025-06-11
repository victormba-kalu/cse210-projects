using System;

// Using namespaces helps organize the code and avoid naming conflicts
namespace ProductOrderingSystem
{
    public class Product
    {
        private string _name;
        private string _productId;
        private double _pricePerUnit;
        private int _quantity;

        public Product(string name, string productId, double pricePerUnit, int quantity)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name), "Product name cannot be null.");
            _productId = productId ?? throw new ArgumentNullException(nameof(productId), "The ID should not be null. Enter valid ID");

            if (pricePerUnit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(pricePerUnit), "Unit price shouldn't be negative. Enter valid input");
            }
            _pricePerUnit = pricePerUnit;

            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity should not be negative. Enter valid input");
            }
            _quantity = quantity;
        }

       
        public string GetName()
        {
            return _name;
        }

        public string GetProductId()
        {
            return _productId;
        }

        
        public double GetTotalCost()
        {
            return _pricePerUnit * _quantity;
        }
    }
}