using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OgretmenProject.Entities;

namespace OgretmenProject.DataAccess
{
    public class OgretmenDal
    {
        SqlConnection _connection = new SqlConnection(@"Server = (localdb)\MSSQLLocalDB; Database=Northwind; Integrated Security = true");
        public void DbConnection()
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
        public void DbDisconnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public bool Add(Ogretmen ogretmen)
        {
            DbConnection();
            SqlCommand command = new SqlCommand("INSERT INTO Ogretmens VALUES(@OgretmenAd,@OgretmenSoyad,@Telephone,@Brans)",_connection);
            command.Parameters.AddWithValue("@OgretmenAd", ogretmen.OgretmenAd);
            command.Parameters.AddWithValue("@OgretmenSoyad", ogretmen.OgretmenSoyad);
            command.Parameters.AddWithValue("@Telephone", ogretmen.Telephone);
            command.Parameters.AddWithValue("@Brans", ogretmen.Brans);
            if (command.ExecuteNonQuery() > 0)
            {
                DbDisconnection();
                Console.WriteLine("Ogretmen added!");
                return true;

            }
            DbDisconnection();
            Console.WriteLine("Mehaba = {0}",ogretmen.OgretmenAd);
;
            return false;

            
        }

        public bool Update(Ogretmen ogretmen)
        {
            SqlCommand command =
                new SqlCommand(
                    "UPDATE Ogretmens SET OgretmenAd = @OgretmenAd,OgretmenSoyad = @OgretmenSoyad , Telephone  = @Telephone , Brans = @Brans Where OgretmenID = @id",
                    _connection);
            command.Parameters.AddWithValue("@OgretmenAd", ogretmen.OgretmenAd);
            command.Parameters.AddWithValue("@OgretmenSoyad", ogretmen.OgretmenSoyad);
            command.Parameters.AddWithValue("@Telephone", ogretmen.Telephone);
            command.Parameters.AddWithValue("@Brans", ogretmen.Brans);
            command.Parameters.AddWithValue("@id", ogretmen.OgretmenID);
            DbConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                DbDisconnection();
                Console.WriteLine("Ogretmen updated!");
                return true;

            }
            DbDisconnection();
            return false;
        }

        public bool Delete(Ogretmen ogretmen)
        {
            SqlCommand command = new SqlCommand("Delete Ogretmens Where OgretmenID = @id", _connection);
            command.Parameters.AddWithValue("@id", ogretmen.OgretmenID);
            DbConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                DbDisconnection();
                Console.WriteLine("Ogretmen deleted!");
                return true;
            }
            DbDisconnection();
            return false;
        }

        public Ogretmen GetById(int id)
        {
            DbConnection();
            SqlCommand command = new SqlCommand("Select * From Ogretmens Where OgretmenID = @id", _connection);
            command.Parameters.AddWithValue("@id", id);


            SqlDataReader reader = command.ExecuteReader();
            Ogretmen _ogretmen = new Ogretmen();
            while (reader.Read())
            {
                Ogretmen ogretmen = new Ogretmen
                {
                    OgretmenID = Convert.ToInt32(reader["OgretmenID"]),
                    OgretmenAd = reader["OgretmenAd"].ToString(),
                    OgretmenSoyad = reader["OgretmenSoyad"].ToString(),
                    Brans = reader["Brans"].ToString(),
                    Telephone = reader["Telephone"].ToString()
                };
                _ogretmen = ogretmen;
            }
            reader.Close();
            DbDisconnection();
            return _ogretmen;
        }

        public List<Ogretmen> GetAll()
        {
            DbConnection();
            SqlCommand command = new SqlCommand("Select * From Ogretmens d", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Ogretmen> ogretmens = new List<Ogretmen>();

            while (reader.Read())
            {
                Ogretmen ogretmen = new Ogretmen
                {
                    OgretmenID = Convert.ToInt32(reader["OgretmenID"]),
                    OgretmenAd = reader["OgretmenAd"].ToString(),
                    OgretmenSoyad = reader["OgretmenSoyad"].ToString(),
                    Brans = reader["Brans"].ToString(),
                    Telephone = reader["Telephone"].ToString()
                };
                ogretmens.Add(ogretmen);
            }
            reader.Close();
            DbDisconnection();
            return ogretmens;
        }
    }
}
