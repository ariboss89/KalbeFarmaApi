using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KalbeService.Models
{
    public class tb_proccess
    {
        public int Id { get; set; }
        public string proccess { get; set; }
        public string objective { get; set; }
        public string entity_reference { get; set; }
        public string document_reference { get; set; }
    }
}