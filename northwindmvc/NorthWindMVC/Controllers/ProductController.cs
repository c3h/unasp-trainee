using NorthWindMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWindMVC.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var db = new NorthWind();
            var ListaProdrutos = (from p in db.Products
                         .Include("Category")
                         .Include("Supplier")
                                  select p).ToList();
            return View("Index", ListaProdrutos);
        }
        public System.Exception ErrorException(System.Exception ex)
        {
            if (ex.InnerException == null)
                return ex;
            else
                return ErrorException(ex.InnerException);
        }
        public ActionResult New()
        {
            var db = new NorthWind();
            var prdts = (from emp in db.Products
                        select emp).ToList();

            var sup = (from emp in db.Suppliers
                       select emp).ToList();

            var cat = (from emp in db.Categories
                       select emp).ToList();

            ViewBag.Categorias = cat;

            ViewBag.Fornecedores = sup;

            ViewBag.Produtos = prdts;

            return View(new Product());
        }

        [HttpPost]
        public ActionResult Save(Product p)
        {
            try
            {
                var db = new NorthWind();
                if(p.ProductID == 0)
                {
                    db.Products.Add(p);
                }
                else
                {
                    db.Products.Attach(p);
                    db.Entry(p).State = EntityState.Modified;
                    
                }
                db.SaveChanges();

                var prdts = (from emp in db.Employees
                            select emp).ToList();

                var sup = (from emp in db.Suppliers
                           select emp).ToList();

                var cat = (from emp in db.Categories
                           select emp).ToList();

                ViewBag.Categorias = cat;

                ViewBag.Fornecedores = sup;

                ViewBag.Produtos = prdts;
            }
            catch (Exception ex)
            {
                ex = ErrorException(ex);
                return View("Erro", ex);
            }
            ViewBag.Message = "O registro foi incluido com sucesso!";
            return View("New", new Product());
        }

        public ActionResult Edit(int id)
        {
            //Recupere o item do banco de dados;
            var db = new NorthWind();
            var product = (from prod in db.Products
                            where prod.ProductID == id
                            select prod).FirstOrDefault();
            if (product == null)
            {
                var ex = new Exception("Registro não encontrado.");
                return View("Erro", ex);
            }
            //Crie uma ViewBag com a lista de empregados;
            var produtos = (from prod in db.Products
                              select prod).ToList();

            var sup = (from emp in db.Suppliers
                       select emp).ToList();

            var cat = (from emp in db.Categories
                       select emp).ToList();

            ViewBag.Categorias = cat;

            ViewBag.Fornecedores = sup;

            ViewBag.Produtos = produtos;
            //Returne a view New, passando como parametro o registro retornado do banco de dados.
            return View("New", product);
            //var db = new NorthWind
        }

        public ActionResult Delete(int ProductID)
        {
            var db = new NorthWind();
            var product = (from emp in db.Products
                            where emp.ProductID == ProductID
                            select emp).FirstOrDefault();
            if (product == null)
            {
                var ex = new Exception("Registro não encontrado.");
                return View("Erro", ex);
            }
            else
            {
                db.Products.Remove(product);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    ex = ErrorException(ex);
                    return View("Erro", ex);
                }
            }
            var produtos = (from emp in db.Products
                              select emp).ToList();
                      
            var sup = (from emp in db.Suppliers
                       select emp).ToList();

            var cat = (from emp in db.Categories
                       select emp).ToList();

            ViewBag.Categorias = cat;

            ViewBag.Fornecedores = sup;

            ViewBag.Produtos = produtos;

            ViewBag.Message = "O registro foi excluído com sucesso!";
            return View("New", new Product());
        }
    }
}