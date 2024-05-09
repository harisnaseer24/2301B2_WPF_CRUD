using Microsoft.AspNetCore.Mvc;

namespace testing.Controllers
{
    public class EmployeeController : Controller
    {
        public string EmpProfile(int id)
        {
            if (id==1)
            {

            return "Emp Lumber :"+id+"  Profile";
            }
            else
            {
                return "" +
                    "no Profile";
            }
        } public string Address(int id, string? dept =null)
        {
            if ( dept == null)
            {
            return $"this is emp having id = {id }";
            }
            else
            {

            return $"this is emp having id = {id } from {dept}";
            }
            }
        }
    }
}
