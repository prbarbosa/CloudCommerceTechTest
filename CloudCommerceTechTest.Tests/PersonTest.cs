using CloudCommerceTechTest.BL.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CloudCommerceTechTest.Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void NameIsNotEmpty()
        {
            Person person = new Person();

            person.Name = "Bob";

            Assert.AreNotEqual(person.Name, "");
        }

        [TestMethod]
        public void StructuredAddressIsNotNull()
        {
            Person person = new Person();

            person.Address = new Address();

            Assert.IsNotNull(person.Address);
        }
    }
}
