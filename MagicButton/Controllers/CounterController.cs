using MagicButton.Models;
using MagicButton.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagicButton.Controllers
{
    public class CounterController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new MagicButtonContext())
            {
                var counter = context.Counters.FirstOrDefault();
                return View(counter);
            }
        }

        [HttpPost]
        public ActionResult Index(Counter counter)
        {
            using (var context = new MagicButtonContext())
            {
                var _oldCounter = context.Counters.FirstOrDefault();
                if (_oldCounter.Index < 10)
                {
                    _oldCounter.Index += 1;
                    context.SaveChanges();
                }

                return View(_oldCounter);
            }
        }
    }
}