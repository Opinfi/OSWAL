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
    public class BandejaEntradaController : Controller
    {
        IBandejaEntradaDAO bandejaEntradaDAO = new BandejaEntradaDAO();
        // GET: BandejaEntrada
        public ActionResult Index()
        {
            string mensaje = string.Empty;
            List<BandejaEntrada> ProcesosEntrada = bandejaEntradaDAO.getAllBandejaEntrada(ref mensaje);
            if (mensaje != "OK")
                return View();
            else
                return View(ProcesosEntrada);
        }

        // GET: BandejaEntrada/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BandejaEntrada/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BandejaEntrada/Create
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

        // GET: BandejaEntrada/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BandejaEntrada/Edit/5
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

        // GET: BandejaEntrada/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BandejaEntrada/Delete/5
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
