using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Monash.Card.Controllers
{
    public class DelegationController : Controller
    {
        // GET: Delegation
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Edit()
        {
            return View();
        }
    }
}