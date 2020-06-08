using CloudCommerceTechTest.BL;
using CloudCommerceTechTest.BL.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CloudCommerceTechTest.Classes
{
    class ConvertDBToCSV : AbstractConvert
    {
        public override void Convert()
        { 
            LoadIntoClass();

            //TODO: Logic to convert dataInClasses into CSV

            SaveFile("Saving file");
        }

        /// <summary>
        /// FUTURE REQUIREMENT
        /// This class will need to override its version (virtual) in the base class 
        /// since we're not loading the class from a CSV now
        /// </summary>
        public override void LoadIntoClass()
        {
            dataInClasses = new List<Person>();
            
            //I implemented this class just to show how easy it is to add this type of conversion
            PersonRepository personRepo = new PersonRepository();
            dataInClasses = personRepo.GetAll();

            Console.WriteLine("Function 'LoadIntoClass()' to convert from DB To CSV is not yet implemented");
        }
    }
}
