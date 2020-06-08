using CloudCommerceTechTest.BL.Classes;
using System.Collections.Generic;

namespace CloudCommerceTechTest.BL
{
    /// <summary>
    /// This class is to handle all CRUD operations, but for the purposes of this technical test, 
    /// this is just to show how I would do it in OOP
    /// Also, unit tests required to test these methods
    /// </summary>
    public class PersonRepository
    {
        public Person GetOneByName(string pName)
        {
            // TODO database logic

            //hardcoded for this OOP example
            Person p = new Person(pName)
            {
                Name = pName,
                Address = new Address { Line1 = "pName's line1", Line2 = "pName's line2" }
            };

            return p;
        }

        public List<Person> GetAll()
        {
            List<Person> output = new List<Person>();

            // TODO database logic

            //hardcoded for this OOP example
            Person p1 = new Person()
            {
                Name = "Anna",
                Address = new Address { Line1 = "32 Spring St", Line2 = "NY 10012" }
            };
            output.Add(p1);
            Person p2 = new Person()
            {
                Name = "Trevor",
                Address = new Address { Line1 = "421 Amsterdam Ave", Line2 = "NY 10024" }
            };
            output.Add(p2);
            Person p3 = new Person()
            {
                Name = "Brandon",
                Address = new Address { Line1 = "27 Prince St", Line2 = "NY 10012" }
            };
            
            output.Add(p3);

            return output;
        }

        public bool Save()
        {
            // TODO database logic

            //hardcoded for this OOP example (assuming that the save is successful)
            return true;
        }
    }
}
