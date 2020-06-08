using CloudCommerceTechTest.BL.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CloudCommerceTechTest.Classes
{
    class ConvertCSVToXML : AbstractConvert
    {
        /// <summary>
        /// 1.loads the classes
        /// 2.serializes the result (XML)
        /// 3.saves the file
        /// </summary>
        public override void Convert()
        {
            LoadIntoClass();
            
            string xml = null;
            using (StringWriter sw = new StringWriter())
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Person>));

                xs.Serialize(sw, dataInClasses);

                try
                {
                    xml = sw.ToString();

                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //we need to lowercase nodes
            XElement doc = XElement.Parse(xml);

            foreach (var element in doc.Elements())
            {
                element.Name = element.Name.LocalName.ToLower();

                foreach (var innerelement in doc.Descendants().Elements())
                {
                    innerelement.Name = innerelement.Name.LocalName.ToLower();
                }
            }

            SaveFile(doc.ToString());
        }
    }
}
