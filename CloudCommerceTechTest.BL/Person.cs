using System;
using System.Configuration;

namespace CloudCommerceTechTest.BL.Classes
{
    public class Person
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Person()
        {
            
        }

        /// <summary>
        /// Construtor required for PersonRepository GetOneByNameMethod
        /// </summary>
        /// <param name="pName"></param>
        public Person(string pName)
        {
            Name = pName;
        }

        Address _address;

        //no logic here, we use the auto-properties
        public String Name { set; get; }

        //there's logic here, we need to do this manually
        public Address Address
        {
            get 
            {
                if (_address == null)
                    _address = new Address();
                return new Address { Line1 = _address.Line1, Line2 = _address.Line2 };
            }
            set
            {
                _address = value;
            }
        }
    }
}
