﻿using System;

namespace ClassesApp
{
    public class Person 
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private Address _address;
        public Person() { }
        public Person(string fName, string lName, Address address = null)
        {
            _firstName = fName;
            _lastName = lName;
            _address = address;
        }

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public string Move()
        {
            return "Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }

        //private string GetAddress()
        //{
        //    return $"Address: {_address.HouseNo} {_address.Street}, {_address.Town}";
        //}

        public override string ToString()
        {
            var addressString = _address.GetAddress();
            return $"{base.ToString()} Name: {GetFullName()} Age: {Age}. {addressString}";
        }

        
    }
}
