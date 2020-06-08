using CloudCommerceTechTest.BL.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace CloudCommerceTechTest.Tests
{
    [TestClass]
    public class AddressTest
    {
        /// <summary>
        /// Test if at least one line of the address is populated
        /// </summary>
        [TestMethod]
        public void AddressIsNotEmpty()
        {
            Address populatedAddress = new Address()
            {
                Line1 = "28700 Arroyo Dr",
                Line2 = "CA 92617"
            };

            Address emptyAddress = new Address()
            {
                Line1 = "",
                Line2 = ""
            };

            //Fluent Assertions nuget package 
            //i could have created a function or use Assert for each field, but this looks more clean
            populatedAddress.Should().NotBeEquivalentTo(emptyAddress);
        }
    }
}
