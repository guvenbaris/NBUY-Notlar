using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using CustomProject.Common;
using Microsoft.VisualBasic.CompilerServices;
using Type = System.Type;


namespace CustomProject.ORM
{
    public class OrmBase<ET> : IOrm<ET> where ET : class, new()
    {
        public List<ET> Select()
        {
            Type tip = typeof(ET);
            string query = $"Select * from ";
            var attributes = tip.GetCustomAttributes(typeof(Table), false);
            //Any() => Herhangi bir data var is True döner 
            //null değil ise ve kayıt var ise

            if (attributes != null && attributes.Any())
            {
                Table tbl = (Table)attributes[0];
                query += tbl.TableName + ";"; // Table attribute tablosundaki ilk eleman TableName 
            }

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand();

            Tools.DbConnection();

            dataAdapter.SelectCommand.CommandText = query;
            dataAdapter.SelectCommand.Connection = Tools._connection; // connection static Tools  sınıfından geldi

            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable); // gelen veriyi dt ye doldurduk

            Tools.DbDisconnection();

            return dataTable.ToList<ET>(); // burada tools sınıfında tanımlayıp DataTable'a bind ettiğimiz 
            // yani bağladığımız metodu. DataTable nesnesi aracılığıyla kullandık.
        }
        public bool Insert(ET entity)
        {
            Type tip = typeof(ET);
            var attributes = tip.GetCustomAttributes(typeof(Table), false);
            string tableName = "";
            if (attributes != null && attributes.Any())
            {
                Table tbl = (Table)attributes[0];
                tableName += tbl.TableName;
            }

            string values = "";
            string parameters = "";
            PropertyInfo[] properties = tip.GetProperties();

            for (int i = 1; i < properties.Length; i++)
            {
                values += properties[i].Name + ",";
                parameters += properties[i].GetValue(entity) + ",";
            }
            values = values.Remove(values.Length - 1);

            string[] resultArray = parameters.Split(',');

            string parametersResult = "";
            for (int i = 0; i < resultArray.Length - 1; i++)
            {
                parametersResult += "'" + resultArray[i] + "'" + ",";
                Console.WriteLine(resultArray[i]);
            }
            parametersResult = parametersResult.Remove(parametersResult.Length - 1);

            Console.WriteLine(parameters);
            string query = $"Insert into {tableName} ({values}) VALUES ({parametersResult})";

            Tools.DbConnection();

            SqlCommand command = new SqlCommand(query, Tools._connection);
            if (command.ExecuteNonQuery() > 0)
            {
                Tools.DbDisconnection();
                Console.WriteLine("Eklendi");
                return true;

            }
            Tools.DbDisconnection();
            return false;
        }
        public bool Update(ET entity)
        {
            Type tip = typeof(ET);

            var attributes = tip.GetCustomAttributes(typeof(Table), false);

            string tableName = "";
            if (attributes != null && attributes.Any())
            {
                Table table = new Table();
                tableName += table.TableName;
            }

            string values = "";
            string parameters = "";

            PropertyInfo[] properties = tip.GetProperties();



        }

        public bool Delete(ET entity)
        {
            throw new NotImplementedException();
        }
    }
}
