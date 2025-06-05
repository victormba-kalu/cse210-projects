using System;
// namespaces make my work look more organized
namespace ProductOrderingSystem
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            // I use the "throw new ArgumentNullException to catch errors and prevent the code from breaking"
            _name = name ?? throw new ArgumentNullException(nameof(name), "Customer name should not be null. Enter valid name");
            _address = address ?? throw new ArgumentNullException(nameof(address), "Customer address shouldn't be null. Enter vaild name");
        }

      
        public string GetName()
        {
            return _name;
        }

       
        public Address GetAddress()
        {
            return _address;
        }

        
        public bool LivesInUSA()
        {
            return _address.IsInUSA(); 
        }
    }
}