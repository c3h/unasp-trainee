using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNorthwind
{
    public class DataSupplier : Banco
    {
        public Supplier Save(Supplier Supplier)
        {
            if (Supplier.SupplierID == 0)
            {
                db.Suppliers.Add(Supplier);
            }
            else
            {
                db.Suppliers.Attach(Supplier);
                db.Entry(Supplier).State =
                    System.Data.Entity.EntityState.Modified;
            }
            db.SaveChanges();
            return Supplier;
        }
        public Supplier GetById(int ID)
        {
            return (from s in db.Suppliers
                    where s.SupplierID== ID
                    select s).FirstOrDefault();
        }
        public void Delete(int ID)
        {
            var Supplier = GetById(ID);
            if (Supplier == null)
                throw new Exception("Registro Não Encontrado");

            db.Suppliers.Remove(Supplier);
            db.SaveChanges();
        }
    }
}
