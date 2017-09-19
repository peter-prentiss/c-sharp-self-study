﻿using System;
namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set;  }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public  string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            get { return _twitterAddress; }
            set 
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else {
                    throw new Exception("The Twitter address must begin with '@");
                }
            }
        }
    }
}
