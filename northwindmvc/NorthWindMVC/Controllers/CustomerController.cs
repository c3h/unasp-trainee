using NorthWindMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWindMVC.Controllers
{
    public class CustomerController : Controller
    {
        private NorthWind db = new NorthWind();

        [HttpGet]
        public ActionResult ListCountries(string id)
        {
            var list = (from c in db.Customers
                        where c.Country != null
                        && (string.IsNullOrEmpty(id) ? true : c.Country.StartsWith(id))                            
                        orderby c.Country
                        select c.Country).ToList().Distinct();

            return Json(list, JsonRequestBehavior.AllowGet);
        }
               

        public ActionResult Delete(string ID)
        {
            var db = new NorthWind();
            var customer = (from c in db.Customers
                            where c.CustomerID == ID
                            select c).FirstOrDefault();
            if (customer == null)
            {
                var ex = new Exception("Registro não encontrado.");
                return View("Erro", ex);
            }
            else
            {
                db.Customers.Remove(customer);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    return View("Erro", ErrorException(ex));
                }
            }
            var customers = (from c in db.Customers
                              select c).ToList();
            ViewBag.Customers = customers;
            ViewBag.Message = "O registro foi excluído com sucesso!";
            return View("Details", customer);
        }

        public ActionResult Details(string ID)
        {
            var customer = (from c in db.Customers
                            where c.CustomerID == ID
                            select c).FirstOrDefault();
            if(customer == null)
            {
                return View("erro", new Exception("Registro não encontrado"));
            }
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            try
            {
                //Como eu salvo um registro no Banco de Dados?
                db.Customers.Add(customer);
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                ex = ErrorException(ex);
                return View("Erro", ex);
            }

            ViewBag.Message = "O registro foi incluido com sucesso!";
            return View("Details", customer);
        }
        
        [HttpGet]
        public ActionResult Edit(string ID)
        {
            var customer = (from c in db.Customers
                            where c.CustomerID == ID
                            select c).FirstOrDefault();
            if(customer == null)
            {
                var ex = new Exception("Registro não encontrado!");
                return View("Erro", ex);
            }
            return View("New", customer);
        }

        // GET: Customer
        public ActionResult Index(Customer customer)
        {
            var customers = (from c in db.Customers
                             where (string.IsNullOrEmpty(customer.CompanyName) ? true : c.CompanyName.Contains(customer.CompanyName))
                             && (string.IsNullOrEmpty(customer.Country) ? true : c.Country.Contains(customer.Country))
                             orderby c.CompanyName
                             select c).ToList();

            ViewBag.CompanyName = customer.CompanyName;
            ViewBag.Country = customer.Country;

            return View(customers);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Customer customer)
        {
            try
            {
                    //Como eu salvo um registro no Banco de Dados?
                    db.Customers.Add(customer);           
                    db.SaveChanges();
                
            }
            catch (Exception ex)
            {
                ex = ErrorException(ex);
                return View("Erro", ex);
            }

            ViewBag.Message = "O registro foi incluido com sucesso!";
            return View("Details", customer);
            
        }
        public System.Exception ErrorException(System.Exception ex)
        {
            if (ex.InnerException == null)
                return ex;
            else
                return ErrorException(ex.InnerException);
        }
    }
}