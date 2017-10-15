using DataAccess.Bandejas;
using Entidades.Bandejas;
using SqlDataAccess.Bandejas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers.Bandejas
{
    public class BandejaSalidaController : BaseController
    {
        IBandejaSalidaDAO bandejaSalidaDAO = new BandejaSalidaDAO();
        // GET: BandejaSalida
        public ActionResult Index()
        {
            string mensaje = string.Empty;
            List<BandejaSalida> ProcesosSalida = bandejaSalidaDAO.getAllBandejaSalida(ref mensaje);
            if (mensaje != "OK")
                return View();
            else
                return View(ProcesosSalida);
        }

        // GET: BandejaSalida/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BandejaSalida/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BandejaSalida/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BandejaSalida/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BandejaSalida/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BandejaSalida/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BandejaSalida/Delete/5
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
