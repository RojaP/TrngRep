using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
}