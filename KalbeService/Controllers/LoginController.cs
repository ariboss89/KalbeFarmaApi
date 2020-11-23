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
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace KalbeService.Controllers
{
    public class LoginController : ApiController
    {
        string connStr = ConfigurationManager.ConnectionStrings["KalbeConnection"].ConnectionString;
        
        [HttpPost]
        public Models.Response UserLogin(tb_admin login)
        {
            using (MySqlConnection _connection = new MySqlConnection(connStr))
            {
                MySqlCommand _command = new MySqlCommand("SELECT *FROM tb_admin WHERE username=@username AND password=@password", _connection);
                _command.Parameters.AddWithValue("@username", login.username);
                _command.Parameters.AddWithValue("@password", login.password);
                _connection.Open();
                var log = _command.ExecuteScalar();
                _connection.Close();

                if (log == null)
                {
                    return new Models.Response { Status = "Invalid", Message = "Invalid User." };
                }
                else
                    return new Models.Response { Status = "Success", Message = "Login Successfully" };
            }
        }
    }
}
