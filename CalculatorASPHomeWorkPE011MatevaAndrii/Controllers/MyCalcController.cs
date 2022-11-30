using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorASPHomeWorkPE011MatevaAndrii.Controllers
{
    public class MyCalcController : Controller
    {
        // GET: MyCalc
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result()
        {
            var x = Convert.ToDouble(RouteData.Values["X"]);
            var y = Convert.ToDouble(RouteData.Values["Y"]);
            var sign = RouteData.Values["sign"];
            string result = "0";
            switch (sign)
            {
                case "plus":
                    result = (x + y).ToString();
                    break;
                case "minus":
                    result = (x - y).ToString();
                    break;
                case "multiply":
                    result = (x * y).ToString();
                    break;
                case "devide":
                    if (y != 0)
                    {
                        result = (x / y).ToString();
                    }
                    else
                    {
                        result = "You can`t devide by zero";
                    }
                    break;
                default:
                    break;
            }
            ViewBag.Res = result;
            return View();  
        }
    }
}