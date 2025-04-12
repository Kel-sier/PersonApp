using System;
using System.Linq;

namespace PersonApp
{
    public class Person
    {
        // Private fields for encapsulation
        private string _name;
        private int _age;
        private string _address;

        // Properties with getters and setters and validation
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty or null.");

                if (value.Length > 100)
                    throw new ArgumentException("Name cannot exceed 100 characters.");

                // Check if the name contains any digits
                foreach (char c in value)
                {
                    if (char.IsDigit(c))
                        throw new ArgumentException("Name cannot contain numbers.");
                }

                _name = value.Trim();
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                if (value > 100)
                    throw new ArgumentOutOfRangeException("Age cannot exceed 100 years.");
                _age = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Address cannot be empty or null.");
                if (value.Length > 200)
                    throw new ArgumentException("Address cannot exceed 200 characters.");
                _address = value.Trim();
            }
        }

        // Constructor with validation
        public Person(string name, int age, string address)
        {
            // Use properties to ensure validation occurs
            Name = name;
            Age = age;
            Address = address;
        }

        // Method to return details
        public virtual string GetDetails()
        {
            try
            {
                return $"Name: {_name}, Age: {_age}, Address: {_address}";
            }
            catch (Exception ex)
            {
                return $"Error retrieving details: {ex.Message}";
            }
        }

        // Method to validate all properties at once
        public virtual void Validate()
        {
            if (string.IsNullOrWhiteSpace(_name))
                throw new InvalidOperationException("Name cannot be empty or null.");

            if (_age < 0 || _age > 120)
                throw new InvalidOperationException("Age must be between 0 and 120.");

            if (string.IsNullOrWhiteSpace(_address))
                throw new InvalidOperationException("Address cannot be empty or null.");
        }
    }
}