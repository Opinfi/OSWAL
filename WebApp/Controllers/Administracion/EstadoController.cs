using DataAccess.Administracion;
using Entidades.Administracion;
using SqlDataAccess.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers.Administracion
{
    public class EstadoController : BaseController
    {
        IEstadoDAO estadoDAO = new EstadoDAO();

        // GET: Estado
        public ActionResult Index()
        {
            string mensaje = string.Empty;
            List<Estado> estados = estadoDAO.getAllEstado(ref mensaje);
            if (mensaje != "OK")
                return View();
            else
                return View(estados);//.Where(p => p.idEstadoTipo == "ES_DOCUMENTO"));
        }

        // GET: Estado/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estado/Create
        public ActionResult Create()
        {
            string mensaje = string.Empty;            
            Estado estados = new Estado();
            estados.idEstadoTipo = "DOCUMENTO";            
            return View(estados);
        }

        // POST: Estado/Create
        [HttpPost]
        public ActionResult Create(Estado estado)
        {
            
            try
            {
                string mensaje = string.Empty;
                estadoDAO.insertEstado(estado, GetApplicationUser(), ref mensaje);
                if (mensaje == "OK")
                {
                    Success("Estado fue registrado con éxito", "Estado", true);
                    return RedirectToAction("Index");
                }
                else
                    return View(estado);
            }
            catch
            {
                return View();
            }
        }



        // GET: Estado/Edit/5
        public ActionResult Edit(int id)
        {
            Estado estado = null;
            string mensaje = string.Empty;
            
            estado = estadoDAO.getEstado(id, ref mensaje);            
            return View(estado);
        }

        // POST: Estado/Edit/5
        [HttpPost]
        public ActionResult Edit(Estado estado)
        {
            try
            {
                string mensaje = string.Empty;
                estadoDAO.updateEstado(estado, GetApplicationUser(), ref mensaje);
                if (mensaje == "OK")
                {
                    Success("Estado fue Actualizado con éxito", "Estado", true);
                    return RedirectToAction("Index");
                }
                else
                {
                    Warning(mensaje, "Estado", true);
                    return View(estado);
                }
            }
            catch (Exception ex)
            {
                Danger(ex.Message, "Estado", true);
                return View(estado);
            }
        }

        //// GET: Estado/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Estado/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
