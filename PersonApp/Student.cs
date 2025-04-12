using System;

namespace PersonApp
{
    public class Student : Person
    {
        // Additional field for Student
        private string _studentID;

        // Property for StudentID with validation
        public string StudentID
        {
            get { return _studentID; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Student ID cannot be empty or null.");
                if (value.Length > 20)
                    throw new ArgumentException("Student ID cannot exceed 20 characters.");

                // Optional: Validate student ID format using regex
                // if (!Regex.IsMatch(value, @"^[A-Za-z0-9\-]+$"))
                //     throw new ArgumentException("Student ID can only contain letters, numbers, and hyphens.");

                _studentID = value.Trim();
            }
        }

        // Constructor - calls the base (Person) constructor with validation
        public Student(string name, int age, string address, string studentID)
            : base(name, age, address)
        {
            StudentID = studentID; // Use property for validation
        }

        // Override the GetDetails method from the Person class
        public override string GetDetails()
        {
            try
            {
                return $"{base.GetDetails()}, Student ID: {_studentID}";
            }
            catch (Exception ex)
            {
                return $"Error retrieving student details: {ex.Message}";
            }
        }

        // Additional method for student-specific details
        public string GetStudentDetails()
        {
            try
            {
                return $"Student ID: {_studentID}, Name: {Name}, Age: {Age}, Address: {Address}";
            }
            catch (Exception ex)
            {
                return $"Error retrieving student details: {ex.Message}";
            }
        }

        // Override validate method to include student-specific validation
        public override void Validate()
        {
            // First validate the base class properties
            base.Validate();

            // Then validate student-specific properties
            if (string.IsNullOrWhiteSpace(_studentID))
                throw new InvalidOperationException("Student ID cannot be empty or null.");
        }
    }
}