using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNorthwind
{
    public class DataProduct : Banco
    {
        public Product Save(Product Product)
        {
            if (Product.ProductID == 0)
            {
                db.Products.Add(Product);
            }
            else
            {
                db.Products.Attach(Product);
                db.Entry(Product).State =
                    System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return Product;
        }
        public Product GetById(int ID)
        {
            return (from p in db.Products
                    where p.ProductID == ID
                    select p).FirstOrDefault();
        }
        public void Delete(int ID)
        {
            var Product = GetById(ID);
            if (Product == null)
                throw new Exception("Registro Não Encontrado");

            db.Products.Remove(Product);
            db.SaveChanges();
        }
    }
}
