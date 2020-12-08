using SPAForvater1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;



namespace SPAForvater1.Controllers
{
    public class ThisController : Controller
    {
        // GET: Home
        public ViewResult Home()
        {
            
            return View();
        }


        [HttpGet]
        public ViewResult Form()
        {
            //ViewData["Head"] = "d-none";
            return View();
        }

        [HttpPost]

        public ViewResult Form(Customer guest)
        {

            if (ModelState.IsValid)
            {
                /* Проверка валидации заполнения формы */

                return View("Thanks", guest);
                
            }

            else
                //Обнаруженна ошибка проверки достоверности
                return View();
        }
        public ViewResult Thanks()
        {
            Response.AddHeader("REFRESH", "10;URL=HomePage");
            return View();
        }
    }
}

