using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWindMVC.Models
{
      class RespostaHtml
    {
        public bool success { get; set; }
        public string message { get; set; }
        public object Data { get; set; }
    }
}