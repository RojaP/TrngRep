using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;

[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "EmployeeCompetencyTrackingSystem.Models")]

namespace EmployeeCompetencyTrackingSystem.Models
{
    public class EmployeeCompetence
    {
        public int EmployeeId { get; set; }
        public string EmployeeIName { get; set; }
        public int CompetencyId { get; set; }
        public string CompetencyName { get; set; }
        public int CompetencyRating { get; set; }
    }
  /*  public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeIName { get; set; }
    }
    public class Competency
    {
        public int CompetencyId { get; set; }
        public string CompetencyName { get; set; }
    }
    public class CandidateCompetency
    {
        public int CandidateId { get; set; }
        public string CompetencyName { get; set; }
    }*/

}