using NorthWindMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWindMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private NorthWind db = new NorthWind();
        

        // GET: Employee
        public ActionResult Index()
        {
            var db = new NorthWind();
            var emps = (from emp in db.Employees
                        select emp).ToList();
            return View("Index", emps);
        }

        public ActionResult New()
        {
            var db = new NorthWind();
            var boss = (from emp in db.Employees
                        select emp).ToList();
            ViewBag.Empregados = boss;
            return View("New", new Employee());
        }

        public System.Exception ErrorException(System.Exception ex)
        {
            if (ex.InnerException == null)
                return ex;
            else
                return ErrorException(ex.InnerException);
        }

        //Esse método deve responder com JSON e não View
        [HttpPost]
        public ActionResult SaveJson(Employee e)
        {
            var resposta = new RespostaHtml { success = true };

            try
            {
                //Usar nossa classe de banco de dados.
                //Instanciando a base.
                var db = new NorthWind();
                if (e.Adventista == null)
                    e.Adventista = false;
                //ou e.Adventista = e.Adventista == null ? false : true;
                if (e.EmployeeID == 0)
                {
                    //Como eu salvo um registro no Banco de Dados?
                    db.Employees.Add(e);
                }
                else
                {
                    db.Employees.Attach(e);
                    db.Entry(e).State = EntityState.Modified;
                }
                db.SaveChanges();

                resposta.Data = e;               
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

        [HttpPost]
        public ActionResult Save(Employee e)
        {
            try
            {
                //Usar nossa classe de banco de dados.
                //Instanciando a base.
                var db = new NorthWind();
                if (e.Adventista == null)
                    e.Adventista = false;
                //ou e.Adventista = e.Adventista == null ? false : true;
                if (e.EmployeeID == 0)
                {
                    //Como eu salvo um registro no Banco de Dados?
                    db.Employees.Add(e);
                }
                else
                {
                    db.Employees.Attach(e);
                    db.Entry(e).State = EntityState.Modified;
                }
                db.SaveChanges();
                var boss = (from emp in db.Employees
                            select emp).ToList();
                ViewBag.Empregados = boss;
            }
            catch (Exception ex)
            {
                ex = ErrorException(ex);
                return View("Erro", ex);
            }
            ViewBag.Message = "O registro foi incluido com sucesso!";
            return View("New", new Employee());
        }

        public ActionResult Edit(int id)
        {
            //Recupere o item do banco de dados;
            var db = new NorthWind();
            var employee = (from emp in db.Employees
                            where emp.EmployeeID == id
                            select emp).FirstOrDefault();
            if (employee == null)
            {
                var ex = new Exception("Registro não encontrado.");
                return View("Erro", ex);
            }
            //Crie uma ViewBag com a lista de empregados;
            var empregados = (from emp in db.Employees
                              select emp).ToList();
            ViewBag.Empregados = empregados;
            //Returne a view New, passando como parametro o registro retornado do banco de dados.
            return View("New", employee);
            //var db = new NorthWind
        }

        public ActionResult Delete(int EmployeeID)
        {
            var db = new NorthWind();
            var employee = (from emp in db.Employees
                            where emp.EmployeeID == EmployeeID
                            select emp).FirstOrDefault();
            if (employee == null)
            {
                var ex = new Exception("Registro não encontrado.");
                return View("Erro", ex);
            }
            else
            {
                db.Employees.Remove(employee);
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
            var empregados = (from emp in db.Employees
                              select emp).ToList();
            ViewBag.Empregados = empregados;
            ViewBag.Message = "O registro foi excluído com sucesso!";
            return View("New", new Employee());
        }


        public ActionResult IndexJavaScript()
        {            
            return View();
        }

        public ActionResult ListEmployeesJson(string FirstName)
        {
            var list = (from e in db.Employees
                        where (string.IsNullOrEmpty(FirstName) ? true : e.FirstName.StartsWith(FirstName))
                        orderby e.FirstName
                        select e).ToList();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DeleteJson(int EmployeeID)
        {
            var resposta = new RespostaHtml { success = true };

            var db = new NorthWind();
            var employee = (from emp in db.Employees
                            where emp.EmployeeID == EmployeeID
                            select emp).FirstOrDefault();
            if (employee == null)
            {
                var ex = new Exception("Registro não encontrado");
                resposta.success = false;
                resposta.message = ex.Message;
                return Json(resposta, JsonRequestBehavior.DenyGet);
            }
            else
            {
                db.Employees.Remove(employee);
                try
                {
                    db.SaveChanges();
                    resposta.Data = employee;
                }
                catch (Exception ex)
                {
                    ex = ErrorException(ex);
                    resposta.success = false;
                    resposta.message = ex.Message;
                    return Json(resposta, JsonRequestBehavior.DenyGet);
                }
            }
            var empregados = (from emp in db.Employees
                              select emp).ToList();

            return Json(resposta, JsonRequestBehavior.DenyGet);
        }

        public ActionResult NewJavaScript(int? Id)
        {
            Employee employee = new Employee();
            if(Id != null)
            {
                employee = (from e in db.Employees
                            where e.EmployeeID == Id.Value
                            select e).FirstOrDefault();
            }
            return View(employee);
        }

        public ActionResult ListEmployees()
        {
            var db = new NorthWind();
            var list = (from e in db.Employees
                        orderby e.LastName
                        select new { e.EmployeeID, e.LastName}).ToList();

            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}