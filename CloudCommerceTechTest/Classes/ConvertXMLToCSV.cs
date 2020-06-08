using CloudCommerceTechTest.BL.Classes;
using System;
using System.Collections.Generic;

namespace CloudCommerceTechTest.Classes
{
    class ConvertXMLToCSV : AbstractConvert
    {
        public override void Convert()
        {
            LoadIntoClass();
            
            //TODO: read from class

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
            //TODO

            Console.WriteLine("Function 'LoadIntoClass()' to convert from XML To CSV is not yet implemented");
        }
    }
}
