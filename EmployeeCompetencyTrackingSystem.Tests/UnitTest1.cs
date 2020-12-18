using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeCompetencyTrackingSystem.Controllers;
using System.Web.Mvc;
using EmployeeCompetencyTrackingSystem.Models;
using System.Collections.Generic;

namespace EmployeeCompetencyTrackingSystem.Tests
{
    [TestClass]
    public class UnitTestEmployeeCompetencyController
    {
        [TestMethod]
        public void TestIndex()
        {
            EmployeeCompetencyController _EmployeeCompetencyController = new EmployeeCompetencyController();
            ViewResult result = (ViewResult) _EmployeeCompetencyController.Index();
            int count = ((List<EmployeeCompetence>)result.Model).Count;
            Assert.AreEqual(8, count);
        }
        [TestMethod]
        public void TestDetailsByEid()
        {
            EmployeeCompetencyController _EmployeeCompetencyController = new EmployeeCompetencyController();
            ViewResult result = (ViewResult)_EmployeeCompetencyController.DetailsByEid(1000);
            int count = ((List<EmployeeCompetence>)result.Model).Count;
            Assert.AreEqual(1, count);
        }
        [TestMethod]
        public void TestDetailsByCid()
        {
            EmployeeCompetencyController _EmployeeCompetencyController = new EmployeeCompetencyController();
            ViewResult result = (ViewResult)_EmployeeCompetencyController.DetailsByCid(1);
            int count = ((List<EmployeeCompetence>)result.Model).Count;
            Assert.AreEqual(3, count);
        }
    }
}
