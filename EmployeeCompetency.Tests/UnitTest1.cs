using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeCompetencyTrackingSystem.Controllers;

using EmployeeCompetencyTrackingSystem.Models;
using System.Web.Mvc;
using System.Collections.Generic;
namespace EmployeeCompetency.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIndex()
        {
            EmployeeController _EmployeeCompetencyController = new EmployeeController();
            ViewResult result = (ViewResult)_EmployeeCompetencyController.Index();
            int count = ((List<EmployeeCompetence>)result.Model).Count;
            Assert.AreEqual(9, count);
        }
        [TestMethod]
        public void TestDetailsByEid()
        {
            EmployeeController _EmployeeCompetencyController = new EmployeeController();
            ViewResult result = (ViewResult)_EmployeeCompetencyController.DetailsByEid(1000);
            int count = ((List<EmployeeCompetence>)result.Model).Count;
            Assert.AreEqual(1, count);
        }
        [TestMethod]
        public void TestDetailsByCid()
        {
            EmployeeController _EmployeeCompetencyController = new EmployeeController();
            ViewResult result = (ViewResult)_EmployeeCompetencyController.DetailsByCid(1);
            int count = ((List<EmployeeCompetence>)result.Model).Count;
            Assert.AreEqual(3, count);
        }
    }
}
