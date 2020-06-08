using System;
using System.Collections.Generic;
using CloudCommerceTechTest.BL;
using CloudCommerceTechTest.BL.Classes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CloudCommerceTechTest.Tests
{
    [TestClass]
    public class PersonRepositoryTests
    {
        [TestMethod]
        public void GetOneByNameValid()
        {
            PersonRepository personRepo = new PersonRepository();

            Person actual = personRepo.GetOneByName("Ben");

            Person expected = new Person()
            {
                Name = "Ben",
                
                Address = new Address
                {
                    Line1 = "pName's line1",//hardcoded address in the class
                    Line2 = "pName's line2" //hardcoded address in the class
                }
            };

            //Fluent Assertions nuget package 
            //i could have created a function or use Assert for each field, but this looks more clean
            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void GetAllReturnsThreeRecords()
        {
            PersonRepository personRepo = new PersonRepository();

            List<Person> personList = personRepo.GetAll();

            Assert.AreEqual(3, personList.Count);


        }
    }
}
