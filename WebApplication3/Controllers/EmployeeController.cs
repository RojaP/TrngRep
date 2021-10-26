using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeCompetencyTrackingSystem.Models;

namespace EmployeeCompetencyTrackingSystem.Controllers
{
    public class EmployeeController : Controller
    {
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
    }
}