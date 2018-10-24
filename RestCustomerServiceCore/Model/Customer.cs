using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestCustomerServiceCore.Model
{
    public class Customer
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _yearOfRegistration;

        public int Id { get => _id; set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int YearOfRegistration { get => _yearOfRegistration; set => _yearOfRegistration = value; }

        public Customer(int id, string firstName, string lastName, int yearOfRegistration)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            YearOfRegistration = yearOfRegistration;
        }

        public Customer()
        {

        }
    }
}
