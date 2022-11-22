﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public class SqlServices
    {

        readonly string conString = String.Empty; // SERVER
        readonly SqlConnection connection;

        public SqlServices()
        {

            //conString = "Data Source=DESKTOP-QB5K7DU; Database=MobileRepairsManagerData; Integrated Security=True";

            //conString = @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=aspnet-MvcMovie;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\Movies.mdf";

            string databasePath = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("DataAccess.dll", "MobileRepairsManagerData.mdf");
            conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + databasePath + ";Integrated Security=True; Connect Timeout=30"; // SERVER

            connection = new SqlConnection
            {
                ConnectionString = conString // bağlantı yolu bağlantı kuran değişkenin içine atandı.
            };
        }

        //veri tabanı kapalıysa aç metodu.
        SqlConnection OpenConnection()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;                        // sql bağlantısı bitti
        }

        // veri tabanı açıksa kapat metodu
        void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // veri tabanında yazdğımız herhangi bir kodu çalıştırmayı sağlayan metot. çalıtırır ancak dönen değerleri okumaz.
        public SqlCommand Execute(string commandText, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;               // komut cümlesi sql tarafına hangi komudu göndericez onu beliryitoruz.
            command.Connection = OpenConnection();
            command.CommandType = CommandType.Text;
            if (parameters != null)                             // parametre gönder ve içerisi nul mu diye kontrol et
            {
                command.Parameters.AddRange(parameters);       // parameetreler null değilse sql e gönder
            }
            command.ExecuteNonQuery();    // execute eden komut
            CloseConnection();            // sql kısmını kapat
            return command;
        }

        // veri tabanına gidip paramtere gönderip, kodları çalıştırıp dönen değerleri okuyan metot
        public SqlDataReader Reader(string commandText, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = OpenConnection();
            command.CommandType = CommandType.Text;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            SqlDataReader dataReader = command.ExecuteReader();             //sql deki kodu çalıştır ve çıktısını oku değerleri datareder değişkenine ay
            return dataReader;
        }

        // stored proc kodlarını alacak metot.
        public SqlCommand Stored(string commandText, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            command.ExecuteNonQuery();
            CloseConnection();
            return command;
        }


        // stored porc dan dönen değerleri okuyan metot.
        public SqlDataReader StoreReader(string commandText, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = OpenConnection();
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }
            SqlDataReader dataReader = command.ExecuteReader();
            return dataReader;
        }


        //veri tabanında new queri kodlarından dönen tabloları tablo olarak alan metot.
        public DataTable GetDataTable(string commandText, params SqlParameter[] parameters)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = Stored(commandText, parameters);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
