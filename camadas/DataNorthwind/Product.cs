using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataNorthwind
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        [ForeignKey("SupplierID")]
        public Supplier Supplier { get; set; }
    }
}