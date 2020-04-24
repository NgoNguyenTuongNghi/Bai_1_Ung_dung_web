using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }

        [HttpPost]

        public ActionResult Index(calc c, string calculate)
        {
            switch (calculate)
            {
                case "add":
                    c.total = "" + (c.val1+c.val2);
                    break;
                case "min":
                    c.total = "" + (c.val1-c.val2);
                    break;
                case "sub":
                    c.total = "" + (c.val1*c.val2);
                    break;
                case "dii":
                    if (c.val2 == 0) 
                        c.total = "Không chia được cho 0"; 
                    else 
                        c.total = "" + (c.val1/c.val2); 
                    break;
                    
            }
            return View(c);
        }
    }
}