using Newtonsoft.Json;

namespace CloudCommerceTechTest.Classes
{
    class ConvertCSVToJSON : AbstractConvert
    {
        /// <summary>
        /// 1.loads the classes
        /// 2.serializes the result (JSON)
        /// 3.saves the file
        /// </summary>
        public override void Convert()
        {
            LoadIntoClass();

            string endResult = JsonConvert.SerializeObject(dataInClasses, Formatting.Indented).Replace("\"", string.Empty).Replace("'", string.Empty);

            SaveFile(endResult);
        }
    }
}
