using KalbeService.Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KalbeService.Controllers
{
    public class ProccessController : ApiController
    {
        [System.Web.Mvc.HttpGet]
        public List<tb_proccess> GetAllProccess()
        {
            string connStr = ConfigurationManager.ConnectionStrings["KalbeConnection"].ConnectionString;

            using (MySqlConnection _connection = new MySqlConnection(connStr))
            {
                _connection.Open();
                MySqlCommand _command = new MySqlCommand("SELECT *FROM tb_proccess", _connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(_command);
                DataTable results = new DataTable();

                adapter.Fill(results);
                _connection.Close();

                if (results == null)
                {
                    NotFound();
                }

                var srlJson = JsonConvert.SerializeObject(results);

                return JsonConvert.DeserializeObject<List<tb_proccess>>(srlJson);
            }
        }
    }
}
