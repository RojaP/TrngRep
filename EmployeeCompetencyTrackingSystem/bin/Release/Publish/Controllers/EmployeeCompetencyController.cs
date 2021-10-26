using EmployeeCompetencyTrackingSystem.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Mvc;

[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "EmployeeCompetencyTrackingSystem.Controllers")]



namespace EmployeeCompetencyTrackingSystem.Controllers
{
    public class EmployeeCompetencyController : Controller
    {
        //
        // GET: /EmployeeCompetency/
        EmployeeCompetencyRepository _EmployeeCompetencyRepository = new EmployeeCompetencyRepository();

        public ActionResult Index()
        {

            return View(_EmployeeCompetencyRepository.EmployeesCompetencies);
        }

        //
        // GET: /EmployeeCompetency/Details/5

        public ActionResult DetailsByEid(int id)
        {
            return View(_EmployeeCompetencyRepository.GetAllEmployeeCompetenciesByEmployeeId(id));
        }
        public ActionResult DetailsByCid(int id)
        {
            return View(_EmployeeCompetencyRepository.GetAllEmployeesCompetenciesByCompetencyId(id));

      

        }

        //
        // GET: /EmployeeCompetency/Create

   /*     public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EmployeeCompetency/Create

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

        //
        // GET: /EmployeeCompetency/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /EmployeeCompetency/Edit/5

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

        //
        // GET: /EmployeeCompetency/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /EmployeeCompetency/Delete/5

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
        }*/
    }
}
