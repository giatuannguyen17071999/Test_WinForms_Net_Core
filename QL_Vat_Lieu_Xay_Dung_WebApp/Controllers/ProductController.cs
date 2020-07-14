using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QL_Vat_Lieu_Xay_Dung_WebApp.Controllers
{
    public class ProductController : Controller
    {
        [Route("san-pham")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("{alias}-c.{id}")]
        public IActionResult Catalog(int id, string keyword, int? pageSize, string sortBy, int page = 1)
        {
            return View();
        }
    }
}
