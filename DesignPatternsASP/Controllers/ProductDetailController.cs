using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Earnings;

namespace DesignPatternsASP.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            // WHEN YOU USE DEPENDENCY INJECTION YOU DONT CREATE THE FABRICS ON THE METHOD
            // Factories
            //LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
            //ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);

            // Products
            var localEarn = _localEarnFactory.GetEarn();
            var foreigEarn = _foreignEarnFactory.GetEarn();

            // Total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreigEarn.Earn(total);

            return View();
        }
    }
}
