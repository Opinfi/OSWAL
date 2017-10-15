using DataAccess.Administracion;
using DataAccess.Proceso;
using Entidades.Administracion;
using Entidades.Proceso;
using SqlDataAccess.Administracion;
using SqlDataAccess.Proceso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers.Procesos
{
    public class ProcesoController : BaseController
    {
        IUsuarioDAO usuarioDAO = new UsuarioDAO();
        ITipoCorrespondenciaDAO tipoCorrespondenciaDAO = new TipoCorrespondenciaDAO();
        IDepartamentoDAO departamentoDAO = new DepartamentoDAO();
        IProcesoDAO procesoDAO = new ProcesoDAO();

        // GET: Proceso
        public ActionResult Index()
        {
            string mensaje = string.Empty;
            List<Proceso> procesos = procesoDAO.getAllProceso(ref mensaje);
            if (mensaje != "OK")
                return View();
            else
                return View(procesos);
        }

        // GET: Proceso/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Proceso/Create
        public ActionResult Create()
        {
            string mensaje = string.Empty;
            List<TipoCorrespondencia> tiposCorrespondencia = tipoCorrespondenciaDAO.getAllTipoCorrespondencia(ref mensaje);
            List<Departamento> departamentos = departamentoDAO.getAllDepartamento(ref mensaje);
            List<Usuario> usuarios = usuarioDAO.getAllUsuario(ref mensaje);
            Proceso proceso = new Proceso();
            ViewBag.Usuarios = usuarios.Where(c => c.Estado);
            ViewBag.Departamentos = departamentos.Where(c => c.Estado);
            ViewBag.TiposCorrespondencia = tiposCorrespondencia.Where(c => c.Estado);
            return View(proceso);
        }

        // POST: Proceso/Create
        [HttpPost]
        public ActionResult Create(Proceso proceso)
        {
            try
            {
                string mensaje = string.Empty;
                procesoDAO.insertProceso(proceso, GetApplicationUser(), ref mensaje);
                
                if (mensaje == "OK")
                {
                    Success("El proceso fue registrado con éxito", "Proceso", true);
                    return RedirectToAction("Index");
                }
                else
                    return View(proceso);
            }
            catch
            {
                return View();
            }
        }

        // GET: Proceso/Edit/5
        public ActionResult Edit(int id)
        {
            Proceso proceso = null;
            string mensaje = string.Empty;

            proceso = procesoDAO.getProceso(id, ref mensaje);
            return View(proceso);
        }
        // POST: Proceso/Edit/5
        [HttpPost]
        public ActionResult Edit(Proceso proceso)
        {
            try
            {
                string mensaje = string.Empty;
                procesoDAO.updateProceso(proceso, GetApplicationUser(), ref mensaje);
                if (mensaje == "OK")
                {
                    Success("El Proceso fue actualizado con éxito", "Proceso", true);
                    return RedirectToAction("Index");
                }
                else
                {
                    Warning(mensaje, "Proceso", true);
                    return View(proceso);
                }
            }
            catch (Exception ex)
            {
                Danger(ex.Message, "Proceso", true);
                return View(proceso);
            }
        }

        // GET: Proceso/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Proceso/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
