using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace DataNorthwind
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [DataType(DataType.Text)]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage="Last Name obrigatório")]
        [StringLength(5, ErrorMessage="Minimo de 3 e maximo de 5 caracteres", MinimumLength = 3)]
        public string LastName { get; set; }

        public string FirstName { get; set; }
        
        public string Title{ get; set; } 
        
        public string TitleOfCourtesy{ get; set; }

        [DataType(DataType.Text)]
        [DisplayFormat(ApplyFormatInEditMode = true,
            DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? BirthDate{ get; set; }

        public DateTime? HireDate { get; set; } 
        public string Address{ get; set; } 
        public string City{ get; set; } 
        public string Region{ get; set; } 
        public string PostalCode{ get; set; } 
        public string Country{ get; set; } 
        public string  HomePhone{ get; set; } 
        public string  Extension{ get; set; } 
        public int? ReportsTo{ get; set; } 
        public string Notes{ get; set; }
        public bool? Adventista { get; set; }
    }
}