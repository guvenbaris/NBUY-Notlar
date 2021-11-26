using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Threading.Channels;
using System.Text.Json;
using JsonApp.ComputerExample;
using JsonApp.ProductExample;
using JsonApp.UserDetayliExample;
using JsonApp.UserExample;
using Newtonsoft.Json;


namespace JsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////
            //Nesne to json (Product)//
            //////////////////////////
            Product product = new Product
            {
                Id = 1,
                ProductAddTime = new DateTime(2021, 11, 25),
                ProductAmount = 50,
                ProductName = "Mouse",
                ProductPrice = 1200.0d,
                ProductKind = new string[] { "kablolu", "kablosuz" }
            };
            ////newtonsoft
            string json = JsonConvert.SerializeObject(product, Formatting.Indented);
            //Console.WriteLine(json);


            ////////////////////////////
            //Json to Nesne (Product)//
            //////////////////////////

            string productDeserialize = @"{'Id':1,
                            'ProductAddTime':'1995-4-17T00:00:00',
                            'ProductAmount':'50',
                            'ProductName':'Klavye',
                            'ProductPrice':1200,
                            'ProductSizes':['Small','Medium']}";

            //newtonsoft deserialize
            Product product1 = JsonConvert.DeserializeObject<Product>(json);

            //string kinds = "";
            //foreach (var product2 in product1.ProductKind)
            //{
            //    kinds += product2 + ", ";
            //}
            //Console.WriteLine($"Ürün eklenme zamanı : {product1.ProductAddTime}, Ürün fiyatı : {product1.ProductPrice}, Ürün Çeşidi :{product1.ProductKind[0]} ");

            ////////////////////////////
            //Nesne to json (User)/////
            //////////////////////////

            User user = new User
            {
                Email = "guvenbariscakan@gmail.com",
                Id = 1,
                Name = "Güven Barış",
                Phone = "05414202712",
                WebSite = "www.guvenbariscakan.com"
            };

            //string userJson = JsonConvert.SerializeObject(user, Formatting.Indented);
            //Console.WriteLine(userJson);

            ////////////////////////////
            //Json to Nesne (User)/////
            //////////////////////////

            //string userDeserialize = @"{'id': 1,
            //    'name': 'Müslüm',
            //    'username': 'Gürses',
            //    'email': 'müslüm_baba@baba.com',
            //    'phone': '155',
            //    'website': 'www.muslum.baba.com'}";

            ////newtonsoft deserialize
            //User user1 = JsonConvert.DeserializeObject<User>(userDeserialize);
            //Console.WriteLine(user1.Email);


            ////////////////////////////
            //Nesne to json (Computer)/
            //////////////////////////

            Computer computer = new Computer
            {
                EkranKarti = "NVDIA GTX 960M",
                HardDisk = new List<string>{"HDD","SSD"},
                Marka = "Monster",
                Ram = "16GB RAM",
            };
            //string computerJson = JsonConvert.SerializeObject(computer, Formatting.Indented);
            //Console.WriteLine(computerJson);

            ////////////////////////////
            //Json to Nesne (Computer)/
            //////////////////////////

            string computerDeserialize = @"{'ekranKarti': 'NVDIA GTX 960M',
                                            'hardDisk':['SSD','HDD'],
                                            'marka':'Monster',
                                            'ram':'16GB RAM'}";

            Computer computer1 = JsonConvert.DeserializeObject<Computer>(computerDeserialize);

            //string hardDisks = "";
            //foreach (var item in computer1.HardDisk)
            //{
            //    hardDisks += item + ", ";
            //}
            //Console.WriteLine($"Ekran Kartı : {computer1.EkranKarti}, HardDisk : {hardDisks}, Marka : {computer1.Marka}, Ram : {computer1.Ram}");



            Geo geo = new Geo
            {
                lng = "-37.3159",
                lat = "81.1496"
            };
            Company company = new Company
            {
                Business = "Yazılım",
                CatchPhrase = "Ayırın dolmadan akşam olmadan",
                Name = "Network Akademi"
            };
            Address address = new Address
            {
                Geo = geo,
                City = "Sakarya",
                Street = "Bağlar Caddesi",
                Suite = "Gola Apartmanı",
                ZipCode = "54100"
            };
            UserDetail userDetail = new UserDetail
            {
                Address = address,
                Company = company,
                Email = "gvnbrs54@gmail.com",
                Id = 1,
                Name = "Güven",
                Phone = "05414202712",
                WebSite = "www.guvenbaricakan.com"
            };

            string userDetailSerialize =  JsonConvert.SerializeObject(userDetail, Formatting.Indented);
            //Console.WriteLine(userDetailSerialize);

            UserDetail userDetailDeserialize = JsonConvert.DeserializeObject<UserDetail>(userDetailSerialize);

            //Console.WriteLine($"User Id : {userDetailDeserialize.Id}, User Name : {userDetailDeserialize.Name}, User Email : {userDetailDeserialize.Email}, " +
            //                  $"User Address : /nStreet : {userDetailDeserialize.Address.Street} Suite : {userDetailDeserialize.Address.Suite}, City : {userDetailDeserialize.Address.ZipCode}, " +
            //                  $"Geo : /n lat : {userDetailDeserialize.Address.Geo.lat}, lng : {userDetailDeserialize.Address.Geo.lng}, Phone : {userDetailDeserialize.Phone}, Website : {userDetailDeserialize.WebSite}, " +
            //                  $"Company : /nname : {userDetailDeserialize.Company.Name}, CatchPhrase : {userDetailDeserialize.Company.CatchPhrase}, Business : {userDetailDeserialize.Company.Business} ");

            
        }
    }
}

