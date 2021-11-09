using parcialPOO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace parcialPOO.Controllers
{
    public class personaController : Controller
    {
        [HttpGet]

        public ActionResult index1()
        {
            return View();
        }

        [HttpPost]

        public ActionResult index1(cajero calculo)
        {
            if (calculo.cantidad % 5 == 0) 
            {
                return Redirect("montoRetirado");
            }
            else
            {
                return Redirect("error");
            }

        }
         
        [HttpGet]
        public ActionResult error() 
        {
            return View();
        }

        [HttpGet] 

        public ActionResult montoRetirado() 
        {
            return View();
        
        } 






    }
}