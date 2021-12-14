using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;


namespace CustomProject.Common
{
    public static class Tools
    {
       public static SqlConnection _connection =
           new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; Database=Northwind; Integrated Security = true");

        public static void DbConnection()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public static void DbDisconnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
        //method binding : this DataTable ile DataTable sınıfına method ekledik.
        public static List<TEt> ToList<TEt>(this DataTable dt) where TEt : class, new()
        {
            Type type = typeof(TEt); // gelen tip ne ? Categories mi Product mı Başka birşey mi ? 
            List<TEt> list = new List<TEt>(); // Gelen tip ten nesnelerin olduğu bir liste
            PropertyInfo[] properties = type.GetProperties(); // sınıfa ait özellikleri bir diziye attık

            foreach (DataRow row in dt.Rows)
            {
                TEt tip = new TEt();
                foreach (PropertyInfo propertyInfo in properties)
                {
                    object value = row[propertyInfo.Name]; // Sınıf özelliğinin adı ile veri tabanında ki tablodan veri çektik 
                    // Yani datarow[CategoryName] dediğmizde orada ki veriye ulaşmış olacağız...
                    if (value != null)
                    {
                        propertyInfo.SetValue(tip,value);
                    }
                }
                list.Add(tip);
            }
            return list;
        }

        public static TEt ToEt<TEt>(this DataTable dt) where TEt : class, new()
        {
            Type type = typeof(TEt);
            TEt entity = new TEt();
            PropertyInfo[] properties = type.GetProperties(); 

            foreach (DataRow row in dt.Rows)
            {
                foreach (PropertyInfo propertyInfo in properties)
                {
                    object value = row[propertyInfo.Name];
                    if (value != null)
                    {
                        propertyInfo.SetValue(entity, value);
                    }
                }
            }
            return entity;
        }
    }
}
