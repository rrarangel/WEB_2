using Projeto01.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto01.Controllers
{
    public class FabricController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Fabric
        public ActionResult Index()
        {
            return View(context.Fabricantes.OrderBy(c => c.Nome));
        }
    }
}