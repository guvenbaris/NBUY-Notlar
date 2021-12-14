using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using CustomProject.Entities;
using CustomProject.ORM;

namespace CustomProject.View2
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoriesORM categoriesOrm = new CategoriesORM();
            //List<Categories> categories = categoriesOrm.Select();

            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category.CategoryName);
            //}
            //Categories categoryAdd = new Categories
            //{
            //    CategoryID = 13,
            //    CategoryName = "Bilgehan",
            //    Description = "Güncellendim",
            //    Picture = Encoding.ASCII.GetBytes("0x31003300")
            //};

            //CategoriesORM.Current.Insert(categoryAdd);

            List<Categories> categories = CategoriesORM.Current.Select();

            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryID}, {category.CategoryName}, {category.Description}, {category.Picture}");
                //string json =  JsonSerializer.Serialize(category);
                //Console.WriteLine(json);
            }

            Console.Write("Güncelleme yapmak istediğiniz ID yi giriniz : "); 
            int updatedID = Convert.ToInt32(Console.ReadLine());

           Categories categorieUpdate =  categoriesOrm.GetById(updatedID);
           Console.Write("Category name giriniz : ");
           categorieUpdate.CategoryName = Console.ReadLine();

           Console.Write("Description giriniz : ");
           categorieUpdate.Description = Console.ReadLine();

           Console.Write("Picture name giriniz : ");
           categorieUpdate.Picture = Encoding.ASCII.GetBytes(Console.ReadLine()!);

           categoriesOrm.Update(categorieUpdate);

           List<Categories> updatedCategories = categoriesOrm.Select();

           foreach (var category in updatedCategories)
           {
               Console.WriteLine($"{category.CategoryID}, {category.CategoryName}, {category.Description}, {category.Picture}");
               //string json =  JsonSerializer.Serialize(category);
               //Console.WriteLine(json);
           }
           
           //Categories updatedCategory = CategoriesORM.Current.GetById(updatedID);

           //Console.WriteLine($"{ updatedCategory.CategoryName}, { updatedCategory.Description}, { updatedCategory.Picture}");

        }
    }
}
