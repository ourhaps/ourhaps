using Microsoft.AspNetCore.Mvc;
using OurHaps.Web.Models;

namespace OurHaps.Web.Controllers
{
    public class TenantConfigurationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Submit(TenantConfigurationViewModel tenantConfigurationViewModel)
        {
            return View("Index");
        }
    }
}
