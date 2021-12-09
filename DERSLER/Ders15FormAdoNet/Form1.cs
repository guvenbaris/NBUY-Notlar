using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders15FormAdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection _connection = new SqlConnection(@$"Server = (localdb)\MSSQLLocalDB; Database=DB_Test; Integrated Security = true");

        private void DBConnection()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                    MessageBox.Show("Bağlantı sağlandı");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void DBDisconnection()
        {
            _connection.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciListUpdate();


        }

        private void OgrenciListUpdate()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select ID,Concat(ad,' ',soyad) as [Ad Soyad],telefon as Telefon, tc as [TC K.Nu.] From Ogrenci", _connection);
            DataTable dtOgrenci = new DataTable();
            dataAdapter.Fill(dtOgrenci);
            dgwOgrenciler.DataSource = dtOgrenci;


            //silme 
            cmbSil.DataSource = dtOgrenci;
            cmbSil.DisplayMember = "Ad Soyad";
            cmbSil.ValueMember = "ID";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            SqlCommand command =
                new SqlCommand(
                    $" INSERT INTO [dbo].[Ogrenci] (ad,soyad,telefon,tc) VALUES(@ad,@soyad,@telefon,@tc)", _connection);


            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            command.Parameters.AddWithValue("@telefon", txtTelephone.Text);
            command.Parameters.AddWithValue("@tc", txtTc.Text);

            DBConnection();


            int affectedRowsCount = command.ExecuteNonQuery();

            if (affectedRowsCount > 0)
            {
                txtAd.Clear();
                txtTc.Clear();
                txtTelephone.Clear();
                txtSoyad.Clear();
                MessageBox.Show("Student added Succesfully !!");

            }
            else
            {
                MessageBox.Show("No students Added !!");
            }

            DBDisconnection();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekId = int.Parse(cmbSil.SelectedValue.ToString());
            SqlCommand command = new SqlCommand("Delete From Ogrenci Where ID = @id", _connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", silinecekId);

            string adSoyad = GetOgrenciAd(silinecekId);
            DialogResult result = MessageBox.Show($" {adSoyad} silmek istediğinizden emin misiniz ? ", "Silme Onayı",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBConnection();
                int etkilenenSatirSayisi = command.ExecuteNonQuery();
                if (etkilenenSatirSayisi > 0)
                {
                    MessageBox.Show("Silme işlemi tamamlandı.");
                }
                DBDisconnection();
            }
            



        }

        private string GetOgrenciAd(int id)
        {
            
            DBConnection();
            SqlCommand command = new SqlCommand($"Select ad,soyad From Ogrenci Where ID = {id}", _connection);
            string adSoyad = "";
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
               adSoyad= dataReader.GetString(0);
            }
            DBDisconnection();
            return adSoyad;
        }
    }
}
