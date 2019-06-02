using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SoapVideoApi.Model;


namespace SoapVideoApi.DAO
{
    public static class VideoDao
    {
        private static readonly MySqlConnection cnx = new MySqlConnection();

        public static void OpenConnection()
        {
            cnx.ConnectionString = "Server=127.0.0.1;Uid=root;Pwd=root;Database=catalogue;";
            cnx.Open();
        }

        public static CatalogVideo GetAll()
        {
            OpenConnection();
            var videos = new CatalogVideo();
            var cmd = new MySqlCommand();
            //DB request
            cmd.CommandText = "SELECT * FROM video";
            cmd.Connection = cnx;
            //execute and read request
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var video = new Video();
                video.ID = dr.GetString("id");
                video.Name = dr.GetString("nom");
                video.Price = dr.GetDouble("prix");
                if (dr["description"] != DBNull.Value)
                    video.Description = dr.GetString("description");
                videos.Video.Add(video);
            }
            CloseConnection();

            return videos;
        }

        public static Video GetById(string id)
        {
            OpenConnection();
            var video = new Video();
            var cmd = new MySqlCommand();
            // DB request
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM video WHERE id=@pid";
            cmd.Parameters.AddWithValue("@pid", id);
            cmd.Prepare();
            // execute and read DB request
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                video.ID = dr.GetString("id");
                video.Name = dr.GetString("nom");
                video.Price = dr.GetDouble("prix");
                if (dr["description"] != DBNull.Value)
                    video.Description = dr.GetString("description");
            }
            CloseConnection();
            return video;
        }

        private static void CloseConnection()
        {
            cnx.Close();
        }
    }
}
