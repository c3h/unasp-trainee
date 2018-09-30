using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWindMVC.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [Display(Name ="Código")]
        public string CustomerID { get; set; }

        [Display(Name = "Compania")]
        public string CompanyName { get; set; }

        [Display(Name = "Nome de Contato")]
        public string ContactName { get; set; }

        [Display(Name = "Titulo do Contato")]
        public string ContactTitle { get; set; }

        [Display(Name = "Endereço")]
        public string Address { get; set; }

        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Display(Name = "Região")]
        public string Region { get; set; }

        [Display(Name = "Código Postal")]
        public string PostalCode { get; set; }

        [Display(Name = "País")]
        public string Country { get; set; }

        [Display(Name = "Fone")]
        public string Phone { get; set; }

        [Display(Name = "Fax")]
        public string Fax { get; set; }
    }
}