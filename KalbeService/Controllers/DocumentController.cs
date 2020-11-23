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
    public class DocumentController : ApiController
    {
        string connStr = ConfigurationManager.ConnectionStrings["KalbeConnection"].ConnectionString;

        [HttpPost]
        public void AddNewDocument(tb_document doc)
        {
            using (MySqlConnection _connection = new MySqlConnection(connStr))
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO tb_document (no_doc, main_proccess, core_proccess, proccess, lob) Values (@no, @main, @core, @proccess, @lob)";
                sqlCmd.Connection = _connection;

                sqlCmd.Parameters.AddWithValue("@no", doc.no_doc);
                sqlCmd.Parameters.AddWithValue("@main", doc.main_proccess);
                sqlCmd.Parameters.AddWithValue("@core", doc.core_proccess);
                sqlCmd.Parameters.AddWithValue("@proccess", doc.proccess);
                sqlCmd.Parameters.AddWithValue("@lob", doc.lob);
                _connection.Open();
                int rowInserted = sqlCmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        [HttpPut]
        public void UpdateDocument(tb_document doc)
        {
            using (MySqlConnection _connection = new MySqlConnection(connStr))
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "UPDATE tbl_document SET main_procces = @main, core_proccess = @core, proccess = @proccess, lob = @lob WHERE no_doc= @no_doc";
                sqlCmd.Connection = _connection;

                sqlCmd.Parameters.AddWithValue("@main", doc.main_proccess);
                sqlCmd.Parameters.AddWithValue("@core", doc.core_proccess);
                sqlCmd.Parameters.AddWithValue("@proccess", doc.proccess);
                sqlCmd.Parameters.AddWithValue("@lob", doc.lob);
                _connection.Open();
                int rowUpdatd = sqlCmd.ExecuteNonQuery();
                _connection.Close();
            }
        }

        [HttpPost]
        public void DeleteDocument(string no_doc)
        {
            using (MySqlConnection _connection = new MySqlConnection(connStr))
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "delete from tbl_document where no_doc = " + no_doc + "";
                sqlCmd.Connection = _connection;
                _connection.Open();
                int rowDeleted = sqlCmd.ExecuteNonQuery();
                _connection.Close();
            }
        }


    }
}
