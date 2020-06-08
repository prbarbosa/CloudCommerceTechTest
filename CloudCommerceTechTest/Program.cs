using CloudCommerceTechTest.Classes;
using System;
using System.IO;

namespace CloudCommerceTechTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //I could have used Ndesk.Options, Command Line Parser Library or Bizark but decided not to. 
            if (args.Length != 2)
            {
                Console.WriteLine("usage: CloudCommerceTechTest.exe <parameter> <filepath>");
                DisplayOptions();
            }
            else
            {
                if (!File.Exists(args[1]))
                {
                    Console.WriteLine(string.Format("Unable to find file '{0}'", args[1]));
                    Console.WriteLine("Program ends here");
                    return;
                }
                switch (args[0])
                {
                    case "csvtoxml":
                        ConvertCSVToXML xml = new ConvertCSVToXML();
                        xml.Convert();
                        break;
                    case "csvtojson":
                        ConvertCSVToJSON json = new ConvertCSVToJSON();
                        json.Convert();
                        break;
                    case "jsontocsv":
                        ConvertJSONToCSV jcsv = new ConvertJSONToCSV();
                        jcsv.Convert();
                        break;
                    case "xmltocsv":
                        ConvertXMLToCSV xcsv = new ConvertXMLToCSV();
                        xcsv.Convert();
                        break;
                    case "dbtocsv":
                        ConvertDBToCSV dbcsv = new ConvertDBToCSV();
                        dbcsv.Convert();
                        break;
                    default:
                        Console.WriteLine("Invalid argument.");
                        Console.WriteLine("usage: CloudCommerceTechTest.exe <parameter> <filepath>\n");
                        DisplayOptions();
                        break;
                }
            }
        }

        static void DisplayOptions()
        {
            Console.WriteLine("Available arguments: ");
            Console.WriteLine("* 'csvtoxml' - to convert from CSV to XML");
            Console.WriteLine("* 'csvtojson' - to convert from CSV to JSON");
            Console.WriteLine("* 'jsontocsv' - to simulate conversion from JSON to CSV");
            Console.WriteLine("* 'xmltocsv' - to simulate conversion from XML to CSV");
            Console.WriteLine("* 'dbtocsv' - to simulate conversion from DATABASE to CSV");
        }
    }
}
