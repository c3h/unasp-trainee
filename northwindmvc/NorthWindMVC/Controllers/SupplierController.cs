using NorthWindMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWindMVC.Controllers
{
    public class SupplierController : Controller
    {
        private NorthWind db = new NorthWind();

        public ActionResult IndexJavaScript()
        {
            return View();
        }

        public ActionResult NewJavaScript(int? Id)
        {
            Supplier supplier = new Supplier();
            if (Id != null)
            {
                supplier = (from s in db.Suppliers
                            where s.SupplierID == Id.Value
                            select s).FirstOrDefault();
            }
            return View(supplier);
        }

        [HttpPost]
        public ActionResult SaveJson(Supplier s)
        {
            var resposta = new RespostaHtml { success = true };

            try
            {                
                if (s.SupplierID == 0)
                {
                    //Como eu salvo um registro no Banco de Dados?
                    db.Suppliers.Add(s);
                }
                else
                {
                    db.Suppliers.Attach(s);
                    db.Entry(s).State = EntityState.Modified;
                }
                db.SaveChanges();

                resposta.Data = s;
            }
            catch (Exception ex)
            {
                ex = ErrorException(ex);
                resposta.success = false;
                resposta.message = ex.Message;
                return Json(resposta, JsonRequestBehavior.DenyGet);
            }
            return Json(resposta, JsonRequestBehavior.DenyGet);
        }

        [HttpGet]
        public ActionResult ListCountries(string id)
        {
            var list = (from s in db.Suppliers
                        where s.Country != null
                        && (string.IsNullOrEmpty(id) ? true : s.Country.StartsWith(id))
                        orderby s.Country
                        select s.Country).ToList().Distinct();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteJson(int SupplierID)
        {
            var resposta = new RespostaHtml { success = true };
            
            var supplier = (from s in db.Suppliers
                            where s.SupplierID == SupplierID
                            select s).FirstOrDefault();
            if (supplier == null)
            {
                var ex = new Exception("Registro não encontrado");
                resposta.success = false;
                resposta.message = ex.Message;
                return Json(resposta, JsonRequestBehavior.DenyGet);
            }
            else
            {
                db.Suppliers.Remove(supplier);
                try
                {
                    db.SaveChanges();
                    resposta.Data = supplier;
                }
                catch (Exception ex)
                {
                    ex = ErrorException(ex);
                    resposta.success = false;
                    resposta.message = ex.Message;
                    return Json(resposta, JsonRequestBehavior.DenyGet);
                }
            }
            var fornecedores = (from s in db.Suppliers
                              select s).ToList();

            return Json(resposta, JsonRequestBehavior.DenyGet);

        }

        public ActionResult ListSuppliersJson(string CompanyName)
        {
            var list = (from s in db.Suppliers
                        where (string.IsNullOrEmpty(CompanyName) ? true : s.CompanyName.StartsWith(CompanyName))
                        orderby s.CompanyName
                        select s).ToList();

            return Json(list, JsonRequestBehavior.AllowGet);
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