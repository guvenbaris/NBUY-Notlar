using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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

        private void LoadGuncelleForm()
        {
            DataRowView item = (DataRowView)cmbUpdate.SelectedItem;
            int  id = int.Parse(item[0].ToString());

            //int id = int.Parse(cmbUpdate.SelectedValue.ToString());
            List<string> data = GetOgrenciInfo(id);
            txtAdUpdate.Text = data.ElementAt(0);
            txtSoyadUpdate.Text = data.ElementAt(1);
            txtTelefonUpdate.Text = data.ElementAt(2);
            txtTCUpdate.Text = data.ElementAt(3);
        }
        private List<string> GetOgrenciInfo(int id)
        {

            DBConnection();
            SqlCommand command = new SqlCommand($"Select * From Ogrenci Where ID = {id}", _connection);
            string adSoyad = "";
            SqlDataReader dataReader = command.ExecuteReader();
            List<string> data= new List<string>();
            while (dataReader.Read())
            {
                data.Add(dataReader.GetString(1));
                data.Add(dataReader.GetString(2));
                data.Add(dataReader.GetString(3));
                data.Add(dataReader.GetString(4));
            }
            DBDisconnection();
            return data;
        }


        private void OgrenciListUpdate()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select ID,Concat(ad,' ',soyad) as [Ad Soyad],telefon as Telefon, tc as [TC K.Nu.],ad,soyad From Ogrenci", _connection);
            DataTable dtOgrenci = new DataTable();
            dataAdapter.Fill(dtOgrenci);
            dgwOgrenciler.DataSource = dtOgrenci;
            dgwOgrenciler.Columns["ID"].Visible = false;
            dgwOgrenciler.Columns["ad"].Visible = false;
            dgwOgrenciler.Columns["soyad"].Visible = false;


            //silme 
            cmbSil.DataSource = dtOgrenci;
            cmbSil.DisplayMember = "Ad Soyad";
            cmbSil.ValueMember = "ID";

            cmbUpdate.DataSource = dtOgrenci;
            cmbUpdate.DisplayMember = "Ad Soyad";
            cmbUpdate.ValueMember = "ID";
            cmbUpdate.SelectedIndex = 0;

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

        private void cmbUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGuncelleForm();
            
        }


    }
}
