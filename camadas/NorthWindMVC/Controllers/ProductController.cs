using NorthWindMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataNorthwind;
using BusinessNorthwind;

namespace NorthWindMVC.Controllers
{
    public class ProductController : Controller
    {
        private NorthWind db = new NorthWind();

        public ActionResult ListProducts(int CategoryID)
        {
            var retorno = (from p in db.Products
                           where p.CategoryID == CategoryID
                           orderby p.ProductName
                           select new
                           {
                               p.ProductID,
                               p.ProductName
                           }).ToList();
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }


        private List<Supplier> Suppliers()
        {
            return (from s in db.Suppliers select s).ToList();
        }

        private List<Category> Categories()
        {
            return (from c in db.Categories select c).ToList();
        }

        public ActionResult Delete(int EmployeeId)
        {
            ViewBag.Message = "O Registro foi excluido com sucesso";

            var empregado = (from e in db.Employees 
                                 where e.EmployeeID == EmployeeId
                                 select e).FirstOrDefault();
            if (empregado == null)
            {
                var ex = new Exception("Registro Não encontrado!");
                return View("Erro",ex);
            }
            try 
	        {	        
                db.Employees.Remove(empregado);
                db.SaveChanges();
	        }
	        catch (Exception ex)
	        {
                return View("Erro",ErrorException(ex));
	        }

            ViewBag.Chefes = ObterChefes();
            return View("New", new Employee());
        }

        public ActionResult Edit(int id)
        {
            // Recupere o item do banco de dados
            var employee = (from e in db.Employees
                            where e.EmployeeID == id
                            select e).FirstOrDefault();
            if (employee == null)
            {
                var ex = new Exception("Registro Não Encontrado");
                return View("Erro", ex);
            }

            ViewBag.Chefes = ObterChefes();
            // retorne a View "New", passando como parametro o registro 
            // retornado do banco de dados
            return View("New", employee);
        }
        
        // GET: Product
        public ActionResult Index()
        {
            var ListaProdutos = (from p in db.Products
                                 .Include("Category")
                                 .Include("Supplier")
                                 select p).ToList();

            return View("Index", ListaProdutos);
        }

        public ActionResult New()
        {
            ViewBag.Suppliers = Suppliers();
            ViewBag.Categories = Categories();

            return View("New", new Product());
        }

        public System.Exception ErrorException(System.Exception ex)
        {
            if (ex.InnerException == null)
                return ex;
            else
                return ErrorException(ex.InnerException);
        }

        [HttpPost]
        public ActionResult Save(Employee e)
        {
            try
            {
                // Usar nossa classe de banco de dados
                e.Adventista = e.Adventista == null ? false : true;
                if (e.EmployeeID == 0)
                {
                    // Como eu salvo um registro no Banco de Dados?
                    db.Employees.Add(e);
                }
                else
                {
                    db.Employees.Attach(e);
                    db.Entry(e).State = EntityState.Modified;
                }
                db.SaveChanges();
                ViewBag.Chefes = ObterChefes();
            }
            catch (Exception ex)
            {
                ex = ErrorException(ex);
                return View("Erro",ex);
            }

            // Se não ocorrer um erro, o que acontece?
            ViewBag.Message = "O Registro Foi Incluido com Sucesso!";
            return View("New", new Employee());
        }

        private List<Employee> ObterChefes()
        {
            return (from emps in db.Employees
                          select emps).ToList();
             
        }
    }
}