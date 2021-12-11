using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OgretmenProject.Entities;

namespace OgretmenProject.JsonDateReader
{
    public class JsonDataHelper
    {
        public List<Ogretmen> ReadJsonFile()
        {
            using (StreamReader reader = new StreamReader($"C:/Users/Barış/Desktop/OgretmenDb/Ogretmen.json"))
            {
                string json = reader.ReadToEnd();
                List<Ogretmen> entities = JsonConvert.DeserializeObject<List<Ogretmen>>(json);
                return entities;
            }
        }
    }
}
