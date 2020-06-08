using CloudCommerceTechTest.BL.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace CloudCommerceTechTest.Classes
{
    abstract class AbstractConvert
    {
        //shared variables
        public string FILENAME = Environment.GetCommandLineArgs()[2];
        public List<Person> dataInClasses = new List<Person>();
        //

        /// <summary>
        /// The behaviour of this function changes, depending on the derived classes that makes the call
        /// There is no default implementation
        /// </summary>
        public abstract void Convert();

        /// <summary>
        /// we need this function to get the contents of the CSV into a class
        /// this function needs to be 'virtual', because in the future we may need to load the class list
        /// from a different source other than CSV
        /// </summary>
        virtual public void LoadIntoClass()
        {
            dataInClasses = new List<Person>();
            List<string[]> csv = new List<string[]>();
            string[] lines = File.ReadAllLines(FILENAME);

            foreach (string line in lines)
                csv.Add(line.Split(','));

            Person p;
            Address a;

            for (int i = 1; i < lines.Length; i++)//i = 1, we don't need the headers
            {
                p = new Person();
                a = new Address();
                p.Name = csv[i][0];
                a.Line1 = csv[i][1];
                a.Line2 = csv[i][2];
                p.Address = a;
                dataInClasses.Add(p);
            }
        }

        /// <summary>
        /// take the string and save it to a file
        /// this function is common to all derived classes and therefore it's implemented here once
        /// </summary>
        /// <param name="output">contents to be saved in a text file</param>
        public void SaveFile(string pOutput)
        {
            Console.WriteLine(pOutput);
            Console.WriteLine("");

            try
            {
                File.WriteAllText("output.txt", pOutput);
                Console.WriteLine("File 'output.txt' has been saved.");
            }
            catch(IOException ex)//if for some reason the file can't be written, I want to know why
            {
                Console.WriteLine("Unable to save file.");
                Console.WriteLine(string.Format("Message: {0}", ex.Message));
                Console.WriteLine(string.Format("Stacktrace: {0}", ex.StackTrace));
            }
        }
    }
}
