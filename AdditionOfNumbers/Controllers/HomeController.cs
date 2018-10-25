using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdditionOfNumbers.Models;
using AdditionOfNumbers.HelperClasses;

namespace AdditionOfNumbers.Controllers
{
    /// <summary>
    /// Home Controller
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult Index(SumModel sum)
        {          
            return View(sum);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }


        /// <summary>
        /// Add two integer numbers
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public ActionResult Add(SumModel sum)
        {
            try
            {
                int FirstNumber = sum.FirstNumber;
                int SecondNumber = sum.SecondNumber;
                sum.Result = FirstNumber + SecondNumber;            
                return RedirectToAction("Index", sum);
            }
            catch(Exception ex)
            {
                HandleError.WriteError(ex);
                return View("Error");
            }
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}