using System;

// Using namespaces for organization and to avoid naming conflicts
namespace ProductOrderingSystem
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            // Null checks for essential address components
            _streetAddress = streetAddress ?? throw new ArgumentNullException(nameof(streetAddress), "Street address cannot be null.");
            _city = city ?? throw new ArgumentNullException(nameof(city), "City cannot be null.");
            _stateProvince = stateProvince ?? throw new ArgumentNullException(nameof(stateProvince), "State/Province cannot be null.");
            _country = country ?? throw new ArgumentNullException(nameof(country), "Country cannot be null.");
        }

        // Method to check if the address is in the USA
        public bool IsInUSA()
        {
        
            return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        public string GetFullAddressString()
        {
           
            return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        }
    }
}