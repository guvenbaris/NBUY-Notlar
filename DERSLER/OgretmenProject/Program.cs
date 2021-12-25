using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OgretmenProject.DataAccess;
using OgretmenProject.Entities;
using OgretmenProject.JsonDateReader;

namespace OgretmenProject
{
    class Program
    {
        static void Main(string[] args)
        {
            OgretmenDal _ogretmenDal = new OgretmenDal();

            //Add all ogretmen from json file
            List<Ogretmen> ogretmens = new List<Ogretmen>();
            JsonDataHelper jsonDataHelper = new JsonDataHelper();
            ogretmens = jsonDataHelper.ReadJsonFile();
            foreach (var ogretmen in ogretmens)
            {
                if (_ogretmenDal.Add(ogretmen))
                {
                    continue;
                }
            }

            //Show all teachers with json formatting and write to file
            string resultEmpty = "";
            foreach (var ogretmen in _ogretmenDal.GetAll())
            {
                string json = JsonConvert.SerializeObject(ogretmen, Formatting.Indented);
                resultEmpty += json + ",";
                Console.WriteLine(json);
            }
            File.WriteAllText(@"D:\path.json", resultEmpty); // dosyaya yazdık hazırladığımız json dosyasını
            Console.WriteLine("Done!!!");

            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
