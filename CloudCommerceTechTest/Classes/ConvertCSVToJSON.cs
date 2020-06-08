using CloudCommerceTechTest.HelperClasses;
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

            var settings = new JsonSerializerSettings();
            settings.ContractResolver = new LowercaseContractResolver();

            string endResult = JsonConvert.SerializeObject(dataInClasses, Formatting.Indented, settings).Replace("\"", string.Empty).Replace("'", string.Empty);

            SaveFile(endResult);
        }
    }
}
