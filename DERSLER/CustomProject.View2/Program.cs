using System;
using System.Collections.Generic;
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
            Categories categories = new Categories
            {
                CategoryName = "Deneme",
                Description = "Hayat sana güzel",
                Picture = "Hayat sevince güzel"

            };
            categoriesOrm.Insert(categories);



        }
    }
}
