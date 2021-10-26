using System.Diagnostics.CodeAnalysis;
using System.Web;
using System.Web.Mvc;

namespace EmployeeCompetencyTrackingSystem
{
       [SuppressMessage("Microsoft.Design", "CA1053:StaticHolderTypesShouldNotHaveConstructors")]
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}